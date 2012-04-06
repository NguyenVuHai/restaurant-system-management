using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public static class RestaurantConfiguration
{

    private static string dbConnectionString;

    public static string DbConnectionString
    {
        get { return RestaurantConfiguration.dbConnectionString; }
    }

    private static string dbProviderName;

    public static string DbProviderName
    {
        get { return RestaurantConfiguration.dbProviderName; }
    }

    private readonly static string siteName;

    public static string SiteName
    {
        get { return RestaurantConfiguration.siteName; }
    }

    static RestaurantConfiguration()
    {
        dbConnectionString = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
        dbProviderName = ConfigurationManager.ConnectionStrings["ApplicationServices"].ProviderName;
    }
}
