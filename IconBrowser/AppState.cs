using LCUNet;

namespace IconBrowser
{
    /// <summary>
    /// Shared context, yes I know it's bad
    /// </summary>
    public static class AppState
    {
        public static LeagueClientApi LeagueClientApi = new LeagueClientApi();
    }
}
