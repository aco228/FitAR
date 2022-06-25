using Direct.Types.SQLServer;
using System;

namespace FitAR.Database
{
  public class ARDirect : DirectDatabaseSqlServer
  {
    public ARDirect() 
      : base("fitardb",
          "dbo",
          "Server=[];Initial Catalog=fitardb;Persist Security Info=False;User ID=fitar;Password=[];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=3000;")
    { }


    public static ARDirect Instance => new ARDirect();

  }
}
