using System.Collections.Generic;
using System.Web.Mvc;
using System;
using System.Reflection;
using System.ComponentModel;
using System.Text;

namespace Odd.Svg.SvgHelpers
{
    public class SvgLine : SvgElementBase
    {
        public SvgLine()
        {
            _tagName = "line";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }

        public SvgLine Id(string id)
        {
            if (this == null) throw new Exception("Method SvgLine.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgLine XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgLine.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgLine XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgLine.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgLine XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgLine.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgLine CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgLine.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgLine Style(string style)
        {
            if (this == null) throw new Exception("Method SvgLine.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgLine Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgLine.Style resulted in a null value.");
            return this;
        }
        public SvgLine X1(double x1)
        {
            if (this == null) throw new Exception("Method SvgLine.X1 resulted in a null value.");
            _attributeStack.Add(@"x1=""" + x1.ToString() + @"""");
            return this;
        }
        public SvgLine X2(double x2)
        {
            if (this == null) throw new Exception("Method SvgLine.X2 resulted in a null value.");
            _attributeStack.Add(@"x2=""" + x2.ToString() + @"""");
            return this;
        }
        public SvgLine Y1(double y1)
        {
            if (this == null) throw new Exception("Method SvgLine.Y1 resulted in a null value.");
            _attributeStack.Add(@"y1=""" + y1.ToString() + @"""");
            return this;
        }
        public SvgLine Y2(double y2)
        {
            if (this == null) throw new Exception("Method SvgLine.Y2 resulted in a null value.");
            _attributeStack.Add(@"y2=""" + y2.ToString() + @"""");
            return this;
        }
        
        public SvgLine X1(string x1)
        {
            if (this == null) throw new Exception("Method SvgLine.X1(string) resulted in a null value.");
            _attributeStack.Add(@"x1=""" + x1 + @"""");
            return this;
        }
        public SvgLine X2(string x2)
        {
            if (this == null) throw new Exception("Method SvgLine.X2(string) resulted in a null value.");
            _attributeStack.Add(@"x2=""" + x2 + @"""");
            return this;
        }
        public SvgLine Y1(string y1)
        {
            if (this == null) throw new Exception("Method SvgLine.Y1(string) resulted in a null value.");
            _attributeStack.Add(@"y1=""" + y1 + @"""");
            return this;
        }
        public SvgLine Y2(string y2)
        {
            if (this == null) throw new Exception("Method SvgLine.Y2(string) resulted in a null value.");
            _attributeStack.Add(@"y2=""" + y2 + @"""");
            return this;
        }

        public SvgLine Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgLine.Presentation resulted in a null value.");
            return this;
        }
        public SvgLine Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgLine.Transforms resulted in a null value.");
            return this;
        }
        public SvgLine Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgLine.Events resulted in a null value.");
            return this;
        }

        public SvgLine HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgLine.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgLine
    {
        public EndSvgLine()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("line");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}