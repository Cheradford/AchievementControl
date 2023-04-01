using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTFull.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Persons_Personid",
                table: "Achievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Form",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Olympiads_Form",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "ScienceActivities_Type",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "SocioCultural_Type",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Sport_Type",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Achievements");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Personid");

            migrationBuilder.CreateTable(
                name: "CreativeActivities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreativeActivities", x => x.id);
                    table.ForeignKey(
                        name: "FK_CreativeActivities_Achievements_id",
                        column: x => x.id,
                        principalTable: "Achievements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IntellectualContests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Form = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntellectualContests", x => x.id);
                    table.ForeignKey(
                        name: "FK_IntellectualContests_Achievements_id",
                        column: x => x.id,
                        principalTable: "Achievements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Olympiads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Theme = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Form = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olympiads", x => x.id);
                    table.ForeignKey(
                        name: "FK_Olympiads_Achievements_id",
                        column: x => x.id,
                        principalTable: "Achievements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ScienceActivities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScienceActivities", x => x.id);
                    table.ForeignKey(
                        name: "FK_ScienceActivities_Achievements_id",
                        column: x => x.id,
                        principalTable: "Achievements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SocioCulturals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocioCulturals", x => x.id);
                    table.ForeignKey(
                        name: "FK_SocioCulturals_Achievements_id",
                        column: x => x.id,
                        principalTable: "Achievements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sports_Achievements_id",
                        column: x => x.id,
                        principalTable: "Achievements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Person_Personid",
                table: "Achievements",
                column: "Personid",
                principalTable: "Person",
                principalColumn: "Personid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Person_Personid",
                table: "Achievements");

            migrationBuilder.DropTable(
                name: "CreativeActivities");

            migrationBuilder.DropTable(
                name: "IntellectualContests");

            migrationBuilder.DropTable(
                name: "Olympiads");

            migrationBuilder.DropTable(
                name: "ScienceActivities");

            migrationBuilder.DropTable(
                name: "SocioCulturals");

            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Achievements",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Form",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Olympiads_Form",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ScienceActivities_Type",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SocioCultural_Type",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Sport_Type",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Theme",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Achievements",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Personid");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Persons_Personid",
                table: "Achievements",
                column: "Personid",
                principalTable: "Persons",
                principalColumn: "Personid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
