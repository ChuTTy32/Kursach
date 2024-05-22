using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crmAutoService
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        Point LastPoint;
        private void Mainframe_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }

        }
        private void Mainframe_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet1.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter1.Fill(this.sTODataSet1.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter1.Fill(this.sTODataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet1.avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.sTODataSet1.avto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.sTODataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.sTODataSet.Purchase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.sTODataSet.Client);

        }
    }
}
