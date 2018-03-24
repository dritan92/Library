using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripton",
                table: "Statuses",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "OpentDate",
                table: "LibraryBranches",
                newName: "OpenDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Statuses",
                newName: "Descripton");

            migrationBuilder.RenameColumn(
                name: "OpenDate",
                table: "LibraryBranches",
                newName: "OpentDate");
        }
    }
}
