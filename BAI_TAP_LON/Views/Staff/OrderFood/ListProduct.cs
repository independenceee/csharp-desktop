using BAI_TAP_LON.Views.Staff.MovieScheduleWindow;
using BAI_TAP_LON.Views.Staff.TicketBillFoodPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Staff.OrderFood
{
    public partial class ListProduct : Form
    {
        public ListProduct()
        {
            InitializeComponent();
        }

        private void tấtCảCácSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code truy van
        }

        
        private void đồĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code truy van

        }

        private void đồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code truy van

        }

        private void guna2BtnBack_Click(object sender, EventArgs e)
        {
            ScreenPage sP = new ScreenPage();
            sP.Show();
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            OrderBill orderBill = new OrderBill();
            orderBill.Show();
        }
    }
}
