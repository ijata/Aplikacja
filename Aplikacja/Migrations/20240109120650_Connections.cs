using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Aplikacja.Migrations
{
    /// <inheritdoc />
    public partial class Connections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Childrens",
                columns: table => new
                {
                    childernId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    childernFirstName = table.Column<string>(type: "text", nullable: true),
                    childernLastName = table.Column<string>(type: "text", nullable: true),
                    isActive = table.Column<int>(type: "integer", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Childrens", x => x.childernId);
                });

            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    CredentialId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CredentialName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.CredentialId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Posilek1 = table.Column<string>(type: "text", nullable: true),
                    Posilek2 = table.Column<string>(type: "text", nullable: true),
                    Posilek3 = table.Column<string>(type: "text", nullable: true),
                    Posilek4 = table.Column<string>(type: "text", nullable: true),
                    Posilek5 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ThreadId = table.Column<int>(type: "integer", nullable: false),
                    SenderId = table.Column<int>(type: "integer", nullable: false),
                    RecipientId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    IsView = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Presence",
                columns: table => new
                {
                    PresenceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChildId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PresenceState = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsAccepted = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presence", x => x.PresenceId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CredentialId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    HomeNumber = table.Column<int>(type: "integer", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber2 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRelation",
                columns: table => new
                {
                    RelationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ChildId = table.Column<int>(type: "integer", nullable: false),
                    RelationType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelation", x => x.RelationId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Childrens");

            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Presence");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRelation");
        }
    }
}
