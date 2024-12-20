using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   

    public class AutoScheduleGenerator
    {
        private string _connectionString;

        public AutoScheduleGenerator(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void GenerateAutoScheduleForMonth()
        {
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

            List<int> userIds = GetUserIds();

            foreach (int userId in userIds)
            {
                // Получаем список смен, доступных для этой роли пользователя
                List<int> shiftIds = GetShiftIdsForUser(userId);

                // Если нет смен для пользователя, переходим к следующему пользователю
                if (shiftIds.Count == 0)
                {
                    Console.WriteLine($"No shifts found for user with ID {userId}. Skipping...");
                    continue;
                }

                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime date = new DateTime(currentYear, currentMonth, day);
                    int periodId = currentMonth; // period_id соответствует месяцу

                    // Определяем смену для дня (может быть более сложная логика)
                    int shiftId = GetShiftForDay(userId, shiftIds, date);

                    if (shiftId != -1)
                    {
                        // Вставляем запись в autoschedule, если смена найдена
                        InsertAutoScheduleRecord(userId, shiftId, periodId, date);
                    }
                }
            }

        }

        private List<int> GetUserIds()
        {
            List<int> userIds = new List<int>();
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id FROM users";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userIds.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return userIds;
        }

        private List<int> GetShiftIdsForUser(int userId)
        {
            List<int> shiftIds = new List<int>();
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                // Получаем роль пользователя
                int roleId = GetUserRoleId(userId, connection);
                if (roleId == -1)
                {
                    Console.WriteLine($"Role not found for user with id {userId}");
                    return shiftIds;
                }
                // Получаем id смен, доступных для этой роли
                string sql = "SELECT id FROM shifts WHERE role_id = @roleId";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@roleId", roleId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            shiftIds.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return shiftIds;
        }
        private int GetUserRoleId(int userId, MySqlConnection connection)
        {
            int roleId = -1;
            string sql = "SELECT role_id FROM users WHERE id = @userId";

            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        roleId = reader.GetInt32(0);
                    }
                }

            }
            return roleId;
        }


        private int GetShiftForDay(int userId, List<int> shiftIds, DateTime date)
        {
            // Простейшая логика: возвращаем первое ID смены из списка
            if (shiftIds.Count > 0)
            {
                return shiftIds[0];
            }
            return -1; // Возвращаем -1, если нет доступных смен
        }

        private void InsertAutoScheduleRecord(int userId, int shiftId, int periodId, DateTime date)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO autoschedule (user_id, shift_id, period_id, dateOfPeriod) VALUES (@userId, @shiftId, @periodId, @dateOfPeriod)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@shiftId", shiftId);
                    command.Parameters.AddWithValue("@periodId", periodId);
                    command.Parameters.AddWithValue("@dateOfPeriod", date);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

    
}
