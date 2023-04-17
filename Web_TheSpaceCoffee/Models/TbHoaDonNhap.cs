using System;
using System.Collections.Generic;

namespace Web_TheSpaceCoffee.Models;

public partial class TbHoaDonNhap
{
    public string MaHoaDonNhap { get; set; } = null!;

    public string MaNhaCungCap { get; set; } = null!;

    public DateTime NgayLap { get; set; }

    public virtual TbNhaCungCap MaNhaCungCapNavigation { get; set; } = null!;

    public virtual ICollection<TbChiTietHdn> TbChiTietHdns { get; set; } = new List<TbChiTietHdn>();
}
