﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    internal class Class1
    {
        public static string hashPassword(string password)
        {
            MD5 md5 = MD5.Create();
<<<<<<< HEAD
=======
            
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var a in hash)
                stringBuilder.Append(a.ToString("X2"));

            return Convert.ToString(stringBuilder);
        }
    }
}
