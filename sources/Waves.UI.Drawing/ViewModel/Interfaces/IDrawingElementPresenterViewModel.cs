﻿using System;
using System.Collections.Generic;
using Waves.Core.Base;
using Waves.Presentation.Interfaces;
using Waves.UI.Drawing.Base.Interfaces;

namespace Waves.UI.Drawing.ViewModel.Interfaces
{
    /// <summary>
    ///     Interface for drawing element presenter view model.
    /// </summary>
    public interface IDrawingElementPresenterViewModel : IPresenterViewModel, IDisposable
    {
        /// <summary>
        ///     Gets or sets foreground.
        /// </summary>
        WavesColor Foreground { get; set; }

        /// <summary>
        ///     Gets or sets background.
        /// </summary>
        WavesColor Background { get; set; }

        /// <summary>
        ///     Gets or sets drawing element.
        /// </summary>
        IDrawingElement DrawingElement { get; set; }

        /// <summary>
        ///     Gets collection of drawing object.
        /// </summary>
        ICollection<IDrawingObject> DrawingObjects { get; }

        /// <summary>
        ///     Adds drawing object.
        /// </summary>
        /// <param name="obj">Drawing object.</param>
        void AddDrawingObject(IDrawingObject obj);

        /// <summary>
        ///     Removes drawing object.
        /// </summary>
        /// <param name="obj">Drawing object.</param>
        void RemoveDrawingObject(IDrawingObject obj);

        /// <summary>
        ///     Updates canvas.
        /// </summary>
        void Update();

        /// <summary>
        ///     Draws on element.
        /// </summary>
        void Draw(object element);

        /// <summary>
        ///     Clears drawing objects.
        /// </summary>
        void Clear();
    }
}