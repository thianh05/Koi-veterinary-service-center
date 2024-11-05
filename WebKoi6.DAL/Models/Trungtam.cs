using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Trungtam
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Vui lòng nhập tên trung tâm")] 
    
    public string? TenTrungTam { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
    public string? DiaChi { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập hotline")]
    public string? Hotline { get; set; }

    public string? MoTa { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }
}
