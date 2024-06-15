using System.ComponentModel.DataAnnotations;
namespace nanh1111kiemtra.Models
{
    public class SinhVien
    {
        [KeyAttribute]
       public  string MaSinhVien { get; set; }
       public  string HoTen { get; set; }
       public  string MaLop { get; set; }

    }
}