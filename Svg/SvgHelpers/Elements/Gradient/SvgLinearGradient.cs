using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgLinearGradient : SvgElementBase
    {

        public SvgLinearGradient()
        {
            _tagName = "linearGradient";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _styles = new List<SvgStyle>();
            //_events = new List<SvgEvent>();
        }

        public SvgLinearGradient Id(string id)
        {
            base._id = id;
            if (this == null) throw new Exception("Method SvgLinearGradient.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgLinearGradient XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgLinearGradient.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgLinearGradient XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgLinearGradient.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgLinearGradient XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgLinearGradient.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgLinearGradient CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgLinearGradient.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgLinearGradient Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgLinearGradient.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgLinearGradient Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgLinearGradient.Style resulted in a null value.");
            return this;
        }
    
        public SvgLinearGradient X1(double x1)
        {
            this._x1 = x1;
            if (this == null) throw new Exception("Method SvgLinearGradient.X1 resulted in a null value.");
            _attributeStack.Add(@"x1=""" + _x1.ToString() + @"""");
            return this;
        }
        public SvgLinearGradient Y1(double y1)
        {
            this._y1 = y1;
            if (this == null) throw new Exception("Method SvgLinearGradient.Y1 resulted in a null value.");
            _attributeStack.Add(@"y1=""" + _y1.ToString() + @"""");
            return this;
        }
        public SvgLinearGradient X2(double x2)
        {
            this._x2 = x2;
            if (this == null) throw new Exception("Method SvgLinearGradient.X2 resulted in a null value.");
            _attributeStack.Add(@"x2=""" + _x2.ToString() + @"""");
            return this;
        }     
        public SvgLinearGradient Y2(double y2)
        {
            this._y2 = y2;
            if (this == null) throw new Exception("Method SvgLinearGradient.y2 resulted in a null value.");
            _attributeStack.Add(@"y2=""" + _y2.ToString() + @"""");
            return this;
        }

        public SvgLinearGradient GradientUnits(string gradientUnits)
        {
            this._gradientUnits = gradientUnits;
            if (this == null) throw new Exception("Method SvgLinearGradient.GradientUnits resulted in a null value.");
            _attributeStack.Add(@"gradientUnits=""" + _gradientUnits + @"""");
            return this;
        }
        public SvgLinearGradient GradientTransform(string gradientTransform)
        {
            this._gradientTransform = gradientTransform;
            if (this == null) throw new Exception("Method SvgLinearGradient.GradientTransform resulted in a null value.");
            _attributeStack.Add(@"gradientTransform=""" + _gradientTransform + @"""");
            return this;
        }
        public SvgLinearGradient SpreadMethod(string spreadMethod)
        {
            this._spreadMethod = spreadMethod;
            if (this == null) throw new Exception("Method SvgLinearGradient.SpreadMethod resulted in a null value.");
            _attributeStack.Add(@"spreadMethod=""" + _spreadMethod + @"""");
            return this;
        }

        public SvgLinearGradient XlinkHref(string xlink_href)
        {
            this._xlink_href = xlink_href;
            if (this == null) throw new Exception("Method SvgLinearGradient.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + _xlink_href + @"""");
            return this;
        }

        public SvgLinearGradient Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgLinearGradient.Presentation resulted in a null value.");
            return this;
        }

        public SvgLinearGradient HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgLinearGradient.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgLinearGradient
    {
        public EndSvgLinearGradient()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("linearGradient");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
