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
<<<<<<< HEAD
        public string FirsName { get; set; } // Исправлено имя поля
=======
        public string FirstName { get; set; } // Исправлено имя поля
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public int RoleId { get; set; }

<<<<<<< HEAD
        public AuthUser(int id, string firsName, string middleName, string lastName, string login, int roleId) // Убран лишний параметр pass
        {
            Id = id;
            FirsName = firsName;
=======
        public AuthUser(int id, string firstName, string middleName, string lastName, string login, int roleId) // Убран лишний параметр pass
        {
            Id = id;
            FirstName = firstName;
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
            MiddleName = middleName;
            LastName = lastName;
            Login = login;
            RoleId = roleId;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
<<<<<<< HEAD
                   $"Имя: {FirsName}\n" +
=======
                   $"Имя: {FirstName}\n" +
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
                   $"Отчество: {MiddleName}\n" +
                   $"Фамилия: {LastName}\n" +
                   $"Логин: {Login}\n" +
                   $"ID роли: {RoleId}";
        }
    }
}
