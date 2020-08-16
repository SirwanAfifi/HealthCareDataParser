using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp.Migrations
{
    public partial class ChangeToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Records",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Records",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Records",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "StartDate",
                table: "Records",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "EndDate",
                table: "Records",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreationDate",
                table: "Records",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
