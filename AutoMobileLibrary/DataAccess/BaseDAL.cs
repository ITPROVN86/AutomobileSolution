using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider dataProvider { get; set; }

        public SqlConnection connection = null;
        public BaseDAL() {
            var connectString = GetConnectionString();
            dataProvider = new StockDataProvider(connectString);
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",true, true)
                .Build();
            return config["ConnectionStrings:MyStockDB"];
        }

        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
