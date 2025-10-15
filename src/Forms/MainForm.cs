using MachineActivityLogger.src.Models;
using MachineActivityLogger.src.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineActivityLogger.src.Forms
{
    public partial class MainForm : Form
    {
        private FileManager _fileManager;
        private User _currentUser;

        public MainForm()
        {
            InitializeComponent();
            _fileManager = new FileManager();
            _currentUser = new User { Username = "Anonymous", UserLevel = 0, IsAuthenticated = false };

            _fileManager.InitializeLogFile();

            UpdateUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            switch (numEditLevel.Value)
            {
                case 0:
                    numEditLevel.Text = "0: Ghi chú";
                    break;
                case 1:
                    numEditLevel.Text = "1: Thông tin";
                    break;
                case 2:
                    numEditLevel.Text = "2: Cảnh báo";
                    break;
                case 3:
                    numEditLevel.Text = "3: Lỗi";
                    break;
                case 4:
                    numEditLevel.Text = "4: Thảm họa";
                    break;

            }
        }

        private void btnWriteLog_Click(object sender, EventArgs e)
        {
            var logEntry = new LogEntry
            {
                Timestamp = DateTime.Now,
                Editor = string.IsNullOrWhiteSpace(txtEditor.Text) ? "Anonymous" : txtEditor.Text,
                Tag = txtTag.Text,
                EditLevel = (int)numEditLevel.Value,
                Content = txtContent.Text,
                UserLevel = _currentUser.UserLevel,
                ActionType = "Create"
            };

            _fileManager.WriteLogToAllFile(logEntry);
            MessageBox.Show("Đã ghi nhật ký thành công!");
            txtContent.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_currentUser.IsAuthenticated)
            {
                // Log out
                _currentUser = new User { Username = "Anonymous", UserLevel = 0, IsAuthenticated = false };
                UpdateUI();
            }
            else
            {
                // Log in
                using (var loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        _currentUser = loginForm.AuthenticatedUser;
                        UpdateUI();
                    }
                }
            }
        }



        private void UpdateUI()
        {
            if (_currentUser.IsAuthenticated)
            {
                this.Text = $"Machine Activity Logger - Đăng nhập như {_currentUser.Username} (Cấp độ {_currentUser.UserLevel})";
                btnLogin.Text = "Đăng xuất";
                btnLogin.BackColor = Color.LightCoral;
            }
            else
            {
                this.Text = "Machine Activity Logger - Chưa đăng nhập";
                btnLogin.Text = "Đăng nhập";
                btnLogin.BackColor = Color.LightGreen;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
