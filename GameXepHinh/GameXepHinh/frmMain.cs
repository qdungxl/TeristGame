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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        static int KichThucGame = 3; // Game xep hinh 3x3, 5x5,...thêm textbox nếu muốn tùy chình trên giao diện.     
        private QuanLyGame QuanLy = new QuanLyGame(KichThucGame);
        private OTrong OTr = null;
        Button[,] arrButton = null;
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                Bitmap bmp = new Bitmap(fileName);
                Bitmap newImage = null;
                newImage = QuanLy.ResizeBitmap(bmp, 300, 300);
                lblHinhGoc.Image = newImage;
                newImage = QuanLy.ResizeBitmap(bmp, 400, 400);
                QuanLy.TaoDuLieuMangHinh(newImage);
                HienThilenPanel();
            }
        }
        private void HienThilenPanel()
        {
            arrButton = new Button[KichThucGame, KichThucGame];
            OTr = QuanLy.LayGiaTriOTrong();
            pnXepHinh.Controls.Clear();
            for(int i = 0; i < KichThucGame; i++)
            {
                for(int j = 0; j < KichThucGame; j++)
                {
                    Button btn = new Button();
                    btn.Width = btn.Height = QuanLy.DsBitMap[0].Width;
                    if (OTr.dong == i && OTr.cot == j)
                    {
                        btn.Image = null;
                    }
                    else
                    {
                        btn.Image = QuanLy.dic.Values.ElementAt(i * KichThucGame + j);
                    }
                    btn.Tag = i + ";" + j + ";" + QuanLy.dic.Keys.ElementAt(i * KichThucGame + j);
                    btn.Location = new Point(j * btn.Width, i * btn.Height);
                    pnXepHinh.Controls.Add(btn);
                    arrButton[i, j] = btn;
                    btn.Click += Btn_Click1;
                }
            }
            kiemtrastt(arrButton);
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] arr = btn.Tag.ToString().Split(';');
            int dong = int.Parse(arr[0]);
            int cot = int.Parse(arr[1]);
            int ViTri = int.Parse(arr[2]);
            if (OChonCoNamKeBenOTrongKhong(OTr.dong,OTr.cot, dong, cot))
            {
                arrButton[OTr.dong, OTr.cot].Image = arrButton[dong, cot].Image;
                arrButton[OTr.dong, OTr.cot].Tag = OTr.dong + ";" + OTr.cot + ";" + ViTri;
                arrButton[dong, cot].Image = null;
                arrButton[dong, cot].Tag = dong + ";" + cot + ";" + OTr.ViTri;
                OTr.dong = dong;
                OTr.cot = cot;
                kiemtrastt(arrButton);
                if (KiemTraChienThang(arrButton))
                {
                    MessageBox.Show("WIN");
                }
            }
        }
        private void kiemtrastt(Button[,] arr)
        {
            string s = "";
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(1); j++)
                {
                    string[] arrS = arr[i, j].Tag.ToString().Split(';');
                    s += arrS[2] + "-";
                }
                s = s + "\n";
            }
            lblKiemTra.Text = s;
        }

        private bool OChonCoNamKeBenOTrongKhong(int dongTrong, int cotTrong, int dong, int cot)
        {
            if (dongTrong - 1 == dong && cotTrong == cot) //nằm trên ô trống.
            {
                return true;
            }
            if (dongTrong + 1 == dong && cotTrong == cot) //nằm dưới ô trống.
            {
                return true;
            }
            if (dongTrong == dong && cotTrong - 1 == cot) // nằm bên trái ô trống.
            {
                return true;
            }
            if (dongTrong == dong && cotTrong + 1 == cot)//nằm bên phải ô trống.
            {
                return true;
            }
            return false;
        }

        private bool KiemTraChienThang(Button[,] arr)
        {
            bool ChienThang = true; //nếu vi trí của các hình được xếp liên tục từ 1-25 thì ngươi chơi xếp đúng. chiến thắng.
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    string[] s = arr[i, j].Tag.ToString().Split(';');
                    int n = int.Parse(s[2]);// vị trí thật của hình khi cắt.
                    if ((i * KichThucGame + j) != n)
                    {
                        ChienThang = false;
                        break;
                    }
                }
            }
            return ChienThang;
        }

        private void btnTronLaiHinh_Click(object sender, EventArgs e)
        {
            QuanLy.TaoDsRandomBitMap();
            HienThilenPanel();
        }
    }
}
