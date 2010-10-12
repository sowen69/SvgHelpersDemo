using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.IO.Compression;

namespace Odd.Svg.SvgHelpers
{
    // Structural
    /// <summary>
    /// 
    /// </summary>
    public static class SvgElementHelper
    {
        /// <summary>
        /// BeginSvg 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static BeginSvg BeginSvg(this HtmlHelper helper)
        {return new BeginSvg();}

        /// <summary>
        /// EndSvg 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvg EndSvg(this HtmlHelper helper)
        {return new EndSvg();}
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgGroupHelper
    {
        /// <summary>
        /// BeginSvgGroup 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static BeginSvgGroup BeginSvgGroup(this HtmlHelper helper)
        {return new BeginSvgGroup();}

        /// <summary>
        /// EndSvgGroup 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgGroup EndSvgGroup(this HtmlHelper helper)
        {return new EndSvgGroup();}
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgDefsHelper
    {
        /// <summary>
        /// BeginSvgDefs 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static BeginSvgDefs BeginSvgDefs(this HtmlHelper helper)
        { return new BeginSvgDefs(); }

        /// <summary>
        /// EndSvgDefs 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgDefs EndSvgDefs(this HtmlHelper helper)
        { return new EndSvgDefs(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgUseHelper
    {
        /// <summary>
        /// SvgUse 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgUse SvgUse(this HtmlHelper helper)
        { return new SvgUse(); }

        /// <summary>
        /// EndSvgUse 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgUse EndSvgUse(this HtmlHelper helper)
        { return new EndSvgUse(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgSymbolHelper
    {
        /// <summary>
        /// BeginSvgSymbol 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static BeginSvgSymbol BeginSvgSymbol(this HtmlHelper helper)
        { return new BeginSvgSymbol(); }

        /// <summary>
        /// EndSvgSymbol 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgSymbol EndSvgSymbol(this HtmlHelper helper)
        { return new EndSvgSymbol(); }
    }

    // Descriptive
    /// <summary>
    /// 
    /// </summary>
    public static class SvgDescHelper
    {
        /// <summary>
        /// SvgDesc
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgDesc SvgDesc(this HtmlHelper helper)
        { return new SvgDesc(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgSvgMetadata
    {
        /// <summary>
        /// BeginSvgMetadata 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static BeginSvgMetadata BeginSvgMetadata(this HtmlHelper helper)
        { return new BeginSvgMetadata(); }

        /// <summary>
        /// EndSvgMetadata 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgMetadata EndSvgMetadata(this HtmlHelper helper)
        { return new EndSvgMetadata(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgTitleHelper
    {
        /// <summary>
        /// SvgTitle 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgTitle SvgTitle(this HtmlHelper helper)
        { return new SvgTitle(); }
    }

    // Basic Shapes
    /// <summary>
    /// 
    /// </summary>
    public static class SvgLineHelper
    {
        /// <summary>
        /// SvgLine 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgLine SvgLine(this HtmlHelper helper)
        {return new SvgLine();}

        /// <summary>
        /// EndSvgLine 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgLine EndSvgLine(this HtmlHelper helper)
        {return new EndSvgLine();}
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgRectHelper
    {
        /// <summary>
        /// SvgRect 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgRect SvgRect(this HtmlHelper helper)
        {return new SvgRect();}

        /// <summary>
        /// EndSvgRect 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgRect EndSvgRect(this HtmlHelper helper)
        {return new EndSvgRect();}
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgCircleHelper
    {
        /// <summary>
        /// SvgCircle 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgCircle SvgCircle(this HtmlHelper helper)
        { return new SvgCircle(); }

        /// <summary>
        /// EndSvgCircle 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgCircle EndSvgCircle(this HtmlHelper helper)
        { return new EndSvgCircle(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgEllipseHelper
    {
        /// <summary>
        /// SvgEllipse 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgEllipse SvgEllipse(this HtmlHelper helper)
        { return new SvgEllipse(); }

        /// <summary>
        /// EndSvgEllipse 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgEllipse EndSvgEllipse(this HtmlHelper helper)
        { return new EndSvgEllipse(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgPathHelper
    {
        /// <summary>
        /// SvgPath 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgPath SvgPath(this HtmlHelper helper)
        { return new SvgPath(); }

        /// <summary>
        /// EndSvgPath 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgPath EndSvgPath(this HtmlHelper helper)
        { return new EndSvgPath(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgPolygonHelper
    {
        /// <summary>
        /// SvgPolygon 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgPolygon SvgPolygon(this HtmlHelper helper)
        { return new SvgPolygon(); }

        /// <summary>
        /// EndSvgPolygon 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgPolygon EndSvgPolygon(this HtmlHelper helper)
        { return new EndSvgPolygon(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgPolylineHelper
    {
        /// <summary>
        /// SvgPolyline 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgPolyline SvgPolyline(this HtmlHelper helper)
        { return new SvgPolyline(); }

        /// <summary>
        /// EndSvgPolyline 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgPolyline EndSvgPolyline(this HtmlHelper helper)
        { return new EndSvgPolyline(); }
    }

    // Text
    /// <summary>
    /// 
    /// </summary>
    public static class SvgTextHelper
    {
        /// <summary>
        /// SvgText 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgText SvgText(this HtmlHelper helper)
        { return new SvgText(); }

        /// <summary>
        /// EndSvgText 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgText EndSvgText(this HtmlHelper helper)
        { return new EndSvgText(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgTSpanHelper
    {
        /// <summary>
        /// SvgTSpan 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgTSpan SvgTSpan(this HtmlHelper helper)
        { return new SvgTSpan(); }

        /// <summary>
        /// EndSvgTSpan 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgTSpan EndSvgTSpan(this HtmlHelper helper)
        { return new EndSvgTSpan(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgTRefHelper
    {
        /// <summary>
        /// SvgTRef 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgTRef SvgTRef(this HtmlHelper helper)
        { return new SvgTRef(); }

        /// <summary>
        /// EndSvgTRef 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgTRef EndSvgTRef(this HtmlHelper helper)
        { return new EndSvgTRef(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgTextPathHelper
    {
        /// <summary>
        /// SvgTextPath 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgTextPath SvgTextPath(this HtmlHelper helper)
        { return new SvgTextPath(); }

        /// <summary>
        /// EndSvgTextPath 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgTextPath EndSvgTextPath(this HtmlHelper helper)
        { return new EndSvgTextPath(); }
    }

    // Gradient
    /// <summary>
    /// 
    /// </summary>
    public static class SvgLinearGradientHelper
    {
        /// <summary>
        /// SvgLinearGradient 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgLinearGradient SvgLinearGradient(this HtmlHelper helper)
        { return new SvgLinearGradient(); }

        /// <summary>
        /// EndSvgLinearGradient 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgLinearGradient EndSvgLinearGradient(this HtmlHelper helper)
        { return new EndSvgLinearGradient(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgRadialGradientHelper
    {
        /// <summary>
        /// SvgRadialGradient 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgRadialGradient SvgRadialGradient(this HtmlHelper helper)
        { return new SvgRadialGradient(); }

        /// <summary>
        /// EndSvgRadialGradient 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgRadialGradient EndSvgRadialGradient(this HtmlHelper helper)
        { return new EndSvgRadialGradient(); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SvgGradientStopHelper
    {
        /// <summary>
        /// SvgGradientStop 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static SvgGradientStop SvgGradientStop(this HtmlHelper helper)
        { return new SvgGradientStop(); }

        /// <summary>
        /// EndSvgGradientStop 
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns></returns>
        public static EndSvgGradientStop EndSvgGradientStop(this HtmlHelper helper)
        { return new EndSvgGradientStop(); }
    }
}
