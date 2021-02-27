using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relikt_2_Models;

namespace Relikt_2_DataAccess.Configurations
{
    public class InquiryDetailConfiguration : IEntityTypeConfiguration<InquiryDetail>
    {
        public void Configure(EntityTypeBuilder<InquiryDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.InquiryHeader)
                .WithOne(x => x.InquiryDetail)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Product)
                .WithOne(x => x.InquiryDetail)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.SizeType)
                .WithOne(x => x.InquiryDetail)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Category)
                .WithOne(x => x.InquiryDetail)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ApplicationType)
                .WithOne(x => x.InquiryDetail)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
