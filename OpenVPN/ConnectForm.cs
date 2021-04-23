using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Renci.SshNet;

namespace OpenVPN
{
    public partial class ConnectForm : DevExpress.XtraEditors.XtraForm
    {
        private Server server;

        public ConnectForm()
        {
            InitializeComponent();
            UsersComboBox.Properties.Items.AddRange(new OpenVPNDataClassesDataContext().Accounts.Select(x => x.Username).ToArray());

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {

                if (IP_Box.Text == "" || Username_Box.Text == "" || Password_Box.Text == "")
                {
                    MessageBox.Show("fields shouldn't be empty..!", "Bad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    server = new Server(IP_Box.Text, Username_Box.Text, Password_Box.Text);
                    ConnectBtn.Text = "Connecting..";
                    Worker.RunWorkerAsync();
                    IP_Box.Enabled = false;
                    Username_Box.Enabled = false;
                    Password_Box.Enabled = false;
                    ConnectBtn.Enabled = false;
                }
                catch (Exception ex)
                { MessageBox.Show("Cannot Connect\n"+ex.Message, "Bad", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void BuildBtn_Click(object sender, EventArgs e)
        {

            var dir = new FolderBrowserDialog();
            dir.ShowDialog();
            var path = dir.SelectedPath;
            var account = new OpenVPNDataClassesDataContext().Accounts.Single(x => x.Username == UsersComboBox.EditValue.ToString().TrimEnd());
            var file= Properties.Resources.ovpn.Replace("?", account.Certificate).Replace("!", account._Key);
            File.WriteAllText(path + "/" + account.Username.TrimEnd() + ".ovpn", file);

        }

        private void BuildAllBtn_Click(object sender, EventArgs e)
        {
            var dir = new FolderBrowserDialog();
            dir.ShowDialog();
            var path = dir.SelectedPath;
            var db = new OpenVPNDataClassesDataContext();
            foreach (var account in db.Accounts)
            {
                File.WriteAllText(path + "/" + account.Username.TrimEnd() + ".ovpn",
                    account.Certificate + "\n" + account._Key);
            }
        }

        private void UsersComboBox_BeforePopup(object sender, EventArgs e)
        {
            UsersComboBox.Properties.Items.Clear();
            UsersComboBox.Properties.Items.AddRange(new OpenVPNDataClassesDataContext().Accounts.Select(x => x.Username).ToArray());

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)=> server.Connect();

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker) delegate {
                ConnectBtn.Text = "Connect";
                new CreateForm(server).ShowDialog();
                IP_Box.Enabled = true;
                Username_Box.Enabled = true;
                Password_Box.Enabled = true;
                ConnectBtn.Enabled = true;
            });
        }

    }
}