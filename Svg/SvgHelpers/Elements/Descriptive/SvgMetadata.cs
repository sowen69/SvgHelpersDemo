using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class BeginSvgMetadata
    {
        // Core Attributes
        string _tagName;
        IList<string> _attributeStack;

        public BeginSvgMetadata()
        {
            _tagName = "metadata";
            _attributeStack = new List<string>();
        }
        public BeginSvgMetadata Id(string id)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public BeginSvgMetadata XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public BeginSvgMetadata XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public BeginSvgMetadata XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method BeginSvgMetadata.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

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

    public class EndSvgMetadata
    {
        public EndSvgMetadata()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("metadata");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}
