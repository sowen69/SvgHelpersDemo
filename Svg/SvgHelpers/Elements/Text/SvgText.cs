using System;
using System.Collections.Generic;
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
            if (this == null) throw new Exception("Method SvgText.Id resulted in a null value.");
            _attributeStack.Add(@"id=""" + id + @"""");
            return this;
        }
        public SvgText XmlBase(string xmlBase)
        {
            if (this == null) throw new Exception("Method SvgText.XmlBase resulted in a null value.");
            _attributeStack.Add(@"xml:base=""" + xmlBase + @"""");
            return this;
        }
        public SvgText XmlLang(string xmlLang)
        {
            if (this == null) throw new Exception("Method SvgText.XmlLang resulted in a null value.");
            _attributeStack.Add(@"xml:lang=""" + xmlLang + @"""");
            return this;
        }
        public SvgText XmlSpace(string xmlSpace)
        {
            if (this == null) throw new Exception("Method SvgText.XmlSpace resulted in a null value.");
            _attributeStack.Add(@"xml:space=""" + xmlSpace + @"""");
            return this;
        }

        public SvgText CssClass(string cssClass)
        {
            if (this == null) throw new Exception("Method SvgText.CssClass resulted in a null value.");
            _attributeStack.Add(@"class=""" + cssClass + @"""");
            return this;
        }
        public SvgText Style(string style)
        {
            if (this == null) throw new Exception("Method SvgText.Style resulted in a null value.");
            _attributeStack.Add(@"style=""" + style + @"""");
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
            if (this == null) throw new Exception("Method SvgText.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        public SvgText Y(double y)
        {
            if (this == null) throw new Exception("Method SvgText.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }        
        public SvgText DX(double dx)
        {
            if (this == null) throw new Exception("Method SvgText.DX resulted in a null value.");
            _attributeStack.Add(@"dx=""" + dx + @"""");
            return this;
        }        
        public SvgText DY(double dy)
        {
            if (this == null) throw new Exception("Method SvgText.DY resulted in a null value.");
            _attributeStack.Add(@"dy=""" + dy + @"""");
            return this;
        }       
        public SvgText Rotate(double rotate)
        {
            if (this == null) throw new Exception("Method SvgText.Rotate resulted in a null value.");
            _attributeStack.Add(@"rotate=""" + rotate + @"""");
            return this;
        }        
        public SvgText TextLength(string textLength)
        {
            if (this == null) throw new Exception("Method SvgText.TextLength resulted in a null value.");
            _attributeStack.Add(@"textLength=""" + textLength + @"""");
            return this;
        }        
        public SvgText LengthAdjust(string lengthAdjust)
        {
            if (this == null) throw new Exception("Method SvgText.LengthAdjust resulted in a null value.");
            _attributeStack.Add(@"lengthAdjust=""" + lengthAdjust + @"""");
            return this;
        }

        public SvgText X(string x)
        {
            if (this == null) throw new Exception("Method SvgText.X resulted in a null value.");
            _attributeStack.Add(@"x=""" + x + @"""");
            return this;
        }
        public SvgText Y(string y)
        {
            if (this == null) throw new Exception("Method SvgText.Y resulted in a null value.");
            _attributeStack.Add(@"y=""" + y + @"""");
            return this;
        }
        public SvgText DX(string dx)
        {
            if (this == null) throw new Exception("Method SvgText.DX resulted in a null value.");
            _attributeStack.Add(@"dx=""" + dx + @"""");
            return this;
        }
        public SvgText DY(string dy)
        {
            if (this == null) throw new Exception("Method SvgText.DY resulted in a null value.");
            _attributeStack.Add(@"dy=""" + dy + @"""");
            return this;
        }
        public SvgText Rotate(string rotate)
        {
            if (this == null) throw new Exception("Method SvgText.Rotate resulted in a null value.");
            _attributeStack.Add(@"rotate=""" + rotate + @"""");
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
