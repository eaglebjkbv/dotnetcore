using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityOrnek.Migrations
{
    public partial class firstMigrtion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ogrenciler",
                columns: table => new
                {
                    ogrenciId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ad = table.Column<string>(nullable: true),
                    soyad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrenciler", x => x.ogrenciId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ogrenciler");
        }
    }
}
