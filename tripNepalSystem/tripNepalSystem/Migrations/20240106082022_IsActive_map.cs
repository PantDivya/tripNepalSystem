﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tripNepalSystem.Migrations
{
    /// <inheritdoc />
    public partial class IsActive_map : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Maps",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Maps");
        }
    }
}
