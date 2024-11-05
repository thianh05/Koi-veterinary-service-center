using System;
using System.Collections.Generic;

namespace WebKoi6.DAL.Models;

public partial class Chuandoantinhtrangnuoc
{
    public int Id { get; set; }

    public int LichhenId { get; set; }

    public DateTime? NgayThang { get; set; }

    public decimal Ph { get; set; }

    public decimal DoCuongNuoc { get; set; }

    public decimal NhietDo { get; set; }
}
