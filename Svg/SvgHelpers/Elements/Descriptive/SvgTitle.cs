﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgTitle
    {
        string _tagName;

        // Core Attributes
        string _id;
        string _xmlBase;
        string _xmlLang;
        string _xmlSpace;

        // CSS Styling
        string _cssClass;
        string _style;
        IList<SvgStyle> _styles;
        IList<string> _attributeStack;

        string _innerText;

        public SvgTitle()
        {
            _tagName = "title";
            _attributeStack = new List<string>();
            _styles = new List<SvgStyle>();
        }

        public SvgTitle Id(string id)
        {
            this._id = id;
            if (this == null) throw new Exception("Method SvgTitle.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgTitle XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgTitle.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgTitle XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgTitle.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgTitle XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgTitle.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgTitle CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgTitle.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgTitle Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgTitle.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgTitle Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgCircle.Style resulted in a null value.");
            return this;
        }


        public SvgTitle Text(string innerText)
        {
            this._innerText = innerText;
            if (this == null) throw new Exception("Method SvgTitle.Text resulted in a null value.");
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
