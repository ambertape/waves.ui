﻿using System;
using System.Collections.Generic;
using Waves.Core.Base;
using Waves.Core.Base.Interfaces;

namespace Waves.UI.Drawing.Base.Interfaces
{
    /// <summary>
    ///     Interface for drawing element.
    /// </summary>
    public interface IDrawingElement : IWavesObject
    {
        /// <summary>
        ///     Draws on element.
        /// </summary>
        /// <param name="element">Element.</param>
        /// <param name="drawingObjects">List of drawing objects.</param>
        void Draw(object element, ICollection<IDrawingObject> drawingObjects);

        /// <summary>
        ///     Draws circle.
        /// </summary>
        /// <param name="location">Location.</param>
        /// <param name="radius">Radius.</param>
        /// <param name="paint">Paint.</param>
        void DrawEllipse(WavesPoint location, float radius, IPaint paint);

        /// <summary>
        ///     Draws line.
        /// </summary>
        /// <param name="point1">Point 1.</param>
        /// <param name="point2">Point 2.</param>
        /// <param name="paint">Paint.</param>
        void DrawLine(WavesPoint point1, WavesPoint point2, IPaint paint);

        /// <summary>
        ///     Draws rectangle
        /// </summary>
        /// <param name="location">Location.</param>
        /// <param name="size">Size.</param>
        /// <param name="paint">Paint.</param>
        /// <param name="cornerRadius">Corner radius.</param>
        void DrawRectangle(WavesPoint location, WavesSize size, IPaint paint, float cornerRadius = 0);

        /// <summary>
        ///     Draws text.
        /// </summary>
        /// <param name="location">Text location.</param>
        /// <param name="text">Text.</param>
        /// <param name="paint">Paint.</param>
        void DrawText(WavesPoint location, string text, ITextPaint paint);

        /// <summary>
        ///     Measures text size.
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="paint">Paint.</param>
        /// <returns>Text's size.</returns>
        WavesSize MeasureText(string text, ITextPaint paint);
    }
}