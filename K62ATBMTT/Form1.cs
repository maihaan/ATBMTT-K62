using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K62ATBMTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // B1: Kiểm tra xem người dùng đã nhập dữ liệu cần mã hóa hay chưa
            if(String.IsNullOrEmpty(tbDLCMH.Text))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần mã hóa");
                tbDLCMH.Focus();
                return;
            }

            // B2: Mã hóa
            String ketQua = "";
            Cesar cs = new Cesar();
            ketQua = cs.MaHoa(tbDLCMH.Text);

            // B3: Hiển thị kết quả
            tbDLMH.Text = ketQua;
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            // B1: Kiem tra xem co du lieu de giai ma hay chua
            if(tbDLMH.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa có dữ liệu để giải mã");
                return;
            }

            // B2: Giai ma
            Cesar cs = new Cesar();
            String ketQua = cs.GiaiMa(tbDLMH.Text);

            // B3: Hien thi ket qua
            tbGiaiMa.Text = ketQua;
        }
    }
}
