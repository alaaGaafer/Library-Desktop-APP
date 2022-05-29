using System.Data;
using System.Data.SqlClient;


namespace CU_Library
{
    public partial class Update_User_Details : Form
    {
        public Update_User_Details()
        {
            InitializeComponent();
        }

        private void Update_Admin_Details_Load(object sender, EventArgs e)
        {

            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (Log_In.A_login)
            {
                label7.Hide();
                FACULTY.Hide();
                SqlDataAdapter dataadapter = new("SELECT AD_NAME as Name,EMAIL as Email FROM ADMIN where ADMIN_ID=" + Log_In.U_ID, cnn);
                DataTable datatable = new();
                dataadapter.Fill(datatable);
                Update_A_View.DataSource = datatable;
                Update_A_View.AutoResizeColumns();
                cnn.Close();
            }
            else
            {
                SqlDataAdapter dataadapter = new("SELECT ST_NAME as Name,EMAIL as Email,FACULTY as Faculty FROM STUDENT where ST_ID=" + Log_In.U_ID, cnn);
                DataTable datatable = new();
                dataadapter.Fill(datatable);
                Update_A_View.DataSource = datatable;
                Update_A_View.AutoResizeColumns();
                cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                if (Log_In.A_login)
                {

                    if (U_Email.Text == "" && U_Name.Text == "" && C_Password.Text == "" && N_Password.Text == "" && R_N_Password.Text == "")
                    {
                        MessageBox.Show("Please enter the data");
                    }
                    else
                    {

                        if (U_Email.Text != "")
                        {
                            SqlCommand cmd1 = new("UPDATE ADMIN SET EMAIL ='" + U_Email.Text + "' where ADMIN_ID=" + Log_In.U_ID, cnn);
                            cmd1.ExecuteNonQuery();
                        }
                        if (U_Name.Text != "")
                        {
                            SqlCommand cmd2 = new("UPDATE ADMIN SET AD_NAME ='" + U_Name.Text + "' where ADMIN_ID=" + Log_In.U_ID, cnn);
                            cmd2.ExecuteNonQuery();
                        }
                        if (C_Password.Text != "")
                        {
                            SqlCommand cmd3 = new("select PASSWORD from ADMIN where ADMIN_ID =" + Log_In.U_ID, cnn);
                            string password = (string)cmd3.ExecuteScalar();


                            if (password == C_Password.Text)
                            {
                                if (N_Password.Text != "" || R_N_Password.Text != "")
                                {
                                    if (N_Password.Text == R_N_Password.Text)
                                    {
                                        SqlCommand cmd4 = new("UPDATE ADMIN SET PASSWORD ='" + N_Password.Text + "' where ADMIN_ID=" + Log_In.U_ID, cnn);
                                        cmd4.ExecuteNonQuery();
                                        MessageBox.Show("Your password is updated");
                                    }
                                    else
                                    {
                                        MessageBox.Show("The 2 Passwords aren't identical");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please write a new password");
                                }


                            }
                            else
                            {
                                MessageBox.Show("You entered your current password wrong");
                            }

                        }


                    }
                    SqlDataAdapter dataadapter = new("SELECT AD_NAME as Name,EMAIL as Email FROM ADMIN where ADMIN_ID=" + Log_In.U_ID, cnn);
                    DataTable datatable = new();
                    dataadapter.Fill(datatable);
                    Update_A_View.DataSource = datatable;
                    Update_A_View.AutoResizeColumns();
                    cnn.Close();
                }
                else
                {
                    if (U_Email.Text == "" && U_Name.Text == "" && C_Password.Text == "" && N_Password.Text == "" && R_N_Password.Text == "" && FACULTY.Text == "")
                    {
                        MessageBox.Show("Please enter the data");
                    }
                    else
                    {
                        if (FACULTY.Text != "")
                        {
                            SqlCommand cmd1 = new("UPDATE STUDENT SET FACULTY ='" + FACULTY.Text + "' where ST_ID=" + Log_In.U_ID, cnn);
                            cmd1.ExecuteNonQuery();
                        }

                        if (U_Email.Text != "")
                        {
                            SqlCommand cmd1 = new("UPDATE STUDENT SET EMAIL ='" + U_Email.Text + "' where ST_ID=" + Log_In.U_ID, cnn);
                            cmd1.ExecuteNonQuery();
                        }
                        if (U_Name.Text != "")
                        {
                            SqlCommand cmd2 = new("UPDATE STUDENT SET ST_NAME ='" + U_Name.Text + "' where ST_ID=" + Log_In.U_ID, cnn);
                            cmd2.ExecuteNonQuery();
                        }
                        if (C_Password.Text != "")
                        {
                            SqlCommand cmd3 = new("select PASSWORD from STUDENT where ST_ID =" + Log_In.U_ID, cnn);
                            string password = (string)cmd3.ExecuteScalar();


                            if (password == C_Password.Text)
                            {
                                if (N_Password.Text != "" || R_N_Password.Text != "")
                                {
                                    if (N_Password.Text == R_N_Password.Text)
                                    {
                                        SqlCommand cmd4 = new("UPDATE STUDENT SET PASSWORD ='" + N_Password.Text + "' where ST_ID=" + Log_In.U_ID, cnn);
                                        cmd4.ExecuteNonQuery();
                                        MessageBox.Show("Your password is updated");
                                    }
                                    else
                                    {
                                        MessageBox.Show("The 2 Passwords aren't identical");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please write a new password");
                                }


                            }
                            else
                            {
                                MessageBox.Show("You entered your current password wrong");
                            }

                        }


                    }
                    SqlDataAdapter dataadapter = new("SELECT ST_NAME as Name, EMAIL as Email ,FACULTY as Faculty FROM STUDENT where ST_ID=" + Log_In.U_ID, cnn);
                    DataTable datatable = new();
                    dataadapter.Fill(datatable);
                    Update_A_View.DataSource = datatable;
                    Update_A_View.AutoResizeColumns();
                    cnn.Close();
                }

            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            User user = new();
            this.Hide();
            user.Show();
        }

        private void Update_User_Details_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
