using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Web.Mvc.Html;

namespace Odd.Svg
{
    public class SvgViewPage : ViewPage
    {
        public HtmlHelper<object> Svg
        {
            get;
            set;
        }

        public override void InitHelpers()
        {
            Ajax = new AjaxHelper<object>(ViewContext, this);
            Html = new HtmlHelper<object>(ViewContext, this);
            Url = new UrlHelper(ViewContext.RequestContext);
            Svg = new HtmlHelper<object>(ViewContext, this);
        }
    }
}
