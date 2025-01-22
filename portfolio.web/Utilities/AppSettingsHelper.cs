namespace portfolio.web.Utilities;

public class AppSettingsHelper
{
    static readonly IConfiguration _config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false).Build();
    public static string TotalCompanies = _config["Misc:total_companies"]!;
    public static string CorporateProjects = _config["Misc:corporate_projects"]!;
    public static string PersonalProjects = _config["Misc:personal_projects"]!;
    public static string StartDate = _config["Misc:start_date"]!;
}