using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Dichvuthuy
{
    public int MaDichVu { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tên dịch vụ")]
    public string? TenDichVu { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập mô tả dịch vụ")]
    public string? MoTa { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }
}
