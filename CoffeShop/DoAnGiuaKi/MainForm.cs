using DoAnGiuaKi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGiuaKi
{
    public partial class MainForm : Form
    {
        private DTO.TaiKhoan tk;

        public DTO.TaiKhoan Tk { 
            get => tk;
            set
            {
                this.tk = value;
            }
        }

        public MainForm(DTO.TaiKhoan acc)
        {           
            InitializeComponent();
            this.Tk = acc;
            AnPanel();
            TaiKhoan(acc);
        }
        public static int idtang;
     
        #region Method
        //Lay Tai Khoan
        public void TaiKhoan(DTO.TaiKhoan acc)
        {
            string t = string.Empty;
            if(Tk.Loaitk == 1)
            {
                t = "Admin";
            }else if(Tk.Loaitk == 2)
            {
                t = "Nhân Viên";
            }
            else
            {
                t = "Đầu Bếp";
            }
            txbtenTK.Text = Tk.Taikhoan;
            txbLoaiTK.Text = t;
            txbtenTK.ReadOnly = true;
            txbLoaiTK.ReadOnly = true;
        }

        //Hien form con
        void OpenFormChild(Form childform)
        {
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childform);
            panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        void AnPanel()
        {
            panelAdmin.Visible = false;
            panelTaiKhoan.Visible = false;
            panelBanAn.Visible = false;
        }

        void AnMenu()
        {
            if (panelAdmin.Visible == true)
                panelAdmin.Visible = false;
            if (panelTaiKhoan.Visible == true)
                panelTaiKhoan.Visible = false;
            if (panelBanAn.Visible == true)
                panelBanAn.Visible = false;
        }

        void HienMenu(Panel pl)
        {
            if(pl.Visible == false)
            {
                AnMenu();
                pl.Visible = true;
            }
            else
            {
                pl.Visible = false;
            }
        }

        #endregion

        #region Event
        private void bntIconBanAn_Click(object sender, EventArgs e)
        {
            HienMenu(panelBanAn);
        }

        private void btnIconTaiKhoan_Click(object sender, EventArgs e)
        {
            HienMenu(panelTaiKhoan);
        }

        private void btnIconAdmin_Click(object sender, EventArgs e)
        {
            HienMenu(panelAdmin);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTang1_Click(object sender, EventArgs e)
        {
            MainForm.idtang = 1;
            OpenFormChild(new BanAn(Tk));           
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            MainForm.idtang = 2;
            OpenFormChild(new BanAn(Tk));
        }


        private void btnTang3_Click(object sender, EventArgs e)
        {
            MainForm.idtang = 3;
            OpenFormChild(new BanAn(Tk));
        }

        private void qlMonAn_Click(object sender, EventArgs e)
        {
            if (tk.Loaitk == 1)
            {
                OpenFormChild(new QuanLyMonAn());
            }
            else
            {
                MessageBox.Show("Tài khoản không đủ quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (tk.Loaitk == 1)
            {
                OpenFormChild(new QuanLyTaiKhoan(Tk));
            }
            else
            {
                MessageBox.Show("Tài khoản không đủ quyền thực hiện chức năng này","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }           
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenFormChild(new ThongTinTaiKhoan(Tk));
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (tk.Loaitk == 1)
            {
                OpenFormChild(new QuanlyBan());
            }
            else
            {
                MessageBox.Show("Tài khoản không đủ quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (tk.Loaitk == 1)
            {
                OpenFormChild(new CRUDHoaDon());
            }
            else
            {
                MessageBox.Show("Tài khoản không đủ quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private int number = 0;

        //Xử lý slide

        void LoadIamges()
        {
            if (number == 4)
            {
                number = 0;
            }
            imagesMain.ImageLocation = string.Format(@"Images\{0}.jpg", number);
            number++;
        }

        private void imageNext_MouseClick(object sender, MouseEventArgs e)
        {
            imagesMain.ImageLocation = string.Format(@"Images\{0}.jpg", number);
            if (number < 4)
            {
                number++;
            }
        }

        private void imagePrev_MouseClick(object sender, MouseEventArgs e)
        {
            imagesMain.ImageLocation = string.Format(@"Images\{0}.jpg", number);
            if (number > 0)
            {
                number--;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadIamges();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Report());
        }
        #endregion


    }
}
