using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgTextPath : SvgElementBase
    {
        public SvgTextPath()
        {
            _tagName="textPath";
            _attributeStack=new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = true;
        }

        public SvgTextPath Id(string id)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgTextPath XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgTextPath XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgTextPath XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgTextPath XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
            return this;
        }
        public SvgTextPath XlinkShow(string xlink_show)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkShow resulted in a null value.");
            _attributeStack.Add(@"xlink:show=""" + xlink_show + @"""");
            return this;
        }
        public SvgTextPath XlinkActuate(string xlink_actuate)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkActuate resulted in a null value.");
            _attributeStack.Add(@"xlink:actuate=""" + xlink_actuate + @"""");
            return this;
        }
        public SvgTextPath XlinkType(string xlink_type)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkType resulted in a null value.");
            _attributeStack.Add(@"xlink:type=""" + xlink_type + @"""");
            return this;
        }
        public SvgTextPath XlinkArcrole(string xlink_arcrole)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkArcrole resulted in a null value.");
            _attributeStack.Add(@"xlink:arcrole=""" + xlink_arcrole + @"""");
            return this;
        }
        public SvgTextPath XlinkTitle(string xlink_title)
        {
            if (this == null) throw new Exception("Method SvgTextPath.XlinkTitle resulted in a null value.");
            _attributeStack.Add(@"xlink:title=""" + xlink_title + @"""");
            return this;
        }

        public SvgTextPath CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgTextPath.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgTextPath Style(string style)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgTextPath Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgTextPath.Style resulted in a null value.");
            return this;
        }

        public SvgTextPath StartOffset(string startOffset)
        {
            if (this == null) throw new Exception("Method SvgTextPath.StartOffset resulted in a null value.");
            _attributeStack.Add(@"startOffset=""" + startOffset + @"""");
            return this;
        }
        public SvgTextPath Method(string method)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Method resulted in a null value.");
            _attributeStack.Add(@"method=""" + method + @"""");
            return this;
        }
        public SvgTextPath Spacing(string spacing)
        {
            if (this == null) throw new Exception("Method SvgTextPath.Spacing resulted in a null value.");
            _attributeStack.Add(@"spacing=""" + spacing + @"""");
            return this;
        }

        public SvgTextPath Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgTextPath.Presentation resulted in a null value.");
            return this;
        }
        public SvgTextPath Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        } 
    }

    public class EndSvgTextPath
    {
        public EndSvgTextPath()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("textPath");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
