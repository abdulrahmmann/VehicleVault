using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleVault.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_UserRelation_And_FKs_ConstraintName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_SubModels_Models_ModelId",
                table: "SubModels");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFeatures_Features_PK_Feature_Id",
                table: "VehicleFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFeatures_Vehicles_PK_Vehicle_Id",
                table: "VehicleFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImages_Vehicles_VehicleId",
                table: "VehicleImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Bodies_BodyId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Categories_CategoryId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colors_ColorId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_DriveTypes_DriveTypeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_FuelTypes_FuelTypeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Makes_MakeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_SubModels_SubModelId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_TransmissionTypes_SubModelId",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UserId",
                table: "Vehicles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Make",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "PK_Make_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubModel_Model",
                table: "SubModels",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "PK_Model_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_VehicleFeatures",
                table: "VehicleFeatures",
                column: "PK_Feature_Id",
                principalTable: "Features",
                principalColumn: "PK_Feature_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleFeatures",
                table: "VehicleFeatures",
                column: "PK_Vehicle_Id",
                principalTable: "Vehicles",
                principalColumn: "PK_Vehicle_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleImages",
                table: "VehicleImages",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "PK_Vehicle_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Body",
                table: "Vehicles",
                column: "BodyId",
                principalTable: "Bodies",
                principalColumn: "PK_Body_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Category",
                table: "Vehicles",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "PK_Category_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Color",
                table: "Vehicles",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "PK_Color_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_DriveType",
                table: "Vehicles",
                column: "DriveTypeId",
                principalTable: "DriveTypes",
                principalColumn: "PK_DriveType_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_FuelType",
                table: "Vehicles",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "PK_FuelType_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Make",
                table: "Vehicles",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "PK_Make_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Model",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "PK_Model_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_SubModel",
                table: "Vehicles",
                column: "SubModelId",
                principalTable: "SubModels",
                principalColumn: "PK_SubModel_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Transmission",
                table: "Vehicles",
                column: "SubModelId",
                principalTable: "TransmissionTypes",
                principalColumn: "PK_TransmissionType_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User",
                table: "Vehicles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Make",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_SubModel_Model",
                table: "SubModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_VehicleFeatures",
                table: "VehicleFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleFeatures",
                table: "VehicleFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleImages",
                table: "VehicleImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Body",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Category",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Color",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_DriveType",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_FuelType",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Make",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Model",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_SubModel",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Transmission",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_UserId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Vehicles");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "PK_Make_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubModels_Models_ModelId",
                table: "SubModels",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "PK_Model_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFeatures_Features_PK_Feature_Id",
                table: "VehicleFeatures",
                column: "PK_Feature_Id",
                principalTable: "Features",
                principalColumn: "PK_Feature_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFeatures_Vehicles_PK_Vehicle_Id",
                table: "VehicleFeatures",
                column: "PK_Vehicle_Id",
                principalTable: "Vehicles",
                principalColumn: "PK_Vehicle_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImages_Vehicles_VehicleId",
                table: "VehicleImages",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "PK_Vehicle_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Bodies_BodyId",
                table: "Vehicles",
                column: "BodyId",
                principalTable: "Bodies",
                principalColumn: "PK_Body_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Categories_CategoryId",
                table: "Vehicles",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "PK_Category_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colors_ColorId",
                table: "Vehicles",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "PK_Color_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_DriveTypes_DriveTypeId",
                table: "Vehicles",
                column: "DriveTypeId",
                principalTable: "DriveTypes",
                principalColumn: "PK_DriveType_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_FuelTypes_FuelTypeId",
                table: "Vehicles",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "PK_FuelType_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Makes_MakeId",
                table: "Vehicles",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "PK_Make_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "PK_Model_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_SubModels_SubModelId",
                table: "Vehicles",
                column: "SubModelId",
                principalTable: "SubModels",
                principalColumn: "PK_SubModel_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_TransmissionTypes_SubModelId",
                table: "Vehicles",
                column: "SubModelId",
                principalTable: "TransmissionTypes",
                principalColumn: "PK_TransmissionType_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
