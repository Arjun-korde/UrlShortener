using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrlShortener.Domain.Entities;

namespace UrlShortener.Infrastructure.Persistence.Configurations;

public class ShortUrlConfiguration : IEntityTypeConfiguration<ShortUrl>
{
    public void Configure(EntityTypeBuilder<ShortUrl> builder)
    {
        builder.ToTable("short_urls");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever();

        builder.Property(x => x.ShortCode)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(x => x.ShortCode)
            .IsUnique();

        builder.Property(x => x.DestinationUrl)
            .HasMaxLength(2048)
            .IsRequired();

        builder.Property(x => x.IsCustomAlias)
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .IsRequired();

        builder.Property(x => x.ShortCodeNormalized)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(x => x.ShortCodeNormalized)
            .IsUnique();

        builder.Property(x => x.UpdatedAt);

        builder.Property(x => x.ExpiresAt)
            .IsRequired();

        builder.Property(x => x.IsActive)
            .IsRequired();

        builder.HasOne(x => x.OwnerUser)
            .WithMany(x => x.ShortUrls)
            .HasForeignKey(x => x.OwnerUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.OwnerUserId);

        builder.HasIndex(x => x.ExpiresAt);
    }
}