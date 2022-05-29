namespace CU_Library
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.SEARCH_BUTTON = new System.Windows.Forms.Button();
            this.TITLE = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.PUBLISHERNAME = new System.Windows.Forms.TextBox();
            this.AUTHORNAME = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LABEL8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SEARCH_RESULTS_GV = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_RESULTS_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // SEARCH_BUTTON
            // 
            this.SEARCH_BUTTON.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SEARCH_BUTTON.Location = new System.Drawing.Point(341, 128);
            this.SEARCH_BUTTON.Name = "SEARCH_BUTTON";
            this.SEARCH_BUTTON.Size = new System.Drawing.Size(94, 29);
            this.SEARCH_BUTTON.TabIndex = 0;
            this.SEARCH_BUTTON.Text = "Search";
            this.SEARCH_BUTTON.UseVisualStyleBackColor = true;
            this.SEARCH_BUTTON.Click += new System.EventHandler(this.SEARCH_BUTTON_Click);
            // 
            // TITLE
            // 
            this.TITLE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TITLE.ForeColor = System.Drawing.Color.Black;
            this.TITLE.Location = new System.Drawing.Point(100, 73);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(125, 27);
            this.TITLE.TabIndex = 1;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(100, 22);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(125, 27);
            this.ISBN.TabIndex = 2;
            // 
            // PUBLISHERNAME
            // 
            this.PUBLISHERNAME.Location = new System.Drawing.Point(356, 73);
            this.PUBLISHERNAME.Name = "PUBLISHERNAME";
            this.PUBLISHERNAME.Size = new System.Drawing.Size(125, 27);
            this.PUBLISHERNAME.TabIndex = 3;
            // 
            // AUTHORNAME
            // 
            this.AUTHORNAME.Location = new System.Drawing.Point(356, 22);
            this.AUTHORNAME.Name = "AUTHORNAME";
            this.AUTHORNAME.Size = new System.Drawing.Size(125, 27);
            this.AUTHORNAME.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(-4, -6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ISBN";
            // 
            // LABEL8
            // 
            this.LABEL8.AutoSize = true;
            this.LABEL8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LABEL8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABEL8.Location = new System.Drawing.Point(240, 80);
            this.LABEL8.Name = "LABEL8";
            this.LABEL8.Size = new System.Drawing.Size(110, 20);
            this.LABEL8.TabIndex = 9;
            this.LABEL8.Text = "Publisher name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(240, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(56, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(507, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Publication year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(553, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category";
            // 
            // SEARCH_RESULTS_GV
            // 
            this.SEARCH_RESULTS_GV.AllowUserToAddRows = false;
            this.SEARCH_RESULTS_GV.AllowUserToDeleteRows = false;
            this.SEARCH_RESULTS_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SEARCH_RESULTS_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SEARCH_RESULTS_GV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.SEARCH_RESULTS_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SEARCH_RESULTS_GV.GridColor = System.Drawing.Color.Black;
            this.SEARCH_RESULTS_GV.Location = new System.Drawing.Point(12, 163);
            this.SEARCH_RESULTS_GV.Name = "SEARCH_RESULTS_GV";
            this.SEARCH_RESULTS_GV.ReadOnly = true;
            this.SEARCH_RESULTS_GV.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SEARCH_RESULTS_GV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SEARCH_RESULTS_GV.Size = new System.Drawing.Size(770, 339);
            this.SEARCH_RESULTS_GV.TabIndex = 14;
            // 
            // Categories
            // 
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(628, 80);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(125, 28);
            this.Categories.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(628, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 27);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 23, 22, 26, 20, 732);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(108, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Film base";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.SEARCH_RESULTS_GV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LABEL8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AUTHORNAME);
            this.Controls.Add(this.PUBLISHERNAME);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.SEARCH_BUTTON);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Search";
            this.Text = "Browse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_FormClosing);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_RESULTS_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SEARCH_BUTTON;
        private TextBox TITLE;
        private TextBox ISBN;
        private TextBox PUBLISHERNAME;
        private TextBox AUTHORNAME;
        private Button button2;
        private Label label1;
        private Label LABEL8;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView SEARCH_RESULTS_GV;
        private ComboBox Categories;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
    }
}