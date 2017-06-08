#region License

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
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Hotcakes.Commerce.Catalog;
using Hotcakes.Commerce.Storage;
using Hotcakes.Modules.Core.Admin.AppCode;

namespace Hotcakes.Modules.Core.Admin.Parts.ContentBlocks.ProductRotator
{
    partial class AdminView : HccContentBlockPart
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadProduct();
        }

        private void LoadProduct()
        {
            var b = HccApp.ContentServices.Columns.FindBlock(BlockId);
            var myProducts = b.Lists.FindList("Products");

            if (myProducts != null && myProducts.Count > 0)
            {
                litCount.Text = myProducts.Count.ToString();
                var settItem = myProducts[0];
                var product = HccApp.CatalogServices.Products.FindWithCache(settItem.Setting1);
                if (product != null)
                {
                    RenderProduct(product);
                }
            }
        }

        private void RenderProduct(Product product)
        {
            var price = HccApp.PriceProduct(product, HccApp.CurrentCustomer, null, HccApp.CurrentlyActiveSales);

            var imageUrl = DiskStorage.ProductImageUrlSmall(HccApp, product.Bvin, product.ImageFileSmall,
                Page.Request.IsSecureConnection);

            var htmlDiv = new HtmlGenericControl("div");
            htmlDiv.Attributes["class"] = "hcBlockContent";
            htmlDiv.Controls.Add(new LiteralControl(product.ProductName));

            phProduct.Controls.Clear();
            phProduct.Controls.Add(new HtmlImage
            {
                Src = imageUrl
            });

            phProduct.Controls.Add(htmlDiv);
        }
    }
}