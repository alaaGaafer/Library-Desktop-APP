using System.Data;
using System.Data.SqlClient;

namespace CU_Library
{
    public partial class Show_Borrowed : Form
    {
        public Show_Borrowed()
        {
            InitializeComponent();
        }

        private void Show_Borrowed_Load(object sender, EventArgs e)
        {
            if (Log_In.A_login)
            {

            }
            else
            {
                Borrowed_list_view.Location = new(12, 38);
                Borrowed_list_view.Size = new Size(782, 520);
                label1.Hide();
                ST_ID.Hide();
                Show_All.Hide();
                Show_Student.Hide();
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlDataAdapter dataadapter = new("SELECT TITLE,BORROWDATE as [Borrow date],DUEDATE as [Due date] from BOOK,BORROWS where ST_ID=" + Log_In.U_ID + "and BORROWS.ISBN = BOOK.ISBN", cnn);
                DataTable datatable = new();
                dataadapter.Fill(datatable);
                Borrowed_list_view.DataSource = datatable;
                cnn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new();
            this.Hide();
            u.Show();
        }

        private void Show_All_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlDataAdapter dataadapter = new("SELECT ST_ID as [Student ID] , TITLE,BORROWDATE as [Borrow date],DUEDATE as [Due date],BORROWS.Admin_ID as [Admin ID] from BOOK,BORROWS where BORROWS.ISBN = BOOK.ISBN", cnn);
                DataTable datatable = new();
                dataadapter.Fill(datatable);
                Borrowed_list_view.DataSource = datatable;
                cnn.Close();
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void Show_Student_Click(object sender, EventArgs e)
        {
            try
            {
                if (ST_ID.Text == "")
                {
                    MessageBox.Show("Please add student id");
                }
                else
                {

                    string connetionString;
                    SqlConnection cnn;
                    connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    SqlDataAdapter dataadapter = new("SELECT TITLE,BORROWDATE as [Borrow date],DUEDATE as [Due date],BORROWS.Admin_ID as [Admin ID] from BOOK,BORROWS where ST_ID=" + ST_ID.Text + "and BORROWS.ISBN = BOOK.ISBN", cnn);
                    DataTable datatable = new();
                    dataadapter.Fill(datatable);
                    Borrowed_list_view.DataSource = datatable;
                    cnn.Close();
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void Show_Borrowed_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
