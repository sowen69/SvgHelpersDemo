using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgTSpan : SvgText
    {
        public SvgTSpan()
        {
            _tagName = "tspan";
            _hasChildNode = true;
        }
    }

    public class EndSvgTSpan
    {
        public EndSvgTSpan()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("tspan");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
