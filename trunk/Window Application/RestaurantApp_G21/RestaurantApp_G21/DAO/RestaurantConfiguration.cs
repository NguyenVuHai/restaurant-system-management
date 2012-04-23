using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
 
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

    public static DbCommand command;
}
