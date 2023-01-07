using System.Net.Http.Json;
using BlazingTrails.Client.Features.Home;

namespace BlazingTrails.Client.Providers;

public interface ITrailProvider
{
    Task<IEnumerable<Trail>?> GetTrailsAsync();
}

public sealed record TrailProvider(HttpClient Client) :
    ITrailProvider
{
    public async Task<IEnumerable<Trail>?> GetTrailsAsync()
    {
        return await Client.GetFromJsonAsync<IEnumerable<Trail>>("trails/trail-data.json").ConfigureAwait(false);
    }
}