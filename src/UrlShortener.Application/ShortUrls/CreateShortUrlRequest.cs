namespace UrlShortener.Application.ShortUrls;

public sealed record CreateShortUrlRequest(
    string DestinationUrl,
    string? CustomAlias,
    DateTimeOffset? ExpiresAt);