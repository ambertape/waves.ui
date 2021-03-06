﻿using System;
using System.Collections.Generic;
using System.Composition;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Waves.Core.Base;
using Waves.Core.Base.Enums;
using Waves.Core.Base.Interfaces;
using Waves.Core.Base.Interfaces.Services;
using Waves.UI.Drawing.Base.Interfaces;
using Waves.UI.Drawing.Services.Interfaces;

namespace Waves.UI.Drawing.Services
{
    /// <summary>
    ///     Drawing service.
    /// </summary>
    [Export(typeof(IWavesService))]
    public class DrawingService : WavesMefLoaderService<IDrawingEngine>, IDrawingService
    {
        private readonly string _currentDirectory = Environment.CurrentDirectory;
        
        private IDrawingEngine _currentEngine;

        /// <inheritdoc />
        public event EventHandler EngineChanged;

        /// <inheritdoc />
        public override Guid Id { get; } = Guid.Parse("47D1A008-2278-43F0-9E95-878EE5001D27");

        /// <inheritdoc />
        public override string Name { get; set; } = "Drawing service";

        /// <inheritdoc />
        [Reactive]
        public IDrawingEngine CurrentEngine
        {
            get => _currentEngine;
            set
            {
                _currentEngine = value;
                this.RaisePropertyChanged(nameof(CurrentEngine));
                OnEngineChanged();
            }
        }

        /// <inheritdoc />
        protected override string ObjectsName => "Drawing Engines";

        /// <inheritdoc />
        public override void LoadConfiguration()
        {
            try
            {
                var name = LoadConfigurationValue(Core.Configuration, "DrawingService-DefaultEngineName", string.Empty);

                if (!string.IsNullOrEmpty(name))
                {
                    foreach (var engine in Objects)
                    {
                        if (!string.Equals(engine.Name, name, StringComparison.OrdinalIgnoreCase)) continue;

                        CurrentEngine = engine;
                        break;
                    }
                }
                else
                {
                    if (Objects.Any())
                        CurrentEngine = Objects.First();
                }
                
                base.LoadConfiguration();
            }
            catch (Exception e)
            {
                OnMessageReceived(this, new WavesMessage(e, false));
            }
        }

        /// <inheritdoc />
        public override void SaveConfiguration()
        {
            try
            {
                if (CurrentEngine != null)
                    Core.Configuration.SetPropertyValue("DrawingService-DefaultEngineName", CurrentEngine.Id);
                
                base.SaveConfiguration();
            }
            catch (Exception e)
            {
                OnMessageReceived(this, new WavesMessage(e, false));
            }
        }
        
        /// <inheritdoc />
        public override void Update()
        {
            if (Paths.Count == 0)
                Paths.Add(_currentDirectory);

            base.Update();

            Paths.Remove(_currentDirectory);
        }

        /// <summary>
        ///     Notifies when engine changed.
        /// </summary>
        protected virtual void OnEngineChanged()
        {
            EngineChanged?.Invoke(this, EventArgs.Empty);

            OnMessageReceived(this, new WavesMessage("Drawing engine",
                "Drawing engine changed to " + CurrentEngine.Name + ".", Name,
                WavesMessageType.Information));
        }
        
        /// <inheritdoc />
        public override void Dispose()
        {
        }
    }
}