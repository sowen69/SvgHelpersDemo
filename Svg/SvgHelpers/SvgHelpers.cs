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
    public static class SvgElementHelper
    {
        public static BeginSvg BeginSvg(this HtmlHelper helper)
        {return new BeginSvg();}

        public static EndSvg EndSvg(this HtmlHelper helper)
        {return new EndSvg();}
    }
    public static class SvgGroupHelper
    {
        public static BeginSvgGroup BeginSvgGroup(this HtmlHelper helper)
        {return new BeginSvgGroup();}

        public static EndSvgGroup EndSvgGroup(this HtmlHelper helper)
        {return new EndSvgGroup();}
    }
    public static class SvgDefsHelper
    {
        public static BeginSvgDefs BeginSvgDefs(this HtmlHelper helper)
        { return new BeginSvgDefs(); }

        public static EndSvgDefs EndSvgDefs(this HtmlHelper helper)
        { return new EndSvgDefs(); }
    }
    public static class SvgUseHelper
    {
        public static SvgUse SvgUse(this HtmlHelper helper)
        { return new SvgUse(); }

        public static EndSvgUse EndSvgUse(this HtmlHelper helper)
        { return new EndSvgUse(); }
    }
    public static class SvgSymbolHelper
    {
        public static BeginSvgSymbol BeginSvgSymbol(this HtmlHelper helper)
        { return new BeginSvgSymbol(); }

        public static EndSvgSymbol EndSvgSymbol(this HtmlHelper helper)
        { return new EndSvgSymbol(); }
    }

    // Descriptive
    public static class SvgDescHelper
    {
        public static SvgDesc SvgDesc(this HtmlHelper helper)
        { return new SvgDesc(); }
    }
    public static class SvgMetadataHelper
    {
        public static BeginSvgMetadata BeginSvgMetadata(this HtmlHelper helper)
        { return new BeginSvgMetadata(); }

        public static EndSvgMetadata EndSvgMetadata(this HtmlHelper helper)
        { return new EndSvgMetadata(); }
    }
    public static class SvgTitleHelper
    {
        public static SvgTitle SvgTitle(this HtmlHelper helper)
        { return new SvgTitle(); }
    }

    // Basic Shapes
    public static class SvgLineHelper
    {
        public static SvgLine SvgLine(this HtmlHelper helper)
        {return new SvgLine();}

        public static EndSvgLine EndSvgLine(this HtmlHelper helper)
        {return new EndSvgLine();}
    }
    public static class SvgRectHelper
    {
        public static SvgRect SvgRect(this HtmlHelper helper)
        {return new SvgRect();}

        public static EndSvgRect EndSvgRect(this HtmlHelper helper)
        {return new EndSvgRect();}
    }
    public static class SvgCircleHelper
    {
        public static SvgCircle SvgCircle(this HtmlHelper helper)
        { return new SvgCircle(); }

        public static EndSvgCircle EndSvgCircle(this HtmlHelper helper)
        { return new EndSvgCircle(); }
    }
    public static class SvgEllipseHelper
    {
        public static SvgEllipse SvgEllipse(this HtmlHelper helper)
        { return new SvgEllipse(); }

        public static EndSvgEllipse EndSvgEllipse(this HtmlHelper helper)
        { return new EndSvgEllipse(); }
    }
    public static class SvgPathHelper
    {
        public static SvgPath SvgPath(this HtmlHelper helper)
        { return new SvgPath(); }

        public static EndSvgPath EndSvgPath(this HtmlHelper helper)
        { return new EndSvgPath(); }
    }
    public static class SvgPolygonHelper
    {
        public static SvgPolygon SvgPolygon(this HtmlHelper helper)
        { return new SvgPolygon(); }

        public static EndSvgPolygon EndSvgPolygon(this HtmlHelper helper)
        { return new EndSvgPolygon(); }
    }
    public static class SvgPolylineHelper
    {
        public static SvgPolyline SvgPolyline(this HtmlHelper helper)
        { return new SvgPolyline(); }

        public static EndSvgPolyline EndSvgPolyline(this HtmlHelper helper)
        { return new EndSvgPolyline(); }
    }

    // Text
    public static class SvgTextHelper
    {
        public static SvgText SvgText(this HtmlHelper helper)
        { return new SvgText(); }

        public static EndSvgText EndSvgText(this HtmlHelper helper)
        { return new EndSvgText(); }
    }
    public static class SvgTSpanHelper
    {
        public static SvgTSpan SvgTSpan(this HtmlHelper helper)
        { return new SvgTSpan(); }

        public static EndSvgTSpan EndSvgTSpan(this HtmlHelper helper)
        { return new EndSvgTSpan(); }
    }
    public static class SvgTRefHelper
    {
        public static SvgTRef SvgTRef(this HtmlHelper helper)
        { return new SvgTRef(); }

        public static EndSvgTRef EndSvgTRef(this HtmlHelper helper)
        { return new EndSvgTRef(); }
    }
    public static class SvgTextPathHelper
    {
        public static SvgTextPath SvgTextPath(this HtmlHelper helper)
        { return new SvgTextPath(); }

        public static EndSvgTextPath EndSvgTextPath(this HtmlHelper helper)
        { return new EndSvgTextPath(); }
    }
}
