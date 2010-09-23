using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Odd.Svg.SvgHelpers
{
    public class SvgUse: SvgElementBase
    {
        public SvgUse()
        {
            _tagName = "use";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }

        public SvgUse Id(string id)
        {
            base._id = id;
            if (this == null) throw new Exception("Method SvgUse.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgUse XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgUse.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgUse XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgUse.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgUse XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgUse.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgUse CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgUse.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass.ToString() + @"""");
            return this;
        }
        public SvgUse Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgUse.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style.ToString() + @"""");
            return this;
        }
        public SvgUse Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgUse.Style resulted in a null value.");
            return this;
        }

        public SvgUse X(double x)
        {
            this._x = x;
            if (this == null) throw new Exception("Method SvgUse.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + _x.ToString() + @"""");
            return this;
        }
        public SvgUse Y(double y)
        {
            this._y = y;
            if (this == null) throw new Exception("Method SvgUse.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + _y.ToString() + @"""");
            return this;
        }
        public SvgUse Height(double height)
        {
            this._height = height;
            if (this == null) throw new Exception("Method SvgUse.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + _height.ToString() + @"""");
            return this;
        }
        public SvgUse Width(double width)
        {
            this._width = width;
            if (this == null) throw new Exception("Method SvgUse.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + _width.ToString() + @"""");
            return this;
        }
        
        public SvgUse XlinkHref(string xlink_href)
        {
            this._xlink_href = xlink_href;
            if (this == null) throw new Exception("Method SvgUse.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + _xlink_href + @"""");
            return this;
        }
        public SvgUse Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgUse.Presentation resulted in a null value.");
            return this;
        }
        public SvgUse Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgUse.Transforms resulted in a null value.");
            return this;
        }
        public SvgUse Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgUse.Events resulted in a null value.");
            return this;
        }
    }

    public class EndSvgUse
    {
        public EndSvgUse()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("use");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}