namespace WasmCv.Services;

public class PageInfoService
{
    public const string BASE_TITLE = "Mustafa Dağcı | Software Developer";
    public string AppTitle { get; private set; } = BASE_TITLE;
    public string? PageTitle { get; private set; }
    public Action<string>? AppTitleChanged { get; set; }

    public void SetPageTitle(string? title)
    {
        if (title != null)
        {
            AppTitle = title + " | " + BASE_TITLE;
        }
        else
        {
            AppTitle = BASE_TITLE;
        }

        PageTitle = title;
        AppTitleChanged?.Invoke(AppTitle);
    }
}