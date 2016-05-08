using QlNhanSuBenhVien.UserInterface;
using System;
using System.Windows.Forms;

namespace QlNhanSuBenhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new FrmChinh());
        }
    }
}