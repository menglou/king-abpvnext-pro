using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyName.ProjectName.Migrations
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

            migrationBuilder.RenameTable(
                name: "NoticeNotificationSubscriptions",
                newName: "NotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "NoticeNotifications",
                newName: "Notifications");

            migrationBuilder.RenameIndex(
                name: "IX_NoticeNotificationSubscriptions_NotificationId",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_NotificationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationSubscriptions",
                table: "NotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DataDictionary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Sort = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataDictionary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataDictionaryDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDictionaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Sort = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataDictionaryDetail", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DataDictionary_Name",
                table: "DataDictionary",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_DataDictionaryDetail_DataDictionaryId",
                table: "DataDictionaryDetail",
                column: "DataDictionaryId");

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
                name: "DataDictionary");

            migrationBuilder.DropTable(
                name: "DataDictionaryDetail");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationSubscriptions",
                table: "NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.RenameTable(
                name: "NotificationSubscriptions",
                newName: "NoticeNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "NoticeNotifications");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_NotificationId",
                table: "NoticeNotificationSubscriptions",
                newName: "IX_NoticeNotificationSubscriptions_NotificationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoticeNotificationSubscriptions",
                table: "NoticeNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoticeNotifications",
                table: "NoticeNotifications",
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
