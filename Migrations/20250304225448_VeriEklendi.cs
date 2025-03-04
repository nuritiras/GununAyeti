using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GununAyeti.Migrations
{
    /// <inheritdoc />
    public partial class VeriEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ayetler",
                columns: new[] { "Id", "Aciklama", "ArapcaMetin", "AyetNo", "SureIsmi" },
                values: new object[,]
                {
                    { 1, "Rahmân, Rahîm olan Allah'ın ismiyle.", "بِسْمِ اللَّهِ اَلرَّحْمٰنِ الرَّحِيمِ", 1, "Fatiha" },
                    { 2, "Hamd, âlemlerin Rabbi(3) olan Allah'a mahsustur.", "اَلْحَمْدُ لِلَّهِ رَبِّ الْعَالَمِينَ", 2, "Fatiha" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ayetler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ayetler",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
