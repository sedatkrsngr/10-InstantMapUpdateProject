using Microsoft.EntityFrameworkCore.Migrations;

namespace InstantMapUpdateProject.API.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courier",
                columns: table => new
                {
                    id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    identityNumber = table.Column<long>(type: "bigint", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CourierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courier", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderFollowCoordinates",
                columns: table => new
                {
                    id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    userLatitude = table.Column<decimal>(type: "DECIMAL(9,6)", nullable: true),
                    userLongitude = table.Column<decimal>(type: "DECIMAL(9,6)", nullable: true),
                    courierLatitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    courierLongitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    centerLatitude = table.Column<decimal>(type: "DECIMAL(9,6)", nullable: true),
                    centerLongitude = table.Column<decimal>(type: "DECIMAL(9,6)", nullable: true),
                    CourierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFollowCoordinates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderFollowRoom",
                columns: table => new
                {
                    id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<long>(type: "bigint", nullable: true),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
                    roomId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFollowRoom", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courier");

            migrationBuilder.DropTable(
                name: "OrderFollowCoordinates");

            migrationBuilder.DropTable(
                name: "OrderFollowRoom");
        }
    }
}
