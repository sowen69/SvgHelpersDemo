using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Odd.Svg.SvgHelpers
{
    public class SvgText : SvgElementBase
    {
        public SvgText()
        {
            _tagName="text";
            _attributeStack=new List<string>();
            _transforms = new List<SvgTransform>();
            _presentations = new List<SvgPresentation>();
            _events = new List<SvgEvent>();
            _styles = new List<SvgStyle>();
            _hasChildNode = true;

        }

        public SvgText Id(string id)
        {
            base._id = id;
            if (this == null) throw new Exception("Method SvgText.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + _id + @"""");
            return this;
        }
        public SvgText XmlBase(string xmlBase)
        {
            this._xmlBase = xmlBase;
            if (this == null) throw new Exception("Method SvgText.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + _xmlBase + @"""");
            return this;
        }
        public SvgText XmlLang(string xmlLang)
        {
            this._xmlLang = xmlLang;
            if (this == null) throw new Exception("Method SvgText.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + _xmlLang + @"""");
            return this;
        }
        public SvgText XmlSpace(string xmlSpace)
        {
            this._xmlSpace = xmlSpace;
            if (this == null) throw new Exception("Method SvgText.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + _xmlSpace + @"""");
            return this;
        }

        public SvgText CssClass(string cssClass)
        {
            this._cssClass = cssClass;
            if (this == null) throw new Exception("Method SvgText.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + _cssClass + @"""");
            return this;
        }
        public SvgText Style(string style)
        {
            this._style = style;
            if (this == null) throw new Exception("Method SvgText.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + _style + @"""");
            return this;
        }
        public SvgText Style(SvgStyle style)
        {
            this._styles.Add(style);
            if (this == null) throw new Exception("Method SvgText.Style resulted in a null value.");
            return this;
        }

        
        public SvgText X(double x)
        {
            this._x = x;
            if (this == null) throw new Exception("Method SvgText.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + _x + @"""");
            return this;
        }
        
        public SvgText Y(double y)
        {
            this._y = y;
            if (this == null) throw new Exception("Method SvgText.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + _y + @"""");
            return this;
        }
        
        public SvgText DX(double dx)
        {
            this._dx = dx;
            if (this == null) throw new Exception("Method SvgText.DX resulted in a null value.");
            _attributeStack.Add(@"dx=""" + _dx + @"""");
            return this;
        }
        
        public SvgText DY(double dy)
        {
            this._dy = dy;
            if (this == null) throw new Exception("Method SvgText.DY resulted in a null value.");
            _attributeStack.Add(@"dy=""" + _dy + @"""");
            return this;
        }
        
        public SvgText Rotate(double rotate)
        {
            this._rotate = rotate;
            if (this == null) throw new Exception("Method SvgText.Rotate resulted in a null value.");
            _attributeStack.Add(@"rotate=""" + _rotate + @"""");
            return this;
        }
        
        public SvgText TextLength(string textLength)
        {
            this._textLength = textLength;
            if (this == null) throw new Exception("Method SvgText.TextLength resulted in a null value.");
            _attributeStack.Add(@"textLength=""" + _textLength + @"""");
            return this;
        }
        
        public SvgText LengthAdjust(string lengthAdjust)
        {
            this._lengthAdjust = lengthAdjust;
            if (this == null) throw new Exception("Method SvgText.LengthAdjust resulted in a null value.");
            _attributeStack.Add(@"lengthAdjust=""" + _lengthAdjust + @"""");
            return this;
        }

        public SvgText Presentation(SvgPresentation presentation)
        {
            this._presentations.Add(presentation);
            if (this == null) throw new Exception("Method SvgText.Presentation resulted in a null value.");
            return this;
        }
        public SvgText Transforms(SvgTransform transform)
        {
            this._transforms.Add(transform);
            if (this == null) throw new Exception("Method SvgText.Transforms resulted in a null value.");
            return this;
        }
        public SvgText Events(SvgEvent svgEvent)
        {
            this._events.Add(svgEvent);
            if (this == null) throw new Exception("Method SvgRect.Events resulted in a null value.");
            return this;
        } 
    }

    public class EndSvgText
    {
        public EndSvgText()
        {
        }
        public override string ToString()
        {
            TagBuilder tag = new TagBuilder("text");
            return tag.ToString(TagRenderMode.EndTag);
        }
    }
}
