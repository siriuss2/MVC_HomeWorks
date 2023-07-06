using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PizzaPropertyAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Pizzas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 0.0 });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 0.0 });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 0.0 });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pizzas");
        }
    }
}
