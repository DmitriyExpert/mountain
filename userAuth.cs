using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class AuthUser : EventArgs // Inherits from EventArgs for event handling
    {
        public int Id { get; set; }
        public string FirsName { get; set; } // Исправлено имя поля
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public int RoleId { get; set; }

        public AuthUser(int id, string firsName, string middleName, string lastName, string login, int roleId) // Убран лишний параметр pass
        {
            Id = id;
            FirsName = firsName;
            MiddleName = middleName;
            LastName = lastName;
            Login = login;
            RoleId = roleId;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Имя: {FirsName}\n" +
                   $"Отчество: {MiddleName}\n" +
                   $"Фамилия: {LastName}\n" +
                   $"Логин: {Login}\n" +
                   $"ID роли: {RoleId}";
        }
    }
}
