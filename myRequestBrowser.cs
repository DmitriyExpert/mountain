using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class myRequestBrowser : Form
    {
        public AuthUser _currentUser { get; set; }
        public myRequestBrowser(AuthUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void myRequestBrowser_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            dataGridViewRequests.ClearSelection();
            labelNotRequest.Text = "";
            DBConnection db = new DBConnection();
            using (MySqlConnection connection = db.getConnection())
            {
                string sqlQuery = "SELECT ros.datesSelected as 'Выбранная дата', ros.new_time_start as 'Время начала', ros.new_time_end as 'Время конца', sht.shiftType_name as " +
                    "'Тип смены', st.status_name as 'Статус' FROM `mountain`.`request_of_schedule` ros INNER JOIN mountain.statuts st ON st.id = ros.status_id" +
                    " INNER JOIN shiftstypes sht ON sht.id = ros.new_typeShift_id WHERE ros.user_id = @Id";
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.Add("@Id", MySqlDbType.Int32).Value = _currentUser.Id;
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    
                    
                    if (table.Rows.Count > 0)
                    {
                        dataGridViewRequests.DataSource = table;
                    } else
                    {
                        labelNotRequest.Text = "У вас нет запросов на смену расписания!";
                    }
                }
            }
        }

        
    }
}
