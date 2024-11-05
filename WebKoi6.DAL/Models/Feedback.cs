using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tên khách hàng")]
    public string? TenKhachHang { get; set; }
    [Required(ErrorMessage = "Vui lòng email khách hàng")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Vui lòng đánh giá")]
    public string? DanhGia { get; set; }
    [Required(ErrorMessage = "Vui lòng bình luận")]
    public string? BinhLuan { get; set; }
    public DateTime NgayPhanHoi { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }
}
