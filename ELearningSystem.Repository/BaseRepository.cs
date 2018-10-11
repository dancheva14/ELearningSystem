using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ELearningSystem.Repository
{
    public class BaseRepository : DbContext
    {
        private string connString = "server=localhost;port=5432;database=postgres;uid=postgres;password=123456";





    }
//        internal IDbConnection Connection
//        {
//            get
//            {
//                return new NpgsqlConnection(connString);
//            }
//        }

//        public T QueryFirst<T>(string functionName, object parameters)
//        {
//            using (var conn = Connection)
//            {
//                conn.Open();
//                return conn.Query<T>(functionName, parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault();
//            }
//        }

//        public List<T> QueryMultiple<T>(string functionName, object parameters = null)
//        {
//            using (var conn = Connection)
//            {
//                conn.Open();
//                return conn.Query<T>(functionName, parameters, null, true, null, CommandType.StoredProcedure).ToList();
//            }
//        }
//    }
//}
