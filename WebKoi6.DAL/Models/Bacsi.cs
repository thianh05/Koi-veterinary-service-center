using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Bacsi
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tên bác sĩ")]
    public string? TenBacSi { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập kinh nghiệm")]
    public int KinhNghiem { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập email")]
    public string? Email { get; set; }

    public string? Availability { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập thông tin thời gian làm việc")]
    public string? Noidung { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
    public string? Sodienthoai { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }
}
