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
            if (this == null) throw new Exception("Method SvgUse.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgUse XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgUse.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgUse XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgUse.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgUse XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgUse.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgUse CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgUse.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgUse Style(string style)
        {
            if (this == null) throw new Exception("Method SvgUse.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style.ToString() + @"""");
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
            if (this == null) throw new Exception("Method SvgUse.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x.ToString() + @"""");
            return this;
        }
        public SvgUse Y(double y)
        {
            if (this == null) throw new Exception("Method SvgUse.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y.ToString() + @"""");
            return this;
        }
        public SvgUse Height(double height)
        {
            if (this == null) throw new Exception("Method SvgUse.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height.ToString() + @"""");
            return this;
        }
        public SvgUse Width(double width)
        {
            if (this == null) throw new Exception("Method SvgUse.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width.ToString() + @"""");
            return this;
        }

        public SvgUse X(string x)
        {
            if (this == null) throw new Exception("Method SvgUse.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        public SvgUse Y(string y)
        {
            if (this == null) throw new Exception("Method SvgUse.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        public SvgUse Height(string height)
        {
            if (this == null) throw new Exception("Method SvgUse.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height + @"""");
            return this;
        }
        public SvgUse Width(string width)
        {
            if (this == null) throw new Exception("Method SvgUse.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width + @"""");
            return this;
        }
        
        public SvgUse XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgUse.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
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