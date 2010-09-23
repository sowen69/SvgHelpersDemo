using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgCircle : SvgElementBase
    {
        public SvgCircle()
        {
            _tagName = "circle";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }



        public SvgCircle Id(string id)
        {
            this._id = id;
            if (this == null) throw new Exception("Method SvgCircle.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgCircle XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgCircle.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgCircle XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgCircle.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgCircle XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgCircle.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgCircle CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgCircle.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgCircle Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgCircle.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgCircle Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgCircle.Style resulted in a null value.");
            return this;
        }
        public SvgCircle CX(double cx)
        {
            this._cx = cx;
            if (this == null) throw new Exception("Method SvgCircle.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + _cx.ToString() + @"""");
            return this;
        }
        public SvgCircle CY(double cy)
        {
            this._cy = cy;
            if (this == null) throw new Exception("Method SvgCircle.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + _cy.ToString() + @"""");
            return this;
        }
        public SvgCircle R(double r)
        {
            this._r = r;
            if (this == null) throw new Exception("Method SvgCircle.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + _r.ToString() + @"""");
            return this;
        }

        public SvgCircle Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgCircle.Presentation resulted in a null value.");
            return this;
        }
        public SvgCircle Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgCircle.Transforms resulted in a null value.");
            return this;
        }
        public SvgCircle Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        }

        public SvgCircle HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgCircle.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgCircle
    {
        public EndSvgCircle()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("circle");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
