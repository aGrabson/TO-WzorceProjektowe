using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WzorceProjektowe.API.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("da697d34-84c0-476a-a083-6e8b00209367"),
                column: "ToInterpret",
                value: "#I1#Interfejs# #CC1#FajnaKlasa# #CC2#Produkt# #C1#KonkretnyBuilder# ");

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("ffb8c2cb-3b24-4bbe-b4bd-34061073ee98"),
                column: "ToInterpret",
                value: "#I1#Interfejs# #CC1#Obserwator# #AC1#Abstrakcyjnaklasa# #CC2#ObserwatorImpl# ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("da697d34-84c0-476a-a083-6e8b00209367"),
                column: "ToInterpret",
                value: "#I1#Interfejs# #CC1#FajnaKlasa# #CC2#Produkt# #C1#KonkretnyBuilder#");

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("ffb8c2cb-3b24-4bbe-b4bd-34061073ee98"),
                column: "ToInterpret",
                value: "#I1#Interfejs# #CC1#Obserwator# #AC1#Abstrakcyjnaklasa# #CC2#ObserwatorImpl#");
        }
    }
}
