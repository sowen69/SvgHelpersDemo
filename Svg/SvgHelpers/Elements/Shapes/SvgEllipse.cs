using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Open an Ellipse tag, self closing unless otherwise specified.
    /// </summary>
    public class SvgEllipse : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgEllipse"/> class.
        /// </summary>
        public SvgEllipse()
        {
            _tagName = "ellipse";
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
        public SvgEllipse Id(string id)
        {
            if (this == null) throw new Exception("Method SvgEllipse.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgEllipse XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgEllipse.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgEllipse XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgEllipse.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgEllipse XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgEllipse.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgEllipse CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgEllipse.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgEllipse Style(string style)
        {
            if (this == null) throw new Exception("Method SvgEllipse.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgEllipse Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgEllipse.Style resulted in a null value.");
            return this;
        }
        /// <CX_double/>
        /// <summary>
        /// The x-axis coordinate of the center of the ellipse. 
        /// </summary>
        /// <param name="cx">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse CX(double cx)
        {
            if (this == null) throw new Exception("Method SvgEllipse.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx + @"""");
            return this;
        }
        /// <CY_double/>
        /// <summary>
        /// The y-axis coordinate of the center of the ellipse. 
        /// </summary>
        /// <param name="cy">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse CY(double cy)
        {
            if (this == null) throw new Exception("Method SvgEllipse.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy + @"""");
            return this;
        }
        /// <RX_double/>
        /// <summary>
        /// The x-axis radius of the ellipse. 
        /// </summary>
        /// <param name="rx">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse RX(double rx)
        {
            if (this == null) throw new Exception("Method SvgEllipse.RX resulted in a null value.");
            _attributeStack.Add(@"rx=""" + rx + @"""");
            return this;
        }
        /// <RY_double/>
        /// <summary>
        /// The y-axis radius of the ellipse. 
        /// </summary>
        /// <param name="ry">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse RY(double ry)
        {
            if (this == null) throw new Exception("Method SvgEllipse.RY resulted in a null value.");
            _attributeStack.Add(@"ry=""" + ry + @"""");
            return this;
        }
        /// <CX_string/>
        /// <summary>
        /// The x-axis coordinate of the center of the ellipse. 
        /// </summary>
        /// <param name="cx">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse CX(string cx)
        {
            if (this == null) throw new Exception("Method SvgEllipse.CX(string) resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx + @"""");
            return this;
        }
        /// <CY_string/>
        /// <summary>
        /// The x-axis coordinate of the center of the ellipse. 
        /// </summary>
        /// <param name="cy">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse CY(string cy)
        {
            if (this == null) throw new Exception("Method SvgEllipse.CY(string) resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy + @"""");
            return this;
        }
        /// <RX_string/>
        /// <summary>
        /// The x-axis radius of the ellipse. 
        /// </summary>
        /// <param name="rx">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse RX(string rx)
        {
            if (this == null) throw new Exception("Method SvgEllipse.RX(string) resulted in a null value.");
            _attributeStack.Add(@"rx=""" + rx + @"""");
            return this;
        }
        /// <RY_string/>
        /// <summary>
        /// The y-axis radius of the ellipse. 
        /// </summary>
        /// <param name="ry">[coordinate]</param>
        /// <returns></returns>
        public SvgEllipse RY(string ry)
        {
            if (this == null) throw new Exception("Method SvgEllipse.RY(string) resulted in a null value.");
            _attributeStack.Add(@"ry=""" + ry + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgEllipse Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgEllipse.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgEllipse Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgEllipse.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgEllipse Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgEllipse.Events resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgEllipse HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgEllipse.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// Closes an Ellipse tag if not self closing
    /// </summary>
    public class EndSvgEllipse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgEllipse"/> class.
        /// </summary>
        public EndSvgEllipse()
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
            TagBuilder tag = new TagBuilder("ellipse");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
