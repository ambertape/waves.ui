﻿using Waves.Core.Base;
using Waves.Core.Base.Interfaces;

namespace Waves.UI.Drawing.Base.Interfaces
{
    /// <summary>
    ///     Interface of drawing object.
    /// </summary>
    public interface IDrawingObject : IWavesObject
    {
        /// <summary>
        ///     Gets whether drawing object is antialiased.
        /// </summary>
        bool IsAntialiased { get; set; }

        /// <summary>
        ///     Gets whether drawing object is visible.
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        ///     Gets or sets object's opacity.
        /// </summary>
        float Opacity { get; set; }

        /// <summary>
        ///     Gets or sets stroke thickness.
        /// </summary>
        float StrokeThickness { get; set; }

        /// <summary>
        ///     Gets or sets fill.
        /// </summary>
        WavesColor Fill { get; set; }

        /// <summary>
        ///     Gets or sets stroke.
        /// </summary>
        WavesColor Stroke { get; set; }

        /// <summary>
        ///     Draw object in current canvas.
        /// </summary>
        /// <param name="e">Drawing element.</param>
        void Draw(IDrawingElement e);
    }
}