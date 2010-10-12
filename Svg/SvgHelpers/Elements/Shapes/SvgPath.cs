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
    public class SvgPath : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgPath"/> class.
        /// </summary>
        public SvgPath()
        {
            _tagName = "path";
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
        public SvgPath Id(string id)
        {
            if (this == null) throw new Exception("Method SvgPath.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgPath XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgPath.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgPath XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgPath.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgPath XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgPath.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgPath CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgPath.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgPath Style(string style)
        {
            if (this == null) throw new Exception("Method SvgPath.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgPath Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgPath.Style resulted in a null value.");
            return this;
        }
        /// <D/>
        /// <summary>
        /// The definition of the outline of a shape.
        /// </summary>
        /// <param name="d">[path data]</param>
        /// <returns></returns>
        public SvgPath D(string d)
        {
            if (this == null) throw new Exception("Method SvgPath.D resulted in a null value.");
            _attributeStack.Add(@"d=""" + d + @"""");
            return this;
        }
        /// <PathLength_double/>
        /// <summary>
        /// The author's computation of the total length of the path, in user units. 
        /// </summary>
        /// <param name="pathLength">[number]</param>
        /// <returns></returns>
        public SvgPath PathLength(double pathLength)
        {
            if (this == null) throw new Exception("Method SvgPath.PathLength resulted in a null value.");
            _attributeStack.Add(@"pathlength=""" + pathLength.ToString() + @"""");
            return this;
        }
        /// <PathLength_string/>
        /// <summary>
        /// The author's computation of the total length of the path, in user units. 
        /// </summary>
        /// <param name="pathLength">[number]</param>
        /// <returns></returns>
        public SvgPath PathLength(string pathLength)
        {
            if (this == null) throw new Exception("Method SvgPath.PathLength(string) resulted in a null value.");
            _attributeStack.Add(@"pathlength=""" + pathLength + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgPath Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgPath.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgPath Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgPath.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgPath Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgPath.Events resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgPath HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgPath.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// End path tag
    /// </summary>
    public class EndSvgPath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgPath"/> class.
        /// </summary>
        public EndSvgPath()
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
            TagBuilder tag = new TagBuilder("path");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
