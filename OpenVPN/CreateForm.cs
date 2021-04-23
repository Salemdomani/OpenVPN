using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OpenVPN
{
    public partial class CreateForm : DevExpress.XtraEditors.XtraForm
    {
        
        public Server server { get; set; }
        private int timeLeft = 31;
        

        public CreateForm(Server server)
        {
            InitializeComponent();
            this.server = server;
          
        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server.IsConnected)
                server.Disconnect();
        }
       
        private void CreateBtn_Click(object sender, EventArgs e)
        {
           
                try
                {
                    
                    Number_Box.Enabled = false;
                    Username_Box.Enabled = false;
                    Password_Box.Enabled = false;
                    CreateBtn.Enabled = false;
                    Worker.RunWorkerAsync();

                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Only Numbers allowed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong\n"+ex.Message);
                }

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(Number_Box.Text);
                while (i>0)
                {
                
                    if (Username_Box.Text == "" && Password_Box.Text == "")
                    {
                        this.Invoke((MethodInvoker)delegate { timer.Start(); });
                        server.MakeUser(UserCreator.CreateRandomUser());
                        this.Invoke((MethodInvoker) delegate { Number_Box.Text = (--i).ToString();});
                    }
                        
                    else if (Username_Box.Text == "" || Password_Box.Text == "")
                    {
                        MessageBox.Show("you left an empty box");
                        return;
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate { timer.Start(); });
                        server.MakeUser(UserCreator.CreateUser(Username_Box.Text, Password_Box.Text));
                        this.Invoke((MethodInvoker)delegate { Number_Box.Text = (--i).ToString(); });
                    }
                }

                e.Result = true;
            }
            
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
                MessageBox.Show("Created Successfully..!", "Nice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Invoke((MethodInvoker)delegate
            {
                Number_Box.Enabled = true;
                Number_Box.Text = "1";
                Username_Box.Enabled = true;
                Password_Box.Enabled = true;
                CreateBtn.Enabled = true;
                CreateBtn.Text = "Create";
            });

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
                CreateBtn.Text = (--timeLeft).ToString();
            else
            {
                timeLeft = 31;
                timer.Stop();
            }
        }


    }
}