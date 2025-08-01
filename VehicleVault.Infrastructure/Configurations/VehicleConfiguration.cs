using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleVault.Domain.Entities;

namespace VehicleVault.Infrastructure.Configurations;

public class VehicleConfiguration: BaseEntityConfiguration<Vehicle>
{
    public override void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        base.Configure(builder);
        
        // Table_Name, Index, PK_Name
        builder.ToTable("Vehicles");
        
        builder.Property(v => v.Id).HasColumnName("PK_Vehicle_Id");
        
        builder.HasIndex(v => v.MakeId);
        builder.HasIndex(v => v.SubModelId);
        builder.HasIndex(v => v.ModelId);
        builder.HasIndex(v => v.CategoryId);
        builder.HasIndex(v => v.DriveTypeId);
        builder.HasIndex(v => v.FuelTypeId);
        builder.HasIndex(v => v.BodyId);
        builder.HasIndex(v => v.TransmissionTypeId);
        builder.HasIndex(v => v.ColorId);
        
        
        // Columns_Name_Length
        builder.Property(v => v.Engine).HasMaxLength(100);
        
        builder.Property(v => v.EngineCc).HasColumnName("Engine_CC");
        
        builder.Property(v => v.EngineCylinders).HasColumnName("Engine_Cylinders");
        
        builder.Property(v => v.EngineLiterDisplay).HasColumnType("money").HasColumnName("Engine_Liter_Display");
        
        builder.Property(v => v.Name).HasMaxLength(150).HasColumnName("Vehicle_Display_Name");
        
        
        // Relations
        
        // Vehicle & Body --> One_To_Many
        builder
            .HasOne(v => v.Body)
            .WithMany(b => b.VehiclesCollection)
            .HasForeignKey(v => v.BodyId)
            .HasConstraintName("FK_Body_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & DriveType --> One_To_Many
        builder
            .HasOne(v => v.DriveType)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.DriveTypeId)
            .HasConstraintName("FK_DriveType_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & Make --> One_To_Many
        builder
            .HasOne(v => v.Make)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.MakeId)
            .HasConstraintName("FK_Make_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & FuelType --> One_To_Many
        builder
            .HasOne(v => v.FuelType)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.FuelTypeId)
            .HasConstraintName("FK_FuelType_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & Model --> One_To_Many
        builder
            .HasOne(v => v.Model)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.ModelId)
            .HasConstraintName("FK_Model_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & SubModel --> One_To_Many
        builder
            .HasOne(v => v.SubModel)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.SubModelId)
            .HasConstraintName("FK_SubModel_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & Color --> One_To_Many
        builder
            .HasOne(v => v.Color)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.ColorId)
            .HasConstraintName("FK_Color_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & Category --> One_To_Many
        builder
            .HasOne(v => v.Category)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.CategoryId)
            .HasConstraintName("FK_Category_Id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        // Vehicle & TransmissionType --> One_To_Many
        builder
            .HasOne(v => v.TransmissionType)
            .WithMany(d => d.VehiclesCollection)
            .HasForeignKey(v => v.SubModelId)
            .HasConstraintName("FK_SubModel_Id")
            .OnDelete(DeleteBehavior.Cascade);
    }
}