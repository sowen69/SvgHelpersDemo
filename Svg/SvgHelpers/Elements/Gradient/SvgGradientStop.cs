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
    public class SvgGradientStop : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgGradientStop"/> class.
        /// </summary>
        public SvgGradientStop()
        {
            _tagName = "stop";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _styles = new List<SvgStyle>();
            //_events = new List<SvgEvent>();
        }
        /// <id/>
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public SvgGradientStop Id(string id)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgGradientStop XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgGradientStop XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgGradientStop XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgGradientStop CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgGradientStop Style(string style)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgGradientStop Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgGradientStop.Style resulted in a null value.");
            return this;
        }
        /// <Offset/>
        /// <summary>
        /// indicates where the gradient stop is placed.  
        /// </summary>
        /// <param name="offset">[number (0-1)] | [percentage (0% - 100%)]</param>
        /// <returns></returns>
        public SvgGradientStop Offset(string offset)
        {
            if (this == null) throw new Exception("Method SvgGradientStop.Offset resulted in a null value.");
            _attributeStack.Add(@"offset=""" + offset + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgGradientStop Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgGradientStop.Presentation resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgGradientStop HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgGradientStop.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// End gradient stop tag
    /// </summary>
    public class EndSvgGradientStop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgGradientStop"/> class.
        /// </summary>
        public EndSvgGradientStop()
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
            TagBuilder tag = new TagBuilder("stop");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
