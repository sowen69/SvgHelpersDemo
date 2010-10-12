using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// 
    /// </summary>
    public class BeginSvgSymbol: SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeginSvgSymbol"/> class.
        /// </summary>
        public BeginSvgSymbol()
        {
            _tagName = "symbol";
            _attributeStack = new List<string>();
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
        public BeginSvgSymbol Id(string id)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public BeginSvgSymbol XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public BeginSvgSymbol XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public BeginSvgSymbol XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public BeginSvgSymbol CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public BeginSvgSymbol Style(string style)
        {
            if (this == null) throw new Exception("Method BeginSvgSymbol.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public BeginSvgSymbol Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Style resulted in a null value.");
            return this;
        }

        //public BeginSvgSymbol PreserveAspectRatio(string preserveAspectRatio)
        //{
        //    this._preserveAspectRatio = preserveAspectRatio;
        //    if (this == null) throw new Exception("Method BeginSvgSymbol.PreserveAspectRatio resulted in a null value.");
        //    return this;
        //}
        //public BeginSvgSymbol ViewBox(string viewBox)
        //{
        //    this._viewBox = viewBox;
        //    if (this == null) throw new Exception("Method BeginSvgSymbol.ViewBox resulted in a null value.");
        //    return this;
        //}
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public BeginSvgSymbol Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgTransform_Collection/>
        /// <summary>
        /// Collection of transform attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="transform">SvgTransform object</param>
        /// <returns></returns>
        public BeginSvgSymbol Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Transforms resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public BeginSvgSymbol Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method BeginSvgSymbol.Events resulted in a null value.");
            return this;
        }
    }

    /// <summary>
    /// Symbol end tag
    /// </summary>
    public class EndSvgSymbol
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgSymbol"/> class.
        /// </summary>
        public EndSvgSymbol()
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
            TagBuilder tag = new TagBuilder("symbol");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}