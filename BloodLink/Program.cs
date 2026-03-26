using BloodLink.Database;
using BloodLink.Forms;

namespace BloodLink
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseHelper.Initialize();
            Application.Run(new LoginForm());
        }
    }
}