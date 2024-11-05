using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Tintuc
{
    public int MaTinTuc { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
    public string? TieuDe { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập nội dung")]
    public string? NoiDung { get; set; }

    public DateTime? NgayDang { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tác giả")]
    public string? TacGia { get; set; }
    public string? Hinhanh { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }
}
