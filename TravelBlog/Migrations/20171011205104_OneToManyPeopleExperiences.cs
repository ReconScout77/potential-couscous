using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class OneToManyPeopleExperiences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperiencePeople");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_People_ExperienceId",
                table: "People",
                column: "ExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Experiences_ExperienceId",
                table: "People",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Experiences_ExperienceId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ExperienceId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "People");

            migrationBuilder.CreateTable(
                name: "ExperiencePeople",
                columns: table => new
                {
                    ExperiencePersonId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    ExperienceId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperiencePeople", x => x.ExperiencePersonId);
                    table.ForeignKey(
                        name: "FK_ExperiencePeople_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperiencePeople_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperiencePeople_ExperienceId",
                table: "ExperiencePeople",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperiencePeople_PersonId",
                table: "ExperiencePeople",
                column: "PersonId");
        }
    }
}
