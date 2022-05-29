using System.Data.SqlClient;

namespace CU_Library
{
    public partial class Films_base : Form
    {
        public Films_base()
        {
            InitializeComponent();
        }

        private void Films_base_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FILM_NAME.Text == "" || DIRECTOR.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please enter the data");
                }
                else
                {
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    //update add = update book then add films
                    if (Update_Book.update_add == true)
                    {
                        SqlCommand comd = new("insert into FILMBASED values(" + Update_Book.isbn + ",'" + FILM_NAME.Text + "','" + DIRECTOR.Text + "','" + dateTimePicker1.Text + "')", cnn);
                        comd.ExecuteNonQuery();
                        MessageBox.Show("The film's info were added succesfully");
                    }
                    else
                    {
                        SqlCommand ISBN = new("select max(ISBN) from BOOK", cnn);
                        int result = (int)ISBN.ExecuteScalar();
                        SqlCommand cmd = new("insert into FILMBASED values(" + result + ",'" + FILM_NAME.Text + "','" + DIRECTOR.Text + "','" + dateTimePicker1.Text + "')", cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The film's info were added succesfully");
                    }
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Update_Book.update_add == true)
            {
                Update_Book.update_add = false;
                Update_Book u = new();
                this.Hide();
                u.Show();
            }
            else
            {
                Add_Book a = new();
                this.Hide();
                a.Show();
            }
        }

        private void Films_base_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
