using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GS.IDP.Migrations
{
    public partial class AddUserSecret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersLogins_Users_UserId",
                table: "UsersLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersLogins",
                table: "UsersLogins");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("337dc567-4cd4-447d-ae99-284aac06c20f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("911eb3e7-4dee-4a29-a792-facd446c43f3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("988e2ffb-8c7b-4ceb-bc74-63c86ec8100a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a87d1ecd-56b2-49a5-92c8-782d5eca075a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b1550eae-2279-4c81-ad48-17690a29ed67"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b2643f41-f4f1-4341-ad29-0690567bb020"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ef09cf8d-9a78-49ac-bdab-33381897f12a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f96eb1c8-0244-42dc-a6e6-36dcfdc5f3d6"));

            migrationBuilder.RenameTable(
                name: "UsersLogins",
                newName: "UserLogins");

            migrationBuilder.RenameIndex(
                name: "IX_UsersLogins_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                column: "Id");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("0ed20baa-c792-4331-85b2-60013ac4da5e"), "8ae71167-24a7-4bfb-9248-fe2675628051", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("0f21fed7-997f-46c9-951c-e33534ad8322"), "b8d046e6-2071-4927-9aae-55a129ce3466", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("2c1cd1ff-2f13-42d0-89cb-e8cd900caf61"), "710f9c2b-9c47-48be-95f2-13230423422f", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("2e4caf04-a75c-4815-99e4-444ddab007a2"), "a2c13680-ee6b-4310-b315-8a06985752b2", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("31044339-c25f-4d01-bacd-93ea196f19f3"), "4977a00a-3724-43ed-8835-38c7bb3348c9", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("35bac0ef-055a-4ac1-b7eb-736f65b58ad7"), "22beb7fe-e684-49b6-b2f2-29dedea99ef9", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("8d47919d-be5b-4e8b-9212-16a7e408ad32"), "6e0ebfe1-ea2c-45aa-9c6a-67c167db0143", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("a2322016-625a-462c-8a3b-d0e62fb83118"), "7a391b8e-39d4-46ad-a9d2-6123201f27f7", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "0ac0c080-da6b-4e06-bd0c-f890af100fae");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "aee30eff-616c-4e93-af41-482f9cc66465");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0ed20baa-c792-4331-85b2-60013ac4da5e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0f21fed7-997f-46c9-951c-e33534ad8322"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2c1cd1ff-2f13-42d0-89cb-e8cd900caf61"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2e4caf04-a75c-4815-99e4-444ddab007a2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("31044339-c25f-4d01-bacd-93ea196f19f3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("35bac0ef-055a-4ac1-b7eb-736f65b58ad7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8d47919d-be5b-4e8b-9212-16a7e408ad32"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a2322016-625a-462c-8a3b-d0e62fb83118"));

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "UsersLogins");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "UsersLogins",
                newName: "IX_UsersLogins_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersLogins",
                table: "UsersLogins",
                column: "Id");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("337dc567-4cd4-447d-ae99-284aac06c20f"), "a45b7efc-d080-4b8b-8a9b-c140580acfa2", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("911eb3e7-4dee-4a29-a792-facd446c43f3"), "1ca2b20e-bd25-4306-b869-5ed0f5e7ca03", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("988e2ffb-8c7b-4ceb-bc74-63c86ec8100a"), "9a364ce9-55ad-41e1-bde0-15bf03e79af0", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("a87d1ecd-56b2-49a5-92c8-782d5eca075a"), "313220e8-4d30-406f-ad19-24337a8eeb75", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("b1550eae-2279-4c81-ad48-17690a29ed67"), "3b019e47-1e26-4ba4-9e60-39135886c41b", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("b2643f41-f4f1-4341-ad29-0690567bb020"), "48561578-5f3a-4528-9a58-65058e5bd4db", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("ef09cf8d-9a78-49ac-bdab-33381897f12a"), "6349e0e8-cb1a-4034-a69c-b4f988b3d3c2", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("f96eb1c8-0244-42dc-a6e6-36dcfdc5f3d6"), "e1033fa7-557f-4d1d-835c-85944b71ce03", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "ab646ee0-3c05-4af7-b72a-1d16bd65441b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "b46cf9bb-d567-43b4-aa35-9573f459b6aa");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersLogins_Users_UserId",
                table: "UsersLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
