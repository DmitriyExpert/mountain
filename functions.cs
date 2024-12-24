using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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

    

        public static bool ContainsDigit(string text)
        {
            return Regex.IsMatch(text, @"\d");
        }
}
}
