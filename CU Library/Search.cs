using System.Data;
using System.Data.SqlClient;
namespace CU_Library
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new();
            this.Hide();
            user.Show();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "    ";
            dateTimePicker1.ShowUpDown = true;
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string Sql = "select CATEGORY_NAME from CATEGORY";
            SqlCommand cmd = new(Sql, cnn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                Categories.Items.Add(DR[0]);
            }
        }

        private void SEARCH_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                if (checkBox1.Checked == false && ISBN.Text == "" && AUTHORNAME.Text == "" && dateTimePicker1.Checked == false && PUBLISHERNAME.Text == "" && TITLE.Text == "" && Categories.Text == "")
                {
                    MessageBox.Show("Please enter anything to search for");
                }
                else
                {
                    int counter = 0;
                    string Query = "SELECT BOOK.ISBN AS ISBN,TITLE AS Title ,AUTHOR_Name AS [Author name],PUBLISHER_Name as [Publisher name],YEAR(PUBLICATIONYEAR) as [Publication year],ISNULL(STRING_AGG(CATEGORY_NAME,'-'),'Not specified') as Categories,ISNULL(STRING_AGG(FILM_NAME,'-'), 'NOT a film base') as Films,ISNULL(STRING_AGG(DIRECTOR,'-'), '-----') as Director,ISNULL(STRING_AGG(year(PRODUCTION_YEAR),'-'), '-----') as [Production year] FROM BOOK LEFT OUTER JOIN BELONGS_TO on BELONGS_TO.ISBN=BOOK.ISBN left outer join CATEGORY on BELONGS_TO.CAT_ID=CATEGORY.CATEGORY_ID LEFT OUTER JOIN FILMBASED on BOOK.ISBN=FILMBASED.ISBN ";
                    if (ISBN.Text != "")
                    {
                        Query += ("where BOOK.ISBN=" + ISBN.Text);
                    }
                    else
                    {
                        if (Categories.Text != "")
                        {
                            Query += ("where CATEGORY_NAME='" + Categories.Text + "'");
                            counter++;
                        }
                        if (TITLE.Text != "")
                        {
                            if (counter > 0)
                            {
                                Query += " and ";
                                Query += ("TITLE like '%" + TITLE.Text + "%'");
                            }
                            else
                            {
                                Query += ("where TITLE like '%" + TITLE.Text + "%'");
                                counter++;
                            }


                        }
                        if (AUTHORNAME.Text != "")
                        {
                            if (counter > 0)
                            {
                                Query += " and ";
                                Query += ("AUTHOR_Name like '%" + AUTHORNAME.Text + "%'");
                            }
                            else
                            {
                                Query += ("where AUTHOR_Name like '%" + AUTHORNAME.Text + "%'");
                                counter++;
                            }
                        }
                        if (PUBLISHERNAME.Text != "")
                        {
                            if (counter > 0)
                            {
                                Query += " and ";
                                Query += ("PUBLISHER_Name like '%" + PUBLISHERNAME.Text + "%'");
                            }
                            else
                            {
                                Query += ("where PUBLISHER_Name like '%" + PUBLISHERNAME.Text + "%'");
                                counter++;
                            }
                        }
                        if (dateTimePicker1.Checked == true)
                        {
                            if (counter > 0)
                            {
                                Query += " and ";

                                Query += ("YEAR(PUBLICATIONYEAR)=" + dateTimePicker1.Text);
                            }
                            else
                            {
                                Query += ("where YEAR(PUBLICATIONYEAR)=" + dateTimePicker1.Text);
                                counter++;
                            }
                        }
                        if (checkBox1.Checked == true)
                        {
                            if (counter > 0)
                            {
                                Query += " and ";

                                Query += ("FILM_NAME IS NOT NULL");
                            }
                            else
                            {
                                Query += ("where FILM_NAME IS NOT NULL");
                            }
                        }
                    }
                    Query += " group by BOOK.ISBN,TITLE,AUTHOR_Name,PUBLICATIONYEAR,PUBLISHER_Name";
                    SqlDataAdapter dataadapter = new(Query, cnn);
                    DataTable datatable = new();
                    dataadapter.Fill(datatable);
                    SEARCH_RESULTS_GV.DataSource = datatable;
                    cnn.Close();
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (((DateTimePicker)sender).ShowCheckBox == true)
            {
                if (((DateTimePicker)sender).Checked == false)
                {
                    ((DateTimePicker)sender).CustomFormat = " ";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    ((DateTimePicker)sender).CustomFormat = "yyyy";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                    ((DateTimePicker)sender).ShowUpDown = true;
                }
            }
            else
            {
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
            }

        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
