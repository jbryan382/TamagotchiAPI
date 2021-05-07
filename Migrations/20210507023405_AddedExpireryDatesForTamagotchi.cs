using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TamagotchiAPI.Migrations
{
    public partial class AddedExpireryDatesForTamagotchi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDead",
                table: "Pets",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastInteractedWithDate",
                table: "Pets",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDead",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "LastInteractedWithDate",
                table: "Pets");
        }
    }
}
