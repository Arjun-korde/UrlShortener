using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrlShortener.Domain.Entities;

namespace UrlShortener.Infrastructure.Persistence.Configurations;

public class UrlClickConfiguration : IEntityTypeConfiguration<UrlClick>
{
    public void Configure(EntityTypeBuilder<UrlClick> builder)
    {
        builder.ToTable("url_clicks");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever();

        builder.Property(x => x.ClickedAt)
            .IsRequired();

        builder.Property(x => x.UserAgent)
            .HasMaxLength(1024);

        builder.Property(x => x.Referrer)
            .HasMaxLength(2048);

        builder.HasOne(x => x.ShortUrl)
            .WithMany(x => x.Clicks)
            .HasForeignKey(x => x.ShortUrlId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.ShortUrlId);

        builder.HasIndex(x => x.ClickedAt);
    }
}