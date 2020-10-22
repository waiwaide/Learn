using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace WindowsFormsApp1
{
    class DBAccess
    {
        string strConnection = "";
        public DBAccess(int iDBType)
        {
            switch (iDBType)
            {
               
                case 0:
                    strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Program.strPath + "\\test.mdb;";
                    break;
                default:
                  
                    break;

            }


        }

        public DataSet getDataset(string strSQL, string strTableName, int iResource)
        {
            DataSet dst = new DataSet();
            switch (iResource)
            {
                case 0:
                    OleDbDataAdapter oada = new OleDbDataAdapter(strSQL, strConnection);
                    oada.Fill(dst, strTableName);
                    break;
                default:
                    OleDbDataAdapter adap1 = new OleDbDataAdapter(strSQL, strConnection);
                    adap1.Fill(dst, strTableName);
                    break;


            }
            return dst;
        }

    }
}
