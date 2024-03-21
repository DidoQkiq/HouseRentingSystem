using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhonenumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3379660d-9dfc-4672-bb67-028f7c39ea1c", "AQAAAAEAACcQAAAAEAArqTOTf40q6EGjfkjDjNtCFpKaN4W2o/SYM+mCQsm408X4rWgddiW8vCknhEq5hA==", "d6f77ef9-b54f-4542-b163-fd42f8eeba7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fc8a390-e605-452d-b6d1-ebd4c6e7216e", "AQAAAAEAACcQAAAAEA23VYASNZy3h7ffzGFSZylQTP1iJTgTAAOqxsurU9Ceacoq358+u84PkMtQ6om0GA==", "12d41360-e8d4-41fd-ad0c-800f45ddc05c" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112f9e11-ee0f-4bb3-81a5-3adc860eabc4", "AQAAAAEAACcQAAAAELOPcGPsesEhCpP1ElGt6dUbs7CqCrPsbfZYqV27psCK6hhToyS6/7qCxLxnA9X3Hg==", "de2ed81a-1ff5-4e58-8838-28c6280dbb92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59bef7e7-56a4-47ff-89c4-c8a7efdcf541", "AQAAAAEAACcQAAAAEHtPe6uSIxt1WbQz9UeGYNy6PpdgNka1z6f9Y8fpHLed0HI7tpoEzu+XK+JHc5sPjA==", "1e7ab2ab-7ae7-485b-8b0e-d14d311376b7" });
        }
    }
}
