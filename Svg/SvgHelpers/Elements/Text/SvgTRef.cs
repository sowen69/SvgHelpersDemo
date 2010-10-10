using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgTRef : SvgElementBase
    {

        // tref is unsupported as of IE9 Beta 1 and Firefox 4 beta 6

        public SvgTRef()
        {
            _tagName="tref";
            _attributeStack=new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = false;
        }

        public SvgTRef Id(string id)
        {
            if (this == null) throw new Exception("Method SvgTRef.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgTRef XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgTRef.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgTRef XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgTRef.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgTRef XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgTRef.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgTRef XlinkHref(string xlink_href)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + xlink_href + @"""");
            return this;
        }
        public SvgTRef XlinkShow(string xlink_show)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkShow resulted in a null value.");
            _attributeStack.Add(@"xlink:show=""" + xlink_show + @"""");
            return this;
        }
        public SvgTRef XlinkActuate(string xlink_actuate)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkActuate resulted in a null value.");
            _attributeStack.Add(@"xlink:actuate=""" + xlink_actuate + @"""");
            return this;
        }
        public SvgTRef XlinkType(string xlink_type)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkType resulted in a null value.");
            _attributeStack.Add(@"xlink:type=""" + xlink_type + @"""");
            return this;
        }
        public SvgTRef XlinkRole(string xlink_role)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkRole resulted in a null value.");
            _attributeStack.Add(@"xlink:role=""" + xlink_role + @"""");
            return this;
        }
        public SvgTRef XlinkArcrole(string xlink_arcrole)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkArcrole resulted in a null value.");
            _attributeStack.Add(@"xlink:arcrole=""" + xlink_arcrole + @"""");
            return this;
        }
        public SvgTRef XlinkTitle(string xlink_title)
        {
            if (this == null) throw new Exception("Method SvgTRef.XlinkTitle resulted in a null value.");
            _attributeStack.Add(@"xlink:title=""" + xlink_title + @"""");
            return this;
        }

        public SvgTRef CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgTRef.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgTRef Style(string style)
        {
            if (this == null) throw new Exception("Method SvgTRef.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
            return this;
        }
        public SvgTRef Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgTRef.Style resulted in a null value.");
            return this;
        }

        public SvgTRef Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgTRef.Presentation resulted in a null value.");
            return this;
        }
        public SvgTRef Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        } 
    }

    public class EndSvgTRef
    {
        public EndSvgTRef()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("tref");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
