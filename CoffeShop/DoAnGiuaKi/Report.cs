using DevExpress.XtraCharts;
using DoAnGiuaKi.DAO;
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
    public partial class Report : Form
    {
        
        public Report()
        {
            InitializeComponent();
            Series sr = new Series("San Pham Ban Chay", ViewType.Pie);
            List<ThongTinHoaDon> tt = ThongTinHoaDonDAO.Instance.Loadtthd();
            DataTable sl = ThongTinHoaDonDAO.Instance.LaySlThucAn();
            int tong = 0;
            foreach(var x in tt)
            {
                tong += x.Soluong;
            }

            foreach(DataRow y in sl.Rows)
            {
                int slTA = 0;
                string s = "";
                DataTable sltt = ThongTinHoaDonDAO.Instance.LayThongTinTheoIDTA((int)y["idTA"]);
                foreach (DataRow x in sltt.Rows)
                {
                    slTA += (int)x["soluong"];
                    s = (string)x["tenTA"];
                }
                float gt = (slTA * 0.1f / tong) * 100;
                sr.Points.Add(new SeriesPoint(s, gt));
            }

            sr.Label.TextPattern = "{A}: {VP:p0}";
            ((PieSeriesLabel)sr.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((PieSeriesLabel)sr.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            PieSeriesView myView = (PieSeriesView)sr.View;
            ChartReport.Series.Add(sr);
        }
    }
}
