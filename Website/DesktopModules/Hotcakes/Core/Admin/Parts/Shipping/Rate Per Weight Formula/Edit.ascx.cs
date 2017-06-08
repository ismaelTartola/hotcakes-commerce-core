﻿#region License

// Distributed under the MIT License
// ============================================================
// Copyright (c) 2016 Hotcakes Commerce, LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.

#endregion

using System;
using System.Globalization;
using Hotcakes.Commerce.Shipping;
using Hotcakes.Commerce.Utilities;
using Hotcakes.Modules.Core.Admin.AppCode;
using Hotcakes.Shipping.Services;

namespace Hotcakes.Modules.Core.Modules.Shipping.Rate_Per_Weight_Formula
{
    public partial class Edit : HccShippingPart
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            LocalizeView();

            AddHighlightColors(lstHighlights);
            LoadZones();
            LoadData();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            NotifyFinishedEditing("Canceled");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            NotifyFinishedEditing(NameField.Text.Trim());
        }

        private void LoadZones()
        {
            lstZones.DataSource = HccApp.OrderServices.ShippingZones.FindForStore(HccApp.CurrentStore.Id);
            lstZones.DataTextField = "Name";
            lstZones.DataValueField = "id";
            lstZones.DataBind();
        }

        private void LoadData()
        {
            NameField.Text = ShippingMethod.Name;
            if (NameField.Text == string.Empty)
            {
                NameField.Text = Localization.GetString("RatePerWeightFormula");
            }

            var Settings = new RatePerWeightFormulaSettings();
            Settings.Merge(ShippingMethod.Settings);
            if (Settings.BaseAmount < 0) Settings.BaseAmount = 0;
            if (Settings.BaseWeight < 0) Settings.BaseWeight = 0;
            if (Settings.MinWeight < 0) Settings.MinWeight = 0;
            if (Settings.MaxWeight < 0) Settings.MaxWeight = 9999;
            if (Settings.AdditionalWeightCharge < 0) Settings.AdditionalWeightCharge = 0;


            BaseAmountField.Text = Settings.BaseAmount.ToString("C");
            AdditionalWeightChargeField.Text = Settings.AdditionalWeightCharge.ToString("C");
            BaseWeightField.Text = Settings.BaseWeight.ToString();
            MinWeightField.Text = Settings.MinWeight.ToString();
            MaxWeightField.Text = Settings.MaxWeight.ToString();


            // ZONES
            if (lstZones.Items.FindByValue(ShippingMethod.ZoneId.ToString()) != null)
            {
                lstZones.ClearSelection();
                lstZones.Items.FindByValue(ShippingMethod.ZoneId.ToString()).Selected = true;
            }

            // Select Hightlights
            var highlight = Settings.GetSettingOrEmpty("highlight");
            if (lstHighlights.Items.FindByText(highlight) != null)
            {
                lstHighlights.ClearSelection();
                lstHighlights.Items.FindByText(highlight).Selected = true;
            }
        }

        private void SaveData()
        {
            var baseAmount = decimal.Parse(BaseAmountField.Text, NumberStyles.Currency);
            var additionalWeightCharge = decimal.Parse(AdditionalWeightChargeField.Text, NumberStyles.Currency);
            var baseWeight = decimal.Parse(BaseWeightField.Text);
            var minWeight = decimal.Parse(MinWeightField.Text);
            var maxWeight = decimal.Parse(MaxWeightField.Text);

            var Settings = new RatePerWeightFormulaSettings();
            Settings.Merge(ShippingMethod.Settings);

            Settings.BaseAmount = Money.RoundCurrency(baseAmount);
            Settings.AdditionalWeightCharge = additionalWeightCharge;
            Settings.BaseWeight = baseWeight;
            Settings.MinWeight = minWeight;
            Settings.MaxWeight = maxWeight;
            Settings["highlight"] = lstHighlights.SelectedValue;

            ShippingMethod.Settings.Merge(Settings);

            ShippingMethod.Name = NameField.Text.Trim();
            ShippingMethod.AdjustmentType = ShippingMethodAdjustmentType.Amount;
            ShippingMethod.Adjustment = 0;
            ShippingMethod.ZoneId = long.Parse(lstZones.SelectedItem.Value);
        }

        private void LocalizeView()
        {
            cvMaxWeightField.ErrorMessage = Localization.GetString("cvMaxWeightField.ErrorMessage");
        }
    }
}