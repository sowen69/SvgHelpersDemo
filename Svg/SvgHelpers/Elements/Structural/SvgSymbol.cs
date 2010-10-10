using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Odd.Svg.SvgHelpers
{
    public class BeginSvgSymbol: SvgElementBase
    {
        public BeginSvgSymbol()
        {
            _tagName = "symbol";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = true;
        }

        public BeginSvgSymbol Id(string id)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public BeginSvgSymbol XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public BeginSvgSymbol XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public BeginSvgSymbol XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public BeginSvgSymbol CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public BeginSvgSymbol Style(string style)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public BeginSvgSymbol Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Style resulted in a null value.");
            return this;
        }

        //public BeginSvgSymbol PreserveAspectRatio(string preserveAspectRatio)
        //{
        //    this._preserveAspectRatio = preserveAspectRatio;
        //    if (this == null) throw new Exception("Method BeginSvgSymbol.PreserveAspectRatio resulted in a null value.");
        //    return this;
        //}
        //public BeginSvgSymbol ViewBox(string viewBox)
        //{
        //    this._viewBox = viewBox;
        //    if (this == null) throw new Exception("Method BeginSvgSymbol.ViewBox resulted in a null value.");
        //    return this;
        //}

        public BeginSvgSymbol Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Presentation resulted in a null value.");
            return this;
        }
        public BeginSvgSymbol Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Transforms resulted in a null value.");
            return this;
        }
        public BeginSvgSymbol Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Events resulted in a null value.");
            return this;
        }
    }

    public class EndSvgSymbol
    {
        public EndSvgSymbol()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("symbol");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}