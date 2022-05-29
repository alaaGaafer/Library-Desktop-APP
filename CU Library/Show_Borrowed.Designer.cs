namespace CU_Library
{
    partial class Show_Borrowed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Borrowed));
            this.Borrowed_list_view = new System.Windows.Forms.DataGridView();
            this.Show_Student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ST_ID = new System.Windows.Forms.TextBox();
            this.Show_All = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Borrowed_list_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Borrowed_list_view
            // 
            this.Borrowed_list_view.AllowUserToAddRows = false;
            this.Borrowed_list_view.AllowUserToDeleteRows = false;
            this.Borrowed_list_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Borrowed_list_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Borrowed_list_view.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Borrowed_list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Borrowed_list_view.Location = new System.Drawing.Point(12, 78);
            this.Borrowed_list_view.Name = "Borrowed_list_view";
            this.Borrowed_list_view.ReadOnly = true;
            this.Borrowed_list_view.RowHeadersWidth = 51;
            this.Borrowed_list_view.RowTemplate.Height = 29;
            this.Borrowed_list_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Borrowed_list_view.Size = new System.Drawing.Size(782, 480);
            this.Borrowed_list_view.TabIndex = 0;
            // 
            // Show_Student
            // 
            this.Show_Student.Location = new System.Drawing.Point(317, 16);
            this.Show_Student.Name = "Show_Student";
            this.Show_Student.Size = new System.Drawing.Size(107, 56);
            this.Show_Student.TabIndex = 1;
            this.Show_Student.Text = "Show student\'s list";
            this.Show_Student.UseVisualStyleBackColor = true;
            this.Show_Student.Click += new System.EventHandler(this.Show_Student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // ST_ID
            // 
            this.ST_ID.Location = new System.Drawing.Point(170, 31);
            this.ST_ID.Name = "ST_ID";
            this.ST_ID.Size = new System.Drawing.Size(125, 27);
            this.ST_ID.TabIndex = 3;
            // 
            // Show_All
            // 
            this.Show_All.Location = new System.Drawing.Point(656, 18);
            this.Show_All.Name = "Show_All";
            this.Show_All.Size = new System.Drawing.Size(138, 52);
            this.Show_All.TabIndex = 4;
            this.Show_All.Text = "Show all borrowed books";
            this.Show_All.UseVisualStyleBackColor = true;
            this.Show_All.Click += new System.EventHandler(this.Show_All_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-4, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show_Borrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Show_All);
            this.Controls.Add(this.ST_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show_Student);
            this.Controls.Add(this.Borrowed_list_view);
            this.Name = "Show_Borrowed";
            this.Text = "Show Borrowed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_Borrowed_FormClosing);
            this.Load += new System.EventHandler(this.Show_Borrowed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Borrowed_list_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Borrowed_list_view;
        private Button Show_Student;
        private Label label1;
        private TextBox ST_ID;
        private Button Show_All;
        private Button button1;
    }
}