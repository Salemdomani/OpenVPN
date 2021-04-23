namespace OpenVPN
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IP_Box = new DevExpress.XtraEditors.TextEdit();
            this.Username_Box = new DevExpress.XtraEditors.TextEdit();
            this.Password_Box = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ConnectBtn = new DevExpress.XtraEditors.SimpleButton();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.UsersComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BuildAllBtn = new DevExpress.XtraEditors.SimpleButton();
            this.BuildBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.IP_Box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username_Box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // IP_Box
            // 
            this.IP_Box.EditValue = "94.140.115.53";
            this.IP_Box.Location = new System.Drawing.Point(84, 31);
            this.IP_Box.Name = "IP_Box";
            this.IP_Box.Size = new System.Drawing.Size(202, 22);
            this.IP_Box.TabIndex = 0;
            // 
            // Username_Box
            // 
            this.Username_Box.EditValue = "root";
            this.Username_Box.Location = new System.Drawing.Point(84, 59);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(202, 22);
            this.Username_Box.TabIndex = 1;
            // 
            // Password_Box
            // 
            this.Password_Box.EditValue = "kokoP@ssw0rd2020";
            this.Password_Box.Location = new System.Drawing.Point(84, 87);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Properties.UseSystemPasswordChar = true;
            this.Password_Box.Size = new System.Drawing.Size(202, 22);
            this.Password_Box.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Server IP";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ConnectBtn);
            this.groupControl1.Controls.Add(this.Password_Box);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.IP_Box);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Username_Box);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(298, 153);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Connection";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(175, 115);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(111, 29);
            this.ConnectBtn.TabIndex = 3;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.UsersComboBox);
            this.groupControl2.Controls.Add(this.BuildAllBtn);
            this.groupControl2.Controls.Add(this.BuildBtn);
            this.groupControl2.Location = new System.Drawing.Point(0, 150);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(298, 151);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Build";
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.Location = new System.Drawing.Point(84, 31);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsersComboBox.Size = new System.Drawing.Size(202, 22);
            this.UsersComboBox.TabIndex = 1;
            this.UsersComboBox.BeforePopup += new System.EventHandler(this.UsersComboBox_BeforePopup);
            // 
            // BuildAllBtn
            // 
            this.BuildAllBtn.Location = new System.Drawing.Point(175, 94);
            this.BuildAllBtn.Name = "BuildAllBtn";
            this.BuildAllBtn.Size = new System.Drawing.Size(111, 29);
            this.BuildAllBtn.TabIndex = 0;
            this.BuildAllBtn.Text = "Build All";
            this.BuildAllBtn.Click += new System.EventHandler(this.BuildAllBtn_Click);
            // 
            // BuildBtn
            // 
            this.BuildBtn.Location = new System.Drawing.Point(175, 59);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(111, 29);
            this.BuildBtn.TabIndex = 0;
            this.BuildBtn.Text = "Build";
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 300);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ConnectForm";
            this.Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)(this.IP_Box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username_Box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersComboBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit IP_Box;
        private DevExpress.XtraEditors.TextEdit Username_Box;
        private DevExpress.XtraEditors.TextEdit Password_Box;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton ConnectBtn;
        private System.ComponentModel.BackgroundWorker Worker;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton BuildBtn;
        private DevExpress.XtraEditors.ComboBoxEdit UsersComboBox;
        private DevExpress.XtraEditors.SimpleButton BuildAllBtn;
    }
}