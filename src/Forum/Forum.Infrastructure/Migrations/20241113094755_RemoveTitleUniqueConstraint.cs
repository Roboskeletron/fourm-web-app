using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forum.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTitleUniqueConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Topics_Title",
                table: "Topics");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5052), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5072), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5079), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5085), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5090), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5099), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5104), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5109), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5114), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5188), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5198), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5203), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5208), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5213), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5218), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5223), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5239), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5249), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5254), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5287), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5292), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5302), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5307), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5311), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5316), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5322), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5331), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5337), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5342), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5346), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5351), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5390), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5395), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5400), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5404), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5409), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5418), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5423), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5428), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5433), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5438), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5443), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5448), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5453), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5496), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5501), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5515), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5535), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5545), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000042-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000043-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5585), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000044-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000045-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5595), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000046-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5599), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000047-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5604), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000048-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5609), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000049-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5614), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5618), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5623), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5628), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5638), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5643), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000050-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5671), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000051-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000052-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5681), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000053-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000054-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000055-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5697), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000056-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000057-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5707), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000058-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5712), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000059-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5717), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5721), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5726), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5731), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5736), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5741), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5763), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000060-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5768), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000061-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5773), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000062-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5778), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000063-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5783), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5788), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000065-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000066-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5798), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000067-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000068-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000069-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5813), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5818), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5823), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5828), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000070-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5893), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000071-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000072-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5903), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000073-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5908), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000074-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5913), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000075-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5918), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000076-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5923), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000077-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000078-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5932), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000079-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5947), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5952), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5990), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5995), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6000), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000080-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6006), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000081-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6011), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000082-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6017), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000083-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000084-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6027), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000085-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6032), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000086-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6037), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000087-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6042), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000088-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6075), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000089-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6084), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6089), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6094), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6099), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6104), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6109), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000090-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6114), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000091-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6118), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000092-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6123), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000093-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6129), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000094-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6134), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000095-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6139), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000096-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000097-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6176), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000098-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6181), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000099-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6186), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6191), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6196), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6201), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6206), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6211), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6216), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6220), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6225), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6230), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6235), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6240), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6273), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6278), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6283), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6288), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6297), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6302), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6307), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6312), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6317), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6323), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6328), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6332), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6337), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6342), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6378), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6383), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6388), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6393), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6398), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6403), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6408), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6412), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6417), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6422), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6427), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6437), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6441), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6446), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6483), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6488), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6493), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6502), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6512), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6522), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6527), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6536), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6541), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6545), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6565), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6570), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6574), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6580), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6584), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6589), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6594), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6599), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6604), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6608), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6613), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6618), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6623), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6628), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6665), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6671), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6676), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6680), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6690), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6700), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6705), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6715), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6719), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6724), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6729), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6734), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6771), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6777), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6782), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6792), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6807), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6816), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6821), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6837), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6869), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000100-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6884), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6891), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6901), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000106-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000107-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6941), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000108-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000109-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6951), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000110-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000111-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6990), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000112-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6995), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000113-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7000), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000114-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7033), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000115-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7038), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000116-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7043), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000117-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7048), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000118-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7053), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000119-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7058), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7068), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7077), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7083), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7087), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000120-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7092), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000121-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000122-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7102), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000123-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7130), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000124-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7135), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000125-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7139), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000126-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7144), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000127-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7149), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000128-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7154), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000129-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7158), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7168), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7173), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7178), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7183), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7188), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000130-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7193), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000131-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7197), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000132-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7227), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000133-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7232), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000134-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7238), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000135-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7242), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000136-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7247), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000137-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7252), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000138-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000139-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7262), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7267), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7277), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7281), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000140-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000141-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7317), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000142-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7322), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000143-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000144-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7332), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000145-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7336), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000146-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7341), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000147-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7346), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000148-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7351), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000149-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7361), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7370), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7375), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7380), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7418), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000150-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000151-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000152-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7433), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000153-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7438), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000154-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7443), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000155-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7448), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000156-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7453), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000157-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7457), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000158-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000159-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7473), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7478), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7483), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7529), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000160-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7535), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000161-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7540), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000162-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7545), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000163-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7549), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000164-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000165-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7559), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000166-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7564), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000167-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7568), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000168-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7573), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000169-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7578), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7583), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7593), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7627), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7632), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7637), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000170-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7641), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000171-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000172-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7651), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000173-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7656), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000174-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000175-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7666), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000176-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7671), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000177-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7676), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000178-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7681), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000179-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7686), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7691), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7695), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7725), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7735), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7740), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000180-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000181-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7750), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000182-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7755), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000183-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7759), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000184-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7764), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000185-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000186-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7774), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000187-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000188-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7784), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000189-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7788), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7793), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7824), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7839), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7844), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000191-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000192-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7859), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000193-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7864), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000194-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7869), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000195-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7874), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000196-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000197-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000198-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000199-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7940), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7945), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7950), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7965), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7970), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7975), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7980), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7985), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7994), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7999), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8004), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8043), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8048), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8053), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8058), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8063), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8068), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8072), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8077), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8082), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8087), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8091), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8096), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8101), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8151), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8156), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8161), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8166), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8171), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8176), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8180), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8185), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8190), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8195), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8200), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8205), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8210), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8215), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8220), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8249), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8258), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8268), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8273), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8282), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8287), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8292), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8297), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8302), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8307), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8339), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8345), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8355), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8364), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8369), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8374), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8394), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8435), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8445), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8450), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8455), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8460), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8465), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8470), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8474), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8479), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8484), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8489), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8494), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8499), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8503), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8532), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8537), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8542), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8547), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8552), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8557), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8562), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8567), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8572), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8577), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8582), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8586), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8591), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8596), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000200-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8601), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8629), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8669), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8678), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8684), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000206-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8689), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000207-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8694), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000208-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8699), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000209-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8704), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8708), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8714), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8718), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8723), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8728), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8733), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000210-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8763), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000211-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8768), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000212-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8773), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000213-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8778), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000214-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8783), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000215-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000216-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8793), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000217-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8798), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000218-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8803), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000219-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8808), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8813), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8818), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8828), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8832), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8863), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000220-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8868), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000221-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8872), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000222-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000223-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8882), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000224-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8887), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000225-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000226-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8897), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000227-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000228-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8906), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000229-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8916), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8926), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8931), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8961), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000230-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000231-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8975), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000232-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8980), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000233-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8985), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000234-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8989), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000235-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8994), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000236-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000237-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9004), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000238-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9009), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000239-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9013), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9018), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9023), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9051), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9056), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9066), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000240-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9071), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000241-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9076), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000242-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9081), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000243-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9086), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000244-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9091), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000245-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9096), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000246-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9101), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000247-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9105), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000248-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000249-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9115), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9150), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9155), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9160), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9165), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9170), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000250-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9175), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000251-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9180), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000252-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9185), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000253-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9189), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000254-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9194), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000255-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9199), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000256-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9204), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000257-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9209), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9213), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000259-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9218), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9248), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9258), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9268), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9273), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000260-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9279), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000261-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9283), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9288), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000263-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9293), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000264-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9298), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000265-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9303), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000266-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9308), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000267-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9313), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000268-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9318), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000269-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9349), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9359), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9373), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000270-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000271-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000272-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000273-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9398), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000274-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000275-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000276-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000277-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000278-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9441), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000279-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9446), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9451), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9457), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9462), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9466), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9476), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000280-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9481), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000281-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9486), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000282-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9491), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000283-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9496), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000284-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9501), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000285-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9506), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000286-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9549), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000287-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9555), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000288-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9559), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000289-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9564), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9569), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9574), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9579), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9584), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9588), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9593), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000290-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9598), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000291-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9603), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000292-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9608), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000293-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9613), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000294-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9618), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000295-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9656), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000296-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000297-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9667), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000298-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9672), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000299-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9677), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9682), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9687), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9692), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9696), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9701), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9706), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9711), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9716), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9721), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9749), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9755), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9765), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9769), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9774), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9779), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9784), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9789), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9794), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9799), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9804), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9808), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9813), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9818), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9865), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9875), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9879), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9884), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9894), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9899), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9914), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9945), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9950), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9955), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9965), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9979), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9984), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9999), new DateTime(2024, 11, 13, 9, 47, 53, 583, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(4), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(9), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(13), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(41), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(46), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(50), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(56), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(60), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(65), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(70), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(75), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(80), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(85), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(90), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(94), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(99), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(104), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(109), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(136), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(142), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(147), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(152), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(157), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(161), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(166), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(172), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(177), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(182), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(187), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(192), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(197), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(206), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(225), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(235), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(245), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(250), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(260), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(269), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(274), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(288), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(328), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(332), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000300-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(342), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(347), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(352), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000304-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(362), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000305-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(366), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000306-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(371), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000307-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(376), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000308-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(381), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000309-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(386), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(391), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(439), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(444), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(450), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000310-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(455), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000311-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(460), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000312-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(465), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000313-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(470), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000314-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(474), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000315-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(479), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000316-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000317-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000318-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(494), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000319-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(529), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(534), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(539), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(544), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(548), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000321-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000322-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000323-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(572), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000324-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(577), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000325-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(582), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000326-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(587), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000327-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(592), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000328-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(597), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000329-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(628), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(633), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(642), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(647), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(652), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(657), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000330-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(662), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000331-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(666), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000332-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(671), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000333-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(676), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000335-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(687), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000336-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000337-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(696), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000338-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(730), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000339-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(735), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(745), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(749), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(754), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(759), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(764), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000340-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(769), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000341-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(774), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000342-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(778), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000343-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000344-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(788), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000345-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(793), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000346-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(822), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000347-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(828), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000348-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(832), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000349-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(842), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(847), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(852), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(857), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(862), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(868), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000350-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(873), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000351-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(878), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000352-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(883), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000353-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(888), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000354-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(892), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000355-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(922), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000356-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(927), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000357-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(932), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000358-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(937), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000359-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(942), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(957), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000360-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000361-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000362-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000363-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000364-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000365-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1047), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000366-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1051), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000367-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1056), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000368-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000369-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1066), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1075), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1080), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1085), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1090), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1095), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000370-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1099), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000371-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1104), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000372-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1109), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000373-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000374-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000375-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1156), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000376-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1162), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000377-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1166), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000378-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1171), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000379-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1181), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1186), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1200), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000380-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1210), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000381-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1215), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000382-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000383-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1253), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000385-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1258), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000386-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1262), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000387-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1267), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000388-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1272), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000389-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1277), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1282), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1287), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1297), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1302), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1307), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000390-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1311), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000391-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1340), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000392-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1345), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000393-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1350), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000394-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1355), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000395-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000396-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1365), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000397-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000399-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1384), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1389), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1393), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1403), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1408), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1441), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1446), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1451), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1466), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1475), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1485), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1489), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1535), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1541), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1546), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1556), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1561), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1565), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1575), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1580), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1585), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1595), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1601), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1606), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1633), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1644), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1649), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1653), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1658), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1663), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1673), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1678), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1688), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1697), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1723), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1728), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1747), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1752), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1758), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1762), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1767), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1772), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1777), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1782), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1787), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1820), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1831), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1836), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1841), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1846), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1851), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1856), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1865), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1870), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1875), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1880), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1886), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1913), new DateTime(2024, 11, 13, 9, 47, 53, 584, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreatedAt",
                value: new DateTime(2024, 11, 13, 9, 47, 53, 587, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Title",
                table: "Topics",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Topics_Title",
                table: "Topics");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8545), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8562), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8566), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8569), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8572), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8576), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8597), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8601), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8604), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8608), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8611), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8615), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8617), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8621), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8623), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8626), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8628), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8632), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8634), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8637), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8657), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8662), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8665), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8676), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8678), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8681), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8683), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8686), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8689), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8692), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8712), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8718), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8721), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8723), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8726), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8729), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8731), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8734), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8736), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8739), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8742), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8744), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8747), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8749), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8783), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8786), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8789), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8791), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8794), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8796), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8799), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8801), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8804), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8810), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8812), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8815), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8820), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8839), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000042-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8844), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000043-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8847), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000044-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8849), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000045-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8851), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000046-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8854), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000047-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8857), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000048-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8859), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000049-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8862), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8864), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8867), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8872), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000050-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8893), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000051-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8896), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000052-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000053-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000054-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000055-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8906), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000056-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8909), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000057-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000058-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000059-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8919), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8922), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8954), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8957), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8963), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000060-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000061-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8968), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000062-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000063-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8973), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8975), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000065-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8978), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000066-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8981), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000067-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8983), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000068-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8986), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000069-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8989), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8991), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9021), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9024), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9032), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000070-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9035), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000071-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9038), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000072-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9040), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000073-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9043), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000074-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9045), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000075-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000076-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9051), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000077-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9053), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000078-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9056), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000079-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9058), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9078), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9081), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9084), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9086), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9089), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9091), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000080-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9094), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000081-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9096), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000082-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000083-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9103), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000084-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9105), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000085-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9130), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000086-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9133), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000087-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9136), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000088-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9139), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000089-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9141), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9144), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9146), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9149), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9151), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9154), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9157), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000090-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000091-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9162), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000092-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9164), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000093-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9167), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000094-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9187), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000095-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9190), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000096-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9192), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000097-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9195), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000098-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9197), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000099-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9200), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9202), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9205), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9207), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9213), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9215), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9218), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9223), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9248), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9255), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9258), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9261), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9266), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9268), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9271), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9273), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9276), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9279), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9281), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9284), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9304), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9307), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9310), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9312), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9315), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9317), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9320), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9322), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9325), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9328), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9336), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9338), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9356), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9359), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9362), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9367), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9373), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9385), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9391), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9423), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9425), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9433), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9438), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9441), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9443), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9446), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9451), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9479), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9482), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9485), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9488), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9493), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9496), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9498), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9501), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9504), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9506), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9509), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9511), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9514), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9517), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9557), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9560), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9562), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9565), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9567), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9570), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9573), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9575), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9578), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9583), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9586), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9588), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9591), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9594), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9615), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9618), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9621), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9623), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000100-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9628), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9632), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9652), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9655), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9658), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000106-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000107-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9663), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000108-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9666), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000109-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9669), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9671), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9674), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9677), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9679), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9682), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9684), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000110-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9687), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000111-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9690), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000112-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9719), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000113-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9722), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000114-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9724), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000115-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9727), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000116-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9729), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000117-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000118-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9735), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000119-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9737), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9742), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9745), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9747), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9752), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000120-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9755), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000121-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9777), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000122-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9779), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000123-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000124-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9785), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000125-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9787), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000126-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000127-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000128-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9795), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000129-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9803), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9805), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9808), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9811), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9834), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000130-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9837), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000131-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000132-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9842), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000133-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000134-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000135-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000136-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9853), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000137-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000138-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000139-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9866), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9869), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9871), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9894), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000140-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9897), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000141-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9899), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000142-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000143-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000144-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9907), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000145-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000146-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000147-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9914), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000148-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9917), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000149-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9922), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9925), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9949), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000150-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9957), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000151-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000152-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9962), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000153-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000154-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9967), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000155-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000156-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9972), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000157-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9975), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000158-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000159-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9982), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9985), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9998), new DateTime(2024, 10, 9, 21, 34, 57, 561, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(4), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(6), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000160-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(9), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000161-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(12), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000162-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(14), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000163-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(17), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000164-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(19), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000165-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(22), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000166-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(25), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000167-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(27), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000168-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(30), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000169-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(32), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(57), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(60), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(62), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(65), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(68), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(70), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000170-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(73), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000171-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(75), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000172-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(78), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000173-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(81), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000174-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(83), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000175-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(86), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000176-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(89), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000177-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(91), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000178-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(94), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000179-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(122), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(125), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(128), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(133), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(136), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000180-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(138), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000181-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(141), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000182-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(143), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000183-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(146), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000184-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(149), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000185-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(151), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000186-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(154), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000187-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(156), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000188-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(176), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000189-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(179), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(182), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(184), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(187), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(189), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(192), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(194), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(197), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000191-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000192-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000193-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(205), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000194-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(208), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000195-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000196-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000197-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(237), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000198-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(239), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000199-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(242), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(245), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(247), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(250), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(258), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(260), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(263), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(265), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(268), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(270), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(273), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(293), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(296), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(299), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(301), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(306), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(312), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(314), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(317), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(319), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(324), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(327), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(350), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(353), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(356), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(358), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(361), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(363), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(366), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(369), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(371), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(374), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(376), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(379), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(381), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(384), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(406), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(408), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(411), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(414), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(416), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(419), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(421), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(424), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(427), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(432), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(434), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(437), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(440), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(442), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(456), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(459), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(461), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(464), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(466), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(469), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(471), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(474), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(476), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(479), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(492), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(520), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(522), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(525), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(528), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(530), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(533), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(535), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(538), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(541), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(543), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(546), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(554), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(580), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(583), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(585), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(588), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(591), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(596), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(599), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(604), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(607), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(609), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(612), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(614), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(635), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000200-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(640), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(671), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(673), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(676), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000206-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(678), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000207-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000208-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(684), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000209-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(686), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(689), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(694), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(716), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(718), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000210-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(721), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000211-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(723), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000212-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000213-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(729), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000214-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(731), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000215-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(734), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000216-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(736), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000217-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(739), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000218-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(741), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000219-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(744), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(747), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(749), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(774), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(777), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(780), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000220-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(785), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000221-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(788), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000222-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(790), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000223-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(793), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000224-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(796), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000225-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(798), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000226-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(801), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000227-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(803), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000228-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(806), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000229-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(809), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(811), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(831), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(834), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(836), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(839), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(841), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000230-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(844), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000231-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(846), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000232-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(849), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000233-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(852), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000234-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(855), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000235-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(857), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000236-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000237-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(862), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000238-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(865), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000239-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(867), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(884), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(887), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(890), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(893), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(895), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(898), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000240-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(901), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000241-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(903), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000242-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(905), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000243-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(908), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000244-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(911), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000245-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(913), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000246-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(916), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000247-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(918), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000248-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000249-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(946), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000250-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000251-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000252-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000253-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000254-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000255-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000256-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000257-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000259-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1015), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1021), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1029), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000260-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1031), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000261-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1034), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1037), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000263-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000264-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000265-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000266-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000267-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1067), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000268-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000269-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1073), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1075), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1078), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1081), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1083), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1085), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1088), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000270-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1090), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000271-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1093), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000272-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1095), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000273-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1098), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000274-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1101), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000275-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1121), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000276-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1124), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000277-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1126), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000278-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1129), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000279-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1132), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1137), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1140), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1145), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000280-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000281-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000282-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1155), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000283-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1157), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000284-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1177), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000285-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1180), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000286-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1182), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000287-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000288-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1188), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000289-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1193), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000290-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1208), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000291-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1211), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000292-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000293-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000294-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1239), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000295-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1242), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000296-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000297-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000298-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1249), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000299-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1252), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1254), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1257), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1260), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1262), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1265), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1268), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1270), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1289), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1295), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1297), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1300), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1303), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1305), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1310), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1313), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1316), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1318), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1321), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1323), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1326), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1339), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1341), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1344), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1346), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1349), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1351), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1354), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1357), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1359), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1362), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1367), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1373), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1375), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1401), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1404), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1407), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1409), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1412), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1415), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1417), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1420), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1426), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1428), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1431), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1433), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1436), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1472), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1485), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1490), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1523), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1526), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1528), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1534), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1536), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1539), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1541), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1544), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1554), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1578), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1580), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1583), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1586), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1588), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1591), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1593), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1596), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1598), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1601), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1606), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1613), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1634), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1637), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1640), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1642), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1645), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1647), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000300-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1650), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1653), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1655), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1658), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000304-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000305-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1663), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000306-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1665), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000307-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000308-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000309-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1698), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1703), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1708), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000310-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1711), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000311-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1713), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000312-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000313-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000314-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1721), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000315-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000316-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1727), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000317-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1729), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000318-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1750), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000319-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1753), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1756), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1759), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1766), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1769), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1771), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000321-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1774), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000322-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000323-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1779), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000324-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1782), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000325-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1784), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000326-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1787), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000327-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1800), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000328-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1803), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000329-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1805), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1811), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1813), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1818), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000330-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1824), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000331-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000332-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1829), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000333-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1832), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1834), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000335-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1863), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000336-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1866), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000337-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1868), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000338-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1871), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000339-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1873), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1876), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1881), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1884), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1886), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1889), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000340-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1891), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000341-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1894), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000342-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1897), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000343-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1899), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000344-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1927), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000345-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1929), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000346-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1932), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000347-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1935), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000348-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000349-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1943), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1948), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1953), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1955), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000350-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000351-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1961), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000352-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000353-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1984), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000354-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1987), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000355-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1989), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000356-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1992), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000357-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000358-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1997), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000359-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2000), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2005), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2007), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2012), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2015), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000360-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2018), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000361-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000362-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000363-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2043), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000364-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2045), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000365-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2048), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000366-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000367-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2053), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000368-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2056), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000369-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2058), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2061), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2063), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2068), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2073), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000370-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2093), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000371-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2096), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000372-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2099), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000373-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2101), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000374-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2104), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000375-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2106), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000376-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2109), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000377-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2111), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000378-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2114), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000379-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2117), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2119), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2122), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2125), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2127), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2169), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000380-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2172), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000381-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2174), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000382-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2177), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000383-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2180), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2182), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000385-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2185), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000386-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2187), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000387-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2190), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000388-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2192), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000389-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2195), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2198), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2200), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2203), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2225), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2228), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000390-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2230), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000391-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2233), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000392-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2235), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000393-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2238), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000394-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2240), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000395-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2243), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000396-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2245), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000397-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2248), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2251), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000399-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2253), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2256), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2258), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2261), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2277), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2289), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2297), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2300), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2303), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2335), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2338), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2343), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2346), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2348), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2351), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2353), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2356), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2358), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2361), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2363), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2371), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2397), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2399), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2402), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2405), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2407), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2412), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2415), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2418), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2423), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2426), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2431), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2433), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2468), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2471), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2474), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2476), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2479), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2481), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2484), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2487), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2489), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2495), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2497), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2502), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2505), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2527), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2530), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2532), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2535), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2548), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2555), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2558), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2561), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2563), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 10, 9, 21, 34, 57, 562, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreatedAt",
                value: new DateTime(2024, 10, 9, 21, 34, 57, 563, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Title",
                table: "Topics",
                column: "Title",
                unique: true);
        }
    }
}
