﻿//-------------------------------------------------------------------------------
// <copyright file="StockDetailViewModel.cs" company="bbv Software Services AG">
//   Copyright (c) 2012
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace StockTicker.ManageStocks
{
    using System;
    using System.Collections.Generic;

    using Caliburn.Micro;

    using StockTicker.Actions;
    using StockTicker.Authentication;
    using StockTicker.Externals;

    internal class StockDetailViewModel : Screen, IStockDetailViewModel
    {
        public StockDetailViewModel(StockDetailModel detailModel)
        {
            this.Model = detailModel;
        }

        public Func<IActionBuilder> Actions { private get; set; }

        public StockDetailModel Model { get; private set; }

        public IEnumerable<IResult> AddPortfolio()
        {
            return this.Actions().WithLogin(bilder => { });
        }
    }
}