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
    public partial class LoginForm : Form
    {
        
            public User AuthenticatedUser { get; private set; }
        private AuthenticationManager _authManager;

            public LoginForm()
            {
                InitializeComponent();
                _authManager = new AuthenticationManager();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text;
                string key = txtKey.Text;

                if (_authManager.ValidateTimeBasedKey(key, username))
                {
                    AuthenticatedUser = new User
                    {
                        Username = username,
                        UserLevel = username.ToLower().Contains("admin") ? 2 : 1,
                        IsAuthenticated = true,
                        LoginTime = DateTime.Now
                    };

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Key xác thực không đúng!");
                }
            }
        }
}
