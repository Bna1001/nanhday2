using System.ComponentModel.DataAnnotations;
namespace nanh1111kiemtra.Models
{
    public class LopHoc
    {
        [KeyAttribute]
       public  string MaLop { get; set; }
       public  string TenLop { get; set; }
       public  string SoPhong { get; set; }

    }
}