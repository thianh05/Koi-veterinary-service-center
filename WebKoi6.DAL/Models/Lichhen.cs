using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Lichhen
{
    public int Id { get; set; }
    public int KhachhangId { get; set; }
    public int BacsiId { get; set; }
    public int DichVuId { get; set; }
    public DateTime? Ngayhen { get; set; }
    public int Trangthai { get; set; }
}
public class LichhenMapping: Lichhen
{
    public string TenKhachHang { get; set; }
    public string Sodienthoai { get; set; }
    public string Email { get; set; }
    public string TenBacSi { get; set; }
    public string TenDichVu { get; set; }
    public int TotalRows { get; set; }
}
