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
    public class SvgRadialGradient : SvgElementBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRadialGradient"/> class.
        /// </summary>
        public SvgRadialGradient()
        {
            _tagName = "radialGradient";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _styles = new List<SvgStyle>();
        }
        /// <id/>
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public SvgRadialGradient Id(string id)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgRadialGradient XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgRadialGradient XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgRadialGradient XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgRadialGradient CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgRadialGradient Style(string style)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgRadialGradient Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgRadialGradient.Style resulted in a null value.");
            return this;
        }
        /// <CX_double/>
        /// <summary>
        /// ‘cx’, ‘cy’ and ‘r’ define the largest (i.e., outermost) circle for the radial gradient. 
        /// </summary>
        /// <param name="cx">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient CX(double cx)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx.ToString() + @"""");
            return this;
        }
        /// <CY_double/>
        /// <summary>
        /// ‘cx’, ‘cy’ and ‘r’ define the largest (i.e., outermost) circle for the radial gradient. 
        /// </summary>
        /// <param name="cy">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient CY(double cy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy.ToString() + @"""");
            return this;
        }
        /// <FX_double/>
        /// <summary>
        /// ‘fx’ and ‘fy’ define the focal point for the radial gradient. 
        /// </summary>
        /// <param name="fx">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient FX(double fx)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.FX resulted in a null value.");
            _attributeStack.Add(@"fx=""" + fx.ToString() + @"""");
            return this;
        }
        /// <FY_double/>
        /// <summary>
        /// ‘fx’ and ‘fy’ define the focal point for the radial gradient. 
        /// </summary>
        /// <param name="fy">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient FY(double fy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.fy resulted in a null value.");
            _attributeStack.Add(@"fy=""" + fy.ToString() + @"""");
            return this;
        }
        /// <r_double/>
        /// <summary>
        /// ‘cx’, ‘cy’ and ‘r’ define the largest (i.e., outermost) circle for the radial gradient. 
        /// </summary>
        /// <param name="r">[length]</param>
        /// <returns></returns>
        public SvgRadialGradient R(double r)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + r.ToString() + @"""");
            return this;
        }
        /// <CX_string/>
        /// <summary>
        /// ‘cx’, ‘cy’ and ‘r’ define the largest (i.e., outermost) circle for the radial gradient. 
        /// </summary>
        /// <param name="cx">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient CX(string cx)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CX resulted in a null value.");
            _attributeStack.Add(@"cx=""" + cx + @"""");
            return this;
        }
        /// <CY_string/>
        /// <summary>
        /// ‘cx’, ‘cy’ and ‘r’ define the largest (i.e., outermost) circle for the radial gradient. 
        /// </summary>
        /// <param name="cy">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient CY(string cy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.CY resulted in a null value.");
            _attributeStack.Add(@"cy=""" + cy + @"""");
            return this;
        }
        /// <FX_double/>
        /// <summary>
        /// ‘fx’ and ‘fy’ define the focal point for the radial gradient. 
        /// </summary>
        /// <param name="fx">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient FX(string fx)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.FX resulted in a null value.");
            _attributeStack.Add(@"fx=""" + fx + @"""");
            return this;
        }
        /// <FY_double/>
        /// <summary>
        /// ‘fx’ and ‘fy’ define the focal point for the radial gradient. 
        /// </summary>
        /// <param name="fy">[coordinate]</param>
        /// <returns></returns>
        public SvgRadialGradient FY(string fy)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.fy resulted in a null value.");
            _attributeStack.Add(@"fy=""" + fy + @"""");
            return this;
        }
        /// <r_string/>
        /// <summary>
        /// ‘cx’, ‘cy’ and ‘r’ define the largest (i.e., outermost) circle for the radial gradient. 
        /// </summary>
        /// <param name="r">[length]</param>
        /// <returns></returns>
        public SvgRadialGradient R(string r)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.R resulted in a null value.");
            _attributeStack.Add(@"r=""" + r + @"""");
            return this;
        }
        /// <GradientUnits/>
        /// <summary>
        /// Defines the coordinate system for attributes ‘cx’, ‘cy’, ‘r’, ‘fx’ and ‘fy’. 
        /// </summary>
        /// <param name="gradientUnits">userSpaceOnUse | objectBoundingBox</param>
        /// <returns></returns>
        public SvgRadialGradient GradientUnits(string gradientUnits)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.GradientUnits resulted in a null value.");
            _attributeStack.Add(@"gradientUnits=""" + gradientUnits + @"""");
            return this;
        }
        /// <GradientTransforms/>
        /// <summary>
        /// Contains the definitions of an optional additional transformation from the gradient coordinate system onto the target coordinate system  
        /// </summary>
        /// <param name="gradientTransform">[Transform list]</param>
        /// <returns></returns>
        public SvgRadialGradient GradientTransform(string gradientTransform)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.GradientTransform resulted in a null value.");
            _attributeStack.Add(@"gradientTransform=""" + gradientTransform + @"""");
            return this;
        }
        /// <SpreadMethod/>
        /// <summary>
        /// Indicates what happens if the gradient starts or ends inside the bounds of the object(s) being painted by the gradient. 
        /// </summary>
        /// <param name="spreadMethod">pad | reflect | repeat</param>
        /// <returns></returns>
        public SvgRadialGradient SpreadMethod(string spreadMethod)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.SpreadMethod resulted in a null value.");
            _attributeStack.Add(@"spreadMethod=""" + spreadMethod + @"""");
            return this;
        }
        /// <XlinkHref/>
        /// <summary>
        /// A IRI reference to an element whose character data content shall be used as character data for this ‘tref’ element. 
        /// </summary>
        /// <param name="xlink_href">IRI reference</param>
        /// <returns></returns>
        public SvgRadialGradient XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgRadialGradient.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgRadialGradient Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgRadialGradient.Presentation resulted in a null value.");
            return this;
        }
        /// <HasChildNodes/>
        /// <summary>
        /// Indicates if the Svg element has child nodes.
        /// </summary>
        /// <param name="hasChildNode">if set to <c>true</c> [has child node].</param>
        /// <returns></returns>
        public SvgRadialGradient HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgRadialGradient.HasChildNode resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// End radialgradient tag
    /// </summary>
    public class EndSvgRadialGradient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgRadialGradient"/> class.
        /// </summary>
        public EndSvgRadialGradient()
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
            TagBuilder tag = new TagBuilder("radialGradient");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
