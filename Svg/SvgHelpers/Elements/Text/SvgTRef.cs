using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Opens an Svg TRef tag, self closing if not otherwise specified.
    /// </summary>
    public class SvgTRef : SvgElementBase
    {

        // tref is unsupported as of IE9 Beta 1 and Firefox 4 beta 6

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgTRef"/> class.
        /// </summary>
        public SvgTRef()
        {
            _tagName="tref";
            _attributeStack=new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = false;
        }
        /// <id/>
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public SvgTRef Id(string id)
        {
            if (this == null) throw new Exception("Method SvgTRef.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgTRef XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgTRef.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgTRef XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgTRef.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgTRef XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgTRef.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <XlinkHref/>
        /// <summary>
        /// A IRI reference to an element whose character data content shall be used as character data for this ‘tref’ element. 
        /// </summary>
        /// <param name="xlink_href">IRI reference</param>
        /// <returns></returns>
        public SvgTRef XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
            return this;
        }
        ///<XlinkShow/>
        /// <summary>
        /// This attribute is provided for backwards compatibility with SVG 1.1 
        /// </summary>
        /// <param name="xlink_show">new | replace | embed | other | none</param>
        /// <returns></returns>
        public SvgTRef XlinkShow(string xlink_show)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkShow resulted in a null value.");
            _attributeStack.Add(@"xlink:show=""" + xlink_show + @"""");
            return this;
        }
        ///<XlinkActuate/>
        /// <summary>
        /// This attribute is provided for backwards compatibility with SVG 1.1 
        /// </summary>
        /// <param name="xlink_actuate">onLoad</param>
        /// <returns></returns>
        public SvgTRef XlinkActuate(string xlink_actuate)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkActuate resulted in a null value.");
            _attributeStack.Add(@"xlink:actuate=""" + xlink_actuate + @"""");
            return this;
        }
        /// <XlinkType/>
        /// <summary>
        /// Identifies the type of XLink being used. 
        /// </summary>
        /// <param name="xlink_type">simple | extended | locator | arc | resource | title | none</param>
        /// <returns></returns>
        public SvgTRef XlinkType(string xlink_type)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkType resulted in a null value.");
            _attributeStack.Add(@"xlink:type=""" + xlink_type + @"""");
            return this;
        }
        /// <XlinkRole/>
        /// <summary>
        /// An optional IRI reference that identifies some resource that describes the intended property. 
        /// </summary>
        /// <param name="xlink_role">[IRI]</param>
        /// <returns></returns>
        public SvgTRef XlinkRole(string xlink_role)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkRole resulted in a null value.");
            _attributeStack.Add(@"xlink:role=""" + xlink_role + @"""");
            return this;
        }
        /// <XlinkArcrole/>
        /// <summary>
        /// An optional IRI reference that identifies some resource that describes the intended property. 
        /// </summary>
        /// <param name="xlink_arcrole">[IRI]</param>
        /// <returns></returns>
        public SvgTRef XlinkArcrole(string xlink_arcrole)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkArcrole resulted in a null value.");
            _attributeStack.Add(@"xlink:arcrole=""" + xlink_arcrole + @"""");
            return this;
        }
        /// <XlinkTitle/>
        /// <summary>
        /// The title attribute shall be used to describe the meaning of a link or resource in a human-readable fashion. 
        /// </summary>
        /// <param name="xlink_title">[string]</param>
        /// <returns></returns>
        public SvgTRef XlinkTitle(string xlink_title)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkTitle resulted in a null value.");
            _attributeStack.Add(@"xlink:title=""" + xlink_title + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgTRef CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgTRef.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgTRef Style(string style)
        {
            if (this == null) throw new Exception("Method SvgTRef.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgTRef Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgTRef.Style resulted in a null value.");
            return this;
        }

        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgTRef Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgTRef.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgTRef Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        } 
    }

    /// <summary>
    /// TRef end tag
    /// </summary>
    public class EndSvgTRef
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgTRef"/> class.
        /// </summary>
        public EndSvgTRef(){
        }
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("tref");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
