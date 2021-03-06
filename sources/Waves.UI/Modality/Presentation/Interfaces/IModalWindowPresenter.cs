﻿using System;
using System.Collections.Generic;
using Waves.Presentation.Interfaces;
using Waves.UI.Base.Interfaces;
using Waves.UI.Modality.Base.Interfaces;

namespace Waves.UI.Modality.Presentation.Interfaces
{
    /// <summary>
    /// Interface for modality window presenter.
    /// </summary>
    public interface IModalWindowPresenter : IPresenter
    {
        /// <summary>
        /// Gets icon.
        /// </summary>
        IVectorImage Icon { get; }

        /// <summary>
        /// Gets title.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Gets or sets height of window.
        /// </summary>
        double MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets width of window.
        /// </summary>
        double MaxWidth { get; set; }

        /// <summary>
        ///     Gets collection of actions.
        /// </summary>
        ICollection<IModalWindowAction> Actions { get; }

        /// <summary>
        /// Event for closing request handling.
        /// </summary>
        event EventHandler<IModalWindowPresenter> WindowRequestClosing;
    }
}