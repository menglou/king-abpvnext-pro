using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace King.AbpVnextPro.Migrations
{
    public partial class initmodule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NoticeNotificationSubscriptions_NoticeNotifications_NotificationId",
                table: "NoticeNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NoticeNotificationSubscriptions",
                table: "NoticeNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NoticeNotifications",
                table: "NoticeNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DictionaryDataDictionaryDetail",
                table: "DictionaryDataDictionaryDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DictionaryDataDictionary",
                table: "DictionaryDataDictionary");

            migrationBuilder.RenameTable(
                name: "NoticeNotificationSubscriptions",
                newName: "NotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "NoticeNotifications",
                newName: "Notifications");

            migrationBuilder.RenameTable(
                name: "DictionaryDataDictionaryDetail",
                newName: "DataDictionaryDetail");

            migrationBuilder.RenameTable(
                name: "DictionaryDataDictionary",
                newName: "DataDictionary");

            migrationBuilder.RenameIndex(
                name: "IX_NoticeNotificationSubscriptions_NotificationId",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_NotificationId");

            migrationBuilder.RenameIndex(
                name: "IX_DictionaryDataDictionaryDetail_DataDictionaryId",
                table: "DataDictionaryDetail",
                newName: "IX_DataDictionaryDetail_DataDictionaryId");

            migrationBuilder.RenameIndex(
                name: "IX_DictionaryDataDictionary_Name",
                table: "DataDictionary",
                newName: "IX_DataDictionary_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationSubscriptions",
                table: "NotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataDictionaryDetail",
                table: "DataDictionaryDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataDictionary",
                table: "DataDictionary",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    BlobName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ByteSize = table.Column<long>(type: "bigint", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSubscriptions_Notifications_NotificationId",
                table: "NotificationSubscriptions",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationSubscriptions_Notifications_NotificationId",
                table: "NotificationSubscriptions");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationSubscriptions",
                table: "NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataDictionaryDetail",
                table: "DataDictionaryDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataDictionary",
                table: "DataDictionary");

            migrationBuilder.RenameTable(
                name: "NotificationSubscriptions",
                newName: "NoticeNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "NoticeNotifications");

            migrationBuilder.RenameTable(
                name: "DataDictionaryDetail",
                newName: "DictionaryDataDictionaryDetail");

            migrationBuilder.RenameTable(
                name: "DataDictionary",
                newName: "DictionaryDataDictionary");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_NotificationId",
                table: "NoticeNotificationSubscriptions",
                newName: "IX_NoticeNotificationSubscriptions_NotificationId");

            migrationBuilder.RenameIndex(
                name: "IX_DataDictionaryDetail_DataDictionaryId",
                table: "DictionaryDataDictionaryDetail",
                newName: "IX_DictionaryDataDictionaryDetail_DataDictionaryId");

            migrationBuilder.RenameIndex(
                name: "IX_DataDictionary_Name",
                table: "DictionaryDataDictionary",
                newName: "IX_DictionaryDataDictionary_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoticeNotificationSubscriptions",
                table: "NoticeNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoticeNotifications",
                table: "NoticeNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DictionaryDataDictionaryDetail",
                table: "DictionaryDataDictionaryDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DictionaryDataDictionary",
                table: "DictionaryDataDictionary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NoticeNotificationSubscriptions_NoticeNotifications_NotificationId",
                table: "NoticeNotificationSubscriptions",
                column: "NotificationId",
                principalTable: "NoticeNotifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
