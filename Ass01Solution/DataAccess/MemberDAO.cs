using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class MemberDAO
    {
        private SqlConnection connection;

        private SqlTransaction transaction;

        private SqlCommand command;

        private String connectString = "Server=(local);uid=sa;pwd=sa;database=Product;Encrypt=False";

        public MemberDAO()
        {
            connection = new SqlConnection(connectString);
            connection.Open();
        }

        public SqlCommand setQuery(String Query)
        {
            command = new SqlCommand(Query, connection);

            return command;
        }

        public void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        public void beginTransaction()
        {
            if (connection != null)
            {
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
            }
        }

        public void rollback()
        {
            if (transaction != null)
            {
                transaction.Rollback();
            }
        }

        public void commit()
        {
            if (transaction != null)
            {
                transaction.Commit();
            }
        }
    }
}
