using System.Data;
using System.Data.SqlClient;

namespace CU_Library
{
    public partial class Borrow_Books : Form
    {
        public Borrow_Books()
        {
            InitializeComponent();
        }

        private void Borrow_Books_Load(object sender, EventArgs e)
        {

            BorrowDate.CustomFormat = "dd/MM/yyyy";
            BorrowDate.Format = DateTimePickerFormat.Custom;
            BorrowDate.Value = DateTime.Today;
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter da = new("select * from BOOK where QUANTITY>0", cnn);
            DataSet ds = new();
            da.Fill(ds, "Book Title");
            Books.DataSource = ds.Tables["Book Title"];
            Books.DisplayMember = "TITLE";
            cnn.Close();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                if (ST_ID.Text == "")
                {
                    MessageBox.Show("Please enter student ID");
                }
                else
                {
                    if (Books.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < Books.CheckedItems.Count; i++)
                        {
                            string TITLE;
                            TITLE = Books.GetItemText(Books.CheckedItems[i]);
                            SqlCommand ISBN = new("select ISBN from BOOK where TITLE='" + TITLE + "'", cnn);
                            int ISBN2 = (int)ISBN.ExecuteScalar();
                            SqlCommand comd = new("insert into BORROWS values(" + ST_ID.Text + "," + ISBN2 + ",'" + BorrowDate.Value.Date.ToString("yyyyMMdd") + "'," + Log_In.U_ID + ")", cnn);
                            comd.ExecuteNonQuery();
                            SqlCommand commd = new("UPDATE BOOK SET QUANTITY=QUANTITY-1 WHERE ISBN=" + ISBN2, cnn);
                            commd.ExecuteNonQuery();

                        }
                        MessageBox.Show("Books were added to student borrowed books list ");
                    }
                    else
                    {
                        MessageBox.Show("Please choose at least 1 book");
                    }
                    cnn.Close();

                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new();
            this.Hide();
            u.Show();
        }

        private void Borrow_Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
