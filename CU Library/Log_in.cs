using System.Data.SqlClient;

namespace CU_Library
{
    public partial class Log_In : Form
    {

        public Log_In()
        {

            InitializeComponent();

        }
        public static string U_ID = "";
        public static bool A_login = false;
        public static bool S_A_login = false;


        private void Log_In_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please enter the data");
                }
                else
                {
                    U_ID = ID.Text;
                    if (!Admin_RButton.Checked && !Student_RButton.Checked)
                    {
                        MessageBox.Show("Please choose whether you are an admin or student");
                    }
                    else
                    {
                        string connetionString;
                        SqlConnection cnn;
                        connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                        cnn = new SqlConnection(connetionString);
                        cnn.Open();
                        if (Admin_RButton.Checked)
                        {

                            SqlCommand Admin_log_in = new("select PASSWORD from ADMIN where ADMIN_ID=" + ID.Text, cnn);
                            string result = (string)Admin_log_in.ExecuteScalar();
                            if (result == Password.Text)
                            {
                                A_login = true;
                                SqlCommand Superc = new("select SUPER_ADMIN from ADMIN where ADMIN_ID=" + ID.Text, cnn);
                                bool Super = (bool)Superc.ExecuteScalar();
                                cnn.Close();
                                if (Super == true)
                                {
                                    S_A_login = true;
                                }
                                User admin = new();
                                this.Hide();
                                admin.Show();

                            }
                            else
                            {
                                MessageBox.Show("You entered either a wrong password or a wrong ID\nplease check your inputs and try again");
                            }
                        }
                        else
                        {
                            SqlCommand Admin_log_in = new("select PASSWORD from STUDENT where ST_ID=" + ID.Text, cnn);
                            string result = (string)Admin_log_in.ExecuteScalar();
                            cnn.Close();
                            if (result == Password.Text)
                            {
                                A_login = false;
                                User u = new();
                                this.Hide();
                                u.Show();
                            }
                            else
                            {
                                MessageBox.Show("You entered either a wrong password or a wrong ID\n please check your inputs and try again");
                            }
                        }

                    }
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void Log_In_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
