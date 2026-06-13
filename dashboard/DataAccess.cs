using System;
using System.Data;
using System.Data.SqlClient;

namespace dashboard
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        // Constructor with optional database parameter
        // Default: AdminLogIn (existing login database)
        public DataAccess(string databaseName = null)
        {
            string dbName = databaseName ?? "AdminLogIn"; // keep old login DB unchanged
            string connStr = $@"Data Source=LAPTOP-36RR26B1\SQLEXPRESS;
                                 Initial Catalog={dbName};
                                 Integrated Security=True;";
            


            this.Sqlcon = new SqlConnection(connStr);
            this.Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            return this.Sqlcom.ExecuteNonQuery();
        }
    }
}
