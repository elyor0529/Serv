using Demo.Serv.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.GUI
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            AdminEmail.Text = Demo.Serv.Properties.Settings.Default.AdminEmail;
            TbxSqlConn.Text = Demo.Serv.Properties.Settings.Default.SqlConnection;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Demo.Serv.Properties.Settings.Default.AdminEmail = AdminEmail.Text;
                Demo.Serv.Properties.Settings.Default.SqlConnection = TbxSqlConn.Text;
                Demo.Serv.Properties.Settings.Default.Save();

                MessageBox.Show("Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                Log4NetManager.Error(exp.ToString());
            }
        }

        private void BtnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo(Path.Combine(Environment.CurrentDirectory, "Demo.Cmd.exe"))
                    {
                        UseShellExecute = true,
                        CreateNoWindow = true,
                        LoadUserProfile = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        WorkingDirectory = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory),
                        Arguments = "install"
                    }
                };
                process.Start();

                process.WaitForExit();

                MessageBox.Show("Successfully", "Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                Log4NetManager.Error(exp.ToString());
            }
        }

        private void BtnUnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo(Path.Combine(Environment.CurrentDirectory, "Demo.Cmd.exe"))
                    {
                        UseShellExecute = true,
                        CreateNoWindow = true,
                        LoadUserProfile = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        WorkingDirectory = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory),
                        Arguments = "uninstall"
                    }
                };

                process.Start();
                process.WaitForExit(1000);

                MessageBox.Show("Successfully", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                Log4NetManager.Error(exp.ToString());
            }
        }
    }
}
