﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Producer_Consumer;

namespace Producer_Consumer.Migrations
{
    [DbContext(typeof(HtmlContext))]
    partial class HtmlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Producer_Consumer.HtmlFeature", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumOfImgs");

                    b.Property<int>("NumOfLinks");

                    b.Property<int>("NumOfSentences");

                    b.Property<int>("NumOfWords");

                    b.HasKey("Id");

                    b.ToTable("HtmlFeatureList");
                });
#pragma warning restore 612, 618
        }
    }
}
