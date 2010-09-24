using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Odd.Svg.SvgHelpers;

namespace Odd.Svg.SvgHelpers
{
    public class SvgAnimationBase : IHideObjectMembers
    {
        #region SvgAnimationBase fields
        // Core Attributes
        internal string _id;
        internal string _xmlBase;
        internal string _xmlLang;
        internal string _xmlSpace;
        
        internal string _otherAttributeName;
        internal string _otherAttributeValue;

        internal string _tagName;

        // All SVG elements can contain any combination of ‘desc’, ‘metadata’, ‘title’
        // therefore ALL elements must have the option to be parent nodes, irrespective 
        // of the fact that nobody will do it :D Hence to save some keystrokes we default
        // to making the element self closing
        internal bool _hasChildNode = false;

        internal IList<string> _attributeStack;
        #endregion
       
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
        public SvgAnimationBase AddAttribute(string name, string value)
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

            foreach (var attrib in _attributeStack)
            {
                tag.Append(attrib);
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
