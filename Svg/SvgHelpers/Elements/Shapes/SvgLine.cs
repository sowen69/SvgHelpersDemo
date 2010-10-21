using System.Collections.Generic;
using System.Web.Mvc;
using System;
using System.Reflection;
using System.ComponentModel;
using System.Text;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Open a Line tag, self closing unless otherwise specified.
    /// </summary>
    public class SvgLine : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgLine"/> class.
        /// </summary>
        public SvgLine()
        {
            _tagName = "line";
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
        public SvgLine Id(string id)
        {
            if (this == null) throw new Exception("Method SvgLine.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgLine XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgLine.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgLine XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgLine.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgLine XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgLine.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgLine CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgLine.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgLine Style(string style)
        {
            if (this == null) throw new Exception("Method SvgLine.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgLine Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgLine.Style resulted in a null value.");
            return this;
        }
        /// <X1_double/>
        /// <summary>
        /// The start x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x1">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLine X1(double x1)
        {
            if (this == null) throw new Exception("Method SvgLine.X1 resulted in a null value.");
            _attributeStack.Add(@"x1=""" + x1.ToString() + @"""");
            return this;
        }
        /// <X2_double/>
        /// <summary>
        /// The end x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x2">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLine X2(double x2)
        {
            if (this == null) throw new Exception("Method SvgLine.X2 resulted in a null value.");
            _attributeStack.Add(@"x2=""" + x2.ToString() + @"""");
            return this;
        }
        /// <Y1_double/>
        /// <summary>
        /// The start y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y1">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLine Y1(double y1)
        {
            if (this == null) throw new Exception("Method SvgLine.Y1 resulted in a null value.");
            _attributeStack.Add(@"y1=""" + y1.ToString() + @"""");
            return this;
        }
        /// <Y2_double/>
        /// <summary>
        /// The end y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y2">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLine Y2(double y2)
        {
            if (this == null) throw new Exception("Method SvgLine.Y2 resulted in a null value.");
            _attributeStack.Add(@"y2=""" + y2.ToString() + @"""");
            return this;
        }
        /// <X1_string/>
        /// <summary>
        /// The start x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x1">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLine X1(string x1)
        {
            if (this == null) throw new Exception("Method SvgLine.X1(string) resulted in a null value.");
            _attributeStack.Add(@"x1=""" + x1 + @"""");
            return this;
        }
        /// <X2_string/>
        /// <summary>
        /// The end x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x2">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLine X2(string x2)
        {
            if (this == null) throw new Exception("Method SvgLine.X2(string) resulted in a null value.");
            _attributeStack.Add(@"x2=""" + x2 + @"""");
            return this;
        }
        /// <Y1_string/>
        /// <summary>
        /// The start y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y1">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLine Y1(string y1)
        {
            if (this == null) throw new Exception("Method SvgLine.Y1(string) resulted in a null value.");
            _attributeStack.Add(@"y1=""" + y1 + @"""");
            return this;
        }
        /// <Y2_string/>
        /// <summary>
        /// The end y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y2">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLine Y2(string y2)
        {
            if (this == null) throw new Exception("Method SvgLine.Y2(string) resulted in a null value.");
            _attributeStack.Add(@"y2=""" + y2 + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgLine Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgLine.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgLine Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgLine.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgLine Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgLine.Events resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgLine HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgLine.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// Closes a Line tag if not self closing
    /// </summary>
    public class EndSvgLine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgLine"/> class.
        /// </summary>
        public EndSvgLine()
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
            TagBuilder tag = new TagBuilder("line");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}