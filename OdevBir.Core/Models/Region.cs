﻿using System;
using System.Collections.Generic;

namespace OdevBir.Core.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; } = new List<Territory>();
}
