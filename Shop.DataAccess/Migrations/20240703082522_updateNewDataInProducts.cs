using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateNewDataInProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "William Durant", 3, "\"The Story of Civilization\" by Will Durant is an eleven-volume series that chronicles the history of Western civilization, offering a comprehensive and accessible narrative from ancient times to the early 19th century. Renowned for its engaging prose and thorough research, the series explores the cultural, social, and political developments that have shaped the modern world.", "123321123321", "The Story of Civilization" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Homer", 3, "\"The Iliad\" by Homer is an ancient Greek epic poem that recounts the significant events of the final weeks of the Trojan War, focusing on the hero Achilles' rage and its devastating consequences. It explores themes of heroism, wrath, and the tragic cost of war.", "123321123321", "Iliada" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Friedrich Von Hayek", 1, "\"The Road to Serfdom\" by Friedrich von Hayek argues that central planning and government control of economic decisions inevitably lead to tyranny and the loss of individual freedoms, advocating instead for free-market capitalism as the safeguard of personal liberty.", "123321123321", "The Road To Serfdom" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "William Manchester", 3, "\"American Caesar\" by William Manchester is a comprehensive biography of General Douglas MacArthur, depicting his complex character and monumental impact on both American and world history, from World War I to the Korean War.", "123321123321", "American Caesar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "David Kushner", 2, "\"Masters of Doom\" by David Kushner is a gripping chronicle of the rise of id Software, focusing on the dynamic partnership of John Carmack and John Romero, who revolutionized the video game industry with their creation of the iconic game \"Doom.\" The book delves into their pioneering innovations, the culture of the gaming world, and the personal and professional tensions that shaped their journey.", "123321123321", "Masters of Doom" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "William Bollito", 2, "\"Twelve Against the Gods\" by William Bolitho is a compelling exploration of twelve extraordinary historical figures who defied convention and embraced risk, shaping the world through their audacity and vision. Bolitho's vivid narratives illustrate the timeless human spirit of adventure and ambition.", "123321123321", "Twelve Against the Gods" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Billy Spark", 1, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "Fortune of Time" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Nancy Hoover", 1, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "Dark Skies" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Julian Button", 2, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "Vanish in the Sunset" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Abby Muscles", 2, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "Cotton Candy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Ron Parker", 3, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "Rock in the Ocean" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Laura Phantom", 3, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "Leaves and Wonders" });
        }
    }
}
