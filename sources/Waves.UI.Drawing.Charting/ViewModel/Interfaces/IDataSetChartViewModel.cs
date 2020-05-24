﻿using System.Collections.Generic;
using Waves.Core.Base;
using Waves.UI.Drawing.Charting.Base.Interfaces;

namespace Waves.UI.Drawing.Charting.ViewModel.Interfaces
{
    /// <summary>
    ///     Interface for data chart view model.
    /// </summary>
    public interface IDataSetChartViewModel : IChartViewModel
    {
        /// <summary>
        ///     Gets collection of added data sets.
        /// </summary>
        List<IDataSet> DataSets { get; }

        /// <summary>
        ///     Adds new data set.
        /// </summary>
        /// <param name="dataSet">Data set.</param>
        void AddDataSet(IDataSet dataSet);

        /// <summary>
        ///     Updates existing data set.
        /// </summary>
        /// <param name="index">Data set index.</param>
        /// <param name="points">Array of points.</param>
        void UpdateDataSet(int index, Point[] points);

        /// <summary>
        ///     Removes existing data set.
        /// </summary>
        /// <param name="index">Data set index.</param>
        void RemoveDataSet(int index);
    }
}