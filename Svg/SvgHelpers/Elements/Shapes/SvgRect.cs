using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgRect : SvgElementBase
    {

        public SvgRect()
        {
            _tagName = "rect";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }

        public SvgRect Id(string id)
        {
            if (this == null) throw new Exception("Method SvgRect.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgRect XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgRect.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgRect XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgRect.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgRect XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgRect.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgRect CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgRect.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgRect Style(string style)
        {
            if (this == null) throw new Exception("Method SvgRect.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgRect Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgRect.Style resulted in a null value.");
            return this;
        }
    
        public SvgRect X(double x)
        {
            if (this == null) throw new Exception("Method SvgRect.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x.ToString() + @"""");
            return this;
        }
        public SvgRect Y(double y)
        {
            if (this == null) throw new Exception("Method SvgRect.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y.ToString() + @"""");
            return this;
        }
        public SvgRect RX(double rx)
        {
            if (this == null) throw new Exception("Method SvgRect.RX resulted in a null value.");
            _attributeStack.Add(@"rx=""" + rx.ToString() + @"""");
            return this;
        }     
        public SvgRect RY(double ry)
        {
            if (this == null) throw new Exception("Method SvgRect.RY resulted in a null value.");
            _attributeStack.Add(@"ry=""" + ry.ToString() + @"""");
            return this;
        }
        public SvgRect Height(double height)
        {
            if (this == null) throw new Exception("Method SvgRect.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height.ToString() + @"""");
            return this;
        }
        public SvgRect Width(double width)
        {
            if (this == null) throw new Exception("Method SvgRect.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width.ToString() + @"""");
            return this;
        }

        public SvgRect X(string x)
        {
            if (this == null) throw new Exception("Method SvgRect.X(string) resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        public SvgRect Y(string y)
        {
            if (this == null) throw new Exception("Method SvgRect.Y(string) resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        public SvgRect RX(string rx)
        {
            if (this == null) throw new Exception("Method SvgRect.RX(string) resulted in a null value.");
            _attributeStack.Add(@"rx=""" + rx + @"""");
            return this;
        }
        public SvgRect RY(string ry)
        {
            if (this == null) throw new Exception("Method SvgRect.RY(string) resulted in a null value.");
            _attributeStack.Add(@"ry=""" + ry + @"""");
            return this;
        }
        public SvgRect Height(string height)
        {
            if (this == null) throw new Exception("Method SvgRect.Height(string) resulted in a null value.");
            _attributeStack.Add(@"height=""" + height + @"""");
            return this;
        }
        public SvgRect Width(string width)
        {
            if (this == null) throw new Exception("Method SvgRect.Width(string) resulted in a null value.");
            _attributeStack.Add(@"width=""" + width + @"""");
            return this;
        }

        public SvgRect Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgRect.Presentation resulted in a null value.");
            return this;
        }
        public SvgRect Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgRect.Transforms resulted in a null value.");
            return this;
        }
        public SvgRect Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        }

        public SvgRect HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgRect.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgRect
    {
        public EndSvgRect()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("rect");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
