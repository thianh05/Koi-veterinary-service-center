using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Khachhang
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tên khách hàng")]
    public string? TenKhachHang { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập số điện thoại khách hàng")]
    public string? SoDienThoai { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập email")]
    public string? Email { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }  
}
