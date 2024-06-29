using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI_Template.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampoA1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoA2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoA3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampoB1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoB2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoB3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabB", x => x.Id);
                });

            //dati iniziali
            migrationBuilder.InsertData(
            table: "TabA",
            columns: new[] { "CampoA1", "CampoA2", "CampoA3" },
            values: new object[,]
            {
                { "Valore1", "Valore2", "Valore3" },
                { "Valore4", "Valore5", "Valore6" }
            });

            migrationBuilder.InsertData(
                table: "TabB",
                columns: new[] { "CampoB1", "CampoB2", "CampoB3" },
                values: new object[,]
                {
            { "Valore1", "Valore2", "Valore3" },
            { "Valore4", "Valore5", "Valore6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabA");

            migrationBuilder.DropTable(
                name: "TabB");
        }
    }
}
