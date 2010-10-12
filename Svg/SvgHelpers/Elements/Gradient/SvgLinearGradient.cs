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
    public class SvgLinearGradient : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgLinearGradient"/> class.
        /// </summary>
        public SvgLinearGradient()
        {
            _tagName = "linearGradient";
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
        public SvgLinearGradient Id(string id)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgLinearGradient XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgLinearGradient XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgLinearGradient XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgLinearGradient CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgLinearGradient Style(string style)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgLinearGradient Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgLinearGradient.Style resulted in a null value.");
            return this;
        }
        /// <X1_double/>
        /// <summary>
        /// The start x-axis coordinate of the SVG gradient
        /// </summary>
        /// <param name="x1">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient X1(double x1)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.X1 resulted in a null value.");
            _attributeStack.Add(@"x1=""" + x1.ToString() + @"""");
            return this;
        }
        /// <Y1_double/>
        /// <summary>
        /// The start y-axis coordinate of the SVG gradient
        /// </summary>
        /// <param name="y1">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient Y1(double y1)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.Y1 resulted in a null value.");
            _attributeStack.Add(@"y1=""" + y1.ToString() + @"""");
            return this;
        }
        /// <X2_double/>
        /// <summary>
        /// The end x-axis coordinate of the SVG gradient 
        /// </summary>
        /// <param name="x2">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient X2(double x2)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.X2 resulted in a null value.");
            _attributeStack.Add(@"x2=""" + x2.ToString() + @"""");
            return this;
        }    
        /// <Y2_double/>
        /// <summary>
        /// The end y-axis coordinate of the SVG gradient
        /// </summary>
        /// <param name="y2">double [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient Y2(double y2)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.y2 resulted in a null value.");
            _attributeStack.Add(@"y2=""" + y2.ToString() + @"""");
            return this;
        }
        /// <X1_string/>
        /// <summary>
        /// The start x-axis coordinate of the SVG gradient
        /// </summary>
        /// <param name="x1">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient X1(string x1)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.X1 resulted in a null value.");
            _attributeStack.Add(@"x1=""" + x1 + @"""");
            return this;
        }
        /// <Y1_string/>
        /// <summary>
        /// The start y-axis coordinate of the SVG gradient
        /// </summary>
        /// <param name="y1">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient Y1(string y1)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.Y1 resulted in a null value.");
            _attributeStack.Add(@"y1=""" + y1 + @"""");
            return this;
        }
        /// <X2_string/>
        /// <summary>
        /// The end x-axis coordinate of the SVG gradient 
        /// </summary>
        /// <param name="x2">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient X2(string x2)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.X2 resulted in a null value.");
            _attributeStack.Add(@"x2=""" + x2 + @"""");
            return this;
        }
        /// <Y2_string/>
        /// <summary>
        /// The end y-axis coordinate of the SVG gradient
        /// </summary>
        /// <param name="y2">string [Coordinate]</param>
        /// <returns></returns>
        public SvgLinearGradient Y2(string y2)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.y2 resulted in a null value.");
            _attributeStack.Add(@"y2=""" + y2 + @"""");
            return this;
        }
        /// <GradientUnits/>
        /// <summary>
        /// Defines the coordinate system for attributes ‘cx’, ‘cy’, ‘r’, ‘fx’ and ‘fy’. 
        /// </summary>
        /// <param name="gradientUnits">userSpaceOnUse | objectBoundingBox</param>
        /// <returns></returns>
        public SvgLinearGradient GradientUnits(string gradientUnits)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.GradientUnits resulted in a null value.");
            _attributeStack.Add(@"gradientUnits=""" + gradientUnits + @"""");
            return this;
        }
        /// <GradientTransforms/>
        /// <summary>
        /// Contains the definitions of an optional additional transformation from the gradient coordinate system onto the target coordinate system  
        /// </summary>
        /// <param name="gradientTransform">[Transform list]</param>
        /// <returns></returns>
        public SvgLinearGradient GradientTransform(string gradientTransform)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.GradientTransform resulted in a null value.");
            _attributeStack.Add(@"gradientTransform=""" + gradientTransform + @"""");
            return this;
        }
        /// <SpreadMethod/>
        /// <summary>
        /// Indicates what happens if the gradient starts or ends inside the bounds of the object(s) being painted by the gradient. 
        /// </summary>
        /// <param name="spreadMethod">pad | reflect | repeat</param>
        /// <returns></returns>
        public SvgLinearGradient SpreadMethod(string spreadMethod)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.SpreadMethod resulted in a null value.");
            _attributeStack.Add(@"spreadMethod=""" + spreadMethod + @"""");
            return this;
        }
        /// <XlinkHref/>
        /// <summary>
        /// A IRI reference to an element whose character data content shall be used as character data for this ‘tref’ element. 
        /// </summary>
        /// <param name="xlink_href">IRI reference</param>
        /// <returns></returns>
        public SvgLinearGradient XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgLinearGradient.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgLinearGradient Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgLinearGradient.Presentation resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgLinearGradient HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgLinearGradient.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// End liniergradient tag
    /// </summary>
    public class EndSvgLinearGradient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgLinearGradient"/> class.
        /// </summary>
        public EndSvgLinearGradient()
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
            TagBuilder tag = new TagBuilder("linearGradient");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
