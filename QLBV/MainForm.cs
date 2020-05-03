using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            customizeDesing();
            openChildForm(new frmChildFormHT());
        }

        private void customizeDesing()
        {
            panelNhanvienSubmenu.Visible = false;
            panelBenhnhanSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelNhanvienSubmenu.Visible == true)
                panelNhanvienSubmenu.Visible = false;
            if (panelBenhnhanSubmenu.Visible == true)
                panelBenhnhanSubmenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }


        private void lblHethong_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanvienSubmenu);
           
        }

       

        private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(ChildForm);
            pnlChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void lblHethong_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHethong_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmChildFormHT());
        }

        private void btnBacsi_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmChildFormBS());
        }

        private void btnKhac_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmChildFormKhac());
        }

        private void btnBenhnhan_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelBenhnhanSubmenu);
        }

        private void btnCoBHYT_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmcoBHYT());
        }

        private void btnKoBHYT_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmkoBHYT());
        }

        private void btnKhamchuabenh_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }


    }
}
