namespace UrlShortener.Domain.Entities;

public class ShortUrl
{
    public Guid Id { get; set; }

    public string ShortCode { get; set; } = null!;

    public string DestinationUrl { get; set; } = null!;

    public bool IsCustomAlias { get; set; }

    public Guid? OwnerUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public bool IsActive { get; set; }

    public string ShortCodeNormalized { get; set; } = null!;

    public User? OwnerUser { get; set; }

    public ICollection<UrlClick> Clicks { get; set; } = [];
}