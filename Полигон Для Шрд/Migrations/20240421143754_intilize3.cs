using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Полигон_Для_Шрд.Migrations
{
    /// <inheritdoc />
    public partial class intilize3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Achievment = table.Column<string>(type: "TEXT", nullable: false),
                    Achievment_is_recieve = table.Column<bool>(type: "INTEGER", nullable: false),
                    Discription_of_achievment = table.Column<string>(type: "TEXT", nullable: false),
                    Achievment_not_recieved_image = table.Column<string>(type: "TEXT", nullable: false),
                    Achievment_recieve_image = table.Column<string>(type: "TEXT", nullable: false),
                    User_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievments", x => x.Id);
                });
        }
    }
}
