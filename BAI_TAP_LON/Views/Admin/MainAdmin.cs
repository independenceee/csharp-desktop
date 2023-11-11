using BAI_TAP_LON.Views.Admin.MovieManagement;
using BAI_TAP_LON.Views.Admin.ShowTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Admin
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm == null)
            {
                activeForm = childForm;
            }
            else
            {
                activeForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iBtnMovie_Click(object sender, EventArgs e)
        {
            SearchFilm searchFilm = new SearchFilm();
            openChildForm(searchFilm);
            lblCurrent.Text = iBtnMovie.Text;
            iconBtnCurrent.IconChar = iBtnMovie.IconChar;

        } 

        private void BtnQLXuatChieu_Click(object sender, EventArgs e)
        {
            ShowTime.ShowTime showTime = new ShowTime.ShowTime();
            openChildForm(showTime);
            lblCurrent.Text = BtnQLXuatChieu.Text;
            iconBtnCurrent.IconChar = BtnQLXuatChieu.IconChar;
        }
    }
}
