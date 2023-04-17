﻿using System;
using System.Collections.Generic;

namespace Web_TheSpaceCoffee.Models;

public partial class TbVatTu
{
    public string MaVatTu { get; set; } = null!;

    public string TenVatTu { get; set; } = null!;

    public string DonViTinh { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual ICollection<TbChiTietHdn> TbChiTietHdns { get; set; } = new List<TbChiTietHdn>();

    public virtual ICollection<TbKhoVatTuCh> TbKhoVatTuChes { get; set; } = new List<TbKhoVatTuCh>();
}
