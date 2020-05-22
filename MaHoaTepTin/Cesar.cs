using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MaHoaTepTin
{
    public class Cesar
    {
        public byte[] BangChuCai;
        private int K = 27;

        public Cesar()
        {
            BangChuCai = new byte[256];
            for(int i = 0; i < 256; i++)
            {
                BangChuCai[i] = (byte)i;
            }
        }

        public byte MaHoa(byte giaTriCanMaHoa)
        {
            return (byte)((giaTriCanMaHoa + K) % BangChuCai.Length);
        }

        public byte GiaiMa(byte giaTriCanGiaiMa)
        {
            if ((giaTriCanGiaiMa - K) >= 0)
                return (byte)(giaTriCanGiaiMa - K);
            else
                return (byte)(giaTriCanGiaiMa - K + BangChuCai.Length);
        }

        public void MaHoaTep(String duongDanTepCanMaHoa, String duongDanTepDaMaHoa, ref ProgressBar pb)
        {
            // Luồng đọc tệp tin
            FileStream fs = new FileStream(duongDanTepCanMaHoa, FileMode.Open);

            // Luồng ghi tệp tin
            FileStream fs1 = new FileStream(duongDanTepDaMaHoa, FileMode.Append);

            int chieuDaiTep = (int)fs.Length;
            int khoiLuongDaXuLy = 0;

            int giaTriDocDuoc;            
            // Đọc từng byte của tệp tin cần mã hóa cho đến hết tệp tin
            while((giaTriDocDuoc = fs.ReadByte()) >= 0)
            {
                // Mã hóa giá trị đọc được
                int giaTriMaHoaDuoc = MaHoa((byte)giaTriDocDuoc);
                // Ghi giá trị mã hóa được vào tệp tin mã hóa
                fs1.WriteByte((byte)giaTriMaHoaDuoc);

                // Cap nhat trang thai
                khoiLuongDaXuLy++;
                pb.Value = (khoiLuongDaXuLy * 100) / chieuDaiTep;
                pb.PerformStep();
                pb.Refresh();
            }

            // Đóng các luồng truy cập đến các tệp tin
            fs.Close();
            fs1.Close();
        }


        public void GiaiMaTep(String duongDanTepCanGiaiMa, String duongDanTepDaGiaiMa, ref ProgressBar pb)
        {
            // Luồng đọc tệp tin
            FileStream fs = new FileStream(duongDanTepCanGiaiMa, FileMode.Open);

            // Luồng ghi tệp tin
            FileStream fs1 = new FileStream(duongDanTepDaGiaiMa, FileMode.Append);
            
            int chieuDaiTep = (int)fs.Length;
            int khoiLuongDaXuLy = 0;

            int giaTriDocDuoc;
            // Đọc từng byte của tệp tin cần mã hóa cho đến hết tệp tin
            while ((giaTriDocDuoc = fs.ReadByte()) >= 0)
            {
                // Giải mã giá trị đọc được
                int giaTriGiaiMaDuoc = GiaiMa((byte)giaTriDocDuoc);
                // Ghi giá trị mã hóa được vào tệp tin mã hóa
                fs1.WriteByte((byte)giaTriGiaiMaDuoc);
                
                // Cap nhat trang thai
                khoiLuongDaXuLy++;
                pb.Value = (khoiLuongDaXuLy * 100) / chieuDaiTep;
                pb.PerformStep();
                pb.Refresh();
            }

            // Đóng các luồng truy cập đến các tệp tin
            fs.Close();
            fs1.Close();
        }

    }
}
