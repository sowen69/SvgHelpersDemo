using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Odd.Svg.SvgHelpers
{
    public class BeginSvgDefs : SvgElementBase
    {
        public BeginSvgDefs()
        {
            _tagName = "defs";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = true;
        }

        public BeginSvgDefs Id(string id)
        {
            if (this == null) throw new Exception("Method BeginSvgDefs.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public BeginSvgDefs XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method BeginSvgDefs.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public BeginSvgDefs XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method BeginSvgDefs.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public BeginSvgDefs XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method BeginSvgDefs.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public BeginSvgDefs CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method BeginSvgDefs.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public BeginSvgDefs Style(string style)
        {
            if (this == null) throw new Exception("Method BeginSvgDefs.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public BeginSvgDefs Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method BeginSvgDefs.Style resulted in a null value.");
            return this;
        }

        public BeginSvgDefs Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method BeginSvgDefs.Presentation resulted in a null value.");
            return this;
        }
        public BeginSvgDefs Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method BeginSvgDefs.Transforms resulted in a null value.");
            return this;
        }
        public BeginSvgDefs Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method BeginSvgDefs.Events resulted in a null value.");
            return this;
        }
    }

    public class EndSvgDefs
    {
        public EndSvgDefs()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("defs");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}
