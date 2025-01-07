using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Forum.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTopicLikesRemoveUnusedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.CreateTable(
                name: "MessageLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    MessageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageLikes_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopicLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TopicId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopicLikes_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8224), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8246), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8250), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8257), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8261), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8264), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8303), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8306), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8309), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8312), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8317), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8323), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8326), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8330), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8333), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8336), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8339), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8341), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8345), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8371), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8374), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8377), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8380), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8383), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8386), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8388), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8391), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8396), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8403), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8405), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8408), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8411), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8433), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8439), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8441), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8444), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8447), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8450), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8452), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8455), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8458), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8461), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8464), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8466), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8469), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8472), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8475), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8477), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8499), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8502), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8505), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8508), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8511), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8513), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8516), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8519), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8521), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8524), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000042-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8527), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000043-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8530), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000044-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8533), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000045-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8536), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000046-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8561), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000047-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8565), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000048-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8567), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000049-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8570), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8573), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8576), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8579), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8581), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8584), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8587), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000050-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8590), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000051-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8593), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000052-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8596), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000053-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8599), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000054-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8602), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000055-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8605), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000056-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8625), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000057-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8628), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000058-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8631), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000059-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8634), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8637), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8640), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8642), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8645), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8647), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8650), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000060-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8653), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000061-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8656), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000062-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8659), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000063-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8664), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000065-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8667), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000066-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000067-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000068-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8695), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000069-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8698), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8701), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8704), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8707), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8709), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8712), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8715), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000070-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8718), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000071-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8720), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000072-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8723), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000073-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8726), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000074-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8728), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000075-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8731), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000076-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8734), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000077-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8748), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000078-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8751), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000079-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8753), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8756), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8759), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8761), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8764), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8767), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8770), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000080-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8773), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000081-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000082-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000083-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8807), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000084-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8810), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000085-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8813), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000086-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8815), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000087-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8818), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000088-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8821), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000089-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8824), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8827), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8832), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8835), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8837), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8840), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000090-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8843), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000091-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8846), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000092-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8875), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000093-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8878), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000094-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8881), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000095-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8884), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000096-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8886), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000097-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8889), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000098-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8892), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000099-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8895), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8897), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8900), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8903), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8905), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8908), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8911), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8914), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8916), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8919), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8941), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8944), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8947), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8950), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8952), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8955), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8958), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8961), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8964), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8966), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8969), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8972), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8975), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8977), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8980), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8983), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9008), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9011), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9014), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9017), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9020), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9023), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9025), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9028), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9031), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9034), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9036), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9039), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9042), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9044), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9066), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9069), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9072), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9075), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9077), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9080), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9083), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9086), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9088), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9091), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9094), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9096), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9099), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9102), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9104), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9107), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9110), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9136), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9139), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9142), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9144), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9147), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9150), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9153), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9156), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9158), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9161), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9164), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9167), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9169), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9172), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9175), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9198), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9200), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9203), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9206), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9209), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9211), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9214), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9217), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9220), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9222), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9225), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9228), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9230), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9233), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9236), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9239), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9252), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9255), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9258), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9261), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9264), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9267), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9270), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9273), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9276), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9279), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9282), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9284), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000100-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9287), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9290), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9335), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9337), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9340), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9343), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000106-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9346), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000107-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9349), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000108-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9352), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000109-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9354), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9357), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9360), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9386), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9389), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9392), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9395), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000110-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9397), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000111-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9400), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000112-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9403), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000113-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9406), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000114-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9408), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000115-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9411), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000116-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9414), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000117-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9417), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000118-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9420), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000119-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9422), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9425), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9428), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9453), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9456), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9459), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9461), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000120-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9464), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000121-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9467), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000122-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9470), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000123-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9473), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000124-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9475), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000125-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9478), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000126-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9481), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000127-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9483), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000128-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9486), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000129-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9489), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9492), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9495), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9515), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9518), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9521), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9524), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000130-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9526), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000131-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9529), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000132-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9532), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000133-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9535), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000134-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9538), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000135-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000136-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9543), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000137-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9546), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000138-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9549), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000139-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9551), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9557), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9559), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9579), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9582), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9585), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000140-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9587), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000141-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9590), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000142-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9593), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000143-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9596), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000144-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9598), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000145-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9601), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000146-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9604), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000147-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9607), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000148-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9609), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000149-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9612), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9615), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9618), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9620), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9640), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9643), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9646), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000150-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9648), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000151-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9651), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000152-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9654), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000153-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9656), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000154-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9659), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000155-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9662), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000156-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9665), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000157-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9667), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000158-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9670), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000159-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9673), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9675), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9678), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9681), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9703), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9706), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9709), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000160-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9711), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000161-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9714), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000162-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9717), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000163-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9720), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000164-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9722), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000165-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9725), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000166-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9728), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000167-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9731), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000168-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9733), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000169-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9736), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9739), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9741), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9744), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9747), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9761), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9764), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000170-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9767), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000171-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000172-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9772), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000173-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000174-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9777), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000175-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9780), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000176-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9783), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000177-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9786), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000178-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9788), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000179-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9791), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9794), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9797), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9799), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9844), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9848), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9850), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000180-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9853), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000181-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000182-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000183-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000184-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000185-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9867), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000186-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9870), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000187-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9873), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000188-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000189-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9879), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9882), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9884), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9887), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9890), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9915), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9918), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9921), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000191-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9923), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000192-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9926), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000193-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9929), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000194-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9932), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000195-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9934), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000196-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9937), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000197-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9940), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000198-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9942), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000199-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9945), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9948), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9950), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9953), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9956), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9977), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9980), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9983), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9985), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9988), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9991), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9994), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9996), new DateTime(2025, 1, 7, 22, 50, 50, 960, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(5), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(8), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(11), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(14), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(16), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(19), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(39), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(42), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(45), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(47), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(50), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(53), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(56), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(59), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(62), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(64), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(67), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(70), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(73), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(75), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(78), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(81), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(114), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(118), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(121), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(124), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(126), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(129), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(132), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(135), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(138), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(141), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(143), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(146), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(149), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(152), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(155), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(157), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(160), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(180), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(182), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(185), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(188), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(191), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(193), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(196), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(199), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(202), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(204), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(207), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(210), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(213), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(215), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(218), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(221), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(243), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(246), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(249), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(252), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(255), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(257), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(260), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(263), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(266), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(268), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(271), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(273), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(276), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(282), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(285), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(301), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(304), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(307), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(309), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(312), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(317), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(320), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(325), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(328), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(331), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(334), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(337), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(339), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(342), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(384), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000200-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(390), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(438), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(441), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(443), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(446), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000206-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000207-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000208-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(455), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000209-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(457), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(460), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(463), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(466), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(469), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(472), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(491), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000210-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000211-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(497), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000212-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(500), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000213-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000214-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(505), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000215-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(508), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000216-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(511), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000217-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(514), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000218-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(516), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000219-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(519), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(524), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(527), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(530), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(533), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(536), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000220-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(554), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000221-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(557), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000222-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(560), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000223-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(562), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000224-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(565), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000225-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(568), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000226-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(571), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000227-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(574), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000228-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(577), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000229-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(579), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(582), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(588), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(591), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(594), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(596), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000230-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(617), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000231-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(620), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000232-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(622), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000233-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(625), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000234-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(628), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000235-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(631), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000236-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(633), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000237-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(636), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000238-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(639), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000239-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(642), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(644), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(647), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(650), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(653), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(655), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(658), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000240-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(696), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000241-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(699), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000242-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(701), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000243-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(704), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000244-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(707), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000245-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(709), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000246-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(712), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000247-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(715), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000248-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(718), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000249-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(720), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(723), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(726), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(729), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(737), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000250-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(757), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000251-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(760), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000252-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(763), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000253-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(765), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000254-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(768), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000255-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(771), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000256-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(774), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000257-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(776), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(779), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000259-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(782), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(784), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(787), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(790), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(793), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(796), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(798), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000260-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(801), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000261-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(819), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(822), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000263-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(825), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000264-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(827), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000265-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000266-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000267-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(836), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000268-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(839), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000269-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(842), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(844), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(852), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000270-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(888), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000271-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(891), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000272-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(894), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000273-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(897), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000274-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(900), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000275-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(903), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000276-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(905), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000277-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(908), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000278-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(911), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000279-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(914), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(917), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(919), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(922), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(925), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(927), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(930), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000280-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(933), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000281-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(974), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000282-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(977), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000283-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(980), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000284-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(983), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000285-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(986), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000286-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000287-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000288-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(994), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000289-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(997), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1000), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1002), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1005), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1007), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1010), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1013), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000290-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000291-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1037), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000292-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1039), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000293-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1042), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000294-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1045), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000295-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1047), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000296-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1050), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000297-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1053), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000298-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1056), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000299-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1058), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1061), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1064), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1067), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1070), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1072), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1075), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1078), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1114), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1120), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1122), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1125), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1128), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1131), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1133), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1136), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1139), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1142), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1145), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1147), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1150), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1153), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1155), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1187), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1190), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1193), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1196), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1199), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1202), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1204), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1207), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1210), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1213), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1216), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1219), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1221), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1224), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1227), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1230), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1233), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1249), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1251), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1254), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1257), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1259), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1262), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1265), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1267), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1270), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1273), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1275), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1278), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1281), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1283), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1286), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1327), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1330), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1333), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1336), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1338), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1341), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1344), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1346), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1349), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1352), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1355), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1357), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1360), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1363), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1366), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1369), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1371), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1400), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1403), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1406), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1408), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1411), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1414), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1416), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1419), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1422), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1424), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1427), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1429), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1432), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1435), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1438), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1440), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1467), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1470), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1473), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1475), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1478), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1481), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1484), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1487), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1489), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1492), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1495), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1498), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000300-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1500), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1503), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1526), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1529), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000304-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1531), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000305-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1534), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000306-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1537), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000307-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1540), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000308-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1542), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000309-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1545), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1548), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1551), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1554), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1556), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1559), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1562), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000310-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1564), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000311-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1567), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000312-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1588), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000313-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1591), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000314-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1594), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000315-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1597), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000316-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1600), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000317-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1603), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000318-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1605), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000319-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1608), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1611), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1614), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1616), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1619), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1622), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1625), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1627), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000321-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1630), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000322-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1633), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000323-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1686), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000324-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1688), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000325-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1691), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000326-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1694), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000327-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1697), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000328-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1700), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000329-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1703), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1706), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1709), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1711), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1714), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1717), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1720), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000330-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1722), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000331-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1725), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000332-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1728), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000333-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1751), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1754), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000335-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1757), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000336-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1865), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000337-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1869), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000338-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1874), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000339-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1878), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1882), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1886), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1890), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1894), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1897), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000340-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000341-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1909), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000342-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000343-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1933), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000344-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1937), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000345-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1942), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000346-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1945), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000347-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1949), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000348-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1953), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000349-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1957), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1961), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1965), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1969), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1973), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1977), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1981), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000350-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1985), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000351-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1989), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000352-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1993), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000353-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2031), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000354-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2035), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000355-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2038), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000356-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2041), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000357-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2044), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000358-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2048), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000359-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2050), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2053), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2056), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2059), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2062), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2064), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2067), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000360-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2070), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000361-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2073), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000362-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2075), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000363-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2123), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000364-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2126), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000365-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2129), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000366-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2132), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000367-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2135), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000368-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000369-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2140), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2143), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2145), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2149), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2151), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2154), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2157), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000370-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2160), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000371-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2162), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000372-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2165), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000373-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2167), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000374-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2204), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000375-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2206), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000376-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2209), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000377-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2212), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000378-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2215), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000379-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2218), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2221), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2223), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2226), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2229), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2232), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2234), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000380-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2237), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000381-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2239), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000382-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2242), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000383-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2245), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2267), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000385-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2270), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000386-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2273), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000387-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2276), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000388-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000389-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2281), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2285), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2287), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2290), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2293), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2296), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2299), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000390-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2302), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000391-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2305), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000392-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2307), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000393-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2310), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000394-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2331), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000395-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2334), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000396-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2337), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000397-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2339), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2342), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000399-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2345), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2348), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2350), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2353), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2356), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2358), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2361), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2364), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2370), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2372), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2392), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2395), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2397), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2400), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2403), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2406), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2409), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2411), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2414), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2417), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2420), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2423), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2425), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2428), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2431), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2434), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2437), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2458), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2461), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2463), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2469), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2472), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2475), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2477), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2480), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2483), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2485), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2488), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2491), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2493), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2496), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2499), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2513), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2515), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2521), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2524), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2527), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2529), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2532), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2535), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2538), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2540), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2543), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2546), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2549), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2551), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2554), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2595), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2597), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2600), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2603), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2606), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2608), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2611), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2614), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2616), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2619), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2622), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2625), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2627), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2630), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2633), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2636), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2664), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2667), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2670), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2684), new DateTime(2025, 1, 7, 22, 50, 50, 961, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 7, 22, 50, 50, 962, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.CreateIndex(
                name: "IX_MessageLikes_MessageId",
                table: "MessageLikes",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageLikes_UserId",
                table: "MessageLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicLikes_TopicId",
                table: "TopicLikes",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicLikes_UserId",
                table: "TopicLikes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageLikes");

            migrationBuilder.DropTable(
                name: "TopicLikes");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<Guid>(type: "uuid", nullable: false),
                    MessageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MessageId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9302), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9319), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9323), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9326), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9329), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9334), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9337), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9340), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9343), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9347), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9350), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9353), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9355), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9358), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000000f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9361), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9379), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9383), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9386), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9391), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9394), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9396), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9399), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9402), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9405), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9407), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9410), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9413), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9415), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000001f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9447), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9450), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9453), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9457), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9460), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9462), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9465), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9468), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9471), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9473), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9476), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9479), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9481), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9484), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9487), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9515), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000002f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9518), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9521), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9524), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9526), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9529), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9532), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9534), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9537), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9543), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9545), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9548), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9551), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9553), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9580), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9583), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000003f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9586), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9588), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9591), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000042-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9594), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000043-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9597), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000044-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9600), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000045-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9603), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000046-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9606), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000047-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9609), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000048-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9612), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000049-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9614), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9617), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9638), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9641), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9643), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9646), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000004f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9649), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000050-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9652), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000051-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9654), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000052-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9657), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000053-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9660), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000054-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9662), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000055-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9665), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000056-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9668), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000057-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9670), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000058-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9673), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000059-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9676), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9679), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9700), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9703), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9705), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9708), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000005f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9711), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000060-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9713), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000061-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9716), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000062-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9719), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000063-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9722), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9724), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000065-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9727), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000066-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9730), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000067-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9733), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000068-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9736), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000069-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9738), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9741), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9763), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9772), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000006f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9774), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000070-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9777), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000071-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9780), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000072-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9783), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000073-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9786), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000074-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9788), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000075-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9791), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000076-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9793), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000077-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9796), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000078-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9799), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000079-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9801), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9804), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9826), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9829), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9832), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9834), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000007f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9837), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000080-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9839), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000081-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000082-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9846), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000083-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9849), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000084-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000085-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9854), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000086-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9868), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000087-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9871), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000088-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000089-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9877), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9879), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9882), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9888), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9890), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000008f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9893), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000090-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9896), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000091-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9898), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000092-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9901), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000093-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9904), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000094-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9907), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000095-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9909), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000096-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9937), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000097-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9940), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000098-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9942), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000099-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9945), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9948), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9950), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9953), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9956), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9958), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000009f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9961), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9964), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9966), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9969), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9972), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9975), new DateTime(2025, 1, 7, 13, 35, 19, 746, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(5), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(8), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(11), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(13), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(16), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(19), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(22), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(25), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(27), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(30), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(33), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(35), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(38), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(41), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(44), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(66), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(69), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(75), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(78), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(80), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(83), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(86), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(89), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(91), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(94), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(97), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(99), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(102), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(105), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(107), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(128), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(132), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(135), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(137), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(140), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(143), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(146), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(148), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(151), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(156), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(159), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(162), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(164), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(167), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(170), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(190), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(193), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(196), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(198), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(201), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(204), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(206), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(209), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(211), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(214), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(217), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(220), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(222), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(225), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(228), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(250), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(253), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(256), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(259), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(261), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(267), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(270), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(272), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(275), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(278), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(281), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(283), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(286), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(289), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(291), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(312), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(318), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(321), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(323), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(326), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(329), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(331), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(334), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(337), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(339), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000000ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(342), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000100-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(345), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(348), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(364), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(367), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(370), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(372), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000106-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(375), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000107-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(378), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000108-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(381), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000109-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(384), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(412), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(416), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(419), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(421), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000010f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(424), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000110-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(427), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000111-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(430), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000112-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(432), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000113-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(435), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000114-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(438), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000115-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(441), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000116-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(443), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000117-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(446), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000118-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000119-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(454), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(483), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(486), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(489), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(491), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000011f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000120-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(496), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000121-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(499), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000122-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000123-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(505), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000124-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(507), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000125-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(510), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000126-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(513), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000127-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(516), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000128-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(518), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000129-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(521), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(524), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(544), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(547), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(549), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(552), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000012f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(555), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000130-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(558), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000131-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(560), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000132-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(563), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000133-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(566), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000134-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(569), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000135-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(571), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000136-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(574), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000137-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(577), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000138-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(580), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000139-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(582), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(585), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(606), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(609), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(611), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(614), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000013f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(617), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000140-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(620), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000141-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(623), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000142-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(625), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000143-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(628), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000144-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(631), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000145-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(633), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000146-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(636), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000147-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(639), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000148-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(642), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000149-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(644), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(670), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(673), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(676), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(678), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(681), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000014f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(684), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000150-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(686), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000151-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(689), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000152-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(692), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000153-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(694), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000154-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(697), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000155-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(700), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000156-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(702), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000157-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(705), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000158-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(708), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000159-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(710), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(737), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(740), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(743), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000015f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(745), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000160-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(748), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000161-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000162-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(754), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000163-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(757), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000164-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(760), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000165-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(763), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000166-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(765), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000167-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(768), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000168-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(771), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000169-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(774), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(796), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(799), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(802), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(808), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000016f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(810), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000170-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000171-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000172-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(819), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000173-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(822), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000174-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(824), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000175-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(827), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000176-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000177-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000178-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(836), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000179-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(838), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(852), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(861), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(863), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000017f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(866), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000180-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(869), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000181-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(871), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000182-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000183-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(877), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000184-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(880), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000185-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(882), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000186-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(885), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000187-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(888), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000188-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(890), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000189-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(916), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(919), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(922), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(925), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(928), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(930), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000018f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(933), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(936), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000191-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(938), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000192-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(941), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000193-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(944), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000194-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(946), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000195-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(949), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000196-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(952), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000197-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(954), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000198-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(957), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000199-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(984), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(987), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(990), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(992), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(995), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(998), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000019f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1000), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1003), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1006), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1008), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1011), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1014), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1017), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1019), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1022), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1025), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1049), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1052), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1054), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1057), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1060), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1062), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1065), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1068), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1071), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1074), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1076), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1079), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1082), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1085), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1107), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1109), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1112), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1115), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1120), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1123), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1126), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1129), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1131), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1134), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1137), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1140), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1142), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1145), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1170), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1173), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1176), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1179), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1182), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1184), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1187), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1189), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1192), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1195), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1198), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1201), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1203), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1206), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1208), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1211), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1234), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1237), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1240), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1243), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1246), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1249), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1252), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1254), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1257), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1260), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1262), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1265), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1268), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1270), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1273), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1276), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1297), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1300), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1303), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1305), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1308), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1310), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1313), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1316), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1319), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1321), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1324), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1327), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1329), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1332), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1335), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1348), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1352), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1354), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1357), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1359), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1362), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1365), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1368), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000001ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1370), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000200-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1373), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1376), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1412), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1414), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1418), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1420), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000206-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1423), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000207-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1444), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000208-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1447), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000209-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1450), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1453), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1455), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1463), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000020f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000210-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1469), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000211-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1472), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000212-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1474), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000213-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1477), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000214-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1480), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000215-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1483), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000216-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1505), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000217-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1508), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000218-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1510), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000219-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1513), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1516), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1518), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1521), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1524), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1526), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000021f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1529), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000220-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1532), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000221-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1534), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000222-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1537), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000223-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1539), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000224-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1542), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000225-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1545), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000226-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1569), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000227-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1572), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000228-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1575), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000229-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1578), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1581), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1583), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1586), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1589), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1592), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000022f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1595), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000230-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1598), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000231-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1601), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000232-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1603), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000233-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1606), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000234-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1609), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000235-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1612), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000236-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1632), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000237-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1635), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000238-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1637), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000239-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1640), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1643), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1646), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1649), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1651), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1654), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000023f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1657), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000240-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1659), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000241-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1662), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000242-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000243-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1667), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000244-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1670), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000245-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1673), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000246-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1697), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000247-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1699), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000248-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1702), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000249-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1705), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1707), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1710), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1713), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1719), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000024f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1722), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000250-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1724), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000251-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1727), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000252-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1730), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000253-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1733), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000254-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1735), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000255-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1738), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000256-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1763), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000257-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1766), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1768), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000259-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1771), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1774), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1776), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1779), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1782), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1785), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000025f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1787), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000260-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1790), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000261-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1793), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1795), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000263-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1798), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000264-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1801), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000265-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1814), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000266-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1818), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000267-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1821), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000268-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1823), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000269-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1826), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1829), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1831), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1834), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1837), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1840), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000026f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1842), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000270-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1845), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000271-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1848), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000272-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1850), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000273-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1853), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000274-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1856), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000275-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1884), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000276-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1887), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000277-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1890), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000278-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1893), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000279-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1899), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1908), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000027f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000280-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1916), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000281-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000282-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1921), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000283-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1924), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000284-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1955), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000285-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1957), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000286-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1960), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000287-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1963), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000288-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1966), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000289-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1969), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1971), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1974), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1977), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1979), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1982), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000028f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1985), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000290-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000291-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1990), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000292-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1993), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000293-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1995), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000294-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2017), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000295-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2019), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000296-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2022), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000297-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2025), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000298-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2027), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000299-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2030), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2033), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2036), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2038), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2041), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2044), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000029f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2047), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2049), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2052), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2055), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2057), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2081), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2084), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2087), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2089), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2092), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2095), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2098), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2101), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2103), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2106), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2109), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2111), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2114), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2117), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2119), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2122), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2143), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2148), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2151), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2153), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2156), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2159), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2162), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2164), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2167), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2170), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2172), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2175), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2178), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2180), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2201), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2204), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2207), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2210), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2212), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2215), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2218), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2220), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2223), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2226), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2228), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2231), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2234), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2237), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2239), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2242), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2263), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2265), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2268), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2271), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2273), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2276), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2282), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2284), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2287), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2290), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2292), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2295), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2298), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2300), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2303), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2317), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2320), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2322), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2325), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2328), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2331), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002e9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2333), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ea-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2336), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002eb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2339), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ec-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2342), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ed-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2345), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ee-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2347), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ef-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2350), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2353), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2355), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2381), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2384), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2387), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2390), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2392), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2395), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2397), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002f9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2400), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2403), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2406), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2409), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2412), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002fe-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2414), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000002ff-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2417), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000300-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2420), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2423), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2450), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2453), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000304-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2456), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000305-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2458), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000306-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2461), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000307-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2463), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000308-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000309-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2469), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2472), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2474), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2477), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2480), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2483), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000030f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2485), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000310-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2488), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000311-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2491), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000312-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2512), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000313-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2515), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000314-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000315-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000316-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2523), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000317-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000318-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2528), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000319-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2531), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2534), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2537), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2539), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2542), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2545), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000031f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2547), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2550), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000321-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2553), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000322-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2574), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000323-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2577), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000324-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2580), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000325-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2583), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000326-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2586), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000327-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2588), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000328-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2591), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000329-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2594), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2596), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2599), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2602), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2604), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2607), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000032f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2610), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000330-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2613), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000331-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2634), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000332-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2637), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000333-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2640), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2642), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000335-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2645), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000336-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2648), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000337-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2651), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000338-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2654), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000339-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2656), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2659), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2665), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2670), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000033f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000340-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2676), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000341-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2700), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000342-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2703), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000343-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2705), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000344-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2708), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000345-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000346-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000347-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2716), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000348-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2719), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000349-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2722), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2724), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2727), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2730), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2733), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2735), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000034f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2738), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000350-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2740), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000351-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2761), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000352-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2764), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000353-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2767), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000354-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2769), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000355-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2772), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000356-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2775), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000357-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2778), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000358-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2780), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000359-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2783), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2786), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2788), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2791), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2794), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2796), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000035f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2799), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000360-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2802), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000361-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2816), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000362-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2819), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000363-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2821), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000364-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2824), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000365-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2827), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000366-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2830), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000367-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2833), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000368-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2835), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000369-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2838), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2841), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2844), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2846), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2849), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2852), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000036f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2855), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000370-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2882), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000371-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2885), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000372-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2887), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000373-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2890), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000374-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2893), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000375-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2896), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000376-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2898), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000377-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2901), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000378-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2904), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000379-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2907), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2909), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2912), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2915), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2917), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2920), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000037f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2923), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000380-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2951), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000381-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2954), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000382-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2956), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000383-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2959), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2961), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000385-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2964), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000386-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2967), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000387-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2970), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000388-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2972), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000389-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2975), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2978), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2980), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2983), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2985), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2988), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000038f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3008), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000390-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000391-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3014), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000392-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3017), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000393-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3019), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000394-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3022), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000395-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3025), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000396-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3027), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000397-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3030), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3033), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000399-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3036), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039a-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3038), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039b-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3041), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039c-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3044), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039d-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3047), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039e-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3049), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0000039f-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3070), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3073), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3076), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3079), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3081), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3084), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3087), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3090), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3092), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3095), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003a9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3098), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003aa-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3101), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ab-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3103), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3106), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ad-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3109), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ae-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3112), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003af-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3132), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3135), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3138), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3141), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3144), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3146), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3149), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3152), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3155), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3157), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003b9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3160), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ba-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3163), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3169), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3172), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003be-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3174), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003bf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3198), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3201), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3206), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3209), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3211), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3214), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3217), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3220), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3223), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003c9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3225), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ca-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3228), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cb-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3231), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3233), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3236), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003ce-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003cf-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3268), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3271), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3274), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3277), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3280), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3285), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3288), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3290), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003d9-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3293), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003da-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3296), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003db-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3298), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dc-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3301), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003dd-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3304), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003de-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3320), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003df-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3323), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e0-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3326), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e1-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3328), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e2-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3331), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e3-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3334), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e4-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3336), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e5-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3339), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e6-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3342), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e7-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3344), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("000003e8-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3358), new DateTime(2025, 1, 7, 13, 35, 19, 747, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 7, 13, 35, 19, 748, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.CreateIndex(
                name: "IX_Files_MessageId",
                table: "Files",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_MessageId",
                table: "Likes",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UserId",
                table: "RoleUser",
                column: "UserId");
        }
    }
}
