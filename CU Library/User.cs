namespace CU_Library
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void Log_Out_Button_Click(object sender, EventArgs e)
        {

            Log_In.S_A_login = false;
            Log_In.A_login = false;
            Log_In log_In = new();
            this.Hide();
            log_In.Show();

        }

        private void Add_Student_Button_Click(object sender, EventArgs e)
        {
            Log_In.A_login = false;
            Add_User add_Student = new();
            this.Hide();
            add_Student.Show();
        }

        private void Add_A_Book_Button_Click(object sender, EventArgs e)
        {
            Add_Book add_Book = new();
            this.Hide();
            add_Book.Show();
        }

        private void Browse_All_Books_Button_Click(object sender, EventArgs e)
        {
            Browse browse = new();
            this.Hide();
            browse.Show();
        }

        private void Search_For_A_Book_Button_Click(object sender, EventArgs e)
        {
            Search s = new();
            this.Hide();
            s.Show();
        }

        private void Update_My_Details_Button_Click(object sender, EventArgs e)
        {
            Update_User_Details UpdateA = new();
            this.Hide();
            UpdateA.Show();
        }

        private void Update_A_Book_Button_Click(object sender, EventArgs e)
        {
            Update_Book update_Book = new();
            this.Hide();
            update_Book.Show();
        }

        private void Supervising_Click(object sender, EventArgs e)
        {
            Log_In.A_login = true;
            Add_User add_Admin = new();
            this.Hide();
            add_Admin.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            if (Log_In.A_login)
            {
                if (Log_In.S_A_login)
                {

                }
                else
                {
                    Supervising.Hide();
                }
            }
            else
            {
                Borrow.Hide();
                Add_A_Book_Button.Hide();
                Add_Student_Button.Hide();
                Supervising.Hide();
                Update_A_Book_Button.Hide();
            }
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            Borrow_Books b = new();
            this.Hide();
            b.Show();
        }

        private void Show_Borrowed_Click(object sender, EventArgs e)
        {
            Show_Borrowed S = new();
            this.Hide();
            S.Show();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
