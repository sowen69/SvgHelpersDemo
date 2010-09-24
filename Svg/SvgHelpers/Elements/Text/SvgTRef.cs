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
            base._id = id;
            if (this == null) throw new Exception("Method SvgTRef.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgTRef XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgTRef.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgTRef XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgTRef.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgTRef XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgTRef.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        
        public SvgTRef XlinkHref(string xlink_href)
        {
            this._xlink_href = xlink_href;
            if (this == null) throw new Exception("Method SvgTRef.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + _xlink_href + @"""");
            return this;
        }
        public SvgTRef XlinkShow(string xlink_show)
        {
            this._xlink_show = xlink_show;
            if (this == null) throw new Exception("Method SvgTRef.XlinkShow resulted in a null value.");
            _attributeStack.Add(@"xlink:show=""" + _xlink_show + @"""");
            return this;
        }
        public SvgTRef XlinkActuate(string xlink_actuate)
        {
            this._xlink_actuate = xlink_actuate;
            if (this == null) throw new Exception("Method SvgTRef.XlinkActuate resulted in a null value.");
            _attributeStack.Add(@"xlink:actuate=""" + _xlink_actuate + @"""");
            return this;
        }
        public SvgTRef XlinkType(string xlink_type)
        {
            this._xlink_type = xlink_type;
            if (this == null) throw new Exception("Method SvgTRef.XlinkType resulted in a null value.");
            _attributeStack.Add(@"xlink:type=""" + _xlink_type + @"""");
            return this;
        }
        public SvgTRef XlinkRole(string xlink_role)
        {
            this._xlink_role = xlink_role;
            if (this == null) throw new Exception("Method SvgTRef.XlinkRole resulted in a null value.");
            _attributeStack.Add(@"xlink:role=""" + _xlink_type + @"""");
            return this;
        }
        public SvgTRef XlinkArcrole(string xlink_arcrole)
        {
            this._xlink_arcrole = xlink_arcrole;
            if (this == null) throw new Exception("Method SvgTRef.XlinkArcrole resulted in a null value.");
            _attributeStack.Add(@"xlink:arcrole=""" + _xlink_arcrole + @"""");
            return this;
        }
        public SvgTRef XlinkTitle(string xlink_title)
        {
            this._xlink_title = xlink_title;
            if (this == null) throw new Exception("Method SvgTRef.XlinkTitle resulted in a null value.");
            _attributeStack.Add(@"xlink:title=""" + _xlink_title + @"""");
            return this;
        }

        public SvgTRef CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgTRef.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgTRef Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgTRef.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
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
