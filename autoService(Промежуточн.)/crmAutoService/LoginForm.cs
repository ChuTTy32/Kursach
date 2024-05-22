using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace crmAutoService
{

    public partial class LoginForm : Form
    {
        public SqlConnection Mycon;
        public SqlCommand Mycom;
        public string connect = "server=BLACKCAT;database=STO;";
        public System.Data.DataSet dataSet;
        string connectionString = "Data Source=BLACKCAT;Initial Catalog=STO;Integrated Security=True";

        private SqlConnection sqlConnection = null;
        public LoginForm()
        {
            InitializeComponent();
        }
        #region Работа с элементами формы

        private void LoginForm_Load(object sender, EventArgs e)
        {

            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

        }

        private void OpenDataBaseConnection(SqlConnection sqlConnection)
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = SystemColors.ControlDark;
            Cursor = Cursors.Hand;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = SystemColors.Control;
            Cursor = Cursors.Default;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            bool SignInResult = PersonChecker(login, password);
            if (SignInResult == true)
            {
                this.Hide();
                MainFrame mainFrame = new MainFrame();
                mainFrame.Show();
            }

        }
        Point LastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }

        }
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        #endregion

        #region Проверка пользователя
        private bool PersonChecker(string login, string pass)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();
            {
                

                SqlCommand loginGetter = new SqlCommand("SELECT login_user, password_user FROM register", myConnection);
                
                SqlDataReader loginReader = loginGetter.ExecuteReader();
                loginReader.Read();
                string DBlogin = loginReader["login_user"].ToString();
                loginReader.Close();

                SqlCommand passwordGetter = new SqlCommand("SELECT password_user FROM register", myConnection);
                SqlDataReader passwordReader = passwordGetter.ExecuteReader();
                passwordReader.Read();
                string DBpassword = passwordReader["password_user"].ToString();
                passwordReader.Close();

                    if ((DBlogin == login) & (DBpassword == pass))
                    {
                        MessageBox.Show("Пользователь найден!");
                        loginReader.Close();
                        passwordReader.Close();
                        return true;
                    }

                loginReader.Close(); // Close the reader before returning false
                MessageBox.Show("Пользователь не найден! \nПопробуйте еще раз!");
                return false;
            }
        }


        #endregion

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}
