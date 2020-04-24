using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

        public void MaHoaTep(String duongDanTepCanMaHoa, String duongDanTepDaMaHoa)
        {
            // Luồng đọc tệp tin
            FileStream fs = new FileStream(duongDanTepCanMaHoa, FileMode.Open);

            // Luồng ghi tệp tin
            FileStream fs1 = new FileStream(duongDanTepDaMaHoa, FileMode.Append);

            // Ghi định dạng của tệp tin gốc vào 4 byte đầu của tệp tin mã hóa
            String dinhDang = Path.GetExtension(duongDanTepCanMaHoa);
            dinhDang = dinhDang.Substring(1);
            if (dinhDang.Length == 1)
                dinhDang = "000" + dinhDang;
            else if (dinhDang.Length == 2)
                dinhDang = "00" + dinhDang;
            else if (dinhDang.Length == 3)
                dinhDang = "0" + dinhDang;
            byte[] bDinhDang = Encoding.ASCII.GetBytes(dinhDang);
            for(int i = 0; i < bDinhDang.Length; i++)
            {
                byte giaTriDinhDangMaHoa = MaHoa(bDinhDang[i]);
                fs1.WriteByte(giaTriDinhDangMaHoa);
            }

            int giaTriDocDuoc;            
            // Đọc từng byte của tệp tin cần mã hóa cho đến hết tệp tin
            while((giaTriDocDuoc = fs.ReadByte()) >= 0)
            {
                // Mã hóa giá trị đọc được
                int giaTriMaHoaDuoc = MaHoa((byte)giaTriDocDuoc);
                // Ghi giá trị mã hóa được vào tệp tin mã hóa
                fs1.WriteByte((byte)giaTriMaHoaDuoc);
            }

            // Đóng các luồng truy cập đến các tệp tin
            fs.Close();
            fs1.Close();
        }


        public void GiaiMaTep(String duongDanTepCanGiaiMa, String duongDanTepDaGiaiMa)
        {
            // Luồng đọc tệp tin
            FileStream fs = new FileStream(duongDanTepCanGiaiMa, FileMode.Open);

            // Luồng ghi tệp tin
            FileStream fs1 = new FileStream(duongDanTepDaGiaiMa, FileMode.Append);

            int dem = 0;
            String dinhDang = "";
            int giaTriDocDuoc;
            // Đọc từng byte của tệp tin cần mã hóa cho đến hết tệp tin
            while ((giaTriDocDuoc = fs.ReadByte()) >= 0)
            {
                dem++;
                // Giải mã giá trị đọc được
                int giaTriGiaiMaDuoc = GiaiMa((byte)giaTriDocDuoc);
                
                if(dem <= 4)
                {
                    byte[] tmp = new byte[1];
                    tmp[0] = (byte)giaTriGiaiMaDuoc;
                    dinhDang += Encoding.ASCII.GetString(tmp);
                    if(dem == 4)
                    {
                        fs1 = new FileStream(duongDanTepDaGiaiMa + "." + dinhDang.Replace("0", ""), FileMode.Append);
                    }
                }
                else
                {
                    // Ghi giá trị mã hóa được vào tệp tin mã hóa
                    fs1.WriteByte((byte)giaTriGiaiMaDuoc);
                }                
            }

            // Đóng các luồng truy cập đến các tệp tin
            fs.Close();
            fs1.Close();
        }

    }
}
