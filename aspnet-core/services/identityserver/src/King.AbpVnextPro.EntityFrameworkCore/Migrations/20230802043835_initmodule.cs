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
                name: "PK_FileFiles",
                table: "FileFiles");

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
                name: "FileFiles",
                newName: "Files");

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
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataDictionaryDetail",
                table: "DataDictionaryDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataDictionary",
                table: "DataDictionary",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationSubscriptions",
                table: "NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

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
                name: "Files",
                newName: "FileFiles");

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
                name: "PK_FileFiles",
                table: "FileFiles",
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
