using HRPayrollSystem.DAL;
using MySqlX.XDevAPI.Common;
using System.Windows.Forms;

namespace HRPayrollSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                using (var conn = HRPayrollSystem.Common.DBHelper.GetConnection())
                {
                    MessageBox.Show("连接成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"连接失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Run(new Form1());
            
        }
    }
}