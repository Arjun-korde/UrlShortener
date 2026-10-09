using Microsoft.Extensions.DependencyInjection;
using UrlShortener.Application.Abstractions;

namespace UrlShortener.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        return services;
    }
}