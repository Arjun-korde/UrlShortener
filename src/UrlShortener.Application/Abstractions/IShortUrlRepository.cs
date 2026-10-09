using UrlShortener.Domain.Entities;

namespace UrlShortener.Application.Abstractions;

public interface IShortUrlRepository
{
    Task<bool> TryCreateAsync(
        ShortUrl shortUrl,
        CancellationToken cancellationToken);
}