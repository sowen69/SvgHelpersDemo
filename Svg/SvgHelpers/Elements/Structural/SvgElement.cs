using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Odd.Svg.SvgHelpers
{
    public class BeginSvg: SvgElementBase
    {
        public BeginSvg()
        {
            _tagName = "svg";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = true;

         
        }
        
        public BeginSvg xlink()
        {
            _xlink = true;
            return this;
        }

        public BeginSvg Id(string id)
        {
            if (this == null) throw new Exception("Method BeginSvg.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public BeginSvg XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method BeginSvg.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public BeginSvg XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method BeginSvg.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public BeginSvg XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method BeginSvg.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public BeginSvg CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method BeginSvg.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass.ToString() + @"""");
            return this;
        }
        public BeginSvg Style(string style)
        {
            if (this == null) throw new Exception("Method BeginSvg.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style.ToString() + @"""");
            return this;
        }
        public BeginSvg Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method BeginSvg.Style resulted in a null value.");
            return this;
        }

        public BeginSvg X(double x)
        {
            if (this == null) throw new Exception("Method BeginSvg.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x.ToString() + @"""");
            return this;
        }
        public BeginSvg Y(double y)
        {
            if (this == null) throw new Exception("Method BeginSvg.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y.ToString() + @"""");
            return this;
        }
        public BeginSvg Height(double height)
        {
            if (this == null) throw new Exception("Method BeginSvg.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height.ToString() + @"""");
            return this;
        }
        public BeginSvg Width(double width)
        {
            if (this == null) throw new Exception("Method BeginSvg.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width.ToString() + @"""");
            return this;
        }
        
        public BeginSvg X(string x)
        {
            if (this == null) throw new Exception("Method BeginSvg.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        public BeginSvg Y(string y)
        {
            if (this == null) throw new Exception("Method BeginSvg.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        public BeginSvg Height(string height)
        {
            if (this == null) throw new Exception("Method BeginSvg.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height + @"""");
            return this;
        }
        public BeginSvg Width(string width)
        {
            if (this == null) throw new Exception("Method BeginSvg.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width + @"""");
            return this;
        }

        //public BeginSvg PreserveAspectRatio(string preserveAspectRatio)
        //{
        //    this._preserveAspectRatio = preserveAspectRatio;
        //    if (this == null) throw new Exception("Method BeginSvg.PreserveAspectRatio resulted in a null value.");
        //    return this;
        //}
        //public BeginSvg ViewBox(string viewBox)
        //{
        //    this._viewBox = viewBox;
        //    if (this == null) throw new Exception("Method BeginSvg.ViewBox resulted in a null value.");
        //    return this;
        //}

        public BeginSvg Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method BeginSvg.Presentation resulted in a null value.");
            return this;
        }
        public BeginSvg Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method BeginSvg.Transforms resulted in a null value.");
            return this;
        }
        public BeginSvg Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method BeginSvg.Events resulted in a null value.");
            return this;
        }
    }

    public class EndSvg
    {
        public EndSvg()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("svg");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}