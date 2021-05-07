using System;

namespace TamagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public int HungerLevel { get; set; } = 0;
        public int HappinessLevel { get; set; } = 0;
        public DateTime LastInteractedWithDate { get; set; } = DateTime.Now;
        public bool IsDead
        {
            get
            {
                return (DateTime.Now - LastInteractedWithDate).TotalDays > 3 ? true : false;
            }
        }
    }
}