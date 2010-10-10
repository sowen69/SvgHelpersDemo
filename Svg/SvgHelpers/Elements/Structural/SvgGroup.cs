using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Odd.Svg.SvgHelpers
{
    public class BeginSvgGroup : SvgElementBase
    {
        public BeginSvgGroup()
        {
            _tagName = "g";
            _attributeStack = new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = true;
        }

        public BeginSvgGroup Id(string id)
        {
            if (this == null) throw new Exception("Method BeginSvgGroup.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public BeginSvgGroup XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method BeginSvgGroup.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public BeginSvgGroup XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method BeginSvgGroup.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public BeginSvgGroup XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method BeginSvgGroup.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public BeginSvgGroup CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method BeginSvgGroup.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public BeginSvgGroup Style(string style)
        {
            if (this == null) throw new Exception("Method BeginSvgGroup.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public BeginSvgGroup Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method BeginSvgGroup.Style resulted in a null value.");
            return this;
        }

        public BeginSvgGroup Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method BeginSvgGroup.Presentation resulted in a null value.");
            return this;
        }
        public BeginSvgGroup Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method BeginSvgGroup.Transforms resulted in a null value.");
            return this;
        }
        public BeginSvgGroup Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method BeginSvgGroup.Events resulted in a null value.");
            return this;
        }
    }

    public class EndSvgGroup
    {
        public EndSvgGroup()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("g");
            return tag.ToString(TagRenderMode.EndTag);
        }

    }
}
