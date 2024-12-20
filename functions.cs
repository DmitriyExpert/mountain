using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

=======
using System.Text.RegularExpressions;
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
namespace WinFormsApp1
{
    internal static class functions
    {
        private static AuthUser CurrentUser;

        public static void SetCurrentUser(AuthUser user)
        {
            CurrentUser = user;
        }
        public static void panelVisible(object sender, EventArgs e, Label label)
        {
            if (CurrentUser.RoleId == 2 || CurrentUser.RoleId == 3)
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }
<<<<<<< HEAD
    }
=======

    

        public static bool ContainsDigit(string text)
        {
            return Regex.IsMatch(text, @"\d");
        }
}
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
}
