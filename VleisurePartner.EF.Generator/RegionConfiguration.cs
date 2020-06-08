// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace VleisurePartner.EF.Generator
{

    // Region
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class RegionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
            : this("dbo")
        {
        }

        public RegionConfiguration(string schema)
        {
            ToTable("Region", schema);
            HasKey(x => x.RegionId);

            Property(x => x.RegionId).HasColumnName(@"RegionID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RegionType).HasColumnName(@"RegionType").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.RelativeSignificance).HasColumnName(@"RelativeSignificance").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SubClass).HasColumnName(@"SubClass").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.RegionName).HasColumnName(@"RegionName").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.RegionNameLong).HasColumnName(@"RegionNameLong").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.ParentRegionType).HasColumnName(@"ParentRegionType").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.ParentRegionName).HasColumnName(@"ParentRegionName").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.ParentRegionNameLong).HasColumnName(@"ParentRegionNameLong").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.CountryName).HasColumnName(@"CountryName").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
        }
    }

}
// </auto-generated>