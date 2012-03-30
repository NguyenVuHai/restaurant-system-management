using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public struct TableDetails
{
    public string MaBan;
    public string TenBan;
    public string MaKhuVuc;
    public string SucChua;
}

public static class TableAccess
{
    static TableAccess()
    {
    }

    public static DataTable GetTables()
    {
        DbCommand command = DataAccessCode.CreateCommand();
        command.CommandText = "SP_GETTABLES";
        return DataAccessCode.ExecuteSelectCommand(command);
    }

    public static TableDetails GetTableDetails(string departmentId)
    {
        DbCommand comm = DataAccessCode.CreateCommand();

        comm.CommandText = "GetTableDetails";

        DbParameter param = comm.CreateParameter();
        param.ParameterName = "@MaBan";
        param.Value = departmentId;
        param.DbType = DbType.Int32;
        comm.Parameters.Add(param);

        DataTable table = DataAccessCode.ExecuteSelectCommand(comm);

        TableDetails details = new TableDetails();
        if (table.Rows.Count > 0)
        {
            details.MaBan = table.Rows[0]["MaBan"].ToString();
            details.TenBan = table.Rows[0]["TenBan"].ToString();
        }
        return details;
    }
}