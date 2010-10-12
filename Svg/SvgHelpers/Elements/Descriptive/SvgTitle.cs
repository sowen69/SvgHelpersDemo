using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// <para>Each container element or graphics element in an SVG drawing can supply a ‘title’</para>
    /// <para>description string where the description is text-only and is not rendered</para>
    /// </summary>
    public class SvgTitle
    {
        string _tagName;

        // Core Attributes
        IList<SvgStyle> _styles;
        IList<string> _attributeStack;

        string _innerText;

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgTitle"/> class.
        /// </summary>
        public SvgTitle()
        {
            _tagName = "title";
            _attributeStack = new List<string>();
            _styles = new List<SvgStyle>();
        }
        /// <id/>
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public SvgTitle Id(string id)
        {
            if (this == null) throw new Exception("Method SvgTitle.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public SvgTitle XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgTitle.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public SvgTitle XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgTitle.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public SvgTitle XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgTitle.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }
        /// <summary>
        /// The CSS class to style the element.
        /// </summary>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns></returns>
        public SvgTitle CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgTitle.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        /// <summary>
        /// A string containing css attributes to style the element.
        /// </summary>
        /// <param name="style">CSS style</param>
        /// <returns></returns>
        public SvgTitle Style(string style)
        {
            if (this == null) throw new Exception("Method SvgTitle.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        /// <SvgStyle_collection/>
        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        /// <param name="style">SvgStyle object</param>
        /// <returns></returns>
        public SvgTitle Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgCircle.Style resulted in a null value.");
            return this;
        }
        /// <summary>
        /// Specifies the inner text of the element
        /// </summary>
        /// <param name="innerText">The inner text.</param>
        /// <returns></returns>
        public SvgTitle Text(string innerText)
        {
            this._innerText = innerText;
            if (this == null) throw new Exception("Method SvgTitle.Text resulted in a null value.");
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