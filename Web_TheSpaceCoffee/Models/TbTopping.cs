using System;
using System.Collections.Generic;

namespace Web_TheSpaceCoffee.Models;

public partial class TbTopping
{
    public string MaTopping { get; set; } = null!;

    public string TenTopping { get; set; } = null!;

    public int GiaBan { get; set; }

    public string? Anh { get; set; }

    public virtual ICollection<TbChiTietToppingHdb> TbChiTietToppingHdbs { get; set; } = new List<TbChiTietToppingHdb>();
}
