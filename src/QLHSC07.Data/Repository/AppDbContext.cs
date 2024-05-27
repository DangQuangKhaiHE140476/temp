using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QLHSC07.Entity;
using QLHSC07.Entity.Administrative;
using QLHSC07.Entity.ConsultCommunity;
using QLHSC07.Entity.CRM;
using QLHSC07.Entity.Document;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.IdentityExtentions.IdentityMapping;
using QLHSC07.Entity.LogHistory;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Entity.QLHSC07_MSG_Entities;
using QLHSC07.Entity.SecurityMatrix;

namespace QLHSC07.Data.Repository
{
    public class AppDbContext : IdentityDbContext<User, Role, string, UserClaim
        , UserRole, UserLogin, RoleClaim, UserTokens>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // them bang o day
        #region core table
        public override DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<EmailTemplate> EmailTemplate { get; set; }

        public DbSet<EmailGenerated> EmailGenerated { get; set; }

        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Commune> Commune { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Province> Province { get; set; }
        
        public DbSet<SecurityMatrix> SecurityMatrix { get; set; }
        public DbSet<Action> Action { get; set; }
        public DbSet<Screen> Screen { get; set; }
        public DbSet<FormTemplate> FormTemplates { get; set; }
        public DbSet<FormTemplateAnswer> FormTemplateAnswers { get; set; }
        public DbSet<FormTemplateQuestion> FormTemplateQuestions { get; set; }
        public DbSet<FileExtension> FileExtension { get; set; }
        public DbSet<LogHistoryEntity> LogHistoryEntities { get; set; }
        public DbSet<DocumentUpload> DocumentUploads { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientNote> ClientNotes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<DepositHistory> DepositHistorys { get; set; }
        #endregion
        /// <summary>
        /// DV declare db context
        /// </summary>
        #region QLHSC07 table
        public DbSet<ConstructionType> ConstructionType { get; set; }
        public DbSet<Records> Records { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public DbSet<PC07Local> PC07Local { get; set; }
        public DbSet<ProjectGroup> ProjectGroup { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<ProjectType> ProjectType { get; set; }
        public DbSet<ReceiveType> ReceiveType { get; set; }
        public DbSet<FileTypeAttachment> FileTypeAttachments { get; set; }
        public DbSet<RecordsStatus> RecordsStatus { get; set; }
        public DbSet<RecordsType> RecordsType { get; set; }
        public DbSet<Regency> Regencys { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<RecordsFile> RecordsFiles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MsgReceive> MsgReceives { get; set; }
        public DbSet<HasMsgSession> HasMsgSessions { get; set; }
        public DbSet<MsgSession> MsgSessions { get; set; }
        public DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public DbSet<DocumentAnsType> DocumentAnsTypes { get; set; }
        public DbSet<MessageHasFile> MessageHasFiles { get; set; }
        public DbSet<Flatline> Flatlines { get; set; }
        public DbSet<HistoryImportLog> HistoryImportLog { get; set; }
        public DbSet<ProjectHasCommune> ProjectHasCommune { get; set; }
        public DbSet<RecordsResultProcessing> RecordsResultProcessings { get; set; }
        public DbSet<Field> Field { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AspNetRefreshTokensMap());

            //modelBuilder.HasPostgresExtension("postgis");

            base.OnModelCreating(modelBuilder);
            #region core model builder

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserRoles)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserRole>()
                .HasOne(e => e.User)
                .WithMany(e => e.UserRoles)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(e => e.Role)
                .WithMany(e => e.UserRoles)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<UserClaim>()
                .HasOne(e => e.User)
                .WithMany(e => e.UserClaims).HasForeignKey(e => e.UserId);

            modelBuilder.Entity<RoleClaim>()
                .HasOne(e => e.Role)
                .WithMany(e => e.RoleClaims).HasForeignKey(e => e.RoleId);
            modelBuilder.Entity<DocumentUpload>()
                .HasOne(e => e.FileExtension);
            modelBuilder.Entity<EmailGenerated>()
                .HasOne(e => e.ReferenceType)
                .WithMany(e => e.EmailGenerates)
                .HasForeignKey(e => e.ReferenceTypeId);
            modelBuilder.Entity<SecurityMatrix>()
                .HasOne(e => e.Action)
                .WithMany(e => e.SecurityMatrices)
                .HasForeignKey(e => e.ActionId);
            modelBuilder.Entity<SecurityMatrix>()
                .HasOne(e => e.Screen)
                .WithMany(e => e.SecurityMatrices)
                .HasForeignKey(e => e.ScreenId);
            modelBuilder.Entity<SecurityMatrix>()
                .HasOne(e => e.Role)
                .WithMany(e => e.SecurityMatrices)
                .HasForeignKey(e => e.RoleId);
            modelBuilder.Entity<District>()
                .HasOne(e => e.Province)
                .WithMany(x => x.Districts)
                .HasForeignKey(x => x.ProvinceId).HasPrincipalKey(e => e.Id).IsRequired();
            modelBuilder.Entity<Commune>()
                .HasOne(e => e.District)
                .WithMany(x => x.Communes)
                .HasForeignKey(x => x.DistrictId).HasPrincipalKey(e => e.Id).IsRequired();

            modelBuilder.Entity<FormTemplateQuestion>()
                .HasOne(e => e.FormTemplate)
                .WithMany(e => e.Questions)
                .HasForeignKey(e => e.FormTemplateId);
            modelBuilder.Entity<PersonInfoAnswer>()
                .HasOne(e => e.FormTemplate)
                .WithMany(e => e.PersonInfoAnswers)
                .HasForeignKey(e => e.TemplateId);

            modelBuilder.Entity<FormTemplateAnswer>()
                .HasOne(e => e.Question)
                .WithMany(e => e.Answers)
                .HasForeignKey(e => e.QuestionId);

            modelBuilder.Entity<AnswerExtension>()
                .HasOne(e => e.PersonInfoAnswer)
                .WithMany(e => e.Answers)
                .HasForeignKey(e => e.PersonInfoId);


            //modelBuilder.Entity<PC07Local>()
            //    .HasOne(e => e.User)
            //    .WithMany(e => e.UserRoles)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<DocumentInfomations>()
            //    .HasOne(e => e.Role)
            //    .WithMany(e => e.UserRoles)
            //    .HasForeignKey(e => e.RoleId);
            #endregion
            modelBuilder.Entity<RecordsTypeFileType>().HasKey(sc => new { sc.RecordsTypeId, sc.FileTypeAttachmentId});

            modelBuilder.Entity<RecordsTypeFileType>()
                .HasOne<RecordsType>(sc => sc.RecordsType)
                .WithMany(s => s.RecordTypeFileTypes)
                .HasForeignKey(sc => sc.RecordsTypeId);


            modelBuilder.Entity<RecordsTypeFileType>()
                .HasOne<FileTypeAttachment>(sc => sc.FileTypeAttachment)
                .WithMany(s => s.RecordTypeFileTypes)
                .HasForeignKey(sc => sc.FileTypeAttachmentId);
           
            modelBuilder.Entity<ProjectHasCommune>()
                        .HasIndex(entity => new { entity.CommuneId, entity.ProjectId }).IsUnique(true);

            modelBuilder.Seed();
        }
    }
}


