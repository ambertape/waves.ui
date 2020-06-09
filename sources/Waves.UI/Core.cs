﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Waves.Core.Base;
using Waves.Core.Base.Enums;
using Waves.Core.Base.Interfaces;
using Waves.UI.Modality.Presentation.Controllers.Interfaces;
using Waves.UI.Modality.Presentation.Interfaces;
using Waves.UI.Services.Interfaces;

namespace Waves.UI
{
    /// <summary>
    ///     UI Core.
    /// </summary>
    public abstract class Core : Waves.Core.Core
    {
        /// <summary>
        ///     Gets whether UI Core is initialized.
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// Gets or sets modal window controller.
        /// </summary>
        protected IModalWindowsPresentationController ModalWindowController { get; set; }

        /// <inheritdoc />
        public sealed override void Start()
        {
            try
            {
                base.Start();

                WriteLogMessage(
                    new Message("UI Core launch", "UI Core is launching...", "UI Core", MessageType.Information));

                Initialize();

                IsInitialized = true;

                WriteLogMessage(
                    new Message("UI Core launch", "UI Core launched successfully.", "UI Core", MessageType.Success));

                AddMessageSeparator();
            }
            catch (Exception ex)
            {
                WriteLogException(ex, "UI Core launch", true);
            }
        }

        /// <summary>
        ///     Shows modality window.
        /// </summary>
        /// <param name="presentation">Presentation.</param>
        public void ShowModalityWindow(IModalWindowPresentation presentation)
        {
            ModalWindowController?.ShowWindow(presentation);
        }

        /// <summary>
        ///     Hides modality window.
        /// </summary>
        /// <param name="presentation">Presentation.</param>
        public void HideModalityWindow(IModalWindowPresentation presentation)
        {
            ModalWindowController?.HideWindow(presentation);
        }

        /// <inheritdoc />
        public override void WriteLogMessage(IMessage message)
        {
            if (message.Type == MessageType.Fatal)
            {
                // TODO: fatal error handling.
            }

            base.WriteLogMessage(message);
        }

        /// <inheritdoc />
        public override void WriteLogException(Exception ex, string sender, bool isFatal)
        {
            if (isFatal)
            {
                // TODO: fatal error handling.
            }

            base.WriteLogException(ex, sender, isFatal);
        }

        /// <summary>
        ///     Initializes UI Core.
        /// </summary>
        protected abstract void Initialize();
    }
}