using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameXepHinh
{
   public  class OTrong
    {
       public int dong { get; set; }// lưu tọa độ ô trống theo phương ngang.
       public int cot { get; set; }//lưu tọa độ ô trống theo phương dọc.
       public int ViTri { get; set; }//lưu thứ tự đúng của ô trống (0->24) trong 25 bức hình được cắt.
    }
}
