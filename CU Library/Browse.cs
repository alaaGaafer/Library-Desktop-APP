using System.Data;
using System.Data.SqlClient;

namespace CU_Library
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void Admin_browse_Load(object sender, EventArgs e)
        {
            if (Log_In.A_login == true)
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlDataAdapter dataadapter = new("SELECT BOOK.ISBN AS ISBN,TITLE AS Title ,AUTHOR_Name AS [Author name],PUBLISHER_Name as [Publisher name],YEAR(PUBLICATIONYEAR) as [Publication year],Admin_ID as [Admin ID],QUANTITY as Quantity,ISNULL(STRING_AGG(CATEGORY_NAME,'-'),'Not specified') as Categories,ISNULL(STRING_AGG(FILM_NAME,'-'), 'NOT a film base') as Films,ISNULL(STRING_AGG(DIRECTOR,'-'), '-----') as Director,ISNULL(STRING_AGG(year(PRODUCTION_YEAR),'-'), '-----') as [Production year] FROM BOOK LEFT OUTER JOIN BELONGS_TO on BELONGS_TO.ISBN=BOOK.ISBN left outer join CATEGORY on BELONGS_TO.CAT_ID=CATEGORY.CATEGORY_ID LEFT OUTER JOIN FILMBASED on BOOK.ISBN=FILMBASED.ISBN group by BOOK.ISBN,TITLE,AUTHOR_Name,PUBLICATIONYEAR,PUBLISHER_Name,Admin_ID,QUANTITY", cnn);
                DataTable datatable = new();
                dataadapter.Fill(datatable);
                Admin_Browse_View.DataSource = datatable;
                cnn.Close();
            }
            else
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Data Source=MOHAMED_EHAB;Initial Catalog=Library_Database;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlDataAdapter dataadapter = new("SELECT BOOK.ISBN AS ISBN,TITLE AS Title ,AUTHOR_Name AS [Author name],PUBLISHER_Name as [Publisher name],YEAR(PUBLICATIONYEAR) as [Publication year],ISNULL(STRING_AGG(CATEGORY_NAME,'-'),'Not specified') as Categories,ISNULL(STRING_AGG(FILM_NAME,'-'), 'NOT a film base') as Films,ISNULL(STRING_AGG(DIRECTOR,'-'), '-----') as Director,ISNULL(STRING_AGG(year(PRODUCTION_YEAR),'-'), '-----') as [Production year] FROM BOOK LEFT OUTER JOIN BELONGS_TO on BELONGS_TO.ISBN=BOOK.ISBN left outer join CATEGORY on BELONGS_TO.CAT_ID=CATEGORY.CATEGORY_ID LEFT OUTER JOIN FILMBASED on BOOK.ISBN=FILMBASED.ISBN group by BOOK.ISBN,TITLE,AUTHOR_Name,PUBLICATIONYEAR,PUBLISHER_Name", cnn);
                DataTable datatable = new();
                dataadapter.Fill(datatable);
                Admin_Browse_View.DataSource = datatable;
                cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new();
            this.Hide();
            u.Show();
        }

        private void Browse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
