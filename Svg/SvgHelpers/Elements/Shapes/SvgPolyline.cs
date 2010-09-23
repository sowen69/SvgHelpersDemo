using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgPolyline : SvgElementBase
    {
        public SvgPolyline()
        {
            _tagName = "polyline";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }

        public SvgPolyline Id(string id)
        {
            base._id = id;
            if (this == null) throw new Exception("Method SvgPolyline.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgPolyline XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgPolyline.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgPolyline XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgPolyline.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgPolyline XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgPolyline.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgPolyline CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgPolyline.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgPolyline Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgPolyline.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgPolyline Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgPolyline.Style resulted in a null value.");
            return this;
        }

        public SvgPolyline Points(string points)
        {
            this._points = points;
            if (this == null) throw new Exception("Method SvgPolyline.Points resulted in a null value.");
            _attributeStack.Add(@"points=""" + _points + @"""");
            return this;
        }
        
        public SvgPolyline Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgPolyline.Presentation resulted in a null value.");
            return this;
        }
        public SvgPolyline Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgPolyline.Transforms resulted in a null value.");
            return this;
        }
        public SvgPolyline Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgPolyline.Events resulted in a null value.");
            return this;
        }

        public SvgPolyline HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgPolyline.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgPolyline
    {
        public EndSvgPolyline()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("polyline");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
