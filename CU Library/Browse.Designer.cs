namespace CU_Library
{
    partial class Browse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browse));
            this.Admin_Browse_View = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Browse_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_Browse_View
            // 
            this.Admin_Browse_View.AllowUserToAddRows = false;
            this.Admin_Browse_View.AllowUserToDeleteRows = false;
            this.Admin_Browse_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Admin_Browse_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Admin_Browse_View.BackgroundColor = System.Drawing.Color.Silver;
            this.Admin_Browse_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin_Browse_View.Location = new System.Drawing.Point(12, 42);
            this.Admin_Browse_View.Name = "Admin_Browse_View";
            this.Admin_Browse_View.ReadOnly = true;
            this.Admin_Browse_View.RowHeadersWidth = 51;
            this.Admin_Browse_View.RowTemplate.Height = 29;
            this.Admin_Browse_View.Size = new System.Drawing.Size(935, 478);
            this.Admin_Browse_View.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-4, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Admin_Browse_View);
            this.Name = "Browse";
            this.Text = "Browse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Browse_FormClosing);
            this.Load += new System.EventHandler(this.Admin_browse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Browse_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Admin_Browse_View;
        private Button button1;
    }
}