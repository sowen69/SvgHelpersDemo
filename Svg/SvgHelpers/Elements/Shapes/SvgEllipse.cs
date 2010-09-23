using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgEllipse : SvgElementBase
    {
        public SvgEllipse()
        {
            _tagName = "ellipse";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }
        public SvgEllipse Id(string id)
        {
            base._id = id;
            if (this == null) throw new Exception("Method SvgEllipse.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgEllipse XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgEllipse.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgEllipse XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgEllipse.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgEllipse XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgEllipse.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgEllipse CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgEllipse.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgEllipse Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgEllipse.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgEllipse Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgEllipse.Style resulted in a null value.");
            return this;
        }
        

        public SvgEllipse CX(double cx)
        {
            this._cx = cx;
            if (this == null) throw new Exception("Method SvgEllipse.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + _cx + @"""");
            return this;
        }
        public SvgEllipse CY(double cy)
        {
            this._cy = cy;
            if (this == null) throw new Exception("Method SvgEllipse.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + _cy + @"""");
            return this;
        }
        public SvgEllipse RX(double rx)
        {
            this._rx = rx;
            if (this == null) throw new Exception("Method SvgEllipse.RX resulted in a null value.");
            _attributeStack.Add(@"rx=""" + _rx + @"""");
            return this;
        }
        public SvgEllipse RY(double ry)
        {
            this._ry = ry;
            if (this == null) throw new Exception("Method SvgEllipse.RY resulted in a null value.");
            _attributeStack.Add(@"ry=""" + _ry + @"""");
            return this;
        }

        public SvgEllipse Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgEllipse.Presentation resulted in a null value.");
            return this;
        }
        public SvgEllipse Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgEllipse.Transforms resulted in a null value.");
            return this;
        }
        public SvgEllipse Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgEllipse.Events resulted in a null value.");
            return this;
        }

        public SvgEllipse HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgEllipse.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgEllipse
    {
        public EndSvgEllipse()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("ellipse");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
