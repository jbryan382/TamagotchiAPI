using System;
using System.Collections.Generic;

namespace TamagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public int HungerLevel { get; set; } = 0;
        public int HappinessLevel { get; set; } = 0;
        public DateTime LastInteractedWithDate { get; set; }
        public bool IsDead { get; set; } = false;

        public bool IsItDead()
        {
            return (DateTime.Now - LastInteractedWithDate).TotalSeconds > 30 ? true : false;
        }
    }
}