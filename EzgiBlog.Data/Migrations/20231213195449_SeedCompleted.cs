using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EzgiBlog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("67966216-8006-46e1-aba2-befbfcc8be13"), "Admin Test", new DateTime(2023, 12, 13, 22, 54, 48, 930, DateTimeKind.Local).AddTicks(7052), null, null, false, null, null, "ASP NET Core" },
                    { new Guid("73cdf461-2e7b-42d8-9fc3-ae5525a5116b"), "Admin Test", new DateTime(2023, 12, 13, 22, 54, 48, 930, DateTimeKind.Local).AddTicks(7047), null, null, false, null, null, "ASP NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("8d9a4895-7412-4162-ac2a-732fdcc4d28f"), "Admin Test", new DateTime(2023, 12, 13, 22, 54, 48, 930, DateTimeKind.Local).AddTicks(7181), null, null, "images/vstest", "png", false, null, null },
                    { new Guid("9849715d-6968-4a5e-b468-638e8f4b556e"), "Admin Test", new DateTime(2023, 12, 13, 22, 54, 48, 930, DateTimeKind.Local).AddTicks(7178), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("0efcb438-64c6-40b5-89dd-2eaa5c9e6eea"), new Guid("67966216-8006-46e1-aba2-befbfcc8be13"), "Visual Studio dolor sit amet consectetur adipiscing elit mattis cras, sed etiam sodales mus pretium dapibus magna varius ut, tellus euismod eget dis porta magnis lacinia ac. Nascetur iaculis interdum facilisi donec nunc hendrerit sem integer vestibulum, ad proin ultrices magna cum consequat lacinia tempus, duis phasellus venenatis pulvinar mauris vehicula suscipit a. Neque rutrum erat arcu volutpat tortor fames leo vestibulum iaculis curae porta sociosqu, sagittis tincidunt lectus mi nec morbi parturient mus metus dictumst aptent vel, sodales accumsan penatibus cras porttitor nisl montes ullamcorper ornare non urna.\r\n\r\nLacus venenatis at morbi feugiat purus accumsan lectus enim pulvinar quis augue sociosqu, porta luctus montes metus felis mauris aliquam arcu leo vivamus facilisis, sed viverra suspendisse sapien blandit commodo scelerisque molestie libero cras ultrices. Quis feugiat semper gravida aliquam sapien blandit at penatibus nec nibh aenean porttitor, fusce justo dapibus lacinia vitae convallis et venenatis faucibus laoreet per. Vestibulum senectus at et bibendum fames risus molestie facilisi, libero quisque lacinia nunc platea donec mattis, aliquet ligula tristique conubia mauris primis metus.", "Admin Test", new DateTime(2023, 12, 13, 22, 54, 48, 930, DateTimeKind.Local).AddTicks(6878), null, null, new Guid("8d9a4895-7412-4162-ac2a-732fdcc4d28f"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("ee619251-f8b5-4f47-970c-182a332d3b41"), new Guid("73cdf461-2e7b-42d8-9fc3-ae5525a5116b"), "Lorem ipsum dolor sit amet consectetur adipiscing elit mattis cras, sed etiam sodales mus pretium dapibus magna varius ut, tellus euismod eget dis porta magnis lacinia ac. Nascetur iaculis interdum facilisi donec nunc hendrerit sem integer vestibulum, ad proin ultrices magna cum consequat lacinia tempus, duis phasellus venenatis pulvinar mauris vehicula suscipit a. Neque rutrum erat arcu volutpat tortor fames leo vestibulum iaculis curae porta sociosqu, sagittis tincidunt lectus mi nec morbi parturient mus metus dictumst aptent vel, sodales accumsan penatibus cras porttitor nisl montes ullamcorper ornare non urna.\r\n\r\nLacus venenatis at morbi feugiat purus accumsan lectus enim pulvinar quis augue sociosqu, porta luctus montes metus felis mauris aliquam arcu leo vivamus facilisis, sed viverra suspendisse sapien blandit commodo scelerisque molestie libero cras ultrices. Quis feugiat semper gravida aliquam sapien blandit at penatibus nec nibh aenean porttitor, fusce justo dapibus lacinia vitae convallis et venenatis faucibus laoreet per. Vestibulum senectus at et bibendum fames risus molestie facilisi, libero quisque lacinia nunc platea donec mattis, aliquet ligula tristique conubia mauris primis metus.", "Admin Test", new DateTime(2023, 12, 13, 22, 54, 48, 930, DateTimeKind.Local).AddTicks(6872), null, null, new Guid("9849715d-6968-4a5e-b468-638e8f4b556e"), false, null, null, "Asp.Net Deneme Makalesi 1", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0efcb438-64c6-40b5-89dd-2eaa5c9e6eea"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ee619251-f8b5-4f47-970c-182a332d3b41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67966216-8006-46e1-aba2-befbfcc8be13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73cdf461-2e7b-42d8-9fc3-ae5525a5116b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8d9a4895-7412-4162-ac2a-732fdcc4d28f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9849715d-6968-4a5e-b468-638e8f4b556e"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
