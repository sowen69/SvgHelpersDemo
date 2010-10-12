using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// 
    /// </summary>
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
        /// <id/>
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public SvgCircle Id(string id)
        {
            if (this == null) throw new Exception("Method SvgCircle.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgCircle XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgCircle.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgCircle XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgCircle.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgCircle XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgCircle.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgCircle CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgCircle.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgCircle Style(string style)
        {
            if (this == null) throw new Exception("Method SvgCircle.Style(string) resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgCircle Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgCircle.Style(<style>) resulted in a null value.");
            return this;
        }
        /// <CX_double/>
        /// <summary>
        /// The x-axis coordinate of the center of the circle. 
        /// </summary>
        /// <param name="cx">[coordinate]</param>
        /// <returns></returns>
        public SvgCircle CX(double cx)
        {
            if (this == null) throw new Exception("Method SvgCircle.CX(double) resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx.ToString() + @"""");
            return this;
        }
        /// <CX_string/>
        /// <summary>
        /// The x-axis coordinate of the center of the circle. 
        /// </summary>
        /// <param name="cx">[coordinate]</param>
        /// <returns></returns>
        public SvgCircle CX(string cx)
        {
            if (this == null) throw new Exception("Method SvgCircle.CX(string) resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx + @"""");
            return this;
        }
        /// <CY_double/>
        /// <summary>
        /// The y-axis coordinate of the center of the circle. 
        /// </summary>
        /// <param name="cy">[coordinate]</param>
        /// <returns></returns>
        public SvgCircle CY(double cy)
        {
            if (this == null) throw new Exception("Method SvgCircle.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy.ToString() + @"""");
            return this;
        }
        /// <CY_string/>
        /// <summary>
        /// The y-axis coordinate of the center of the circle. 
        /// </summary>
        /// <param name="cy">[coordinate]</param>
        /// <returns></returns>
        public SvgCircle CY(string cy)
        {
            if (this == null) throw new Exception("Method SvgCircle.CY(string) resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy + @"""");
            return this;
        }
        /// <R_double/>
        /// <summary>
        /// The radius of the circle. 
        /// </summary>
        /// <param name="r">[length]</param>
        /// <returns></returns>
        public SvgCircle R(double r)
        {
            if (this == null) throw new Exception("Method SvgCircle.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + r.ToString() + @"""");
            return this;
        }
        /// <R_string/>
        /// <summary>
        /// The radius of the circle. 
        /// </summary>
        /// <param name="r">[length]</param>
        /// <returns></returns>
        public SvgCircle R(string r)
        {
            if (this == null) throw new Exception("Method SvgCircle.R(string) resulted in a null value.");
            _attributeStack.Add(@"r=""" + r + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgCircle Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgCircle.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgCircle Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgCircle.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgCircle Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgCircle HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgCircle.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// End circle tag
    /// </summary>
    public class EndSvgCircle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgCircle"/> class.
        /// </summary>
        public EndSvgCircle()
        {
        }
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("circle");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
