using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ticket_master.Migrations
{
    public partial class TicketsModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegistered",
                table: "Users",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IncorporatedDate",
                table: "Organisations",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegistered",
                table: "Organisations",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegistered",
                table: "Users",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IncorporatedDate",
                table: "Organisations",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegistered",
                table: "Organisations",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
