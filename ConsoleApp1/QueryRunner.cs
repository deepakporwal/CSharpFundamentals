using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class QueryRunner
    {
        private IDbConnection connection;

        public void RunQuery(string query) 
        {
            Helper helper = new Helper();
            if (helper.Validate(query)) 
            {
                OpenConnection();
                CloseConnection();
            }
        }

        protected void OpenConnection() 
        {

        }

        protected void CloseConnection() 
        {
        
        }
       
    }

    internal class Helper
    {
        internal bool Validate(string query) 
        {
            return true;
        }
    }
}
