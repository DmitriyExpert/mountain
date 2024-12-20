using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;


namespace WinFormsApp1
{
    public partial class cabinet : Form
    {
        public AuthUser _currUser { get; set; }
        public AuthUser _currentUser { get; set; }
        private Label labelVisible;
        private List<DateTime> _allDates;
        private int _currentWeekIndex = 0;
        private int _daysInWeek = 7;
        public cabinet(AuthUser CurrentUser)
        {
            InitializeComponent();
            button_next.Click += _nextWeekButton_Click;
            button_prev.Click += _prevWeekButton_Click;
            if (CurrentUser.RoleId == 2)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role_name FROM mountain.roles where `id` = @parseId", db.getConnection());
            command.Parameters.Add("@parseId", MySqlDbType.VarChar).Value = Convert.ToString(CurrentUser.RoleId);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show(table.Rows.Count.ToString());
                DataRow row = table.Rows[0];
                string roleName = row["role_name"]?.ToString() ?? "Роль не определена";
                labelProff.Text = roleName;
            }
            else
            {
                labelProff.Text = "Ошибка";
            }

            fioUser.Text = CurrentUser.LastName + " " + CurrentUser.FirstName + " " + CurrentUser.MiddleName;
            identifyUser.Text = CurrentUser.Id.ToString() + ' ' + "-";

            _currUser = CurrentUser;
            labelVisible = this.panel;
            functions.SetCurrentUser(_currUser);
            functions.panelVisible(this, EventArgs.Empty, labelVisible);


        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureToCabinet_Click(object sender, EventArgs e)
        {

        }

        private void backtomenu_Click(object sender, EventArgs e)
        {

            menu newmenu = new menu(_currUser);
            this.Close();
            newmenu.Show();
        }

