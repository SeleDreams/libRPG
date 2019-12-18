// Copyright - SeleDreams - 2019
using System;
namespace libRPG.Battle
{
    public interface IStat
    {
        /// <summary>
        /// Gets or sets the value of this particular stat.
        /// </summary>
        float Value { get; set; }
        float Max { get; }
    }
}
