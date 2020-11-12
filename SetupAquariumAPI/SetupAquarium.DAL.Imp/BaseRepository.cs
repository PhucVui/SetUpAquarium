using System.Data;
using System.Data.SqlClient;

namespace SetupAquarium.DAL.Imp
{
    public class BaseRepository
    {
        protected IDbConnection connection;
        public BaseRepository()
        {
            connection = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=SetupAquarium;Integrated Security=True");
        }
    }
}
