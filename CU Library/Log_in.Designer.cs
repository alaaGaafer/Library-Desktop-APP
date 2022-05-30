namespace CU_Library
{
    partial class Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Log_In_Button = new System.Windows.Forms.Button();
            this.Student_RButton = new System.Windows.Forms.RadioButton();
            this.Admin_RButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(216, 171);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(125, 27);
            this.ID.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(216, 239);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(125, 27);
            this.Password.TabIndex = 4;
            // 
            // Log_In_Button
            // 
            this.Log_In_Button.Location = new System.Drawing.Point(158, 334);
            this.Log_In_Button.Name = "Log_In_Button";
            this.Log_In_Button.Size = new System.Drawing.Size(94, 29);
            this.Log_In_Button.TabIndex = 5;
            this.Log_In_Button.Text = "Log in";
            this.Log_In_Button.UseVisualStyleBackColor = true;
            this.Log_In_Button.Click += new System.EventHandler(this.Log_In_Button_Click);
            // 
            // Student_RButton
            // 
            this.Student_RButton.AutoSize = true;
            this.Student_RButton.Location = new System.Drawing.Point(140, 296);
            this.Student_RButton.Name = "Student_RButton";
            this.Student_RButton.Size = new System.Drawing.Size(81, 24);
            this.Student_RButton.TabIndex = 6;
            this.Student_RButton.TabStop = true;
            this.Student_RButton.Text = "Student";
            this.Student_RButton.UseVisualStyleBackColor = true;
            // 
            // Admin_RButton
            // 
            this.Admin_RButton.AutoSize = true;
            this.Admin_RButton.Location = new System.Drawing.Point(324, 296);
            this.Admin_RButton.Name = "Admin_RButton";
            this.Admin_RButton.Size = new System.Drawing.Size(74, 24);
            this.Admin_RButton.TabIndex = 7;
            this.Admin_RButton.TabStop = true;
            this.Admin_RButton.Text = "Admin";
            this.Admin_RButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Log_In_Button);
            this.groupBox1.Location = new System.Drawing.Point(69, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 384);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 408);
            this.Controls.Add(this.Admin_RButton);
            this.Controls.Add(this.Student_RButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Log_In";
            this.Text = "CU Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_In_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ID;
        private TextBox Password;
        private Button Log_In_Button;
        private RadioButton Student_RButton;
        private RadioButton Admin_RButton;
        private GroupBox groupBox1;
    }
}