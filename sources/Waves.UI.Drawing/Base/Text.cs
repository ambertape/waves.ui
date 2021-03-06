﻿using Waves.Core.Base;
using Waves.UI.Drawing.Base.Interfaces;

namespace Waves.UI.Drawing.Base
{
    /// <summary>
    ///     Text.
    /// </summary>
    public class Text : DrawingObject
    {
        /// <inheritdoc />
        public override string Name { get; set; } = "Text";

        /// <summary>
        ///     Gets or sets text style.
        /// </summary>
        public ITextStyle Style { get; set; }

        /// <summary>
        ///     Gets or sets text value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     Gets or sets text location.
        /// </summary>
        public WavesPoint Location { get; set; } = new WavesPoint(0, 0);

        /// <inheritdoc />
        public override void Draw(IDrawingElement e)
        {
            if (Style == null) return;
            if (!IsVisible) return;

            using var paint = new TextPaint
            {
                Fill = Fill,
                IsAntialiased = IsAntialiased,
                Opacity = Opacity,
                TextStyle = Style
            };

            e.DrawText(Location, Value, paint);
        }

        /// <inheritdoc />
        public override void Dispose()
        {
        }
    }
}