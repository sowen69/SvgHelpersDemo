﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Odd.Svg.SvgHelpers;

namespace Odd.Svg.SvgHelpers
{
    public abstract class SvgElementBase : IHideObjectMembers
    {
        #region ElementBase fields
        // Core Attributes
        internal string _svgDec = "xmlns=\"http://www.w3.org/2000/svg\"";
        internal string _xlinkDec = "xmlns:xlink=\"http://www.w3.org/1999/xlink\"";
        internal string _id;
        internal string _xmlBase;
        internal string _xmlLang;
        internal string _xmlSpace;

        // CSS Styling
        internal string _cssClass;
        internal string _style;

        // Geometry
        internal double _x;
        internal double _y;

        internal double _x1 = 0;
        internal double _y1 = 0;
        internal double _x2 = 0;
        internal double _y2 = 0;

        internal double _height;
        internal double _width;

        internal string _points;

        internal double _rx;
        internal double _ry;

        internal double _r;

        internal string _d;

        internal double _cx;
        internal double _cy;

        internal double _dx;
        internal double _dy;

        internal double _rotate;

        internal double _pathLength;
        
        // Xlink
        internal bool _xlink;
        internal string _xlink_href;
        internal string _xlink_show;
        internal string _xlink_actuate;
        internal string _xlink_type;
        internal string _xlink_role;
        internal string _xlink_arcrole;
        internal string _xlink_title;

        // Text Path

        internal string _startOffset;
        internal string _method;
        internal string _spacing;

        // Other
        internal string _textLength;
        internal string _lengthAdjust;
        internal string _viewBox;
        internal string _preserveAspectRatio;

        internal string _otherAttributeName;
        internal string _otherAttributeValue;

        internal string _tagName;

        // All SVG elements can contain any combination of ‘desc’, ‘metadata’, ‘title’
        // therefore ALL elements must have the option to be parent nodes, irrespective 
        // of the fact that nobody will do it :D Hence to save some keystrokes we default
        // to making the element self closing
        internal bool _hasChildNode = false;

        // Transforms, events and presentation attributes split into their own classes
        // to keep the intellisence as clean as possible with so many option to choose from.
        internal IList<SvgTransform> _transforms;
        internal IList<SvgEvent> _events;
        internal IList<SvgPresentation> _presentations;
        internal IList<SvgStyle> _styles;

        internal IList<string> _attributeStack;
        #endregion

        /// <summary>The Id of the element that can be used by Xlink and CSS</summary>
        ///
        /// <returns>blah</returns>


        // Get Out of Jail Free Card: 
        // If i've missed an attribute that should be in here
        // it can be added at runtime.
        /// <summary>
        /// <para>Add any attribute to the SVG element using Key:Value pair.</para>
        /// <para>Always define LAST in the call chain</para>
        /// </summary>
        /// <param name="name">Attribute Name</param>
        /// <param name="value">Attribute Value</param>
        /// <returns></returns>
        public SvgElementBase AddAttribute(string name, string value)
        {
            this._otherAttributeName = name;
            this._otherAttributeValue = value;
            if (this == null) throw new Exception("Method SvgElementBase.AddAttribute resulted in a null value.");
            _attributeStack.Add(name + @"=""" + value + @"""");
            return this;
        }

        public override string ToString()
        {
            StringBuilder tag = new StringBuilder("<");
            tag.Append(_tagName);
            tag.Append(" ");
            if (_tagName == "svg")
            {
                tag.Append(_svgDec);
                tag.Append(" ");
            }
            if (_xlink == true)
            {
                tag.Append(_xlinkDec);
                tag.Append(" ");
            }

            foreach (var attrib in _attributeStack)
            {
                tag.Append(attrib);
                tag.Append(" ");
            }
            foreach (var style in _styles)
            {
                tag.Append(style);
                tag.Append(" ");
            }
            foreach (var transform in _transforms)
            {
                tag.Append(transform.ToString());
                tag.Append(" ");
            }

            foreach (var presentation in _presentations)
            {
                tag.Append(presentation.ToString());
                tag.Append(" ");
            }
            foreach (var ev in _events)
            {
                tag.Append(ev.ToString());
                tag.Append(" ");
            }

            int index = tag.Length;
            tag.Remove(index - 1, 1);

            return (_hasChildNode == false)
                    ? tag.Append("/>").ToString()
                    : tag.Append(">").ToString();
        }

    }         
}