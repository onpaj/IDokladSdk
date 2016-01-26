﻿using System;

namespace IdokladSdk.Attributes
{
    internal class RankAttribute : Attribute
    {
        public RankAttribute(int rank)
        {
            RankValue = rank;
        }

        public RankAttribute()
        {
        }

        public int RankValue { get; protected set; }
    }
}