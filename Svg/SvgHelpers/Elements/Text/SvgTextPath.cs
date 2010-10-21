using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Opens an Svg TextPath tag, self closing if not otherwise specified.
    /// </summary>
    public class SvgTextPath : SvgElementBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgTextPath"/> class.
        /// </summary>
        public SvgTextPath()
        {
            _tagName="textPath";
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
        public SvgTextPath Id(string id)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgTextPath XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgTextPath XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgTextPath XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <XlinkHref/>
        /// <summary>
        /// A IRI reference to an element whose character data content shall be used as character data for this ‘tref’ element. 
        /// </summary>
        /// <param name="xlink_href">IRI reference</param>
        /// <returns></returns>
        public SvgTextPath XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
            return this;
        }
        ///<XlinkShow/>
        /// <summary>
        /// This attribute is provided for backwards compatibility with SVG 1.1 
        /// </summary>
        /// <param name="xlink_show">new | replace | embed | other | none</param>
        /// <returns></returns>
        public SvgTextPath XlinkShow(string xlink_show)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkShow resulted in a null value.");
            _attributeStack.Add(@"xlink:show=""" + xlink_show + @"""");
            return this;
        }
        ///<XlinkActuate/>
        /// <summary>
        /// This attribute is provided for backwards compatibility with SVG 1.1 
        /// </summary>
        /// <param name="xlink_actuate">onLoad</param>
        /// <returns></returns>
        public SvgTextPath XlinkActuate(string xlink_actuate)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkActuate resulted in a null value.");
            _attributeStack.Add(@"xlink:actuate=""" + xlink_actuate + @"""");
            return this;
        }
        /// <XlinkType/>
        /// <summary>
        /// Identifies the type of XLink being used. 
        /// </summary>
        /// <param name="xlink_type">simple | extended | locator | arc | resource | title | none</param>
        /// <returns></returns>
        public SvgTextPath XlinkType(string xlink_type)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkType resulted in a null value.");
            _attributeStack.Add(@"xlink:type=""" + xlink_type + @"""");
            return this;
        }
        /// <XlinkRole/>
        /// <summary>
        /// An optional IRI reference that identifies some resource that describes the intended property. 
        /// </summary>
        /// <param name="xlink_arcrole">[IRI]</param>
        /// <returns></returns>
        public SvgTextPath XlinkArcrole(string xlink_arcrole)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkArcrole resulted in a null value.");
            _attributeStack.Add(@"xlink:arcrole=""" + xlink_arcrole + @"""");
            return this;
        }
        /// <XlinkTitle/>
        /// <summary>
        /// The title attribute shall be used to describe the meaning of a link or resource in a human-readable fashion. 
        /// </summary>
        /// <param name="xlink_title">[string]</param>
        /// <returns></returns>
        public SvgTextPath XlinkTitle(string xlink_title)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkTitle resulted in a null value.");
            _attributeStack.Add(@"xlink:title=""" + xlink_title + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgTextPath CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgTextPath.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgTextPath Style(string style)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_ollection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgTextPath Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgTextPath.Style resulted in a null value.");
            return this;
        }
        /// <StartOffset/>
        /// <summary>
        /// <para>An offset from the start of the ‘path’ for the initial current text position,</para>
        /// <para>calculated using the user agent's distance along the path algorithm.</para>
        /// </summary>
        /// <param name="startOffset">[length]</param>
        /// <returns></returns>
        public SvgTextPath StartOffset(string startOffset)
        {
            if (this == null) throw new Exception("Method SvgTextPath.StartOffset resulted in a null value.");
            _attributeStack.Add(@"startOffset=""" + startOffset + @"""");
            return this;
        }
        /// <method/>
        /// <summary>
        /// Indicates the method by which text should be rendered along the path.
        /// </summary>
        /// <param name="method">align | stretch</param>
        /// <returns></returns>
        public SvgTextPath Method(string method)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Method resulted in a null value.");
            _attributeStack.Add(@"method=""" + method + @"""");
            return this;
        }
        /// <Spacing/>
        /// <summary>
        /// Indicates how the user agent should determine the spacing between glyphs that are to be rendered along a path. 
        /// </summary>
        /// <param name="spacing">auto | exact</param>
        /// <returns></returns>
        public SvgTextPath Spacing(string spacing)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Spacing resulted in a null value.");
            _attributeStack.Add(@"spacing=""" + spacing + @"""");
            return this;
        }
        /// <SvgPresentation_collection/>
        /// <summary>
        /// Collection of presentation attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="presentation">SvgPresentation object</param>
        /// <returns></returns>
        public SvgTextPath Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgTextPath.Presentation resulted in a null value.");
            return this;
        }
        /// <SvgEvent_Collection/>
        /// <summary>
        /// Collection of event attributes to be applied to an SVG element. 
        /// </summary>
        /// <param name="svgEvent">SvgEvent object</param>
        /// <returns></returns>
        public SvgTextPath Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        } 
    }

    /// <summary>
    /// TextPath end tag
    /// </summary>
    public class EndSvgTextPath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgTextPath"/> class.
        /// </summary>
        public EndSvgTextPath()
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
            TagBuilder tag = new TagBuilder("textPath");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
