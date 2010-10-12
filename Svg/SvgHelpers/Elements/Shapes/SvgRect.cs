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
    public class SvgRect : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRect"/> class.
        /// </summary>
        public SvgRect()
        {
            _tagName = "rect";
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
        public SvgRect Id(string id)
        {
            if (this == null) throw new Exception("Method SvgRect.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgRect XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgRect.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgRect XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgRect.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgRect XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgRect.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgRect CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgRect.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgRect Style(string style)
        {
            if (this == null) throw new Exception("Method SvgRect.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgRect Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgRect.Style resulted in a null value.");
            return this;
        }
        /// <X_double/>
        /// <summary>
        /// The x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x">double [Coordinate]</param>
        /// <returns></returns>
        public SvgRect X(double x)
        {
            if (this == null) throw new Exception("Method SvgRect.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x.ToString() + @"""");
            return this;
        }
        /// <Y_double/>
        /// <summary>
        /// The y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y">double [Coordinate]</param>
        /// <returns></returns>
        public SvgRect Y(double y)
        {
            if (this == null) throw new Exception("Method SvgRect.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y.ToString() + @"""");
            return this;
        }
        /// <RX_double/>
        /// <summary>
        /// For rounded rectangles, the x-axis radius of the ellipse used to round off the corners of the rectangle. 
        /// </summary>
        /// <param name="rx">[length]</param>
        /// <returns></returns>
        public SvgRect RX(double rx)
        {
            if (this == null) throw new Exception("Method SvgRect.RX resulted in a null value.");
            _attributeStack.Add(@"rx=""" + rx.ToString() + @"""");
            return this;
        }
        /// <RX_double/>
        /// <summary>
        /// For rounded rectangles, the y-axis radius of the ellipse used to round off the corners of the rectangle. 
        /// </summary>
        /// <param name="ry">[length]</param>
        /// <returns></returns>
        public SvgRect RY(double ry)
        {
            if (this == null) throw new Exception("Method SvgRect.RY resulted in a null value.");
            _attributeStack.Add(@"ry=""" + ry.ToString() + @"""");
            return this;
        }
        /// <Height_double/>
        /// <summary>
        /// The height of the SVG element 
        /// </summary>
        /// <param name="height">double [length]</param>
        /// <returns></returns>
        public SvgRect Height(double height)
        {
            if (this == null) throw new Exception("Method SvgRect.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height.ToString() + @"""");
            return this;
        }
        /// <Width_double/>
        /// <summary>
        /// The width of the SVG element 
        /// </summary>
        /// <param name="width">double [length]</param>
        /// <returns></returns>
        public SvgRect Width(double width)
        {
            if (this == null) throw new Exception("Method SvgRect.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width.ToString() + @"""");
            return this;
        }
        /// <X_string/>
        /// <summary>
        /// The x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x">string [Coordinate]</param>
        /// <returns></returns>
        public SvgRect X(string x)
        {
            if (this == null) throw new Exception("Method SvgRect.X(string) resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        /// <Y_string/>
        /// <summary>
        /// The y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y">string [Coordinate]</param>
        /// <returns></returns>
        public SvgRect Y(string y)
        {
            if (this == null) throw new Exception("Method SvgRect.Y(string) resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        /// <RX_string/>
        /// <summary>
        /// For rounded rectangles, the x-axis radius of the ellipse used to round off the corners of the rectangle. 
        /// </summary>
        /// <param name="rx">[length]</param>
        /// <returns></returns>
        public SvgRect RX(string rx)
        {
            if (this == null) throw new Exception("Method SvgRect.RX(string) resulted in a null value.");
            _attributeStack.Add(@"rx=""" + rx + @"""");
            return this;
        }
        /// <RX_string/>
        /// <summary>
        /// For rounded rectangles, the y-axis radius of the ellipse used to round off the corners of the rectangle. 
        /// </summary>
        /// <param name="ry">[length]</param>
        /// <returns></returns>
        public SvgRect RY(string ry)
        {
            if (this == null) throw new Exception("Method SvgRect.RY(string) resulted in a null value.");
            _attributeStack.Add(@"ry=""" + ry + @"""");
            return this;
        }
        /// <Height_string/>
        /// <summary>
        /// The height of the SVG element 
        /// </summary>
        /// <param name="height">string [length]</param>
        /// <returns></returns>
        public SvgRect Height(string height)
        {
            if (this == null) throw new Exception("Method SvgRect.Height(string) resulted in a null value.");
            _attributeStack.Add(@"height=""" + height + @"""");
            return this;
        }
        /// <Width_string/>
        /// <summary>
        /// The width of the SVG element 
        /// </summary>
        /// <param name="width">string [length]</param>
        /// <returns></returns>
        public SvgRect Width(string width)
        {
            if (this == null) throw new Exception("Method SvgRect.Width(string) resulted in a null value.");
            _attributeStack.Add(@"width=""" + width + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgRect Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgRect.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgRect Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgRect.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgRect Events(SvgEvent svgEvent)
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
        public SvgRect HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgRect.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// End rect tah
    /// </summary>
    public class EndSvgRect
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgRect"/> class.
        /// </summary>
        public EndSvgRect()
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
            TagBuilder tag = new TagBuilder("rect");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
