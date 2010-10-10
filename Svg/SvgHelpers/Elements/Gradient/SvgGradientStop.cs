using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgGradientStop : SvgElementBase
    {

        public SvgGradientStop()
        {
            _tagName = "stop";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _styles = new List<SvgStyle>();
            //_events = new List<SvgEvent>();
        }

        public SvgGradientStop Id(string id)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgGradientStop XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgGradientStop XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgGradientStop XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgGradientStop CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgGradientStop Style(string style)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgGradientStop Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgGradientStop.Style resulted in a null value.");
            return this;
        }

        public SvgGradientStop Offset(string offset)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.Offset resulted in a null value.");
            _attributeStack.Add(@"offset=""" + offset + @"""");
            return this;
        }

        public SvgGradientStop Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgGradientStop.Presentation resulted in a null value.");
            return this;
        }

        public SvgGradientStop HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgGradientStop.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgGradientStop
    {
        public EndSvgGradientStop()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("stop");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
