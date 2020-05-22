using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MaHoaTepTin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbMaHoa.Checked = true;
            rbGiaiMa.Checked = false;
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaHoa.Checked == true)
                rbGiaiMa.Checked = false;
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked == true)
                rbMaHoa.Checked = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Mọi tệp tin bạn thích | *.*";
            od.Multiselect = false;

            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiem tra xem nguoi dung da chon tep tin can tuong tac hay chua
            if(tbDuongDan.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tệp tin cần Mã hóa hoặc Giải mã");
                return;
            }

            // Kiem tra xem tep tin co ton tai hay khong
            if(!File.Exists(tbDuongDan.Text))
            {
                MessageBox.Show("Tệp tin bạn đã chọn không tồn tại. Hãy chọn lại tệp tin");
                return;
            }

            // Yeu cau nguoi dung chon vi tri luu tep tin ket qua
            String viTriLuu = "";
            SaveFileDialog sd = new SaveFileDialog();
            String ext = Path.GetExtension(tbDuongDan.Text);
            sd.Filter = "*" + ext + " | *" + ext;

            if (sd.ShowDialog() == DialogResult.OK)
            {
                viTriLuu = sd.FileName;
            }
            else
            {
                return;
            }

            // Thuc hien ma hoa hoac giai ma theo yeu cau cua nguoi dung
            if(rbMaHoa.Checked == true)
            {
                // Ma hoa tep tin
                Cesar cs = new Cesar();
                cs.MaHoaTep(tbDuongDan.Text, viTriLuu, ref pbTienTrinh);
            }
            else
            {
                // Giai ma tep tin
                Cesar cs = new Cesar();
                cs.GiaiMaTep(tbDuongDan.Text, viTriLuu, ref pbTienTrinh);
            }
        }
    }
}
