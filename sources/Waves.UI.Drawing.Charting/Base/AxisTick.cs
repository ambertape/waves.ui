﻿using Waves.UI.Drawing.Charting.Base.Enums;
using Waves.UI.Drawing.Charting.Base.Interfaces;

namespace Waves.UI.Drawing.Charting.Base
{
    /// <summary>
    ///     Axis tick.
    /// </summary>
    public class AxisTick : IAxisTick
    {
        /// <inheritdoc />
        public bool IsVisible { get; set; }

        /// <inheritdoc />
        public float Value { get; set; }

        /// <inheritdoc />
        public string Description { get; set; }

        /// <inheritdoc />
        public AxisTickType Type { get; set; }

        /// <inheritdoc />
        public AxisTickOrientation Orientation { get; set; }
    }
}