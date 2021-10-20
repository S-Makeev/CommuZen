using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CommuZen0._01.Migrations
{
    public partial class ModifiedTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleEntity_Users_UserId",
                table: "ArticleEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatEntityUserEntity_ChatEntity_ChatsId",
                table: "ChatEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatEntity",
                table: "ChatEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleEntity",
                table: "ArticleEntity");

            migrationBuilder.RenameTable(
                name: "ChatEntity",
                newName: "Chats");

            migrationBuilder.RenameTable(
                name: "ArticleEntity",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleEntity_UserId",
                table: "Articles",
                newName: "IX_Articles_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chats",
                table: "Chats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserChats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    ChatId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserChats_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserChats_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Header = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserChats_ChatId",
                table: "UserChats",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChats_UserId",
                table: "UserChats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatEntityUserEntity_Chats_ChatsId",
                table: "ChatEntityUserEntity",
                column: "ChatsId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatEntityUserEntity_Chats_ChatsId",
                table: "ChatEntityUserEntity");

            migrationBuilder.DropTable(
                name: "UserChats");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chats",
                table: "Chats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Chats",
                newName: "ChatEntity");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "ArticleEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_UserId",
                table: "ArticleEntity",
                newName: "IX_ArticleEntity_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatEntity",
                table: "ChatEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleEntity",
                table: "ArticleEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleEntity_Users_UserId",
                table: "ArticleEntity",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatEntityUserEntity_ChatEntity_ChatsId",
                table: "ChatEntityUserEntity",
                column: "ChatsId",
                principalTable: "ChatEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
