using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// 
    /// </summary>
    public class SvgUse: SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgUse"/> class.
        /// </summary>
        public SvgUse()
        {
            _tagName = "use";
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
        public SvgUse Id(string id)
        {
            if (this == null) throw new Exception("Method SvgUse.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgUse XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgUse.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgUse XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgUse.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgUse XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgUse.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgUse CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgUse.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgUse Style(string style)
        {
            if (this == null) throw new Exception("Method SvgUse.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style.ToString() + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgUse Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgUse.Style resulted in a null value.");
            return this;
        }
        /// <X_double/>
        /// <summary>
        /// The x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x">double [Coordinate]</param>
        /// <returns></returns>
        public SvgUse X(double x)
        {
            if (this == null) throw new Exception("Method SvgUse.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x.ToString() + @"""");
            return this;
        }
        /// <Y_double/>
        /// <summary>
        /// The y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y">double [Coordinate]</param>
        /// <returns></returns>
        public SvgUse Y(double y)
        {
            if (this == null) throw new Exception("Method SvgUse.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y.ToString() + @"""");
            return this;
        }
        /// <Height_double/>
        /// <summary>
        /// The height of the SVG element 
        /// </summary>
        /// <param name="height">double [length]</param>
        /// <returns></returns>
        public SvgUse Height(double height)
        {
            if (this == null) throw new Exception("Method SvgUse.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height.ToString() + @"""");
            return this;
        }
        /// <Width_double/>
        /// <summary>
        /// The width of the SVG element 
        /// </summary>
        /// <param name="width">double [length]</param>
        /// <returns></returns>
        public SvgUse Width(double width)
        {
            if (this == null) throw new Exception("Method SvgUse.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width.ToString() + @"""");
            return this;
        }
        /// <X_string/>
        /// <summary>
        /// The x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x">string [Coordinate]</param>
        /// <returns></returns>
        public SvgUse X(string x)
        {
            if (this == null) throw new Exception("Method SvgUse.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        /// <Y_string/>
        /// <summary>
        /// The y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y">string [Coordinate]</param>
        /// <returns></returns>
        public SvgUse Y(string y)
        {
            if (this == null) throw new Exception("Method SvgUse.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        /// <Height_string/>
        /// <summary>
        /// The height of the SVG element 
        /// </summary>
        /// <param name="height">string [length]</param>
        /// <returns></returns>
        public SvgUse Height(string height)
        {
            if (this == null) throw new Exception("Method SvgUse.Height resulted in a null value.");
            _attributeStack.Add(@"height=""" + height + @"""");
            return this;
        }
        /// <Width_string/>
        /// <summary>
        /// The width of the SVG element 
        /// </summary>
        /// <param name="width">string [length]</param>
        /// <returns></returns>
        public SvgUse Width(string width)
        {
            if (this == null) throw new Exception("Method SvgUse.Width resulted in a null value.");
            _attributeStack.Add(@"width=""" + width + @"""");
            return this;
        }
        /// <XlinkHref/>
        /// <summary>
        /// A IRI reference to an element whose character data content shall be used as character data for this ‘tref’ element. 
        /// </summary>
        /// <param name="xlink_href">IRI reference</param>
        /// <returns></returns>
        public SvgUse XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgUse.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgUse Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgUse.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgUse Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgUse.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgUse Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgUse.Events resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// Use end tag
    /// </summary>
    public class EndSvgUse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgUse"/> class.
        /// </summary>
        public EndSvgUse()
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
            TagBuilder tag = new TagBuilder("use");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}