namespace CU_Library
{
    partial class Update_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Book));
            this.ISBN_Get = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Book_Details = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.U_QUANTITY = new System.Windows.Forms.TextBox();
            this.U_TITLE = new System.Windows.Forms.TextBox();
            this.U_AUTHOR = new System.Windows.Forms.TextBox();
            this.U_P_NAME = new System.Windows.Forms.TextBox();
            this.U_P_YEAR = new System.Windows.Forms.TextBox();
            this.Current_Cat_View = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat_View = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Films = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current_Cat_View)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN_Get
            // 
            this.ISBN_Get.Location = new System.Drawing.Point(471, 12);
            this.ISBN_Get.Name = "ISBN_Get";
            this.ISBN_Get.Size = new System.Drawing.Size(94, 29);
            this.ISBN_Get.TabIndex = 0;
            this.ISBN_Get.Text = "Get";
            this.ISBN_Get.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ISBN_Get.UseVisualStyleBackColor = true;
            this.ISBN_Get.Click += new System.EventHandler(this.ISBN_Get_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(268, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(326, 14);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(125, 27);
            this.ISBN.TabIndex = 3;
            // 
            // Book_Details
            // 
            this.Book_Details.AllowUserToAddRows = false;
            this.Book_Details.AllowUserToDeleteRows = false;
            this.Book_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Book_Details.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Book_Details.BackgroundColor = System.Drawing.Color.White;
            this.Book_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_Details.Location = new System.Drawing.Point(12, 56);
            this.Book_Details.Name = "Book_Details";
            this.Book_Details.ReadOnly = true;
            this.Book_Details.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Book_Details.RowTemplate.Height = 29;
            this.Book_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Book_Details.Size = new System.Drawing.Size(825, 153);
            this.Book_Details.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(558, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Publication year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(558, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publisher name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(297, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(33, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Author name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(90, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Title";
            // 
            // U_QUANTITY
            // 
            this.U_QUANTITY.Location = new System.Drawing.Point(368, 240);
            this.U_QUANTITY.Name = "U_QUANTITY";
            this.U_QUANTITY.Size = new System.Drawing.Size(125, 27);
            this.U_QUANTITY.TabIndex = 11;
            // 
            // U_TITLE
            // 
            this.U_TITLE.Location = new System.Drawing.Point(134, 240);
            this.U_TITLE.Name = "U_TITLE";
            this.U_TITLE.Size = new System.Drawing.Size(125, 27);
            this.U_TITLE.TabIndex = 12;
            // 
            // U_AUTHOR
            // 
            this.U_AUTHOR.Location = new System.Drawing.Point(134, 290);
            this.U_AUTHOR.Name = "U_AUTHOR";
            this.U_AUTHOR.Size = new System.Drawing.Size(125, 27);
            this.U_AUTHOR.TabIndex = 13;
            // 
            // U_P_NAME
            // 
            this.U_P_NAME.Location = new System.Drawing.Point(679, 288);
            this.U_P_NAME.Name = "U_P_NAME";
            this.U_P_NAME.Size = new System.Drawing.Size(125, 27);
            this.U_P_NAME.TabIndex = 14;
            // 
            // U_P_YEAR
            // 
            this.U_P_YEAR.Location = new System.Drawing.Point(679, 240);
            this.U_P_YEAR.Name = "U_P_YEAR";
            this.U_P_YEAR.Size = new System.Drawing.Size(125, 27);
            this.U_P_YEAR.TabIndex = 15;
            // 
            // Current_Cat_View
            // 
            this.Current_Cat_View.AllowUserToAddRows = false;
            this.Current_Cat_View.AllowUserToDeleteRows = false;
            this.Current_Cat_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Current_Cat_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Current_Cat_View.BackgroundColor = System.Drawing.Color.White;
            this.Current_Cat_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Current_Cat_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categories});
            this.Current_Cat_View.Location = new System.Drawing.Point(635, 324);
            this.Current_Cat_View.Name = "Current_Cat_View";
            this.Current_Cat_View.ReadOnly = true;
            this.Current_Cat_View.RowHeadersWidth = 51;
            this.Current_Cat_View.RowTemplate.Height = 29;
            this.Current_Cat_View.Size = new System.Drawing.Size(169, 188);
            this.Current_Cat_View.TabIndex = 16;
            // 
            // Categories
            // 
            this.Categories.DataPropertyName = "CATEGORY_NAME";
            this.Categories.HeaderText = "Categories";
            this.Categories.MinimumWidth = 6;
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            // 
            // Cat_View
            // 
            this.Cat_View.FormattingEnabled = true;
            this.Cat_View.Location = new System.Drawing.Point(101, 337);
            this.Cat_View.Name = "Cat_View";
            this.Cat_View.Size = new System.Drawing.Size(158, 180);
            this.Cat_View.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 40);
            this.label7.TabIndex = 18;
            this.label7.Text = "     All\r\ncategories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(551, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 40);
            this.label8.TabIndex = 19;
            this.label8.Text = "   Book\'s\r\ncategories";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(-4, -6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "Title";
            this.TITLE.MinimumWidth = 6;
            this.TITLE.Name = "TITLE";
            this.TITLE.Width = 134;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update films";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 29);
            this.button4.TabIndex = 22;
            this.button4.Text = "Add films";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Films
            // 
            this.Films.FormattingEnabled = true;
            this.Films.Location = new System.Drawing.Point(326, 14);
            this.Films.Name = "Films";
            this.Films.Size = new System.Drawing.Size(125, 28);
            this.Films.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 29);
            this.button5.TabIndex = 24;
            this.button5.Text = "Delete Book";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Update_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 524);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Films);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cat_View);
            this.Controls.Add(this.Current_Cat_View);
            this.Controls.Add(this.U_P_YEAR);
            this.Controls.Add(this.U_P_NAME);
            this.Controls.Add(this.U_AUTHOR);
            this.Controls.Add(this.U_TITLE);
            this.Controls.Add(this.U_QUANTITY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Book_Details);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISBN_Get);
            this.Name = "Update_Book";
            this.Text = "Update Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_Book_FormClosing);
            this.Load += new System.EventHandler(this.Update_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current_Cat_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ISBN_Get;
        private Label label2;
        private TextBox ISBN;
        private DataGridView Book_Details;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox U_QUANTITY;
        private TextBox U_TITLE;
        private TextBox U_AUTHOR;
        private TextBox U_P_NAME;
        private TextBox U_P_YEAR;
        private DataGridView Current_Cat_View;
        private CheckedListBox Cat_View;
        private DataGridViewTextBoxColumn Categories;
        private Label label7;
        private Label label8;
        private Button button2;
        private DataGridViewTextBoxColumn TITLE;
        private Button button3;
        private Button button4;
        private ComboBox Films;
        private Button button5;
    }
}