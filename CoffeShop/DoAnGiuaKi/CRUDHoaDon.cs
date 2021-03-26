using DoAnGiuaKi.DAO;
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
    public partial class CRUDHoaDon : Form
    {
        public CRUDHoaDon()
        {
            InitializeComponent();
            DateTimePickerLoad();
            LoadThongKe(dtpFrom.Value.ToString(), dtpTo.Value.ToString());
        }

        public void LoadThongKe(string ngay1, string ngay2)
        {
            dataThongKe.DataSource = HoaDonDAO.Instance.ThongKeHoaDon(ngay1, ngay2);
        }
        
        void DateTimePickerLoad()
        {
            DateTime today = DateTime.Now;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
             dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string ngay1 = dtpFrom.Value.ToString("yyyyMMdd");
            string ngay2 = dtpTo.Value.ToString("yyyyMMdd");
            LoadThongKe(ngay1, ngay2);
        }
    }
}
