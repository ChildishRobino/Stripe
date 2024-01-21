using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { "0925bbe7-bde5-40c6-b6b5-2d95cd1bddc9", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/13/500", 13000L, "Product 13" },
                    { "28b9876c-7422-476b-96b6-6d4a6fc98b52", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/5/500", 5000L, "Product 5" },
                    { "363dec49-5f75-447b-a14e-f5bca894e101", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/10/500", 10000L, "Product 10" },
                    { "4559a953-6575-4a36-92d8-eb4f2d6988ca", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/12/500", 12000L, "Product 12" },
                    { "54745717-e183-4ddc-b42a-d0f9f70a7b7e", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/14/500", 14000L, "Product 14" },
                    { "573b6192-8980-4775-856e-74ed0af99ae6", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/11/500", 11000L, "Product 11" },
                    { "5cc7a856-4f22-4f2d-9778-bb4752bf6182", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/9/500", 9000L, "Product 9" },
                    { "6b62dec5-1437-4827-bca1-f49800d30789", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/1/500", 1000L, "Product 1" },
                    { "7041de9f-aa61-41bc-9f40-0c2ef865f297", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/18/500", 18000L, "Product 18" },
                    { "8b967a59-714d-47d3-9fe8-0207ccdf829b", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/7/500", 7000L, "Product 7" },
                    { "8d05cbef-0afc-4892-8f93-56988891d645", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/15/500", 15000L, "Product 15" },
                    { "90c4c915-6720-445e-a642-17884348db68", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/3/500", 3000L, "Product 3" },
                    { "9702dd1e-c35b-4bd9-b3f2-176ab325cb9d", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/20/500", 20000L, "Product 20" },
                    { "9d0c414d-e322-493f-81f3-d1e72067db9b", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/4/500", 4000L, "Product 4" },
                    { "b03a183a-a1aa-41a5-91ee-6e23964ab652", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/17/500", 17000L, "Product 17" },
                    { "cf9c0f0d-2e66-488a-aa5d-ed3a1db0d4fe", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/16/500", 16000L, "Product 16" },
                    { "da993c4d-028f-4653-a2b8-2eb54ad872dd", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/2/500", 2000L, "Product 2" },
                    { "e5d8f50f-2615-495e-aa4f-4c3c19cc7db6", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/8/500", 8000L, "Product 8" },
                    { "f4c18335-370e-4217-a721-71aae51d94f7", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/19/500", 19000L, "Product 19" },
                    { "fde74c4c-f525-4e71-8c3e-2b6e623ef618", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/6/500", 6000L, "Product 6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
