using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;


namespace MrMohb//.DXL
{
    class DXL
     {
        SqlConnection cn;
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter da;


        public DXL()
        {                            
            cn = new SqlConnection(@"Data Source=B1ONE-PC\SQLEXPRESS;Initial Catalog=MrMohbDB;Integrated Security=True");
           
        }
        public void open()
        {

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        public void close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        #region  لقراءة البيانات من قاعدة البيانات

        public DataTable Reader(string sp, SqlParameter[] p)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = cn;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region Remove User ,Update User,Add User عمل حذف او تعديل او اضافه

        public void RUA(string sp, SqlParameter[] p)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = cn;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            cmd.ExecuteNonQuery();

        }

        #endregion
    }
}

