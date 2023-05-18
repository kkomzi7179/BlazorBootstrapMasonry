using Microsoft.JSInterop;

namespace BlazorBootstrapMasonry.Client;

public interface IMasonryService
{
    Task Init(string parentSelector, string itemSelector, bool percentPosition = true, float transitionDurationSecs = .2F);
}

public class MasonryService : IMasonryService
{
    private readonly IJSRuntime _jsRuntime;

    public MasonryService(IJSRuntime jSRuntime)
    {
        _jsRuntime = jSRuntime;
    }

    /// <summary>
    /// options ref : https://masonry.desandro.com/options.html
    /// </summary>
    /// <param name="parentSelector"></param>
    /// <param name="itemSelector"></param>
    /// <param name="percentPosition"></param>
    /// <param name="transitionDurationSecs"></param>
    /// <returns></returns>
    public async Task Init(string parentSelector, string itemSelector, bool percentPosition = true, float transitionDurationSecs = 0.2f)
    {
        var transitionDurationStr = $"{transitionDurationSecs}s";

        await _jsRuntime.InvokeVoidAsync("initMasonry", parentSelector, itemSelector, percentPosition, transitionDurationStr);
    }
}