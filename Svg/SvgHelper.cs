using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc.Resources;
using System.Web.Routing;
using System.Web.Mvc;

namespace Odd.Svg
{
    public class SvgHelper : HtmlHelper
    {

        public SvgHelper(ViewContext viewContext, IViewDataContainer viewDataContainer)
            : base(viewContext, viewDataContainer, RouteTable.Routes)
        {}

        public SvgHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection)
        {
            if (viewContext == null)
            {
                throw new ArgumentNullException("viewContext");
            }
            if (viewDataContainer == null)
            {
                throw new ArgumentNullException("viewDataContainer");
            }
            if (routeCollection == null)
            {
                throw new ArgumentNullException("routeCollection");
            }

        }

    }
}
