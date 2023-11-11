using Guna.UI2.WinForms;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Classes
{
    internal class CommonFunctions
    {
        DataProcesser dtBase = new DataProcesser();
        public void FillComboBox(ComboBox comboName, DataTable data, string displayMember, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }
        public void FillKryptonComboBox(KryptonComboBox comboName, DataTable data, string displayMember, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }
        public void FillGunaComboBox(Guna2ComboBox comboName, DataTable data, string displayMember, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }



        public string OpenFile(PictureBox picAnh)
        {
            string fileNameImg="";
            string[] image;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image(*.jpg)|*jpg|Image(*.png)|*.png|All file|*.*";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    picAnh.Image = Image.FromFile(ofd.FileName);
                    image = ofd.FileName.ToString().Split('\\');
                    fileNameImg = image[image.Length - 1];

                    //MessageBox.Show(fileNameImg);
                    
                }
                catch
                {
                    MessageBox.Show("Bạn phải mở file ảnh");
                }
            }
            return fileNameImg;
           
        }

        public string MaTuSinh(string tenBang, string truongMa, string maBatDau)
        {
            int id = 0;
            bool check = false; // kiem tra tim duowc ma hay chua
            string ma = "";
            while (check == false)
            {
                DataTable dt = dtBase.ReadData("select * from " + tenBang + " where " + truongMa + "=N'" + maBatDau + id.ToString() + "'");
                if (dt.Rows.Count == 0)
                {
                    check = true;
                }
                else
                {
                    id++;
                    check = false;

                }
            }
            ma = maBatDau + id.ToString();
            return ma;

        }
       
    }
}
