﻿using System;

namespace Mapsui.Extensions.Cache;

public class Tile
{
    public int Level { get; set; }
    public int Col { get; set; }
    public int Row { get; set; }
    public DateTime Created { get; set; }
    public byte[] Data { get; set; }
}