using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K62ATBMTT
{
    public class Cesar
    {
        // Mã hóa Cesar gồm các thành phần sau:
        // INPUT
        // - Bảng chữ cái
        // - Giá trị của hệ số dịch chuyển k
        // - Giá trị cần mã hóa
        // OUTPUT
        // - Giá trị mã hóa được

        char[] BangChuCai = new char[] { 'a', 'b', 'c', '0', '3', '5', '2', 'e', 'g', 'o', 
         'x', 'y', 'j', 'ă', 'â', 'ắ', 'ằ', 'k', 'l', 'n', 'r', 'p', 'w','ư', 'ử', 'ứ'
        , 'ẳ', 'ặ', 'ấ', 'ầ', 'ẩ', 'ậ', 'd', 'đ', 'ê', 'ế', 'ề', 'ể', 'ệ', 'Ă', 'Â', '1',
        '4', '6', '7', '8', '9','đ', '`', '~', '@', '#', '$', '%', '^', '&', '*', 'ừ', 'ự',
        '(', ')', '{', '}', '[', ']', '\\', '|', ',', '.', ':', ';', '"', '\'', '<', '>',
        '?', '/', 'à', 'á', 'ả', 'ạ', 'ó', 'ỏ', 'ọ', 'ò', 'u', 'ú', 'ù', 'ụ', 'ủ', 'i',
        'í', 'ì', 'ỉ', 'ị', 'h', 'ô', 'ố', 'ổ', 'ồ', 'ộ'};
        int K = 5;

        public String MaHoa(String giaTriCanMaHoa)
        {
            // Duyệt từng ký tự trong giaTriCanMaHoa và mã hóa từng ký tự đó
            String ketQuaMaHoa = "";
            for(int i = 0; i < giaTriCanMaHoa.Length; i++)
            {
                ketQuaMaHoa += MaHoaKyTu(giaTriCanMaHoa[i]).ToString();
            }
            return ketQuaMaHoa;
        }

        public char MaHoaKyTu(char kyTuCanMa)
        {
            // B1: Xác định vị trí của ký tự cần mã hóa trong bảng chữ cái
            int viTriDau = -1;
            for(int i = 0; i < BangChuCai.Length; i++)
            {
                if(kyTuCanMa.Equals(BangChuCai[i]))
                {
                    viTriDau = i;
                    break;
                }
            }

            // B2: Xác định vị trí của ký tự mã hóa được theo công thức
            // Vị trí mới = (vị trí cũ + K)% chiều dài bảng chữ cái
            if (viTriDau == -1)
                return kyTuCanMa;
            else
            {
                int viTriMoi = (viTriDau + K) % BangChuCai.Length;
                // B3: Trả về ký tự ở vị trí mới trong bảng chữ cái
                return BangChuCai[viTriMoi];
            }
        }

        public String GiaiMa(String giaTriCanGiaiMa)
        {
            String ketQuaGiaiMa = "";
            // Duyệt từng ký tự cần giải mã
            for (int i = 0; i < giaTriCanGiaiMa.Length; i++)
            {
                // Giải mã từng ký tự và thêm vào kết quả giải mã
                ketQuaGiaiMa += GiaiMaKyTu(giaTriCanGiaiMa[i]).ToString();
            }
            return ketQuaGiaiMa;
        }

        public char GiaiMaKyTu(char kyTuCanGiaiMa)
        {
            // B1: Tìm vị trí của ký tự cần giải mã trong bảng chữ cái
            int viTriDau = -1;
            for(int i = 0; i < BangChuCai.Length; i++)
            {
                if(kyTuCanGiaiMa.Equals(BangChuCai[i]))
                {
                    viTriDau = i;
                    break;
                }
            }

            // B2: Tính vị trí mới theo công thức giải mã của Cesar
            if (viTriDau == -1) // ky tu can giai ma khong co trong bang chu cai
                return kyTuCanGiaiMa;
            else
            {

                int viTriMoi = 0;
                if (viTriDau - K >= 0)
                    viTriMoi = viTriDau - K;
                else
                    viTriMoi = viTriDau - K + BangChuCai.Length;

                // B3: Tìm ký tự ở vị trí mới trong bảng chữ cái và trả về ký tự đó
                return BangChuCai[viTriMoi];
            }
        }
    }
}
