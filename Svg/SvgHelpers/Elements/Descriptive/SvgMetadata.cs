using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Element for defining the SVG document Metadata
    /// </summary>
    public class BeginSvgMetadata
    {
        // Core Attributes
        string _tagName;
        IList<string> _attributeStack;

        /// <summary>
        /// Initializes a new instance of the <see cref="BeginSvgMetadata"/> class.
        /// </summary>
        public BeginSvgMetadata()
        {
            _tagName = "metadata";
            _attributeStack = new List<string>();
        }
        /// <id/>
        /// <summary>
        /// Specifies the id of the element.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public BeginSvgMetadata Id(string id)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        /// <XmlBase/>
        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity. 
        /// </summary>
        /// <param name="xmlBase">The XML base.</param>
        /// <returns></returns>
        public BeginSvgMetadata XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        /// <XmlLang/>
        /// <summary>
        /// Standard XML attribute to specify the language (e.g., English) used in the contents and attribute values of particular elements.
        /// </summary>
        /// <param name="xmlLang">The XML lang.</param>
        /// <returns></returns>
        public BeginSvgMetadata XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        /// <XmlSpace/>
        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// </summary>
        /// <param name="xmlSpace">default | preserve</param>
        /// <returns></returns>
        public BeginSvgMetadata XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
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
            
            int index = tag.Length;
            tag.Remove(index - 1, 1);

            tag.Append(">");

            return tag.ToString();
        }
    }

    /// <summary>
    /// End metadata tag
    /// </summary>
    public class EndSvgMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndSvgMetadata"/> class.
        /// </summary>
        public EndSvgMetadata()
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
            TagBuilder tag = new TagBuilder("metadata");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}