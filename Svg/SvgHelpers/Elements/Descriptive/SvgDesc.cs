using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgDesc
    {
        string _tagName;
        
        // Core Attributes
        IList<SvgStyle> _styles;
        IList<string> _attributeStack;

        string _innerText;

        public SvgDesc()
        {
             _tagName = "desc";
             _attributeStack = new List<string>();
             _styles = new List<SvgStyle>();
        }

        public SvgDesc Id(string id)
        {
            if (this == null) throw new Exception("Method SvgDesc.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgDesc XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgDesc.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgDesc XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgDesc.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgDesc XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgDesc.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgDesc CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgDesc.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgDesc Style(string style)
        {
            if (this == null) throw new Exception("Method SvgDesc.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgDesc Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgCircle.Style resulted in a null value.");
            return this;
        }

        public SvgDesc Text(string innerText)
        {
            this._innerText = innerText;
            if (this == null) throw new Exception("Method SvgDesc.Text resulted in a null value.");
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
