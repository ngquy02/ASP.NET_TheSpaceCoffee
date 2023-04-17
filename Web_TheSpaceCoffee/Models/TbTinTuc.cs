using System;
using System.Collections.Generic;

namespace Web_TheSpaceCoffee.Models;

public partial class TbTinTuc
{
    public string MaTinTuc { get; set; } = null!;

    public string TieuDe { get; set; } = null!;

    public DateTime NgayDang { get; set; }

    public string NoiDung { get; set; } = null!;

    public virtual ICollection<TbCuaHang> MaCuaHangs { get; set; } = new List<TbCuaHang>();
}
