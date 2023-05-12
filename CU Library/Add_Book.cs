using System.Data;
using System.Data.SqlClient;

namespace CU_Library
{
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }
//just a cooment
        private void Add_Book_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Author_Name.Text == "" || Publisher_Name.Text == "" || Quantity.Text == "" || Book_title.Text == "")
                {
                    MessageBox.Show("Please enter the data");
                }
                else
                {
                    string Quantity2 = Quantity.Text;
                    if (Quantity2[0] == '-')
                    {
                        MessageBox.Show("Please enter a right value to a quantity");
                        Quantity.Clear();
                        throw new();
                    }
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    SqlCommand ISBN = new("select max(ISBN) from BOOK", cnn);
                    int result = (int)ISBN.ExecuteScalar();
                    SqlCommand cmd = new("insert into BOOK values(" + (result + 1) + "," + Log_In.U_ID + ",'" + Publisher_Name.Text + "','" + Author_Name.Text + "','" + Book_title.Text + "','" + dateTimePicker1.Text + "'," + Quantity.Text + ")", cnn);
                    cmd.ExecuteNonQuery();
                    if (Categories_list.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < Categories_list.CheckedItems.Count; i++)
                        {
                            string Cat;
                            Cat = Categories_list.GetItemText(Categories_list.CheckedItems[i]);
                            SqlCommand Category_id = new("select CATEGORY_ID from CATEGORY where CATEGORY_NAME='" + Cat + "'", cnn);
                            int Category_ID = (int)Category_id.ExecuteScalar();
                            SqlCommand comd = new("insert into BELONGS_TO values(" + (result + 1) + "," + Category_ID + ")", cnn);
                            comd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose at least 1 category");
                    }
                    cnn.Close();
                    DialogResult dialogResult = MessageBox.Show("Is there a movie based on this book ?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Films_base f = new();
                        this.Hide();
                        f.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Book added with ISBN " + (result + 1));
                    }
                }
            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }
        private void Add_Book_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter da = new("select CATEGORY_NAME from CATEGORY", cnn);
            DataSet ds = new();
            da.Fill(ds, "CATEGORY NAME");
            Categories_list.DataSource = ds.Tables["CATEGORY NAME"];
            Categories_list.DisplayMember = "CATEGORY_NAME";
            cnn.Close();

        }

        private void Add_Category_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                if (Category_Name.Text == "")
                {
                    MessageBox.Show("Please enter category name");
                }
                else
                {

                    SqlCommand CategoryID = new("select max(CATEGORY_ID) from CATEGORY", cnn);
                    int result = (int)CategoryID.ExecuteScalar();
                    SqlCommand cmd = new("insert into CATEGORY values(" + (result + 1) + ",'" + Category_Name.Text + "')", cnn);
                    cmd.ExecuteNonQuery();

                }

                SqlDataAdapter da = new("select CATEGORY_NAME from CATEGORY", cnn);
                DataSet ds = new();
                da.Fill(ds, "CATEGORY NAME");
                Categories_list.DataSource = ds.Tables["CATEGORY NAME"];
                Categories_list.DisplayMember = "CATEGORY_NAME";
                cnn.Close();

            }
            catch
            { MessageBox.Show("Error\nPlease check your inputs"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new();
            this.Hide();
            user.Show();
        }

        private void Add_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
