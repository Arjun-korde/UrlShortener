using System.Security.Cryptography;
using UrlShortener.Application.Abstractions;

namespace UrlShortener.Infrastructure.ShortCodes;

public sealed class Base62ShortCodeGenerator : IShortCodeGenerator
{
    private const string Characters =
        "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    private const int DefaultLength = 7;

    public string Generate()
    {
        return string.Create(
            DefaultLength,
            Characters,
            static (buffer, characters) =>
            {
                for (var i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = characters[
                        RandomNumberGenerator.GetInt32(characters.Length)];
                }
            });
    }
}