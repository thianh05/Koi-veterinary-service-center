using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Banggia
{
    public int Id { get; set; }
    public int MaDichVu { get; set; }
    public decimal Gia { get; set; }
    public decimal Phidichuyen { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }
    [NotMapped]
    public string? TenDichVu { get; set; }
}
