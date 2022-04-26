using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FarahProjest.Models
{
    public partial class FarahContext : DbContext
    {
        
        public FarahContext(DbContextOptions<FarahContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbActivity> TbActivities { get; set; }
        public virtual DbSet<TbAidBasket> TbAidBaskets { get; set; }
        public virtual DbSet<TbAsset> TbAssets { get; set; }
        public virtual DbSet<TbBenefactor> TbBenefactors { get; set; }
        public virtual DbSet<TbCategory> TbCategories { get; set; }
        public virtual DbSet<TbContact> TbContacts { get; set; }
        public virtual DbSet<TbContactAddress> TbContactAddresses { get; set; }
        public virtual DbSet<TbContactDetail> TbContactDetails { get; set; }
        public virtual DbSet<TbCourse> TbCourses { get; set; }
        public virtual DbSet<TbDemandOrder> TbDemandOrders { get; set; }
        public virtual DbSet<TbDonation> TbDonations { get; set; }
        public virtual DbSet<TbFacebookUser> TbFacebookUsers { get; set; }
        public virtual DbSet<TbFamilyAsset> TbFamilyAssets { get; set; }
        public virtual DbSet<TbFamilyBeneficiary> TbFamilyBeneficiaries { get; set; }
        public virtual DbSet<TbFamilyMember> TbFamilyMembers { get; set; }
        public virtual DbSet<TbFamilyStatus> TbFamilyStatuses { get; set; }
        public virtual DbSet<TbFile> TbFiles { get; set; }
        public virtual DbSet<TbFileFamily> TbFileFamilies { get; set; }
        public virtual DbSet<TbGallery> TbGalleries { get; set; }
        public virtual DbSet<TbGalleryPic> TbGalleryPics { get; set; }
        public virtual DbSet<TbGoogleUser> TbGoogleUsers { get; set; }
        public virtual DbSet<TbMaterial> TbMaterials { get; set; }
        public virtual DbSet<TbMemberActivity> TbMemberActivities { get; set; }
        public virtual DbSet<TbMemberCourse> TbMemberCourses { get; set; }
        public virtual DbSet<TbMembership> TbMemberships { get; set; }
        public virtual DbSet<TbMonthlySalary> TbMonthlySalaries { get; set; }
        public virtual DbSet<TbNotification> TbNotifications { get; set; }
        public virtual DbSet<TbOffer> TbOffers { get; set; }
        public virtual DbSet<TbRole> TbRoles { get; set; }
        public virtual DbSet<TbSession> TbSessions { get; set; }
        public virtual DbSet<TbSkill> TbSkills { get; set; }
        public virtual DbSet<TbSponser> TbSponsers { get; set; }
        public virtual DbSet<TbSponserOrder> TbSponserOrders { get; set; }
        public virtual DbSet<TbStore> TbStores { get; set; }
        public virtual DbSet<TbTempAuth> TbTempAuths { get; set; }
        public virtual DbSet<TbTimesZone> TbTimesZones { get; set; }
        public virtual DbSet<TbUpdatingSponser> TbUpdatingSponsers { get; set; }
        public virtual DbSet<TbUser> TbUsers { get; set; }
        public virtual DbSet<TbUserInRole> TbUserInRoles { get; set; }
        public virtual DbSet<TbUserNotification> TbUserNotifications { get; set; }
        public virtual DbSet<TbVolunteer> TbVolunteers { get; set; }
        public virtual DbSet<TbVolunteerActivity> TbVolunteerActivities { get; set; }
        public virtual DbSet<TbVolunteerCourse> TbVolunteerCourses { get; set; }
        public virtual DbSet<TbdimCity> TbdimCities { get; set; }
        public virtual DbSet<TbdimCountry> TbdimCountries { get; set; }
        public virtual DbSet<TbdimFileExtension> TbdimFileExtensions { get; set; }
        public virtual DbSet<TbdimProvince> TbdimProvinces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TbActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__tbActivi__45F4A79138AB0B05");

                entity.ToTable("tbActivity");

                entity.Property(e => e.ActivityId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.NameActivity)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Place).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TargetActivity).HasMaxLength(50);
            });

            modelBuilder.Entity<TbAidBasket>(entity =>
            {
                entity.HasKey(e => e.AidBasketId);

                entity.ToTable("tbAidBasket");

                entity.Property(e => e.AidBasketId).ValueGeneratedNever();

                entity.Property(e => e.BasketDate).HasColumnType("date");

                entity.Property(e => e.BasketRecievedDate).HasColumnType("date");

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.RecieverName).HasMaxLength(50);

                entity.Property(e => e.StatusBasket).HasMaxLength(50);
            });

            modelBuilder.Entity<TbAsset>(entity =>
            {
                entity.HasKey(e => e.AssetId);

                entity.ToTable("tbAsset");

                entity.Property(e => e.AssetId).ValueGeneratedNever();

                entity.Property(e => e.AssetName).HasMaxLength(50);

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbBenefactor>(entity =>
            {
                entity.HasKey(e => e.BenefactorId);

                entity.ToTable("tbBenefactor");

                entity.Property(e => e.BenefactorId).ValueGeneratedNever();

                entity.Property(e => e.BenefactorName).HasMaxLength(50);

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tbCategory");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbContact>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK_tbContact_1");

                entity.ToTable("tbContact");

                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TbContactAddress>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("tbContactAddress");

                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.AddressDetail).HasMaxLength(256);

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.GeogText).HasComputedColumnSql("([GeogInfo].[STAsText]())", false);
            });

            modelBuilder.Entity<TbContactDetail>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("tbContactDetail");

                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__tbCourse__C92D71A7FB11090A");

                entity.ToTable("tbCourse");

                entity.Property(e => e.CourseId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.NameCouse)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Place).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TargetCourse).HasMaxLength(50);
            });

            modelBuilder.Entity<TbDemandOrder>(entity =>
            {
                entity.HasKey(e => e.DemandOrderId)
                    .HasName("PK__tbDemand__0C1994C13E2B420F");

                entity.ToTable("tbDemandOrder");

                entity.Property(e => e.DemandOrderId).ValueGeneratedNever();

                entity.Property(e => e.AcceptOrderDate).HasColumnType("date");

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.DemandOrderDate).HasColumnType("date");

                entity.Property(e => e.DescriptionDemand).HasMaxLength(100);

                entity.Property(e => e.RejectOrderDate).HasColumnType("date");

                entity.Property(e => e.StatusOrder).HasMaxLength(50);

                entity.HasOne(d => d.Benefactor)
                    .WithMany(p => p.TbDemandOrders)
                    .HasForeignKey(d => d.BenefactorId)
                    .HasConstraintName("FK__tbDemandO__Benef__18B6AB08");

                entity.HasOne(d => d.FamilyBeneficiary)
                    .WithMany(p => p.TbDemandOrders)
                    .HasForeignKey(d => d.FamilyBeneficiaryId)
                    .HasConstraintName("FK__tbDemandO__Famil__16CE6296");

                entity.HasOne(d => d.Sponser)
                    .WithMany(p => p.TbDemandOrders)
                    .HasForeignKey(d => d.SponserId)
                    .HasConstraintName("FK__tbDemandO__Spons__17C286CF");
            });

            modelBuilder.Entity<TbDonation>(entity =>
            {
                entity.HasKey(e => e.DonationId);

                entity.ToTable("tbDonation");

                entity.Property(e => e.DonationId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.RecievedDate).HasColumnType("date");

                entity.Property(e => e.StatusDonation).HasMaxLength(50);

                entity.Property(e => e.TypeDonation).HasMaxLength(50);
            });

            modelBuilder.Entity<TbFacebookUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbFacebookUser");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.FaceBookId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TbFamilyAsset>(entity =>
            {
                entity.HasKey(e => e.FamilyAssetId);

                entity.ToTable("tbFamilyAsset");

                entity.Property(e => e.FamilyAssetId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusAsset).HasMaxLength(50);
            });

            modelBuilder.Entity<TbFamilyBeneficiary>(entity =>
            {
                entity.HasKey(e => e.FamilyBeneficiaryId);

                entity.ToTable("tbFamilyBeneficiary");

                entity.Property(e => e.FamilyBeneficiaryId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.DetectionDate).HasColumnType("date");

                entity.Property(e => e.FamilyIncoming).HasMaxLength(300);

                entity.Property(e => e.MonthlyIncoming).HasMaxLength(50);

                entity.Property(e => e.NiceName).HasMaxLength(50);

                entity.Property(e => e.OrderSenderAdj).HasMaxLength(50);

                entity.Property(e => e.OrderSenderName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<TbFamilyMember>(entity =>
            {
                entity.HasKey(e => e.FamilyMemberId)
                    .HasName("PK_tbFileMember");

                entity.ToTable("tbFamilyMember");

                entity.Property(e => e.FamilyMemberId).ValueGeneratedNever();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.ClassMember).HasMaxLength(50);

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.HealthState).HasMaxLength(50);

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SocialState).HasMaxLength(50);

                entity.Property(e => e.TypeMember).HasMaxLength(50);
            });

            modelBuilder.Entity<TbFamilyStatus>(entity =>
            {
                entity.HasKey(e => e.FamilyStatusId);

                entity.ToTable("tbFamilyStatus");

                entity.Property(e => e.FamilyStatusId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("tbFile");

                entity.Property(e => e.FileId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");
            });

            modelBuilder.Entity<TbFileFamily>(entity =>
            {
                entity.HasKey(e => e.FileFamilyId);

                entity.ToTable("tbFileFamily");

                entity.Property(e => e.FileFamilyId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.FileName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbGallery>(entity =>
            {
                entity.HasKey(e => e.GalleryId);

                entity.ToTable("tbGallery");

                entity.Property(e => e.GalleryId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Details).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(1550);
            });

            modelBuilder.Entity<TbGalleryPic>(entity =>
            {
                entity.HasKey(e => e.GalleryPicId);

                entity.ToTable("tbGalleryPic");

                entity.Property(e => e.GalleryPicId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Details).HasMaxLength(1500);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(1500);
            });

            modelBuilder.Entity<TbGoogleUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbGoogleUser");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.GoogleId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMaterial>(entity =>
            {
                entity.HasKey(e => e.MaterialId);

                entity.ToTable("tbMaterial");

                entity.Property(e => e.MaterialId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.MaterialName).HasMaxLength(50);

                entity.Property(e => e.MaterialStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<TbMemberActivity>(entity =>
            {
                entity.HasKey(e => e.MemberActivityId)
                    .HasName("PK__tbMember__7932E9AD52552237");

                entity.ToTable("tbMemberActivity");

                entity.Property(e => e.MemberActivityId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TbMemberActivities)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbMemberA__Activ__078C1F06");

                entity.HasOne(d => d.FamilyMember)
                    .WithMany(p => p.TbMemberActivities)
                    .HasForeignKey(d => d.FamilyMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbMemberA__Famil__0697FACD");
            });

            modelBuilder.Entity<TbMemberCourse>(entity =>
            {
                entity.HasKey(e => e.MemberCourseId)
                    .HasName("PK__tbMember__B47E18E7DFFEFC73");

                entity.ToTable("tbMemberCourse");

                entity.Property(e => e.MemberCourseId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TbMemberCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbMemberC__Cours__02C769E9");

                entity.HasOne(d => d.FamilyMember)
                    .WithMany(p => p.TbMemberCourses)
                    .HasForeignKey(d => d.FamilyMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbMemberC__Famil__03BB8E22");
            });

            modelBuilder.Entity<TbMembership>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbMembership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordFormat).HasDefaultValueSql("((0))");

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);
            });

            modelBuilder.Entity<TbMonthlySalary>(entity =>
            {
                entity.HasKey(e => e.MonthlySalaryId);

                entity.ToTable("tbMonthlySalary");

                entity.Property(e => e.MonthlySalaryId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.RecievedDate).HasColumnType("date");

                entity.Property(e => e.RecievedName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbNotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("tbNotification");

                entity.Property(e => e.NotificationId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.NotificationDescription).HasMaxLength(50);

                entity.Property(e => e.NotificationName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbOffer>(entity =>
            {
                entity.HasKey(e => e.OfferId)
                    .HasName("PK__tbOffer__8EBCF0917CC11372");

                entity.ToTable("tbOffer");

                entity.Property(e => e.OfferId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.OfferAcceptDate).HasColumnType("date");

                entity.Property(e => e.OfferDate).HasColumnType("date");

                entity.Property(e => e.OfferRejectDate).HasColumnType("date");

                entity.Property(e => e.OfferStatus).HasMaxLength(50);

                entity.Property(e => e.TypeOffer).HasMaxLength(50);

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.TbOffers)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK__tbOffer__Materia__11158940");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TbOffers)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbOffer__OrderId__10216507");
            });

            modelBuilder.Entity<TbRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("tbRoles");

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TbSession>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("tbSession");

                entity.Property(e => e.SessionId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceCode).HasMaxLength(50);

                entity.Property(e => e.FirebaseToken).HasMaxLength(500);

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.TokenCode).HasMaxLength(50);

                entity.Property(e => e.VersionNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<TbSkill>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__tbSkills__DFA0918791156BBE");

                entity.ToTable("tbSkills");

                entity.Property(e => e.SkillId).ValueGeneratedNever();

                entity.Property(e => e.NameSkill)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSponser>(entity =>
            {
                entity.HasKey(e => e.SponserId)
                    .HasName("PK__tbSponse__F632EA3795ABB592");

                entity.ToTable("tbSponser");

                entity.Property(e => e.SponserId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SponserAddress).HasMaxLength(50);

                entity.Property(e => e.SponserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<TbSponserOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tbSponse__C3905BCFA8C49A86");

                entity.ToTable("tbSponserOrder");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.SponserSalary).HasMaxLength(20);

                entity.Property(e => e.SponserShipPeriod).HasMaxLength(50);

                entity.Property(e => e.SponsorAcceptDate).HasColumnType("date");

                entity.Property(e => e.SponsorRejectDate).HasColumnType("date");

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.Property(e => e.StatusOrder).HasMaxLength(50);

                entity.HasOne(d => d.FamilyBeneficiary)
                    .WithMany(p => p.TbSponserOrders)
                    .HasForeignKey(d => d.FamilyBeneficiaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbSponser__Famil__0D44F85C");

                entity.HasOne(d => d.Sponser)
                    .WithMany(p => p.TbSponserOrders)
                    .HasForeignKey(d => d.SponserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbSponser__Spons__0C50D423");
            });

            modelBuilder.Entity<TbStore>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.ToTable("tbStore");

                entity.Property(e => e.StoreId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbTempAuth>(entity =>
            {
                entity.HasKey(e => e.ClusterId);

                entity.ToTable("tbTempAuth");

                entity.Property(e => e.AuthCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbTimesZone>(entity =>
            {
                entity.HasKey(e => e.TimeZoneId);

                entity.ToTable("tbTimesZone");

                entity.Property(e => e.TimeZoneId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.TimeZoneName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TbUpdatingSponser>(entity =>
            {
                entity.HasKey(e => e.UpdateId)
                    .HasName("PK__tbUpdati__3C748E7AAD123013");

                entity.ToTable("tbUpdatingSponser");

                entity.Property(e => e.UpdateId)
                    .ValueGeneratedNever()
                    .HasColumnName("updateId");

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.Signature).HasMaxLength(20);

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TbUpdatingSponsers)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__tbUpdatin__Order__13F1F5EB");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbUsers");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClusterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CLusterId");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TbUserInRole>(entity =>
            {
                entity.HasKey(e => e.ClusterId);

                entity.ToTable("tbUserInRole");
            });

            modelBuilder.Entity<TbUserNotification>(entity =>
            {
                entity.HasKey(e => e.UserNotification);

                entity.ToTable("tbUserNotification");

                entity.Property(e => e.UserNotification).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbVolunteer>(entity =>
            {
                entity.HasKey(e => e.VolunteerId)
                    .HasName("PK__tbVolunt__716F6F2CEBA9A03F");

                entity.ToTable("tbVolunteer");

                entity.Property(e => e.VolunteerId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SocialStatus).HasMaxLength(50);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .HasColumnName("telephone");

                entity.Property(e => e.VolunteerName).HasMaxLength(50);

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.TbVolunteers)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbVolunte__Skill__74794A92");
            });

            modelBuilder.Entity<TbVolunteerActivity>(entity =>
            {
                entity.HasKey(e => e.VolunteerActivityId)
                    .HasName("PK__tbVolunt__7CDC8D6C4CCF496A");

                entity.ToTable("tbVolunteerActivity");

                entity.Property(e => e.VolunteerActivityId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TbVolunteerActivities)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbVolunte__Activ__7EF6D905");

                entity.HasOne(d => d.Volunteer)
                    .WithMany(p => p.TbVolunteerActivities)
                    .HasForeignKey(d => d.VolunteerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbVolunte__Volun__7FEAFD3E");
            });

            modelBuilder.Entity<TbVolunteerCourse>(entity =>
            {
                entity.HasKey(e => e.VolunteerCourseId)
                    .HasName("PK__tbVolunt__665D65B8A72A6C74");

                entity.ToTable("tbVolunteerCourse");

                entity.Property(e => e.VolunteerCourseId).ValueGeneratedNever();

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TbVolunteerCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbVolunte__Cours__7B264821");

                entity.HasOne(d => d.Volunteer)
                    .WithMany(p => p.TbVolunteerCourses)
                    .HasForeignKey(d => d.VolunteerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbVolunte__Volun__7C1A6C5A");
            });

            modelBuilder.Entity<TbdimCity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("tbdimCity");

                entity.Property(e => e.CityId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CityAscii)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("City_ascii");

                entity.Property(e => e.CityCode).HasMaxLength(5);

                entity.Property(e => e.CityNameAr).HasMaxLength(256);

                entity.Property(e => e.CityNameEn).HasMaxLength(256);

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.GeogText).HasComputedColumnSql("([GeogInfo].[STAsText]())", false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lng");

                entity.Property(e => e.Pop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pop");
            });

            modelBuilder.Entity<TbdimCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("tbdimCountry");

                entity.Property(e => e.CountryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Continent)
                    .HasMaxLength(250)
                    .HasColumnName("continent");

                entity.Property(e => e.CountriesNameCode)
                    .HasMaxLength(250)
                    .HasColumnName("countries_name_code");

                entity.Property(e => e.CountryCode).HasMaxLength(250);

                entity.Property(e => e.CountryId1)
                    .HasMaxLength(250)
                    .HasColumnName("country_id");

                entity.Property(e => e.CountryNameAr).HasMaxLength(250);

                entity.Property(e => e.CountryNameEn).HasMaxLength(250);

                entity.Property(e => e.GeogText).HasComputedColumnSql("([GeogInfo].[STAsText]())", false);

                entity.Property(e => e.Iso3)
                    .HasMaxLength(250)
                    .HasColumnName("iso3");

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lng");

                entity.Property(e => e.Pop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pop");
            });

            modelBuilder.Entity<TbdimFileExtension>(entity =>
            {
                entity.HasKey(e => e.FileExtensionId);

                entity.ToTable("tbdimFileExtension");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TbdimProvince>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.ToTable("tbdimProvince");

                entity.Property(e => e.ProvinceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClusterId).ValueGeneratedOnAdd();

                entity.Property(e => e.ProvinceNameAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProvinceNameEn)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
