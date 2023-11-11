using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Staff
{
    public partial class MainStaff : Form
    {
        public MainStaff()
        {
            InitializeComponent();
            customizeDesing();
        }
        
        private void customizeDesing()
        {
            panelMovieSubMenu.Visible = false;
            panelFoodDrinkSubMenu.Visible = false;
            panelOtherSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelMovieSubMenu.Visible == true) 
            {
                panelMovieSubMenu.Visible = false;
            }
            if (panelFoodDrinkSubMenu.Visible == true)
            {
                panelFoodDrinkSubMenu.Visible = false;
            }
            if (panelOtherSubMenu.Visible == true)
            {
                panelOtherSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        
        private void iBtnMovie_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMovieSubMenu);
            lblCurrent.Text = iBtnMovie.Text;
            iconBtnCurrent.IconChar = iBtnMovie.IconChar;
            openChildForm(new ShowtimePage.MovieShowtimePage());

        }


        private void iBtnFoodDrink_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFoodDrinkSubMenu);
            lblCurrent.Text = iBtnFoodDrink.Text;
            iconBtnCurrent.IconChar = iBtnFoodDrink.IconChar;
            openChildForm(new OrderFood.FoodandDrinkPage());
        }

        private void iBtnOther_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOtherSubMenu);
            lblCurrent.Text = iBtnOther.Text;
            iconBtnCurrent.IconChar = iBtnOther.IconChar;
        }

        private void iBtnProblem_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = iBtnProblem.Text;
            iconBtnCurrent.IconChar = iBtnProblem.IconChar;
        }
        //button home
        private void iconButton1_Click(object sender, EventArgs e)
        {
            iconBtnCurrent.IconChar = IconChar.HomeUser;
            lblCurrent.Text = "Home";
            openChildForm(new MainHome());
        }
        private void btnHotMovie_Click(object sender, EventArgs e)
        {

            //codes
        
            hideSubMenu();
        }

        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            //codes
            
            hideSubMenu();
        }

        private void btnShowingMovie_Click(object sender, EventArgs e)
        {
            //codes
            
            hideSubMenu();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            //codes
           
            hideSubMenu();
        }

        private void btnDink_Click(object sender, EventArgs e)
        {
            //codes
           
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            //codes

            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //codes

            hideSubMenu();
        }

        //open childform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm == null)
            {
                activeForm = childForm;
            }
            else
            {
                activeForm.Close();
            }
            
            childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
