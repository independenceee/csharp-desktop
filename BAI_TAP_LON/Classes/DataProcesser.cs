using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Classes
{
    internal class DataProcesser
    {
        //string strConnect = "Data Source=LAPTOP-KQVKE8JK\\SQLEXPRESS01;Initial Catalog=QLBanVe;Integrated Security=True";
        string strConnect = "Data Source=LAPTOP-KQVKE8JK\\SQLEXPRESS01;Initial Catalog=QLBanVe1;Integrated Security=True";
        SqlConnection sqlConn = null;

        void OpenConnect()
        {
            sqlConn = new SqlConnection(strConnect);
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }
        }
        void CloseConnect()
        {

            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();// đóng kết nối ngăn chặn việc sd kết nối khi ko cần thiết
                sqlConn.Dispose();// giải phóng tài nguyên tuy nhiên khi sử dụng nếu bạn sử dụng using block với SqlConnection, nó sẽ tự động gọi Dispose() ngay khi kết thúc khối using,

            }
        }
        //ham thay doi du lieu : insert , delete, update
        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand command = new SqlCommand(); // sử dụng để thực hiện các truy vấn SQL trên cơ sở dữ liệu
            command.Connection = sqlConn;// Gán đối tượng SqlConnection (sqlConn) cho thuộc tính Connection của đối tượng SqlCommand. xác định kết nối cơ sở dữ liệu mà truy vấn sẽ được thực hiện 
            command.CommandText = sql;//Gán chuỗi truy vấn SQL (sql) cho thuộc tính CommandText của đối tượng SqlCommand. Điều này xác định nội dung cụ thể của truy vấn SQL mà bạn muốn thực hiện.
            command.ExecuteNonQuery();//Thực thi truy vấn SQL được đặt trong CommandText
            CloseConnect();

        }
        // doc du lieu: thuc hien lenh select
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, sqlConn);  //cầu nối giữa dữ liệu trong cơ sở dữ liệu và các đối tượng dữ liệu cục bộ như DataTable 
            dataAdapter.Fill(dt);//để đổ dữ liệu từ cơ sở dữ liệu vào DataTable dt từ câu lênh sql select bằng kết nối sqlConn
            CloseConnect();
            return dt;
        }
    }
}
