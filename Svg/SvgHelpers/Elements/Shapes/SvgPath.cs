using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgPath : SvgElementBase
    {
        public SvgPath()
        {
            _tagName = "path";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
        }

        public SvgPath Id(string id)
        {
            base._id = id;
            if (this == null) throw new Exception("Method SvgPath.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgPath XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgPath.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgPath XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgPath.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgPath XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgPath.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgPath CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgPath.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgPath Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgPath.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgPath Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgPath.Style resulted in a null value.");
            return this;
        }
        
        public SvgPath D(string d)
        {
            this._d = d;
            if (this == null) throw new Exception("Method SvgPath.D resulted in a null value.");
            _attributeStack.Add(@"d=""" + _d + @"""");
            return this;
        }
        public SvgPath PathLength(double pathLength)
        {
            this._pathLength = pathLength;
            if (this == null) throw new Exception("Method SvgPath.PathLength resulted in a null value.");
            _attributeStack.Add(@"pathlength=""" + _pathLength.ToString() + @"""");
            return this;
        }

        public SvgPath Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgPath.Presentation resulted in a null value.");
            return this;
        }
        public SvgPath Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgPath.Transforms resulted in a null value.");
            return this;
        }
        public SvgPath Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgPath.Events resulted in a null value.");
            return this;
        }

        public SvgPath HasChildNode(bool hasChildNode)
        {
            this._hasChildNode = hasChildNode;
            if (this == null) throw new Exception("Method SvgPath.HasChildNode resulted in a null value.");
            return this;
        }
    }

    public class EndSvgPath
    {
        public EndSvgPath()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("path");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
