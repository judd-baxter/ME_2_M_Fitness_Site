using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BackBone
{
    public class SelectStatement<T>
    {
        private string TableName;

        private Dictionary<string, string> WhereParameters;

        private List<string> SelectParameters;

        private DatabaseConnection Database;

        public SelectStatement(string tableName)
        {
            TableName = tableName;
            WhereParameters = new Dictionary<string, string>();
            SelectParameters = new List<string>();
            Database = new DatabaseConnection();
        }

        public void AddParameter(string value)
        {
            SelectParameters.Add(value);
        }

        public void Where(string column, string value)
        {
            WhereParameters.Add(column, value);
        }

        public IEnumerable<T> ExecuteStatement()
        {
            Database.Connection.Open();
            IEnumerable<T> objects = new ObjectMapper<T>().CreateList(new MySqlCommand(ConstructQuery(), Database.Connection).ExecuteReader());
            Database.Connection.Close();

            return objects;
        }

        private string ConstructQuery()
        {
            string query = "SELECT ";
            int record = 0;
            foreach (string select in SelectParameters)
            {
                if (record < 1)
                {
                    query += select;
                }
                else
                {
                    query += ", " + select;
                }
                record++;
            }
            query += " FROM " + TableName;

            record = 0;
            foreach (KeyValuePair<string, string> where in WhereParameters)
            {
                if (record < 1)
                {
                    query += " WHERE " + where.Key + " = '" + where.Value + "'";
                }
                else
                {
                    query += " AND " + where.Key + " = '" + where.Value + "'";
                }
                record++;
            }
            return query;
        }

    }
}
