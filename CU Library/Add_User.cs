using System.Data.SqlClient;
namespace CU_Library
{
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();



                if (User_Name.Text == "" || Email.Text == "")
                {
                    MessageBox.Show("Please enter the data");
                }
                else
                {
                    if (Log_In.A_login)
                    {
                        SqlCommand id = new("select max(ADMIN_ID) from ADMIN", cnn);
                        int result = (int)id.ExecuteScalar();
                        SqlCommand cmd = new("insert into ADMIN values(" + (result + 1) + ",'" + User_Name.Text + "','" + Email.Text + "','0000',0)", cnn);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show("Admin added with ID " + (result + 1) + "\nWith default Password 0000 and he/she has to change it");
                    }
                    else
                    {
                        if (Faculty.Text == "")
                        { MessageBox.Show("Please enter the data"); }
                        else
                        {
                            SqlCommand id = new("select max(ST_ID) from STUDENT", cnn);
                            int result = (int)id.ExecuteScalar();
                            SqlCommand cmd = new("insert into STUDENT values(" + (result + 1) + "," + Log_In.U_ID + ",'" + User_Name.Text + "','" + Email.Text + "','0000','" + Faculty.Text + "')", cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            MessageBox.Show("Student added with ID " + (result + 1) + "\nWith default Password 0000 and he/she has to change it");
                        }
                    }
                }

            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            if (Log_In.A_login)
            {
                label5.Text = "Admin name";
                label5.Location = new Point(149, 179);
                Faculty.Hide();
                label4.Hide();
                Add_Button.Text = "Add admin";
                label6.Text = "Add admin";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_In.A_login = true;
            User user = new();
            this.Hide();
            user.Show();
        }

        private void Add_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}