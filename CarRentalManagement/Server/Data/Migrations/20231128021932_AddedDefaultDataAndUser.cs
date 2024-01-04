using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "f50e69d8-a711-43a1-bbfd-9b88124cd955");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "c3a3b348-f62f-418d-9249-1f96c4809adb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95e3fca3-b1cd-45dc-bb82-dad39becb1d8", "AQAAAAEAACcQAAAAEBdklpZqPzqWI3iVIBGkMQP3th3+oXIJKEm/JTbOgkQuEUnE3FljZr4WDAgo/NjrHw==", "7e0271f1-5172-4778-9654-7cccbc266f69" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4482), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4491), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4662), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4728), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4729), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4731), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4732), new DateTime(2023, 11, 28, 10, 19, 32, 373, DateTimeKind.Local).AddTicks(4733) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "14f77ba3-f2f1-4215-a319-71e5b1ad6824");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "cfbcddab-cb8d-40ee-8306-4a09f3cba186");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "242ea826-fb0e-4c06-af4f-8e98571697cf", "AQAAAAEAACcQAAAAEGhHQbpbdHQJ5Wsr2mTWWjurvXMu/qLEMn9go8F6xWfo8SZMMw3PogtAPQcNxn0lcQ==", "ad955cea-756d-4e2b-9c41-b0f63ce58a52" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2955), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 11, 28, 10, 12, 38, 178, DateTimeKind.Local).AddTicks(2960) });
        }
    }
}
