using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// 
    /// </summary>
    public class SvgText : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgText"/> class.
        /// </summary>
        public SvgText()
        {
            _tagName="text";
            _attributeStack=new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = true;
        }
        /// <id/>
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public SvgText Id(string id)
        {
            if (this == null) throw new Exception("Method SvgText.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgText XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgText.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgText XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgText.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgText XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgText.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgText CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgText.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgText Style(string style)
        {
            if (this == null) throw new Exception("Method SvgText.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgText Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgText.Style resulted in a null value.");
            return this;
        }
        /// <X_double/>
        /// <summary>
        /// The x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x">double [Coordinate]</param>
        /// <returns></returns>
        public SvgText X(double x)
        {
            if (this == null) throw new Exception("Method SvgText.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        /// <Y_double/>
        /// <summary>
        /// The y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y">double [Coordinate]</param>
        /// <returns></returns>
        public SvgText Y(double y)
        {
            if (this == null) throw new Exception("Method SvgText.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        /// <DX_double/>
        /// <summary>
        /// Shifts in the current text position along the x-axis for the characters within this element or any of its descendants. 
        /// </summary>
        /// <param name="dx">double [length]</param>
        /// <returns></returns>
        public SvgText DX(double dx)
        {
            if (this == null) throw new Exception("Method SvgText.DX resulted in a null value.");
            _attributeStack.Add(@"dx=""" + dx + @"""");
            return this;
        }
        /// <DY_double/>
        /// <summary>
        /// Shifts in the current text position along the y-axis for the characters within this element or any of its descendants. 
        /// </summary>
        /// <param name="dy">double [length]</param>
        /// <returns></returns>
        public SvgText DY(double dy)
        {
            if (this == null) throw new Exception("Method SvgText.DY resulted in a null value.");
            _attributeStack.Add(@"dy=""" + dy + @"""");
            return this;
        }
        /// <Rotate_double/>
        /// <summary>
        /// <para>The supplemental rotation about the current text position that will be applied to</para>
        /// <para>all of the glyphs corresponding to each character within this element.</para> 
        /// </summary>
        /// <param name="rotate">double [number]</param>
        /// <returns></returns>
        public SvgText Rotate(double rotate)
        {
            if (this == null) throw new Exception("Method SvgText.Rotate resulted in a null value.");
            _attributeStack.Add(@"rotate=""" + rotate + @"""");
            return this;
        }
        /// <summary>
        /// The purpose of this attribute is to allow the author to achieve exact alignment 
        /// </summary>
        /// <param name="textLength">[length]</param>
        /// <returns></returns>
        public SvgText TextLength(string textLength)
        {
            if (this == null) throw new Exception("Method SvgText.TextLength resulted in a null value.");
            _attributeStack.Add(@"textLength=""" + textLength + @"""");
            return this;
        }
        /// <summary>
        /// Indicates the type of adjustments which the user agent shall make 
        /// </summary>
        /// <param name="lengthAdjust">spacing ~ spacingAndGlyphs</param>
        /// <returns></returns>
        public SvgText LengthAdjust(string lengthAdjust)
        {
            if (this == null) throw new Exception("Method SvgText.LengthAdjust resulted in a null value.");
            _attributeStack.Add(@"lengthAdjust=""" + lengthAdjust + @"""");
            return this;
        }
        /// <X_string/>
        /// <summary>
        /// The x-axis coordinate of the SVG element 
        /// </summary>
        /// <param name="x">string [Coordinate]</param>
        /// <returns></returns>
        public SvgText X(string x)
        {
            if (this == null) throw new Exception("Method SvgText.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        /// <Y_string/>
        /// <summary>
        /// The y-axis coordinate of the SVG element
        /// </summary>
        /// <param name="y">string [Coordinate]</param>
        /// <returns></returns>
        public SvgText Y(string y)
        {
            if (this == null) throw new Exception("Method SvgText.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        /// <DX_string/>
        /// <summary>
        /// Shifts in the current text position along the x-axis for the characters within this element or any of its descendants. 
        /// </summary>
        /// <param name="dx">string [length]</param>
        /// <returns></returns>
        public SvgText DX(string dx)
        {
            if (this == null) throw new Exception("Method SvgText.DX resulted in a null value.");
            _attributeStack.Add(@"dx=""" + dx + @"""");
            return this;
        }
        /// <DY_string/>
        /// <summary>
        /// Shifts in the current text position along the y-axis for the characters within this element or any of its descendants. 
        /// </summary>
        /// <param name="dy">string [length]</param>
        /// <returns></returns>
        public SvgText DY(string dy)
        {
            if (this == null) throw new Exception("Method SvgText.DY resulted in a null value.");
            _attributeStack.Add(@"dy=""" + dy + @"""");
            return this;
        }
        /// <Rotate_string/>
        /// <summary>
        /// <para>The supplemental rotation about the current text position that will be applied to</para>
        /// <para>all of the glyphs corresponding to each character within this element.</para> 
        /// </summary>
        /// <param name="rotate">string [number]</param>
        /// <returns></returns>
        public SvgText Rotate(string rotate)
        {
            if (this == null) throw new Exception("Method SvgText.Rotate resulted in a null value.");
            _attributeStack.Add(@"rotate=""" + rotate + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgText Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgText.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public SvgText Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgText.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgText Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        } 
    }

    /// <summary>
    /// Text end tag
    /// </summary>
    public class EndSvgText
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgText"/> class.
        /// </summary>
        public EndSvgText()
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
            TagBuilder tag = new TagBuilder("text");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
