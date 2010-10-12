using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// <para>Each container element or graphics element in an SVG drawing can supply a ‘desc’</para>
    /// <para>description string where the description is text-only and is not rendered</para>
    /// </summary>
    public class SvgDesc
    {
        string _tagName;
        
        // Core Attributes
        IList<SvgStyle> _styles;
        IList<string> _attributeStack;

        string _innerText;

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgDesc"/> class.
        /// </summary>
        public SvgDesc()
        {
             _tagName = "desc";
             _attributeStack = new List<string>();
             _styles = new List<SvgStyle>();
        }
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public SvgDesc Id(string id)
        {
            if (this == null) throw new Exception("Method SvgDesc.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgDesc XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgDesc.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgDesc XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgDesc.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgDesc XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgDesc.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgDesc CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgDesc.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgDesc Style(string style)
        {
            if (this == null) throw new Exception("Method SvgDesc.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgDesc Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgCircle.Style resulted in a null value.");
            return this;
        }
        /// <summary>
        /// Inner text of the element.
        /// </summary>
        /// <param name="innerText">The inner text.</param>
        /// <returns></returns>
        public SvgDesc Text(string innerText)
        {
            this._innerText = innerText;
            if (this == null) throw new Exception("Method SvgDesc.Text resulted in a null value.");
            return this;
        }
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder tag = new StringBuilder("<");
            tag.Append(_tagName);
            tag.Append(" ");

            foreach (var attrib in _attributeStack)
            {
                tag.Append(attrib);
                tag.Append(" ");
            }
            foreach (var style in _styles)
            {
                tag.Append(style);
                tag.Append(" ");
            }

            int index = tag.Length;
            tag.Remove(index - 1, 1);
            
            tag.Append(">");
            tag.Append(_innerText);
            
            tag.Append("</");
            tag.Append(_tagName);
            tag.Append(">");

            return tag.ToString();
        }
    }
}