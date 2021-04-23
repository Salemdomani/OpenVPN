namespace OpenVPN
{
    partial class CreateForm
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
            this.components = new System.ComponentModel.Container();
            this.Username_Box = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Number_Box = new DevExpress.XtraEditors.TextEdit();
            this.CreateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Password_Box = new DevExpress.XtraEditors.TextEdit();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Username_Box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Box.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Box
            // 
            this.Username_Box.Location = new System.Drawing.Point(84, 31);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(202, 22);
            this.Username_Box.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Number_Box);
            this.groupControl1.Controls.Add(this.CreateBtn);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Password_Box);
            this.groupControl1.Controls.Add(this.Username_Box);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(298, 132);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Creation";
            // 
            // Number_Box
            // 
            this.Number_Box.Location = new System.Drawing.Point(84, 90);
            this.Number_Box.Name = "Number_Box";
            this.Number_Box.Size = new System.Drawing.Size(51, 22);
            this.Number_Box.TabIndex = 4;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(141, 87);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(145, 29);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "username";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "password";
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(84, 59);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(202, 22);
            this.Password_Box.TabIndex = 1;
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 132);
            this.Controls.Add(this.groupControl1);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Username_Box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Box.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Username_Box;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit Password_Box;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton CreateBtn;
        private DevExpress.XtraEditors.TextEdit Number_Box;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.Timer timer;
    }
}