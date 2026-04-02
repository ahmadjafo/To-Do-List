namespace To_Do_List
{
    partial class Form1
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
            this.TxtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkListTask = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPanding = new System.Windows.Forms.Label();
            this.lblComleted = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRemoveTask = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // TxtTaskName
            // 
            this.TxtTaskName.Location = new System.Drawing.Point(191, 152);
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.Size = new System.Drawing.Size(370, 26);
            this.TxtTaskName.TabIndex = 0;
            this.TxtTaskName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 118);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Do";
            // 
            // chkListTask
            // 
            this.chkListTask.FormattingEnabled = true;
            this.chkListTask.Location = new System.Drawing.Point(191, 193);
            this.chkListTask.Name = "chkListTask";
            this.chkListTask.Size = new System.Drawing.Size(370, 211);
            this.chkListTask.TabIndex = 4;
            this.chkListTask.SelectedIndexChanged += new System.EventHandler(this.chkListTask_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Panding :";
            // 
            // lblPanding
            // 
            this.lblPanding.AutoSize = true;
            this.lblPanding.Location = new System.Drawing.Point(279, 421);
            this.lblPanding.Name = "lblPanding";
            this.lblPanding.Size = new System.Drawing.Size(18, 20);
            this.lblPanding.TabIndex = 7;
            this.lblPanding.Text = "0";
            // 
            // lblComleted
            // 
            this.lblComleted.AutoSize = true;
            this.lblComleted.Location = new System.Drawing.Point(474, 421);
            this.lblComleted.Name = "lblComleted";
            this.lblComleted.Size = new System.Drawing.Size(18, 20);
            this.lblComleted.TabIndex = 9;
            this.lblComleted.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Completed :";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = global::To_Do_List.Properties.Resources.arrow;
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2CircleButton2.Location = new System.Drawing.Point(12, 12);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(49, 48);
            this.guna2CircleButton2.TabIndex = 11;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveTask.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRemoveTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveTask.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTask.Image = global::To_Do_List.Properties.Resources.delete;
            this.btnRemoveTask.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRemoveTask.Location = new System.Drawing.Point(587, 141);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRemoveTask.Size = new System.Drawing.Size(49, 48);
            this.btnRemoveTask.TabIndex = 10;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::To_Do_List.Properties.Resources.plus__2_;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2CircleButton1.Location = new System.Drawing.Point(653, 141);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(49, 48);
            this.guna2CircleButton1.TabIndex = 5;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.lblComleted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPanding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.chkListTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTaskName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkListTask;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPanding;
        private System.Windows.Forms.Label lblComleted;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleButton btnRemoveTask;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
    }
}

