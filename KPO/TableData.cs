using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    public class TableData : ITable
    {
        public IEnumerable<Table> GetAll()
        {
            string sql = "select * from UsersTable";
            string pathCurrent= System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+pathCurrent+@"\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                var orderDetails = connection.Query<Table>(sql).ToList();
                return orderDetails;
            }
        }
        public Table GetFirstItem()
        {
            string sql = "select * from UsersTable order by ime";
            string pathCurrent = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathCurrent + @"\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                var orderDetails = connection.Query<Table>(sql).ToList();
                return orderDetails.FirstOrDefault();
            }
        }

        public Table GetUserByName(string name)
        {
            string sql = "select * from UsersTable where Ime like ="+name;
            string pathCurrent = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathCurrent + @"\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                var orderDetails = connection.Query<Table>(sql).ToList();
                return orderDetails.FirstOrDefault();
            }
        }
        public Table GetUserByAddres(string address)
        {
            string sql = "select * from UsersTable where Naslov like =" + address;
            string pathCurrent = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathCurrent + @"\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                var orderDetails = connection.Query<Table>(sql).ToList();
                return orderDetails.FirstOrDefault();
            }
        }

    }
}
