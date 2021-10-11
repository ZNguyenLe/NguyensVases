using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyensVases.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(         //This adds an entirely new column named Rating into the Vases Table
                name: "Rating",
                table: "Vases",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(    // this adds a new text box when you type a rating for a certain vase inside the create form.
                name: "Rating",
                table: "Vases");
        }
    }
}
