using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityForeignKey.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "yazarlar",
                columns: table => new
                {
                    YazarId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    YazarAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yazarlar", x => x.YazarId);
                });

            migrationBuilder.CreateTable(
                name: "kitaplar",
                columns: table => new
                {
                    KitapId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapAdi = table.Column<string>(nullable: true),
                    YazarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaplar", x => x.KitapId);
                    table.ForeignKey(
                        name: "FK_kitaplar_yazarlar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "yazarlar",
                        principalColumn: "YazarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kitaplar_YazarId",
                table: "kitaplar",
                column: "YazarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitaplar");

            migrationBuilder.DropTable(
                name: "yazarlar");
        }
    }
}
