using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgRadialGradient : SvgElementBase
    {

        public SvgRadialGradient()
        {
            _tagName = "radialGradient";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _styles = new List<SvgStyle>();
            //_events = new List<SvgEvent>();
        }

        public SvgRadialGradient Id(string id)
        {
            base._id = id;
            if (this == null) throw new Exception("Method SvgRadialGradient.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgRadialGradient XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgRadialGradient XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgRadialGradient XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgRadialGradient CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgRadialGradient.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgRadialGradient Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgRadialGradient.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgRadialGradient Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgRadialGradient.Style resulted in a null value.");
            return this;
        }
    
        public SvgRadialGradient CX(double cx)
        {
            this._cx = cx;
            if (this == null) throw new Exception("Method SvgRadialGradient.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + _cx.ToString() + @"""");
            return this;
        }
        public SvgRadialGradient CY(double cy)
        {
            this._cy = cy;
            if (this == null) throw new Exception("Method SvgRadialGradient.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + _cy.ToString() + @"""");
            return this;
        }
        public SvgRadialGradient FX(double fx)
        {
            this._fx = fx;
            if (this == null) throw new Exception("Method SvgRadialGradient.FX resulted in a null value.");
            _attributeStack.Add(@"fx=""" + _fx.ToString() + @"""");
            return this;
        }     
        public SvgRadialGradient FY(double fy)
        {
            this._fy = fy;
            if (this == null) throw new Exception("Method SvgRadialGradient.fy resulted in a null value.");
            _attributeStack.Add(@"fy=""" + _fy.ToString() + @"""");
            return this;
        }
        public SvgRadialGradient R(double r)
        {
            this._r = r;
            if (this == null) throw new Exception("Method SvgRadialGradient.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + _r.ToString() + @"""");
            return this;
        }

        public SvgRadialGradient GradientUnits(string gradientUnits)
        {
            this._gradientUnits = gradientUnits;
            if (this == null) throw new Exception("Method SvgRadialGradient.GradientUnits resulted in a null value.");
            _attributeStack.Add(@"gradientUnits=""" + _gradientUnits + @"""");
            return this;
        }
        public SvgRadialGradient GradientTransform(string gradientTransform)
        {
            this._gradientTransform = gradientTransform;
            if (this == null) throw new Exception("Method SvgRadialGradient.GradientTransform resulted in a null value.");
            _attributeStack.Add(@"gradientTransform=""" + _gradientTransform + @"""");
            return this;
        }
        public SvgRadialGradient SpreadMethod(string spreadMethod)
        {
            this._spreadMethod = spreadMethod;
            if (this == null) throw new Exception("Method SvgRadialGradient.SpreadMethod resulted in a null value.");
            _attributeStack.Add(@"spreadMethod=""" + _spreadMethod + @"""");
            return this;
        }

        public SvgRadialGradient XlinkHref(string xlink_href)
        {
            this._xlink_href = xlink_href;
            if (this == null) throw new Exception("Method SvgRadialGradient.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + _xlink_href + @"""");
            return this;
        }

        public SvgRadialGradient Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgRadialGradient.Presentation resulted in a null value.");
            return this;
        }

        public SvgRadialGradient HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgRadialGradient.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgRadialGradient
    {
        public EndSvgRadialGradient()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("radialGradient");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
