using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstate.Data.Migrations
{
    public partial class simplify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_Images_ImageID",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_ImageID",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "Listings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "Listings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Listings_ImageID",
                table: "Listings",
                column: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_Images_ImageID",
                table: "Listings",
                column: "ImageID",
                principalTable: "Images",
                principalColumn: "ImageID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
