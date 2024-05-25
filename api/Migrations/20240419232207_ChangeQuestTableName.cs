using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeQuestTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subtasks_Quest_QuestId",
                table: "Subtasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quest",
                table: "Quest");

            migrationBuilder.RenameTable(
                name: "Quest",
                newName: "Quests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quests",
                table: "Quests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subtasks_Quests_QuestId",
                table: "Subtasks",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subtasks_Quests_QuestId",
                table: "Subtasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quests",
                table: "Quests");

            migrationBuilder.RenameTable(
                name: "Quests",
                newName: "Quest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quest",
                table: "Quest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subtasks_Quest_QuestId",
                table: "Subtasks",
                column: "QuestId",
                principalTable: "Quest",
                principalColumn: "Id");
        }
    }
}
