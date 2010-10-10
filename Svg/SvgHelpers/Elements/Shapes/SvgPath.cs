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
            if (this == null) throw new Exception("Method SvgPath.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgPath XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgPath.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgPath XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgPath.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgPath XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgPath.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgPath CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgPath.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgPath Style(string style)
        {
            if (this == null) throw new Exception("Method SvgPath.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
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
            if (this == null) throw new Exception("Method SvgPath.D resulted in a null value.");
            _attributeStack.Add(@"d=""" + d + @"""");
            return this;
        }
        public SvgPath PathLength(double pathLength)
        {
            if (this == null) throw new Exception("Method SvgPath.PathLength resulted in a null value.");
            _attributeStack.Add(@"pathlength=""" + pathLength.ToString() + @"""");
            return this;
        }

        public SvgPath PathLength(string pathLength)
        {
            if (this == null) throw new Exception("Method SvgPath.PathLength(string) resulted in a null value.");
            _attributeStack.Add(@"pathlength=""" + pathLength + @"""");
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
