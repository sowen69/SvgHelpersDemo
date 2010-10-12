using System;
using System.Collections.Generic;
using System.Text;

namespace Odd.Svg.SvgHelpers
{
    public class SvgEvent : IHideObjectMembers
    {
        #region Event Fields
        string _onload;
        string _onfocusin;
        string _onfocusout;
        string _onactivate;
        string _onclick;
        string _onmousedown;
        string _onmouseup;
        string _onmouseover;
        string _onmousemove;
        string _onmouseout;
        string _onunload;
        string _onabort;
        string _onerror;
        string _onresize;
        string _onscroll;
        string _onzoom;
        string _otherAttributeName;
        string _otherAttributeValue;
        IList<string> _attributeStack;
        #endregion

        public SvgEvent()
        {
            _attributeStack = new List<string>();
        }
                
        public SvgEvent OnLoad(string onload)
        {
            this._onload = onload;
            if (this == null) throw new Exception("Method SvgEvent.OnLoad resulted in a null value.");
            _attributeStack.Add(@"onload=""" + _onload + @"""");
            return this;
        }
        public SvgEvent OnFocusIn(string onfocusin)
        {
            this._onfocusin = onfocusin;
            if (this == null) throw new Exception("Method SvgEvent.OnFocusIn resulted in a null value.");
            _attributeStack.Add(@"onfocusin=""" + onfocusin + @"""");
            return this;
        }
        public SvgEvent OnFocusOut(string onfocusout)
        {
            this._onfocusout = onfocusout;
            if (this == null) throw new Exception("Method SvgEvent.OnFocusOut resulted in a null value.");
            _attributeStack.Add(@"onfocusout=""" + onfocusout + @"""");
            return this;
        }
        public SvgEvent OnActivate(string onactivate)
        {
            this._onactivate = onactivate;
            if (this == null) throw new Exception("Method SvgEvent.OnActivate resulted in a null value.");
            _attributeStack.Add(@"onactivate=""" + onactivate + @"""");
            return this;
        }
        public SvgEvent OnClick(string onclick)
        {
            this._onclick = onclick;
            if (this == null) throw new Exception("Method SvgEvent.OnClick resulted in a null value.");
            _attributeStack.Add(@"onclick=""" + onclick + @"""");
            return this;
        }
        public SvgEvent OnMouseDown(string onmousedown)
        {
            this._onmousedown = onmousedown;
            if (this == null) throw new Exception("Method SvgEvent.OnMouseDown resulted in a null value.");
            _attributeStack.Add(@"onmousedown=""" + onmousedown + @"""");
            return this;
        }
        public SvgEvent OnMouseUp(string onmouseup)
        {
            this._onmouseup = onmouseup;
            if (this == null) throw new Exception("Method SvgEvent.OnMouseUp resulted in a null value.");
            _attributeStack.Add(@"onmouseup=""" + onmouseup + @"""");
            return this;
        }
        public SvgEvent OnMouseOver(string onmouseover)
        {
            this._onmouseover = onmouseover;
            if (this == null) throw new Exception("Method SvgEvent.OnMouseOver resulted in a null value.");
            _attributeStack.Add(@"onmouseover=""" + onmouseover + @"""");
            return this;
        }
        public SvgEvent OnMouseMove(string onmousemove)
        {
            this._onmousemove = onmousemove;
            if (this == null) throw new Exception("Method SvgEvent.OnMouseMove resulted in a null value.");
            _attributeStack.Add(@"onmousemove=""" + onmousemove + @"""");
            return this;
        }
        public SvgEvent OnMouseOut(string onmouseout)
        {
            this._onmouseout = onmouseout;
            if (this == null) throw new Exception("Method SvgEvent.OnMouseOut resulted in a null value.");
            _attributeStack.Add(@"onmouseout=""" + onmouseout + @"""");
            return this;
        }
        public SvgEvent OnUnload(string onunload)
        {
            this._onunload = onunload;
            if (this == null) throw new Exception("Method SvgEvent.OnUnload resulted in a null value.");
            _attributeStack.Add(@"onunload=""" + onunload + @"""");
            return this;
        }
        public SvgEvent OnAbort(string onabort)
        {
            this._onabort = onabort;
            if (this == null) throw new Exception("Method SvgEvent.OnAbort resulted in a null value.");
            _attributeStack.Add(@"onabort=""" + onabort + @"""");
            return this;
        }
        public SvgEvent OnError(string onerror)
        {
            this._onerror = onerror;
            if (this == null) throw new Exception("Method SvgEvent.OnError resulted in a null value.");
            _attributeStack.Add(@"onerror=""" + onerror + @"""");
            return this;
        }
        public SvgEvent OnResize(string onresize)
        {
            this._onresize = onresize;
            if (this == null) throw new Exception("Method SvgEvent.OnResize resulted in a null value.");
            _attributeStack.Add(@"onresize=""" + onresize + @"""");
            return this;
        }
        public SvgEvent OnScroll(string onscroll)
        {
            this._onscroll = onscroll;
            if (this == null) throw new Exception("Method SvgEvent.OnScroll resulted in a null value.");
            _attributeStack.Add(@"onscroll=""" + onscroll + @"""");
            return this;
        }
        public SvgEvent OnZoom(string onzoom)
        {
            this._onzoom = onzoom;
            if (this == null) throw new Exception("Method SvgEvent.OnZoom resulted in a null value.");
            _attributeStack.Add(@"onzoom=""" + onzoom + @"""");
            return this;
        }
        public SvgEvent AddAttribute(string name, string value)
        {
            this._otherAttributeName = name;
            this._otherAttributeValue = value;
            if (this == null) throw new Exception("Method SvgEvent.AddAttribute resulted in a null value.");
            _attributeStack.Add(name + @"=""" + value + @"""");
            return this;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder eventAttributes = new StringBuilder();
            foreach (var attrib in _attributeStack)
            {
                eventAttributes.Append(attrib);
                eventAttributes.Append(" ");
            }
            int index = eventAttributes.Length;
            eventAttributes.Remove(index - 1, 1);

            return eventAttributes.ToString();
        }
    }
}
