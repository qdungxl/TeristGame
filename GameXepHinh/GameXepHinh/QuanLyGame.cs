using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh
{
    public class QuanLyGame
    {
        int KichThuoc;
        Random rd = new Random();
        public int DoKhoDe { get; set; } // Đăt số lần trộn khi trộn hình. Cách trộn lại hình như làm bằng tay ngoài thực tế.
        private OTrong OTr = new OTrong();
        public List<Bitmap> DsBitMap = new List<Bitmap>();
        public Dictionary<int, Bitmap> dic = new Dictionary<int, Bitmap>();
        public QuanLyGame(int n)
        {
            KichThuoc = n;
            DoKhoDe = 10; // mặc định = 10, thêm textbox nếu muốn tùy biến độ khó dễ.
        }
        public void TaoDsRandomBitMap()
        {
            dic.Clear();
            #region tạo mảng 2 chiều khởi tạo giá trị -24. Tương ứng 25 hình bitmap nhỏ
            int[,] arr = new int[KichThuoc, KichThuoc];
            for(int i = 0; i< KichThuoc; i++)
            {
                for (int j = 0; j < KichThuoc; j++)
                {
                    arr[i, j] = i * KichThuoc + j;
                }
            }
            #endregion
            #region Biến đổi mảng 2 chiều để 25 hình bitmap sắp xếp lộn xộn, có thể ghép lại được
            int dong = 0;
            int cot = 0;
            int temp;
            for (int i = 0; i < 200; i++)
            {
                int n = rd.Next(4) + 1;
                switch (n)
                {
                    case 1://trai
                        if (cot - 1 >= 0)
                        {
                            temp = arr[dong, cot];
                            arr[dong, cot] = arr[dong, cot - 1];
                            arr[dong, cot - 1] = temp;
                            cot--;
                        }
                        break;
                    case 2://phai
                        if (cot + 1 <= (KichThuoc-1))
                        {
                            temp = arr[dong, cot];
                            arr[dong, cot] = arr[dong, cot + 1];
                            arr[dong, cot + 1] = temp;
                            cot++;
                        }
                        break;
                    case 3://tren
                        if (dong - 1 >= 0)
                        {
                            temp = arr[dong, cot];
                            arr[dong, cot] = arr[dong - 1, cot];
                            arr[dong - 1, cot] = temp;
                            dong--;
                        }
                        break;
                    case 4://duoi
                        if (dong + 1 <= (KichThuoc-1))
                        {
                            temp = arr[dong, cot];
                            arr[dong, cot] = arr[dong + 1, cot];
                            arr[dong + 1, cot] = temp;
                            dong++;
                        }
                        break;
                    default:
                        break;
                }
            }
            #endregion
            for (int i =0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    dic.Add(arr[i, j], DsBitMap[arr[i, j]]);
                }
            }
            this.OTr.dong = dong;
            OTr.cot = cot;
            OTr.ViTri = arr[OTr.dong, OTr.cot];
        }      
        public void TaoDuLieuMangHinh(Bitmap bmp)
        {
            DsBitMap.Clear();
            for (int dong = 0; dong < KichThuoc; dong++)
            {
                for (int cot = 0; cot < KichThuoc; cot++)
                {
                    Rectangle rec = new Rectangle(cot * bmp.Width/KichThuoc, dong * bmp.Width / KichThuoc, bmp.Width / KichThuoc, bmp.Width / KichThuoc);
                    Bitmap newBmp = bmp.Clone(rec, bmp.PixelFormat);
                    DsBitMap.Add(newBmp);
                }
            }
            TaoDsRandomBitMap();
        }
        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            #region cắt ảnh đưa về hình vuông
            int ChieuNgang = bmp.Width;
            int ChieuDoc = bmp.Height;
            int Canh;
            if (ChieuDoc > ChieuNgang)
                Canh = ChieuNgang;
            else
                Canh = ChieuDoc;
            var recX = ChieuNgang / 2 - Canh / 2;
            var recY = ChieuDoc / 2 - Canh / 2;
            Rectangle rec = new Rectangle(recX, recY, Canh, Canh);
            bmp = bmp.Clone(rec, bmp.PixelFormat);
            #endregion
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
        public OTrong LayGiaTriOTrong()
        {
            return OTr;
        }
    }
}
