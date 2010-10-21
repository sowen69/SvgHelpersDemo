using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Open a Polyline tag, self closing unless otherwise specified.
    /// </summary>
    public class SvgPolyline : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgPolyline"/> class.
        /// </summary>
        public SvgPolyline()
        {
            _tagName = "polyline";
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
        public SvgPolyline Id(string id)
        {
            if (this == null) throw new Exception("Method SvgPolyline.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgPolyline XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgPolyline.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgPolyline XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgPolyline.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgPolyline XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgPolyline.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgPolyline CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgPolyline.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgPolyline Style(string style)
        {
            if (this == null) throw new Exception("Method SvgPolyline.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgPolyline Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgPolyline.Style resulted in a null value.");
            return this;
        }
        /// <Points/>
        /// <summary>
        /// The points that make up the polygon.
        /// </summary>
        /// <param name="points">[list of points]</param>
        /// <returns></returns>
        public SvgPolyline Points(string points)
        {
            if (this == null) throw new Exception("Method SvgPolyline.Points resulted in a null value.");
            _attributeStack.Add(@"points=""" + points + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgPolyline Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgPolyline.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgPolyline Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgPolyline.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgPolyline Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgPolyline.Events resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgPolyline HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgPolyline.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// Closes a Polyline tag if not self closing
    /// </summary>
    public class EndSvgPolyline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgPolyline"/> class.
        /// </summary>
        public EndSvgPolyline()
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
            TagBuilder tag = new TagBuilder("polyline");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
