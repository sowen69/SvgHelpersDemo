using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// 
    /// </summary>
    public class SvgTSpan : SvgText
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgTSpan"/> class.
        /// </summary>
        public SvgTSpan()
        {
            _tagName = "tspan";
            _hasChildNode = true;
        }
    }

    /// <summary>
    /// TSpan End Tag
    /// </summary>
    public class EndSvgTSpan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgTSpan"/> class.
        /// </summary>
        public EndSvgTSpan(){
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("tspan");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