        private void cabinet_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FillTableLayoutPanel(_currUser);
            DBConnection db = new DBConnection();
            db.openConnection();
            int counterDay = 0;
            int counterShiftDay = 0;
            int counterShiftNight = 0;
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) AS total_shifts,SUM(CASE WHEN s.typeShift_id = 1 THEN 1 ELSE 0 END) AS day_shifts, SUM(CASE WHEN s.typeShift_id = 2 THEN 1 ELSE 0 END) AS night_shifts FROM mountain.autoschedule a INNER JOIN mountain.shifts s ON a.shift_id = s.id WHERE a.user_id = @user_id;", db.getConnection());
            command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = Convert.ToString(_currentUser.Id);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read()) // Используем if, так как у нас одна строка
                {
                    counterDay = Convert.ToInt32(reader["total_shifts"]);
                    counterShiftDay = Convert.ToInt32(reader["day_shifts"]);
                    counterShiftNight = Convert.ToInt32(reader["night_shifts"]);
                }
            }
            labelForCounterDay.Text = $"Всего смен - {counterDay}";
            labelForShiftDay.Text = $"Дневных смен - {counterShiftDay}";
            labelForShiftNight.Text = $"Ночных смен - {counterShiftNight}";
            db.closeConnection();
            using (MySqlConnection connection = db.getConnection())
            {
                connection.Open();
                string sqlQuery = "SELECT time_start, time_end FROM mountain.shifts WHERE role_id = @roleId AND typeShift_id = 1";
                string timeStart = "";
                string timeEnd = "";
                using (MySqlCommand command1 = new MySqlCommand(sqlQuery, connection))
                {
                    command1.Parameters.Add("@roleId", MySqlDbType.VarChar).Value = _currentUser.RoleId;
                    using (MySqlDataReader reader = command1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            timeStart = Convert.ToString(reader["time_start"]);
                            timeEnd = Convert.ToString(reader["time_end"]);
                        }
                        else
                        {
                            MessageBox.Show("Данных нет!");
                        }
                    }
                }
                labelTimePeriodDayShift.Text = $"Для дневной смены: {timeStart} - {timeEnd}";
                string timeStartNight = "";
                string timeEndNight = "";
                string sqlQuery2 = "SELECT time_start, time_end FROM mountain.shifts WHERE role_id = @roleId AND typeShift_id = 2";
                using (MySqlCommand command2 = new MySqlCommand(sqlQuery2, connection))
                {
                    command2.Parameters.Add("@roleId", MySqlDbType.VarChar).Value = _currentUser.RoleId;
                    using (MySqlDataReader reader1 = command2.ExecuteReader())
                    {

                        if (reader1.Read())
                        {
                            timeStartNight = Convert.ToString(reader1["time_start"]);

                            timeEndNight = Convert.ToString(reader1["time_end"]);
                        }
                        else
                        {
                            MessageBox.Show("Данных нет!");
                        }
                    }
                }

                labelTimePeriodNightShift.Text = $"Для ночной смены: {timeStartNight} - {timeEndNight}";
                connection.Close();
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toRedact_Click(object sender, EventArgs e)
        {
            editme editme = new editme(_currUser);
            this.Close();
            editme.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            contacts contacts = new contacts(_currUser);
            this.Close();
            contacts.Show();
        }

        private void toContact_Click(object sender, EventArgs e)
        {
            contacts contacts = new contacts(_currUser);
            this.Close();
            contacts.Show();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            adminpanelmenu adminpanelmenu = new adminpanelmenu(_currUser);
            this.Close();
            adminpanelmenu.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            requestEditSchedule requestEditSchedule = new requestEditSchedule(_currUser);
            requestEditSchedule.Show();
        }

        private void labelProff_Click(object sender, EventArgs e)
        {

        }

        private void FillTableLayoutPanel(AuthUser _currUser)
        {
            _currentUser = _currUser;
            tableLayoutPanel1.Controls.Clear(); // Очищаем tableLayoutPanel
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            _allDates = new List<DateTime>();
            UpdateTable();
        }

        private void UpdateTable()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            // Получаем данные из базы данных для текущей недели
            DataTable dt = GetScheduleData(_currentUser);
            if (dt.Rows.Count == 0)
            {
                return;
            }

            if (_allDates == null || _allDates.Count == 0)
            {
                // Получаем уникальные даты из таблицы
                foreach (DataRow row in dt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["dateOfPeriod"]);
                    if (!_allDates.Contains(date))
                    {
                        _allDates.Add(date);
                    }
                }
                _allDates.Sort();
            }

            // Выбираем даты текущей недели
            List<DateTime> currentWeekDates = GetCurrentWeekDates();

            // Создание заголовков столбцов
            int columnCount = currentWeekDates.Count;
            tableLayoutPanel1.ColumnCount = columnCount;
            for (int i = 0; i < columnCount; i++)
            {
                // Создаем колонку
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnCount));

                // Дата
                Label dateLabel = new Label();
                dateLabel.Text = currentWeekDates[i].ToString("yyyy-MM-dd");
                dateLabel.TextAlign = ContentAlignment.MiddleCenter;
                dateLabel.Dock = DockStyle.Fill;
                dateLabel.BorderStyle = BorderStyle.FixedSingle; // Добавляем границу
                tableLayoutPanel1.Controls.Add(dateLabel, i, 0);

                // День недели
                Label dayOfWeekLabel = new Label();
                dayOfWeekLabel.Text = GetShortDayOfWeek(currentWeekDates[i].DayOfWeek);
                dayOfWeekLabel.TextAlign = ContentAlignment.MiddleCenter;
                dayOfWeekLabel.Dock = DockStyle.Fill;
                dayOfWeekLabel.BorderStyle = BorderStyle.FixedSingle; // Добавляем границу
                tableLayoutPanel1.Controls.Add(dayOfWeekLabel, i, 1);


                // Тип смены (пока пустой)
                Label shiftTypeLabel = new Label();
                shiftTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
                shiftTypeLabel.Dock = DockStyle.Fill;
                shiftTypeLabel.BorderStyle = BorderStyle.FixedSingle; // Добавляем границу
                tableLayoutPanel1.Controls.Add(shiftTypeLabel, i, 2);

            }

            // Создание строк
            int rowCount = 3;
            tableLayoutPanel1.RowCount = rowCount;

            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // Заполнение смен по датам
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(row["dateOfPeriod"]);
                if (!currentWeekDates.Contains(date)) continue;

                int columnIndex = currentWeekDates.IndexOf(date);

                if (columnIndex == -1) continue;

                string shiftType = row["shiftType_name"].ToString();
                // Упрощение названия смены
                string shiftTypeShort = GetShortShiftTypeName(shiftType);

                // Вставляем тип смены
                Label shiftLabel = (Label)tableLayoutPanel1.GetControlFromPosition(columnIndex, 2);
                shiftLabel.Text = shiftTypeShort;
            }
        }
        private DataTable GetScheduleData(AuthUser _currUser)
        {
            DBConnection db = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            MySqlCommand command = new MySqlCommand("USE mountain; SELECT autoschedule.id,dateOfPeriod, time_start, time_end, shiftType_name FROM mountain.autoschedule INNER JOIN mountain.shifts ON shifts.id = autoschedule.shift_id INNER JOIN mountain.shiftstypes ON shiftstypes.id = shifts.typeShift_id WHERE autoschedule.user_id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _currUser.Id;
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        private List<DateTime> GetCurrentWeekDates()
        {
            if (_allDates == null || _allDates.Count == 0) return new List<DateTime>();

            int startIndex = _currentWeekIndex * _daysInWeek;
            if (startIndex >= _allDates.Count) return new List<DateTime>();
            int endIndex = Math.Min(startIndex + _daysInWeek, _allDates.Count);
            return _allDates.GetRange(startIndex, endIndex - startIndex);
        }

        private void _nextWeekButton_Click(object sender, EventArgs e)
        {
            if (_allDates == null || _allDates.Count == 0) return;
            if ((_currentWeekIndex + 1) * _daysInWeek >= _allDates.Count) return;
            _currentWeekIndex++;
            // Обновляем таблицу на основе новых данных
            UpdateTable();
        }
        private void _prevWeekButton_Click(object sender, EventArgs e)
        {
            if (_currentWeekIndex <= 0) return;
            _currentWeekIndex--;
            // Обновляем таблицу на основе новых данных
            UpdateTable();
        }
        private string GetShortDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday: return "ПН";
                case DayOfWeek.Tuesday: return "ВТ";
                case DayOfWeek.Wednesday: return "СР";
                case DayOfWeek.Thursday: return "ЧТ";
                case DayOfWeek.Friday: return "ПТ";
                case DayOfWeek.Saturday: return "СБ";
                case DayOfWeek.Sunday: return "ВС";
                default: return "";
            }
        }

        private string GetShortShiftTypeName(string shiftType)
        {
            switch (shiftType)
            {
                case "Дневная": return "Д";
                case "Ночная": return "Н";
                case "Выходной": return "В";
                case "Отпуск": return "О";
                default: return shiftType;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            whowithme whowithme = new whowithme(_currentUser);
            whowithme.Show();
        }
    }
}
