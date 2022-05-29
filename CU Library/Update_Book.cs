using System.Data;
using System.Data.SqlClient;

namespace CU_Library
{

    public partial class Update_Book : Form
    {
        public static bool update_add = false;
        public static bool update_update = false;
        public static String isbn = "";
        public Update_Book()
        {
            InitializeComponent();

        }


        private void Update_Book_Load(object sender, EventArgs e)
        {
            //update_update means update films page
            if (update_update == true)
            {
                Cat_View.Hide();
                Current_Cat_View.Hide();
                button4.Hide();
                U_P_NAME.Hide();
                U_AUTHOR.Hide();
                label7.Hide();
                label8.Hide();
                button3.Hide();
                button5.Hide();
                label5.Hide();
                label3.Hide();
                label2.Location = new(242, 17);
                label2.Text = "Film name";
                label4.Text = "Director";
                label1.Text = "Production year";
                label6.Text = "Film name";
                label6.Location = new(50, 247);
                ISBN.Hide();
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd = new("select FILM_NAME from FILMBASED WHERE ISBN=" + isbn, cnn);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Films.Items.Add(DR[0]);
                }
                cnn.Close();
            }
            else
            {
                Films.Hide();
            }

        }


        private void ISBN_Get_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                if (update_update == false)
                {
                    SqlDataAdapter dataadapter = new("SELECT BOOK.ISBN as ISBN,TITLE as [Title],AUTHOR_Name as[Author name],PUBLISHER_Name as[Publisher name],year(PUBLICATIONYEAR) as[publication year],ISNULL(STRING_AGG(FILM_NAME,'-'), 'NOT a film base') as Films ,ISNULL(STRING_AGG(DIRECTOR,'-'), '-----') as Director ,ISNULL(STRING_AGG(Year(PRODUCTION_YEAR),'-'), '-----') as [Production year],Admin_ID as[Admin ID],QUANTITY as[Quantity] FROM BOOK LEFT OUTER JOIN FILMBASED on BOOK.ISBN=FILMBASED.ISBN where BOOK.ISBN=" + ISBN.Text + "GROUP BY BOOK.ISBN , BOOK.TITLE ,AUTHOR_Name , PUBLISHER_Name,PUBLICATIONYEAR,Admin_ID,QUANTITY", cnn);
                    DataTable datatable = new();
                    dataadapter.Fill(datatable);
                    Book_Details.DataSource = datatable;
                    /*------------------------------------------------------------------*/
                    SqlDataAdapter da = new("select CATEGORY_NAME from CATEGORY", cnn);
                    DataSet ds = new();
                    da.Fill(ds, "CATEGORY NAME");
                    Cat_View.DataSource = ds.Tables["CATEGORY NAME"];
                    Cat_View.DisplayMember = "CATEGORY_NAME";
                    /*-----------------------------------------------------------------*/
                    SqlDataAdapter CATEGORY = new("select CATEGORY_NAME from CATEGORY, BELONGS_TO where BELONGS_TO.ISBN =" + ISBN.Text + " AND BELONGS_TO.CAT_ID = CATEGORY.CATEGORY_ID", cnn);
                    DataTable CATEGORY1 = new();
                    CATEGORY.Fill(CATEGORY1);
                    Current_Cat_View.AutoGenerateColumns = false;
                    Current_Cat_View.DataSource = CATEGORY1;
                    Current_Cat_View.AutoResizeColumns();
                    cnn.Close();

                    isbn = ISBN.Text;
                }
                else
                {


                    SqlDataAdapter dataadapter = new("SELECT FILM_NAME AS [Film name],DIRECTOR AS[Director],year(PRODUCTION_YEAR) AS[Production year] FROM FILMBASED WHERE ISBN= " + isbn + " AND FILM_NAME ='" + Films.SelectedItem.ToString() + "'", cnn);
                    DataTable datatable = new();
                    dataadapter.Fill(datatable);
                    Book_Details.DataSource = datatable;
                    cnn.Close();
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string connetionString;
                SqlConnection conn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                conn = new SqlConnection(connetionString);
                conn.Open();
                if (update_update == false)
                {
                    if (U_AUTHOR.Text == "" && U_QUANTITY.Text == "" && U_P_NAME.Text == "" && U_P_YEAR.Text == "" && U_TITLE.Text == "" && Cat_View.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Please fill at least 1 box");
                    }
                    else
                    {
                        if (Cat_View.CheckedItems.Count > 0)
                        {
                            SqlCommand comMd = new("DELETE FROM BELONGS_TO WHERE ISBN = " + ISBN.Text, conn);
                            comMd.ExecuteNonQuery();
                            for (int i = 0; i < Cat_View.CheckedItems.Count; i++)
                            {
                                string Cat;
                                Cat = Cat_View.GetItemText(Cat_View.CheckedItems[i]);
                                SqlCommand Category_id = new("select CATEGORY_ID from CATEGORY where CATEGORY_NAME='" + Cat + "'", conn);
                                int Category_ID = (int)Category_id.ExecuteScalar();
                                SqlCommand comd = new("insert into BELONGS_TO values(" + ISBN.Text + "," + Category_ID + ")", conn);
                                comd.ExecuteNonQuery();
                            }
                        }
                        if (U_AUTHOR.Text != "")
                        {
                            SqlCommand cmd1 = new("UPDATE BOOK SET AUTHOR_Name ='" + U_AUTHOR.Text + "' where ISBN=" + ISBN.Text, conn);
                            cmd1.ExecuteNonQuery();
                        }
                        if (U_TITLE.Text != "")
                        {
                            SqlCommand cmd2 = new("UPDATE BOOK SET TITLE ='" + U_TITLE.Text + "' where ISBN=" + ISBN.Text, conn);
                            cmd2.ExecuteNonQuery();
                        }
                        if (U_P_NAME.Text != "")
                        {
                            SqlCommand cmd3 = new("UPDATE BOOK SET PUBLISHER_Name ='" + U_P_NAME.Text + "' where ISBN=" + ISBN.Text, conn);
                            cmd3.ExecuteNonQuery();
                        }
                        if (U_P_YEAR.Text != "")
                        {
                            SqlCommand cmd4 = new("UPDATE BOOK SET PUBLICATIONYEAR ='" + U_P_YEAR.Text + "' where ISBN=" + ISBN.Text, conn);
                            cmd4.ExecuteNonQuery();
                        }
                        if (U_QUANTITY.Text != "")
                        {
                            string Quantity2 = U_QUANTITY.Text;
                            if (Quantity2[0] == '-')
                            {
                                U_QUANTITY.Clear();
                                throw new();
                            }
                            else
                            {
                                SqlCommand cmd5 = new("UPDATE BOOK SET QUANTITY =" + U_QUANTITY.Text + " where ISBN=" + ISBN.Text, conn);
                                cmd5.ExecuteNonQuery();
                            }
                        }
                        SqlCommand cmd6 = new("UPDATE BOOK set Admin_ID =" + Log_In.U_ID + " where ISBN = " + ISBN.Text, conn);
                        cmd6.ExecuteNonQuery();
                        SqlDataAdapter dataadapter = new("SELECT BOOK.ISBN as ISBN,TITLE as [Title],AUTHOR_Name as[Author name],PUBLISHER_Name as[Publisher name],year(PUBLICATIONYEAR) as[publication year],ISNULL(STRING_AGG(FILM_NAME,'-'), 'NOT a film base') as Films ,ISNULL(STRING_AGG(DIRECTOR,'-'), '-----') as Director ,ISNULL(STRING_AGG(Year(PRODUCTION_YEAR),'-'), '-----') as [Production year],Admin_ID as[Admin ID],QUANTITY as[Quantity] FROM BOOK LEFT OUTER JOIN FILMBASED on BOOK.ISBN=FILMBASED.ISBN WHERE BOOK.ISBN=" + ISBN.Text + "GROUP BY BOOK.ISBN , BOOK.TITLE ,AUTHOR_Name , PUBLISHER_Name,PUBLICATIONYEAR,Admin_ID,QUANTITY", conn);
                        DataTable datatable = new();
                        dataadapter.Fill(datatable);
                        Book_Details.DataSource = datatable;
                        /*---------------------------------------------*/
                        SqlDataAdapter CATEGORY = new("select CATEGORY_NAME from CATEGORY, BELONGS_TO where BELONGS_TO.ISBN =" + ISBN.Text + " AND BELONGS_TO.CAT_ID = CATEGORY.CATEGORY_ID", conn);
                        DataTable CATEGORY1 = new();
                        CATEGORY.Fill(CATEGORY1);
                        Current_Cat_View.AutoGenerateColumns = false;
                        Current_Cat_View.DataSource = CATEGORY1;
                        conn.Close();
                        MessageBox.Show("Book has been updated");
                    }
                }
                else
                {
                    if (U_QUANTITY.Text == "" && U_P_YEAR.Text == "" && U_TITLE.Text == "")
                    {
                        MessageBox.Show("Please fill at least 1 box");
                    }
                    else
                    {
                        if (U_TITLE.Text != "")
                        {
                            SqlCommand cmd2 = new("UPDATE FILMBASED SET FILM_NAME ='" + U_TITLE.Text + "' where ISBN=" + isbn + "and FILM_NAME ='" + Films.Text + "'", conn);
                            cmd2.ExecuteNonQuery();
                            if (U_QUANTITY.Text != "")
                            {
                                SqlCommand cmd5 = new("UPDATE FILMBASED SET DIRECTOR ='" + U_QUANTITY.Text + "' where ISBN=" + isbn + "and FILM_NAME ='" + U_TITLE.Text + "'", conn);
                                cmd5.ExecuteNonQuery();
                            }
                            if (U_P_YEAR.Text != "")
                            {
                                SqlCommand cmd4 = new("UPDATE FILMBASED SET PRODUCTION_YEAR ='" + U_P_YEAR.Text + "' where ISBN=" + isbn + "and FILM_NAME ='" + U_TITLE.Text + "'", conn);
                                cmd4.ExecuteNonQuery();
                            }
                            SqlDataAdapter dataadapter = new("SELECT FILM_NAME AS [Film name],DIRECTOR AS[Director],year(PRODUCTION_YEAR) AS[Production year] FROM FILMBASED WHERE ISBN= " + isbn + " AND FILM_NAME ='" + U_TITLE.Text + "'", conn);
                            DataTable datatable = new();
                            dataadapter.Fill(datatable);
                            Book_Details.DataSource = datatable;
                            Films.Items.Clear();
                            SqlCommand cmd = new("select FILM_NAME from FILMBASED WHERE ISBN=" + isbn, conn);
                            SqlDataReader DR = cmd.ExecuteReader();
                            while (DR.Read())
                            {
                                Films.Items.Add(DR[0]);
                            }
                            conn.Close();
                            Films.ResetText();
                            Films.SelectedText = U_TITLE.Text;

                        }
                        else
                        {
                            if (U_QUANTITY.Text != "")
                            {
                                SqlCommand cmd5 = new("UPDATE FILMBASED SET DIRECTOR ='" + U_QUANTITY.Text + "' where ISBN=" + isbn + "and FILM_NAME ='" + Films.SelectedItem.ToString() + "'", conn);
                                cmd5.ExecuteNonQuery();
                            }
                            if (U_P_YEAR.Text != "")
                            {
                                SqlCommand cmd4 = new("UPDATE FILMBASED SET PRODUCTION_YEAR ='" + U_P_YEAR.Text + "' where ISBN=" + isbn + "and FILM_NAME ='" + Films.SelectedItem.ToString() + "'", conn);
                                cmd4.ExecuteNonQuery();
                            }
                            SqlDataAdapter dataadapter = new("SELECT FILM_NAME AS [Film name],DIRECTOR AS[Director],year(PRODUCTION_YEAR) AS[Production year] FROM FILMBASED WHERE ISBN= " + isbn + " AND FILM_NAME ='" + Films.SelectedItem.ToString() + "'", conn);
                            DataTable datatable = new();
                            dataadapter.Fill(datatable);
                            Book_Details.DataSource = datatable;
                            conn.Close();

                        }


                    }
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (update_update == false)
            {
                User user = new();
                this.Hide();
                user.Show();
            }
            else
            {
                update_update = false;
                Update_Book b = new();
                this.Hide();
                b.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (ISBN.Text == "")
                {
                    MessageBox.Show("Please choose a book to update its films");
                }
                else
                {
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    SqlCommand filmcount = new("select COUNT(FILM_NAME) FROM FILMBASED WHERE ISBN=" + ISBN.Text, cnn);
                    int F = (int)filmcount.ExecuteScalar();
                    if (F == 0)
                    {
                        MessageBox.Show("This book isn't filmbased\ntry adding some films and then update them");
                    }
                    else
                    {
                        update_update = true;
                        Update_Book b = new();
                        this.Hide();
                        b.Show();
                    }
                }

            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ISBN.Text == "")
                {
                    MessageBox.Show("Please choose a book to add films to");
                }
                else
                {
                    update_add = true;
                    Films_base f = new();
                    this.Hide();
                    f.Show();
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection S = new("Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True");
                S.Open();
                DialogResult dialogResult = MessageBox.Show("This book has dependencies are you sure you want to delete it ?\nit may also be borrowed by some students !!", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand category = new("DELETE BELONGS_TO WHERE ISBN=" + isbn, S);
                    category.ExecuteNonQuery();
                    SqlCommand M = new("Delete BORROWS WHERE ISBN=" + isbn, S);
                    M.ExecuteNonQuery();
                    SqlCommand B = new("Delete FILMBASED WHERE ISBN=" + isbn, S);
                    B.ExecuteNonQuery();
                    SqlCommand C = new("Delete BOOK WHERE ISBN=" + isbn, S);
                    C.ExecuteNonQuery();
                    S.Close();
                    Update_Book a = new();
                    this.Hide();
                    a.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error\nPlease try again later");
            }
        }

        private void Update_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
