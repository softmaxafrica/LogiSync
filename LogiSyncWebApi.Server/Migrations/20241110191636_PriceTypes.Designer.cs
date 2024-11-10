﻿// <auto-generated />
using System;
using LogiSyncWebApi.Server.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LogiSyncWebApi.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241110191636_PriceTypes")]
    partial class PriceTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Company", b =>
                {
                    b.Property<string>("CompanyID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("COMPANY_ID");

                    b.Property<string>("AdminContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ADMIN_CONTACT");

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ADMIN_EMAIL");

                    b.Property<string>("AdminFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ADMIN_FULL_NAME");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COMPANY_ADDRESS");

                    b.Property<string>("CompanyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COMPANY_DESCRIPTION");

                    b.Property<double?>("CompanyLatitude")
                        .HasColumnType("float")
                        .HasColumnName("COMPANY_LATITUDE");

                    b.Property<double?>("CompanyLongitude")
                        .HasColumnType("float")
                        .HasColumnName("COMPANY_LONGITUDE");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COMPANY_NAME");

                    b.Property<string>("CompanyTinNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COMPANY_TIN_NUMBER");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.CompanyCustomer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TXNID")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyCustomers");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CUSTOMER_ID");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ADDRESS");

                    b.Property<string>("BankAccountHolder")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BANK_ACCOUNT_HOLDER");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BANK_ACCOUNT_NUMBER");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BANK_NAME");

                    b.Property<string>("BillingAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BILLING_ADDRESS");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CARD_NUMBER");

                    b.Property<string>("CardType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CARD_TYPE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EXPIRY_DATE");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FULL_NAME");

                    b.Property<string>("MobileNetwork")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOBILE_NETWORK");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOBILE_NUMBER");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PAYMENT_METHOD");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PHONE");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Driver", b =>
                {
                    b.Property<string>("DriverID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DRIVER_ID");

                    b.Property<string>("CompanyID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FULL_NAME");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMAGE_URL");

                    b.Property<string>("LicenseClasses")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LICENSE_CLASSES");

                    b.Property<DateOnly?>("LicenseExpireDate")
                        .HasColumnType("date")
                        .HasColumnName("LICENSE_EXPIRE_DATE");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LICENSE_NUMBER");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PHONE");

                    b.Property<string>("RegstrationComment")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REGISTRATION_COMMENT");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUS");

                    b.Property<bool?>("isAvilableForBooking")
                        .HasColumnType("bit")
                        .HasColumnName("IS_AVILABLE_FOR_BOOKING");

                    b.HasKey("DriverID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.GenTable", b =>
                {
                    b.Property<long?>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CODE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("Code"));

                    b.Property<DateTime?>("Cdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CDATE");

                    b.Property<string>("Cuser")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CUSER");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<DateTime?>("Edate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EDATE");

                    b.Property<string>("Euser")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EUSER");

                    b.Property<string>("LastAction")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_ACTION");

                    b.HasKey("Code");

                    b.ToTable("GenTables");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.GenTableColumn", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CODE");

                    b.Property<DateTime?>("Cdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CDATE");

                    b.Property<string>("ColumnDisplay")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COLUMN_DISPLAY");

                    b.Property<string>("ColumnIncluded")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COLUMN_INCLUDED");

                    b.Property<long?>("ColumnIndex")
                        .HasColumnType("bigint")
                        .HasColumnName("COLUMN_INDEX");

                    b.Property<string>("Cuser")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CUSER");

                    b.Property<DateTime?>("Edate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EDATE");

                    b.Property<string>("Euser")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EUSER");

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FIELD");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("HEADER");

                    b.Property<string>("LastAction")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_ACTION");

                    b.Property<long?>("TableCode")
                        .HasColumnType("bigint")
                        .HasColumnName("TABLE_CODE");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TYPE");

                    b.Property<long?>("Width")
                        .HasColumnType("bigint")
                        .HasColumnName("WIDTH");

                    b.HasKey("Code");

                    b.ToTable("GenTableColumns");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.GenTranslation", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CODE");

                    b.Property<DateTime?>("Cdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CDATE");

                    b.Property<string>("Cuser")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CUSER");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<DateTime?>("Edate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EDATE");

                    b.Property<string>("Euser")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EUSER");

                    b.Property<string>("LastAction")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_ACTION");

                    b.Property<string>("language")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LANGUAGE");

                    b.HasKey("Code");

                    b.ToTable("GenTranslations");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("INVOICE_NUMBER");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceNumber"));

                    b.Property<double>("Amount")
                        .HasColumnType("float")
                        .HasColumnName("AMOUNT");

                    b.Property<string>("CustomerID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CUSTOMER_ID");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DUE_DATE");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ISSUE_DATE");

                    b.Property<string>("JobRequestID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("JOB_REQUEST_ID");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUS");

                    b.HasKey("InvoiceNumber");

                    b.HasIndex("CustomerID");

                    b.HasIndex("JobRequestID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.JobRequest", b =>
                {
                    b.Property<string>("JobRequestID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("JOB_REQUEST_ID");

                    b.Property<string>("AssignedCompany")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ASSIGNED_COMPANY");

                    b.Property<string>("CargoDescription")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CARGO_DESCRIPTION");

                    b.Property<string>("ContainerNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONTAINER_NUMBER");

                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DeliveryLocation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DELIVERY_LOCATION");

                    b.Property<string>("DriverID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PickupLocation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PICKUP_LOCATION");

                    b.Property<string>("PriceAgreementID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PRICE_AGREEMENT_ID");

                    b.Property<string>("RequestType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REQUEST_TYPE");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUS");

                    b.Property<string>("TruckID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TruckType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TRUCK_TYPE");

                    b.HasKey("JobRequestID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("DriverID");

                    b.HasIndex("PriceAgreementID");

                    b.HasIndex("TruckID");

                    b.ToTable("JobRequests");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Location", b =>
                {
                    b.Property<string>("LocationID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("LOCATION_ID");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("LATITUDE");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("LONGITUDE");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2")
                        .HasColumnName("TIME_STAMP");

                    b.Property<string>("TruckID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("TRUCK_ID");

                    b.HasKey("LocationID");

                    b.HasIndex("TruckID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Payment", b =>
                {
                    b.Property<string>("PaymentID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PAYMENT_ID");

                    b.Property<double>("AmountPaid")
                        .HasColumnType("float")
                        .HasColumnName("AMOUNT_PAID");

                    b.Property<int>("InvoiceNumber")
                        .HasColumnType("int")
                        .HasColumnName("INVOICE_NUMBER");

                    b.Property<int?>("InvoiceNumber1")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("PAYMENT_DATE");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PAYMENT_METHOD");

                    b.Property<string>("ReferenceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REFERENCE_NUMBER");

                    b.HasKey("PaymentID");

                    b.HasIndex("InvoiceNumber1");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.RequestWithPayment", b =>
                {
                    b.Property<string>("PriceAgreementID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PRICE_AGREEMENT_ID");

                    b.Property<decimal?>("AgreedPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("AGREED_PRICE");

                    b.Property<string>("CompanyID")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COMPANY_ID");

                    b.Property<decimal?>("CompanyPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("COMPANY_PRICE");

                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CUSTOMER_ID");

                    b.Property<decimal?>("CustomerPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("CUSTOMER_PRICE");

                    b.Property<string>("JobRequestID")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REQUEST_ID");

                    b.HasKey("PriceAgreementID");

                    b.ToTable("PriceAgreements");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.SecUser", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("USER_ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMAIL");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_LOGIN");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PASSWORD_HASH");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ROLE");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUS");

                    b.HasKey("UserID");

                    b.ToTable("SecUsers");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Truck", b =>
                {
                    b.Property<string>("TruckID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("TRUCK_ID");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BRAND");

                    b.Property<string>("CabinType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CABIN_TYPE");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CATEGORY");

                    b.Property<string>("CompanyID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("COMPANY_ID");

                    b.Property<string>("Drive")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DRIVE");

                    b.Property<string>("DriverID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DriverID");

                    b.Property<string>("EngineCapacity")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ENGINE_CAPACITY");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FUEL_TYPE");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<bool>("IsTruckAvilableForBooking")
                        .HasColumnType("bit")
                        .HasColumnName("IS_TRUCK_AVILABLE_FOR_BOOKING");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MODEL");

                    b.Property<string>("TruckNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TRUCK_NUMBER");

                    b.Property<string>("TruckTypeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("TRUCK_TYPE_ID");

                    b.Property<string>("chasisNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CHASIS_NO");

                    b.HasKey("TruckID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("DriverID");

                    b.HasIndex("TruckTypeID");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.TruckType", b =>
                {
                    b.Property<string>("TruckTypeID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("TRUCK_TYPE_ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("SampleImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SAMPLE_IMAGE_URL");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TYPE_NAME");

                    b.HasKey("TruckTypeID");

                    b.ToTable("TruckTypes");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.CompanyCustomer", b =>
                {
                    b.HasOne("LogiSyncWebApi.Server.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogiSyncWebApi.Server.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Driver", b =>
                {
                    b.HasOne("LogiSyncWebApi.Server.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Invoice", b =>
                {
                    b.HasOne("LogiSyncWebApi.Server.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogiSyncWebApi.Server.Models.JobRequest", "JobRequest")
                        .WithMany("Invoices")
                        .HasForeignKey("JobRequestID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Customer");

                    b.Navigation("JobRequest");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.JobRequest", b =>
                {
                    b.HasOne("LogiSyncWebApi.Server.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("LogiSyncWebApi.Server.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverID");

                    b.HasOne("LogiSyncWebApi.Server.Models.RequestWithPayment", "PriceAgreement")
                        .WithMany()
                        .HasForeignKey("PriceAgreementID");

                    b.HasOne("LogiSyncWebApi.Server.Models.Truck", "Truck")
                        .WithMany("JobRequests")
                        .HasForeignKey("TruckID");

                    b.Navigation("Customer");

                    b.Navigation("Driver");

                    b.Navigation("PriceAgreement");

                    b.Navigation("Truck");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Location", b =>
                {
                    b.HasOne("LogiSyncWebApi.Server.Models.Truck", "Truck")
                        .WithMany("Locations")
                        .HasForeignKey("TruckID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Truck");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Payment", b =>
                {
                    b.HasOne("LogiSyncWebApi.Server.Models.Invoice", null)
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceNumber1");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Truck", b =>
                {
                    b.HasOne("LogiSyncWebApi.Server.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogiSyncWebApi.Server.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverID");

                    b.HasOne("LogiSyncWebApi.Server.Models.TruckType", "TruckType")
                        .WithMany()
                        .HasForeignKey("TruckTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Driver");

                    b.Navigation("TruckType");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Invoice", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.JobRequest", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("LogiSyncWebApi.Server.Models.Truck", b =>
                {
                    b.Navigation("JobRequests");

                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
