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
            base._id = id;
            if (this == null) throw new Exception("Method SvgRect.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgRect XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgRect.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgRect XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgRect.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgRect XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgRect.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgRect CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgRect.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgRect Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgRect.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
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
            this._x = x;
            if (this == null) throw new Exception("Method SvgRect.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + _x.ToString() + @"""");
            return this;
        }
        public SvgRect Y(double y)
        {
            this._y = y;
            if (this == null) throw new Exception("Method SvgRect.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + _y.ToString() + @"""");
            return this;
        }
        public SvgRect RX(double rx)
        {
            this._rx = rx;
            if (this == null) throw new Exception("Method SvgRect.RX resulted in a null value.");
            _attributeStack.Add(@"rx=""" + _rx.ToString() + @"""");
            return this;
        }     
        public SvgRect RY(double ry)
        {
            this._ry = ry;
            if (this == null) throw new Exception("Method SvgRect.RY resulted in a null value.");
            _attributeStack.Add(@"ry=""" + _ry.ToString() + @"""");
            return this;
        }
        public SvgRect Height(double height)
        {
            this._height = height;
            if (this == null) throw new Exception("Method SvgRect.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + _height.ToString() + @"""");
            return this;
        }
        public SvgRect Width(double width)
        {
            this._width = width;
            if (this == null) throw new Exception("Method SvgRect.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + _width.ToString() + @"""");
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
