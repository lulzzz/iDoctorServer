﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AN.DAL.Migrations
{
    public partial class shiftcentervalidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notification_Ku",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notification_Ar",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notification",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Ku",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Ar",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address_Ku",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_Ar",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "an",
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Expertise",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 690, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Expertise",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 690, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ExpertiseCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 690, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ExpertiseCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 690, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Province",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 688, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Province",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 688, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Province",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 688, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ScientificCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ScientificCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ScientificCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 11, 18, 53, 689, DateTimeKind.Local).AddTicks(4093));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notification_Ku",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notification_Ar",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notification",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Ku",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Ar",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address_Ku",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Address_Ar",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "an",
                table: "ShiftCenter",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                schema: "an",
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Expertise",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 179, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Expertise",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 179, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ExpertiseCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 179, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ExpertiseCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 179, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Province",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 177, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Province",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 177, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Province",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 177, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ScientificCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ScientificCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 179, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ScientificCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 179, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "Service",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                schema: "an",
                table: "ServiceCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 11, 27, 10, 54, 23, 178, DateTimeKind.Local).AddTicks(5012));
        }
    }
}
