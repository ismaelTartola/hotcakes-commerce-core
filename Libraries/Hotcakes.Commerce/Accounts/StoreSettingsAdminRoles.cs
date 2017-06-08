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

namespace Hotcakes.Commerce.Accounts
{
    [Serializable]
    public class StoreSettingsAdminRoles
    {
        private readonly StoreSettings parent;

        public StoreSettingsAdminRoles(StoreSettings s)
        {
            parent = s;
        }

        public string RoleCatalogManagement
        {
            get { return parent.GetProp("RoleCatalogManagement"); }
            set { parent.SetProp("RoleCatalogManagement", value); }
        }

        public string RoleOrdersAndCustomers
        {
            get { return parent.GetProp("RoleOrdersAndCustomers"); }
            set { parent.SetProp("RoleOrdersAndCustomers", value); }
        }

        public string RoleStoreAdministration
        {
            get { return parent.GetProp("RoleStoreAdministration"); }
            set { parent.SetProp("RoleStoreAdministration", value); }
        }

        public string RoleMobileAccess
        {
            get { return parent.GetProp("RoleMobileAccess"); }
            set { parent.SetProp("RoleMobileAccess", value); }
        }
    }
}