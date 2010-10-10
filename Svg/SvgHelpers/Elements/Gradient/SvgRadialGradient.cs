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
        }

        public SvgRadialGradient Id(string id)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgRadialGradient XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgRadialGradient XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgRadialGradient XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgRadialGradient CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgRadialGradient Style(string style)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
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
            if (this == null) throw new Exception("Method SvgRadialGradient.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx.ToString() + @"""");
            return this;
        }
        public SvgRadialGradient CY(double cy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy.ToString() + @"""");
            return this;
        }
        public SvgRadialGradient FX(double fx)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.FX resulted in a null value.");
            _attributeStack.Add(@"fx=""" + fx.ToString() + @"""");
            return this;
        }     
        public SvgRadialGradient FY(double fy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.fy resulted in a null value.");
            _attributeStack.Add(@"fy=""" + fy.ToString() + @"""");
            return this;
        }
        public SvgRadialGradient R(double r)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + r.ToString() + @"""");
            return this;
        }

        public SvgRadialGradient CX(string cx)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx + @"""");
            return this;
        }
        public SvgRadialGradient CY(string cy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy + @"""");
            return this;
        }
        public SvgRadialGradient FX(string fx)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.FX resulted in a null value.");
            _attributeStack.Add(@"fx=""" + fx + @"""");
            return this;
        }
        public SvgRadialGradient FY(string fy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.fy resulted in a null value.");
            _attributeStack.Add(@"fy=""" + fy + @"""");
            return this;
        }
        public SvgRadialGradient R(string r)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + r + @"""");
            return this;
        }

        public SvgRadialGradient GradientUnits(string gradientUnits)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.GradientUnits resulted in a null value.");
            _attributeStack.Add(@"gradientUnits=""" + gradientUnits + @"""");
            return this;
        }
        public SvgRadialGradient GradientTransform(string gradientTransform)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.GradientTransform resulted in a null value.");
            _attributeStack.Add(@"gradientTransform=""" + gradientTransform + @"""");
            return this;
        }
        public SvgRadialGradient SpreadMethod(string spreadMethod)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.SpreadMethod resulted in a null value.");
            _attributeStack.Add(@"spreadMethod=""" + spreadMethod + @"""");
            return this;
        }

        public SvgRadialGradient XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
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
