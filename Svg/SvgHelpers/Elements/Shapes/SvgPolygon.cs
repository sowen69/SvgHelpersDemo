using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Open a Polygon tag, self closing unless otherwise specified.
    /// </summary>
    public class SvgPolygon : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgPolygon"/> class.
        /// </summary>
        public SvgPolygon()
        {
            _tagName = "polygon";
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
        public SvgPolygon Id(string id)
        {
            if (this == null) throw new Exception("Method SvgPolygon.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgPolygon XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgPolygon.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgPolygon XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgPolygon.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgPolygon XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgPolygon.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgPolygon CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgPolygon.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgPolygon Style(string style)
        {
            if (this == null) throw new Exception("Method SvgPolygon.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgPolygon Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgPolygon.Style resulted in a null value.");
            return this;
        }
        /// <Points/>
        /// <summary>
        /// The points that make up the polygon.
        /// </summary>
        /// <param name="points">[list of points]</param>
        /// <returns></returns>
        public SvgPolygon Points(string points)
        {
            if (this == null) throw new Exception("Method SvgPolygon.D resulted in a null value.");
            _attributeStack.Add(@"points=""" + points + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgPolygon Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgPolygon.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgPolygon Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgPolygon.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgPolygon Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgPolygon.Events resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgPolygon HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgPolygon.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// Closes a Polygon tag if not self closing
    /// </summary>
    public class EndSvgPolygon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgPolygon"/> class.
        /// </summary>
        public EndSvgPolygon()
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
            TagBuilder tag = new TagBuilder("polygon");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
