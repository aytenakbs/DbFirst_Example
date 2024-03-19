using System;
using System.Collections.Generic;

namespace DBFirst_Example.Models;

public partial class TblEgitman
{
    public int EgitmenId { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? UzmanlikAlani { get; set; }
}
