using System;
using System.Collections.Generic;
using System.Text;

namespace Odd.Svg.SvgHelpers
{
    public class SvgTransform : IHideObjectMembers
    {
        #region Transform Fields
        double _xScaleFactor ;
        double _yScaleFactor ;

        double _xTranslate ;
        double _yTranslate ;

        double _xShearFactor ;
        double _yShearFactor ;

        double _angle ;
        double _xCenter ;
        double _yCenter ;

        double _xSkewAngle ;
        double _ySkewAngle ;

        double[] _matrix ;

        IList<string> _attributeStack;
        #endregion

        public SvgTransform()
        {
            _attributeStack = new List<string>();
            _matrix = new double[6];
        }

        /// <summary>
        /// Scales the element/group in proportion
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public SvgTransform Scale(double x)
        {
            this._xScaleFactor = x;
            if (this == null) throw new Exception("Method SvgTransform.Scale (proportinal) resulted in a null value.");
            _attributeStack.Add(@"scale(" + _xScaleFactor.ToString() + ")");
            return this;
        }
        /// <summary>
        /// Scales the element/group by the relevant factors
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public SvgTransform Scale(double x, double y)
        {
            this._xScaleFactor = x;
            this._yScaleFactor = y;
            if (this == null) throw new Exception("Method SvgTransform.Scale (non proportional) resulted in a null value.");
            _attributeStack.Add(@"scale(" + _xScaleFactor.ToString() + " " + _yScaleFactor.ToString() + ")");
            return this;
        }
        public SvgTransform Translate(double x, double y)
        {
            this._xTranslate = x;
            this._yTranslate = y;
            if (this == null) throw new Exception("Method SvgTransform.Translate resulted in a null value.");
            _attributeStack.Add(@"translate(" + _xTranslate.ToString() + " " + _yTranslate.ToString() + ")");
            return this;
        }
        public SvgTransform SkewX(double x)
        {
            this._xSkewAngle = x;
            if (this == null) throw new Exception("Method SvgTransform.SkewX resulted in a null value.");
            _attributeStack.Add(@"skewX(" + _xSkewAngle.ToString() + ")");
            return this;
        }
        public SvgTransform SkewY(double y)
        {
            this._ySkewAngle = y;
            if (this == null) throw new Exception("Method SvgTransform.SkewY resulted in a null value.");
            _attributeStack.Add(@"skewY(" + _ySkewAngle.ToString() + ")");
            return this;
        }
        public SvgTransform Shear(double x, double y)
        {
            this._xShearFactor = x;
            this._yShearFactor = y;
            if (this == null) throw new Exception("Method SvgTransform.Shear resulted in a null value.");
            _attributeStack.Add(@"shear(" + _xShearFactor.ToString() + " " + _yShearFactor.ToString() + ")");
            return this;
        }
        public SvgTransform Rotate(double a)
        {
            this._angle = a;
            if (this == null) throw new Exception("Method SvgTransform.Rotate (default centers) resulted in a null value.");
            _attributeStack.Add(@"rotate(" + _angle.ToString() + ")");
            return this;
        }
        public SvgTransform Rotate(double a, double x, double y)
        {
            this._xCenter = x;
            this._yCenter = y;
            this._angle = a;
            if (this == null) throw new Exception("Method SvgTransform.Rotate (defined centers) resulted in a null value.");
            _attributeStack.Add(@"rotate("+_angle.ToString() + " " + _xCenter.ToString() + " " + _yCenter.ToString() + ")");
            return this;
        }
        public SvgTransform Matrix(double a, double b,double c,double d,double e,double f)
        {
            this._matrix[0] = a;
            this._matrix[1] = b;
            this._matrix[2] = c;
            this._matrix[3] = d;
            this._matrix[4] = e;
            this._matrix[5] = f;
            if (this == null) throw new Exception("Method SvgTransform.Matrix resulted in a null value.");
            _attributeStack.Add(@"matrix(" + _matrix[0].ToString() + _matrix[1].ToString() + _matrix[2].ToString() + _matrix[3].ToString() + _matrix[4].ToString() + _matrix[5].ToString() + ") ");
            return this;
        }

        public override string ToString()
        {
            StringBuilder transformAttributes = new StringBuilder(@"transform=""");
            foreach (var attrib in _attributeStack)
            {
                transformAttributes.Append(attrib);
                transformAttributes.Append(" ");
            }
            int index = transformAttributes.Length;
            transformAttributes.Remove(index - 1, 1);
            transformAttributes.Append(@"""");
            return transformAttributes.ToString();
        }
    }
}
