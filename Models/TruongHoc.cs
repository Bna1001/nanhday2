using System.ComponentModel.DataAnnotations;
namespace nanh1111kiemtra.Models
{
    public class TruongHoc
    {
        [KeyAttribute]
       public  string MaTruongHoc { get; set; }
       public  string TenTruongHoc { get; set; }
       public  string MaLop { get; set; }

    }
}