using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebKoi6.DAL.Models;

public partial class Chuandoanbenhcakoi
{
    public int Id { get; set; }
    public int LichhenId { get; set; }
    public DateTime? NgayThang { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập chuẩn đoán bệnh")]
    public string? ChuanDoan { get; set; }

    public string? DauHieu { get; set; }

    public string? HinhThucDieuTri { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tên loại cá koi")]
    public string? TenLoaiCaKoi { get; set; }
}
