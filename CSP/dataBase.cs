using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP
{
    class dataBase
    {
        public SqlConnection sqlconn = null;
        public string ip = "127.0.0.1", db_id = "sa", db_pw = "jungho3710", db_name = "mydb2";

        public string path = "SERVER=127.0.0.1,1433; DATABASE=mydb2; UID=sa; PASSWORD=jungho3710";
        //"SERVER=127.0.0.1,1433; DATABASE = yourDB; UID = sql; PASSWORD = 1234";

        public string loginDB()
        {
            path = "SERVER = " + ip + ",1433; DATABASE = " + db_name + "; UID = " + db_id + "; PASSWORD = " + db_pw;
            try
            {
                sqlconn = new SqlConnection(path);
                sqlconn.Open();
                return "done";
            } catch
            {
                return "error";
            }            
        }
    }
}
