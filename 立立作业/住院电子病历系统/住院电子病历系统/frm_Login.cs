using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 住院电子病历系统
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //将窗体显示在屏幕中间
        }

        private void btn_lg_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=住院电子病历系统;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();                                       
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText =
               "SELECT COUNT(1) FROM tb_User WHERE No=@No " +
               "AND Password=HASHBYTES('MD5',@Password)" +
               $"AND identify='{this.cbB_lgidentity.Text.Trim()}';";  
          
            SqlParameter sqlParameter = new SqlParameter();                                        
            sqlParameter.ParameterName = "@No";                                                         
            sqlParameter.Value = this.txb_lgName.Text.Trim();                                       
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    
            sqlParameter.Size = 10;                                                                     
            sqlCommand.Parameters.Add(sqlParameter);                                                    
         
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_lgPwd.Text.Trim());             
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                          
     
            sqlConnection.Open();                                                                      
            int rowCount = (int)sqlCommand.ExecuteScalar();                                             
            sqlConnection.Close();                                                                    
            if (rowCount == 1)                                                                        
            {
                MessageBox.Show("登录成功!");														
            }
            else                                                                                      
            {
                MessageBox.Show("身份/用户号/密码有误，请重新输入！");									
                this.txb_lgPwd.Focus();                                                              
                this.txb_lgPwd.SelectAll();                                                         
            }
        }
    }
}
