using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgCircle : SvgElementBase
    {
        /// <summary>
        /// Creates an inline SVG circle http://www.w3.org/TR/SVG11/shapes.html#CircleElement
        /// </summary>
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
            if (this == null) throw new Exception("Method SvgCircle.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgCircle XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgCircle.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgCircle XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgCircle.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgCircle XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgCircle.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgCircle CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgCircle.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgCircle Style(string style)
        {
            if (this == null) throw new Exception("Method SvgCircle.Style(string) resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgCircle Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgCircle.Style(<style>) resulted in a null value.");
            return this;
        }
        public SvgCircle CX(double cx)
        {
            if (this == null) throw new Exception("Method SvgCircle.CX(double) resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx.ToString() + @"""");
            return this;
        }
        public SvgCircle CX(string cx)
        {
            if (this == null) throw new Exception("Method SvgCircle.CX(string) resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx + @"""");
            return this;
        }
        public SvgCircle CY(double cy)
        {
            if (this == null) throw new Exception("Method SvgCircle.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy.ToString() + @"""");
            return this;
        }
        public SvgCircle CY(string cy)
        {
            if (this == null) throw new Exception("Method SvgCircle.CY(string) resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy + @"""");
            return this;
        }
        public SvgCircle R(double r)
        {
            if (this == null) throw new Exception("Method SvgCircle.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + r.ToString() + @"""");
            return this;
        }
        public SvgCircle R(string r)
        {
            if (this == null) throw new Exception("Method SvgCircle.R(string) resulted in a null value.");
            _attributeStack.Add(@"r=""" + r + @"""");
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
