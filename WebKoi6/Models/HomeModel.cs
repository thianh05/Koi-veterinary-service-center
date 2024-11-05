using System.ComponentModel.DataAnnotations;
using WebKoi6.DAL.Models;

namespace WebKoi6.Web.Models
{
    public class HomeModel
    {
        public Trungtam ObjTrungTam { get; set; }
        public List<Bacsi> ListBacSi { get; set; }
        public List<Tintuc> ListTintuc { get; set; }
        public List<Faq> ListFaq { get; set; }
    }
    public class DatlichModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tên khách hàng")]
        public string TenKhachHang { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string Email {  get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string Sodienthoai { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn dịch vụ")]
        public int Madichvu { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ngày đặt lịch hẹn")]
        public DateTime? NgayDatLich { get; set; }
        public int BacsiId { get; set; }
    }
}
