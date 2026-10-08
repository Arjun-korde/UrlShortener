namespace UrlShortener.Domain.Entities;

public class UrlClick
{
    public Guid Id { get; set; }

    public Guid ShortUrlId { get; set; }

    public DateTime ClickedAt { get; set; }

    public string? UserAgent { get; set; }

    public string? Referrer { get; set; }

    public ShortUrl ShortUrl { get; set; } = null!;
}