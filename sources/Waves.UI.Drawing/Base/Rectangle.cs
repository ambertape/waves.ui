﻿using Waves.Core.Base;
using Waves.UI.Drawing.Base.Interfaces;

namespace Waves.UI.Drawing.Base
{
    /// <summary>
    ///     Rectangle.
    /// </summary>
    public class Rectangle : ShapeDrawingObject
    {
        /// <inheritdoc />
        public override string Name { get; set; } = "Rectangle";

        /// <summary>
        ///     Gets or sets corner radius.
        /// </summary>
        public float CornerRadius { get; set; }

        /// <inheritdoc />
        public override void Draw(IDrawingElement e)
        {
            if (!IsVisible) return;

            using var paint = new Paint
            {
                Fill = Fill,
                IsAntialiased = IsAntialiased,
                Opacity = Opacity,
                Stroke = Stroke,
                StrokeThickness = StrokeThickness
            };

            e.DrawRectangle(Location, new WavesSize(Width, Height), paint, CornerRadius);
        }

        /// <inheritdoc />
        public override void Dispose()
        {
        }
    }
}