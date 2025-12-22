using System.Collections.Generic;
using System.Reflection;
using EadsWebAPI.EadsDbContext.Models;
using ETSWebAPI.EadsDbContext.Models;
using ETSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using static System.Collections.Specialized.BitVector32;

namespace CloudSuiteToETSTransfer.EadsDbContext
{
    public class ECSContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = AppSettingsUtil.GetConnectionString("ECSDBConnect");
            base.OnConfiguring(optionsBuilder);
            // var connectionString = "Server=eads-etsdev.database.windows.net;Database=ETS;user id=EadsUser;password=EadsCoolTulsa2020;TrustServerCertificate=True;MultipleActiveResultSets=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public virtual DbSet<MenuModel> Menus { get; set; }
        public virtual DbSet<ProductModel> Products { get; set; }
        public virtual DbSet<AppInstanceModel> AppInstances { get; set; }
        public virtual DbSet<AppInstanceUserModel> AppInstanceUsers { get; set; }
        public virtual DbSet<AssemblyModel> Assemblys { get; set; }
        public virtual DbSet<AttachmentModel> Attachments { get; set; }
        public virtual DbSet<AuthUserModel> AuthUsers { get; set; }
        public virtual DbSet<BatchModel> Batchs { get; set; }
        public virtual DbSet<BatchProductModel> BatchProducts { get; set; }
        public virtual DbSet<BatchSectionTagModel> BatchSectionTags { get; set; }
        public virtual DbSet<CustomerModel> Customers { get; set; }
        public virtual DbSet<EnumGroupModel> EnumGroups { get; set; }



        public virtual DbSet<EnumModel> Enums { get; set; }
        public virtual DbSet<FacilityModel> Facilitys { get; set; }
        public virtual DbSet<FanModel> Fans { get; set; }
        public virtual DbSet<FileModel> Files { get; set; }
        public virtual DbSet<FinishDetailModel> FinishDetails { get; set; }
        public virtual DbSet<FolderModel> Folders { get; set; }
        public virtual DbSet<GaugeCalibrationDateModel> GaugeCalibrationDates { get; set; }
        public virtual DbSet<HydrostaticCertModel> HydrostaticCerts { get; set; }
        public virtual DbSet<LocationModel> Locations { get; set; }
        public virtual DbSet<ManufacturerModel> Manufacturers { get; set; }
        public virtual DbSet<ModelModel> Models { get; set; }

        public virtual DbSet<NBNLogModel> NBNLogs { get; set; }
        public virtual DbSet<PurchaseOrderModel> PurchaseOrders { get; set; }
        public virtual DbSet<SalesOrderModel> SalesOrders { get; set; }
        public virtual DbSet<SectionInspectionModel> SectionInspections { get; set; }
        public virtual DbSet<SectionModel> Sections { get; set; }
        public virtual DbSet<AlternateIdModel> AlternateIds { get; set; }

        public virtual DbSet<DocumentModel2> Documents { get; set; }
        public virtual DbSet<DocumentTypeModel> DocumentTypes { get; set; }
        public virtual DbSet<FieldModel> Fields { get; set; }
        public virtual DbSet<FieldValueModel> FieldValues { get; set; }
        public virtual DbSet<GroupModel> Groups { get; set; }
        public virtual DbSet<SalesOrderApprovalModel> SalesOrderApprovals { get; set; }
        public virtual DbSet<PaintColorModel> PaintColors { get; set; }
        public virtual DbSet<MappedFieldModel> MappedFields { get; set; }
        public virtual DbSet<CoolerSizeModel> CoolerSizes { get; set; }
        public virtual DbSet<PDMTransferFileModel> PDMTransferFiles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssemblyModel>(entity =>
            {
                entity.ToTable(tb => tb.HasTrigger("Assembly_Insert"));
                entity.ToTable(tb => tb.HasTrigger("Assembly_Delete"));
                entity.ToTable(tb => tb.HasTrigger("Assembly_Update"));

            });
            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.ToTable(tb => tb.HasTrigger("Product_Insert"));
                entity.ToTable(tb => tb.HasTrigger("Product_Delete"));
                entity.ToTable(tb => tb.HasTrigger("Product_Update"));

            });
        }
    }
}
