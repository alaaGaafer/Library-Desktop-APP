namespace CU_Library
{
    partial class Borrow_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow_Books));
            this.label1 = new System.Windows.Forms.Label();
            this.Books = new System.Windows.Forms.CheckedListBox();
            this.Borrow = new System.Windows.Forms.Button();
            this.ST_ID = new System.Windows.Forms.TextBox();
            this.BorrowDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(79, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // Books
            // 
            this.Books.BackColor = System.Drawing.SystemColors.Window;
            this.Books.FormattingEnabled = true;
            this.Books.Location = new System.Drawing.Point(313, 60);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(265, 422);
            this.Books.TabIndex = 1;
            // 
            // Borrow
            // 
            this.Borrow.Location = new System.Drawing.Point(114, 265);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(122, 53);
            this.Borrow.TabIndex = 2;
            this.Borrow.Text = "Add Borrowed Books";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // ST_ID
            // 
            this.ST_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_ID.Location = new System.Drawing.Point(164, 131);
            this.ST_ID.Name = "ST_ID";
            this.ST_ID.Size = new System.Drawing.Size(122, 27);
            this.ST_ID.TabIndex = 3;
            // 
            // BorrowDate
            // 
            this.BorrowDate.Location = new System.Drawing.Point(164, 194);
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.Size = new System.Drawing.Size(122, 27);
            this.BorrowDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(21, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Borrowing on day :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-4, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Borrow_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BorrowDate);
            this.Controls.Add(this.ST_ID);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.label1);
            this.Name = "Borrow_Books";
            this.Text = "Borrow_Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Borrow_Books_FormClosing);
            this.Load += new System.EventHandler(this.Borrow_Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckedListBox Books;
        private Button Borrow;
        private TextBox ST_ID;
        private DateTimePicker BorrowDate;
        private Label label2;
        private Button button1;
    }
}