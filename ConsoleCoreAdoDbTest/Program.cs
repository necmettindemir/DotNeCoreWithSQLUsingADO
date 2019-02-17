using CoreAdoDbLib;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleCoreAdoDbTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            IDataDB dataDB                = new MsSqlDataDB(configuration); //we want to connect to mssql otherwise we could use MySqlDataDB
            IUserRepo repo                = new UserRepo(dataDB);
            UserController userController = new UserController(repo);

            Result result = userController.GetUserList();

            if (result.ResulCode > 0)
            {
                System.Data.DataSet ds = (System.Data.DataSet)result.Obj;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine(ds.Tables[0].Rows[i]["Username"].ToString());
                }
            }
            else
            {
                Console.WriteLine(result.ResultMessage);
            }
            

        }
    }
}
