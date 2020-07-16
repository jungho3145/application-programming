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
        public string ip = "127.0.0.1", db_id = "sql", db_pw = "1234", db_name = "yourDB";

        public string path = "SERVER=127.0.0.1,1433; DATABASE=yourDB; UID=sql; PASSWORD=1234";
        //"SERVER=127.0.0.1,1433; DATABASE = yourDB; UID = sql; PASSWORD = 1234";

        public string loginDB()
        {
            path = "SERVER=" + ip + ",1433; DATABASE=" + db_name + "; UID=" + db_id + "; PASSWORD=" + db_pw;
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

        public string returnObject(string type)
        {
            string getObject = null;
            switch(type)
            {
                case "path":
                    getObject = path;
                    break;
                case "ip":
                    getObject = ip;
                    break;
                case "id":
                    getObject = db_id;
                    break;
                case "pw":
                    getObject = db_pw;
                    break;
                case "name":
                    getObject = db_name;
                    break;
            }
            return getObject;
        }
    }
}
