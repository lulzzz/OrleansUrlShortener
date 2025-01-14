using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace UrlShortener.Infra.Silo;

public static class ContainerRunHelper
{
    public static bool IsRunningInContainer()
    {
        return Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER")?.Trim().ToLower() == "true";
    }
}