using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgPolygon : SvgElementBase
    {
        public SvgPolygon()
        {
            _tagName = "polygon";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }
        public SvgPolygon Id(string id)
        {
            if (this == null) throw new Exception("Method SvgPolygon.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgPolygon XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgPolygon.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgPolygon XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgPolygon.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgPolygon XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgPolygon.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgPolygon CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgPolygon.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgPolygon Style(string style)
        {
            if (this == null) throw new Exception("Method SvgPolygon.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgPolygon Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgPolygon.Style resulted in a null value.");
            return this;
        }

        public SvgPolygon Points(string points)
        {
            if (this == null) throw new Exception("Method SvgPolygon.D resulted in a null value.");
            _attributeStack.Add(@"points=""" + points + @"""");
            return this;
        }
        
        public SvgPolygon Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgPolygon.Presentation resulted in a null value.");
            return this;
        }
        public SvgPolygon Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgPolygon.Transforms resulted in a null value.");
            return this;
        }
        public SvgPolygon Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgPolygon.Events resulted in a null value.");
            return this;
        }

        public SvgPolygon HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgPolygon.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgPolygon
    {
        public EndSvgPolygon()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("polygon");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
