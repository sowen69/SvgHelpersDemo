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
            base._id = id;
            if (this == null) throw new Exception("Method SvgTextPath.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgTextPath XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgTextPath.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgTextPath XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgTextPath.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgTextPath XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgTextPath.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgTextPath XlinkHref(string xlink_href)
        {
            this._xlink_href = xlink_href;
            if (this == null) throw new Exception("Method SvgTextPath.XlinkHref resulted in a null value.");
            _attributeStack.Add(@"xlink:href=""" + _xlink_href + @"""");
            return this;
        }
        public SvgTextPath XlinkShow(string xlink_show)
        {
            this._xlink_show = xlink_show;
            if (this == null) throw new Exception("Method SvgTextPath.XlinkShow resulted in a null value.");
            _attributeStack.Add(@"xlink:show=""" + _xlink_show + @"""");
            return this;
        }
        public SvgTextPath XlinkActuate(string xlink_actuate)
        {
            this._xlink_actuate = xlink_actuate;
            if (this == null) throw new Exception("Method SvgTextPath.XlinkActuate resulted in a null value.");
            _attributeStack.Add(@"xlink:actuate=""" + _xlink_actuate + @"""");
            return this;
        }
        public SvgTextPath XlinkType(string xlink_type)
        {
            this._xlink_type = xlink_type;
            if (this == null) throw new Exception("Method SvgTextPath.XlinkType resulted in a null value.");
            _attributeStack.Add(@"xlink:type=""" + _xlink_type + @"""");
            return this;
        }
        public SvgTextPath XlinkArcrole(string xlink_arcrole)
        {
            this._xlink_arcrole = xlink_arcrole;
            if (this == null) throw new Exception("Method SvgTextPath.XlinkArcrole resulted in a null value.");
            _attributeStack.Add(@"xlink:arcrole=""" + _xlink_arcrole + @"""");
            return this;
        }
        public SvgTextPath XlinkTitle(string xlink_title)
        {
            this._xlink_title = xlink_title;
            if (this == null) throw new Exception("Method SvgTextPath.XlinkTitle resulted in a null value.");
            _attributeStack.Add(@"xlink:title=""" + _xlink_title + @"""");
            return this;
        }

        public SvgTextPath CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgTextPath.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgTextPath Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgTextPath.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
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
            this._startOffset = startOffset;
            if (this == null) throw new Exception("Method SvgTextPath.StartOffset resulted in a null value.");
            _attributeStack.Add(@"startOffset=""" + _startOffset + @"""");
            return this;
        }
        public SvgTextPath Method(string method)
        {
            this._method = method;
            if (this == null) throw new Exception("Method SvgTextPath.Method resulted in a null value.");
            _attributeStack.Add(@"method=""" + _method + @"""");
            return this;
        }
        public SvgTextPath Spacing(string spacing)
        {
            this._spacing = spacing;
            if (this == null) throw new Exception("Method SvgTextPath.Spacing resulted in a null value.");
            _attributeStack.Add(@"spacing=""" + _spacing + @"""");
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
