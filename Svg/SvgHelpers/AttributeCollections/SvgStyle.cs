using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// 
    /// </summary>
    public class SvgStyle : IHideObjectMembers
    {
        #region AttributeBase fields
        string _alignment_baseline;
        string _baseline_shift;
        string _clip;
        string _clip_path;
        string _clip_rule;
        string _color;
        string _color_interpolation;
        string _color_interpolation_filters;
        string _color_profile;
        string _color_rendering;
        string _cursor;
        string _direction;
        string _display;
        string _dominant_baseline;
        string _enable_background;
        string _fill;
        string _fill_opacity;
        string _fill_rule;
        string _filter;
        string _flood_color;
        string _flood_opacity;
        string _font_family;
        string _font_size;
        string _font_size_adjust;
        string _font_stretch;
        string _font_style;
        string _font_variant;
        string _font_weight;
        string _glyph_orientation_horizontal;
        string _glyph_orientation_vertical;
        string _image_rendering;
        string _kerning;
        string _letter_spacing;
        string _lighting_color;
        string _marker_end;
        string _marker_mid;
        string _marker_start;
        string _mask;
        string _opacity;
        string _overflow;
        string _pointer_events;
        string _shape_rendering;
        string _stop_color;
        string _stop_opacity;
        string _stroke;
        string _stroke_dasharray;
        string _stroke_dashoffset;
        string _stroke_linecap;
        string _stroke_linejoin;
        string _stroke_miterlimit;
        string _stroke_opacity;
        string _stroke_width;
        string _text_anchor;
        string _text_decoration;
        string _text_rendering;
        string _unicode_bidi;
        string _visibility;
        string _word_spacing;
        string _writing_mode;
        string _otherAttributeName;
        string _otherAttributeValue;
        IList<string> _attributeStack;
        #endregion

        /// <summary>
        /// Collection of styling attributes to be applied to an SVG element.
        /// </summary>
        public SvgStyle()
        {
            _attributeStack = new List<string>();
        }

        /// <AlignmentBaseline />
        /// <summary>
        /// <para>This property specifies how an object is aligned with respect to its parent.</para>
        /// <para>This property specifies which baseline of this element is to be aligned with the corresponding</para> 
        /// <para>baseline of the parent. It defaults to the baseline with the same name as the computed</para>
        /// <para>value of the alignment-baseline property.</para>
        /// </summary>
        /// <param name="alignment_baseline"><para>auto | baseline | before-edge | text-before-edge |</para>
        /// <para>middle | central | after-edge | text-after-edge | ideographic | alphabetic |</para>
        /// <para>hanging | mathematical | inherit</para></param>
        /// <returns></returns>
        public SvgStyle AlignmentBaseline(string alignment_baseline)
        {
            this._alignment_baseline = alignment_baseline;
            if (this == null) throw new Exception("Method SvgStyle.Alignment_Baseline resulted in a null value.");
            _attributeStack.Add("alignment-baseline:" + _alignment_baseline);
            return this;
        }

        /// <BaselineShift />
        /// <summary>
        /// <para>The ‘baseline-shift’ property allows repositioning of the dominant-baseline relative </para>
        /// <para>to the dominant-baseline of the parent text content element. The shifted object might be a sub- or superscript.</para>
        /// <para>Within the shifted object, the whole baseline-table is offset; not just a single baseline.</para>
        /// </summary>
        /// <param name="baseline_shift">baseline | sub | super | [percentage] | [length] | inherit</param>
        /// <returns></returns>
        public SvgStyle BaselineShift(string baseline_shift)
        {
            this._baseline_shift = baseline_shift;
            if (this == null) throw new Exception("Method SvgStyle.Baseline_Shift resulted in a null value.");
            _attributeStack.Add("baseline-shift:" + _baseline_shift);
            return this;
        }

        /// <Clip />
        /// <summary>
        /// <para>The ‘clip’ property has the same parameter values as defined in CSS2 ([CSS2], section 11.1.2).</para
        /// ><para>Unitless values, which indicate current user coordinates, are permitted on the coordinate values on the [shape].</para>
        /// <para>The value of auto defines a clipping path along the bounds of the viewport created by the given element.</para>
        /// </summary>
        /// <param name="clip">[shape] | auto | inherit</param>
        /// <returns></returns>
        public SvgStyle Clip(string clip)
        {
            this._clip = clip;
            if (this == null) throw new Exception("Method SvgStyle.Clip resulted in a null value.");
            _attributeStack.Add("clip:" + _clip);
            return this;
        }

        /// <ClipPath />
        /// <summary>
        /// <para>(funciri) An IRI reference to another graphical object within the same SVG document</para>
        /// <para>fragment which will be used as the clipping path. If the IRI reference is not valid</para>
        /// <para>(e.g it points to an object that doesn't exist or the object is not a ‘clipPath’ element)</para>
        /// <para>the ‘clip-path’ property must be treated as if it hadn't been specified.</para>
        /// </summary>
        /// <param name="clip_path">[funciri] | none | inherit</param>
        /// <returns></returns>
        public SvgStyle ClipPath(string clip_path)
        {
            this._clip_path = clip_path;
            if (this == null) throw new Exception("Method SvgStyle.Clip_Path resulted in a null value.");
            _attributeStack.Add("clip-path:" + _clip_path);
            return this;
        }

        /// <ClipRule />
        /// <summary>
        /// <para>The ‘clip-rule’ property only applies to graphics elements that are </para>
        /// <para>contained within a ‘clipPath’ element. </para>
        /// </summary>
        /// <param name="clip_rule">nonzero | evenodd | inherit</param>
        /// <returns></returns>
        public SvgStyle ClipRule(string clip_rule)
        {
            this._clip_rule = clip_rule;
            if (this == null) throw new Exception("Method SvgStyle.Clip_Rule resulted in a null value.");
            _attributeStack.Add("clip-rule:" + _clip_rule);
            return this;
        }

        /// <Color />
        /// <summary>
        /// Specify color as you would in CSS2
        /// </summary>
        /// <param name="color">[color] | inherit</param>
        /// <returns></returns>
        public SvgStyle Color(string color)
        {
            this._color = color;
            if (this == null) throw new Exception("Method SvgStyle.Color resulted in a null value.");
            _attributeStack.Add("color:" + _color);
            return this;
        }

        /// <ColorInterpolation />
        /// <summary>
        /// <para>The ‘color-interpolation’ property specifies the color space for gradient </para>
        /// <para>interpolations, color animations and alpha compositing.</para>
        /// </summary>
        /// <param name="color_interpolation">auto | sRGB | linearRGB | inherit</param>
        /// <returns></returns>
        public SvgStyle ColorInterpolation(string color_interpolation)
        {
            this._color_interpolation = color_interpolation;
            if (this == null) throw new Exception("Method SvgStyle.Color_Interpolation resulted in a null value.");
            _attributeStack.Add("color-interpolation:" + _color_interpolation);
            return this;
        }

        /// <ColorInterpolation_Filters />
        /// <summary>
        /// <para>The ‘color-interpolation-filters’ property specifies the color space for </para>
        /// <para>imaging operations performed via filter effects.</para>
        /// </summary>
        /// <param name="color_interpolation_filters">auto | sRGB | linearRGB | inherit</param>
        /// <returns></returns>
        public SvgStyle ColorInterpolation_Filters(string color_interpolation_filters)
        {
            this._color_interpolation_filters = color_interpolation_filters;
            if (this == null) throw new Exception("Method SvgStyle.Color_Interpolation_Filters resulted in a null value.");
            _attributeStack.Add("color-interpolation-filters:" + _color_interpolation_filters);
            return this;
        }

        /// <ColorProfile />
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color_profile">auto | sRGB | [name] | [iri] | inherit</param>
        /// <returns></returns>
        public SvgStyle ColorProfile(string color_profile)
        {
            this._color_profile = color_profile;
            if (this == null) throw new Exception("Method SvgStyle.Color_Profile resulted in a null value.");
            _attributeStack.Add("color-profile:" + _color_profile);
            return this;
        }

        /// <ColorRendering />
        /// <summary>
        /// <para>The ‘color-rendering’ property provides a hint to the SVG user agent about </para>
        /// <para>how to optimize its color interpolation and compositing operations.</para>
        /// </summary>
        /// <param name="color_rendering">auto | optimizeSpeed | optimizeQuality | inherit</param>
        /// <returns></returns>
        public SvgStyle ColorRendering(string color_rendering)
        {
            this._color_rendering = color_rendering;
            if (this == null) throw new Exception("Method SvgStyle.Color_Rendering resulted in a null value.");
            _attributeStack.Add("color-rendering:" + _color_rendering);
            return this;
        }

        /// <Cursor />
        /// <summary>
        /// <para>The ‘cursor’ property for SVG is identical to the ‘cursor’ property defined in </para>
        /// <para>CSS2 ([CSS2], section 18.1), with the additional requirement that SVG user </para>
        /// <para>agents must support cursors defined by the SVG ‘cursor’ element. </para>
        /// <para>This gives a single, cross-platform, interoperable cursor format,</para>
        /// <para> with PNG as the raster component.</para>
        /// </summary>
        /// <param name="cursor">[ [(funciri) ,]* [ auto | crosshair | default | pointer | move | e-resize | ne-resize | nw-resize | n-resize | se-resize | sw-resize | s-resize | w-resize| text | wait | help ] ] | inherit</param>
        /// <returns></returns>
        public SvgStyle Cursor(string cursor)
        {
            this._cursor = cursor;
            if (this == null) throw new Exception("Method SvgStyle.Cursor resulted in a null value.");
            _attributeStack.Add("cursor:" + _cursor);
            return this;
        }

        /// <Direction />
        /// <summary>
        /// <para>This property specifies the base writing direction of text and the direction of </para>
        /// <para>embeddings and overrides (see ‘unicode-bidi’) for the Unicode bidirectional </para>
        /// <para>algorithm. For the ‘direction’ property to have any effect, the ‘unicode-bidi’ </para>
        /// <para>property's value must be embed or bidi-override.</para>
        /// </summary>
        /// <param name="direction">ltr | rtl | inherit</param>
        /// <returns></returns>
        public SvgStyle Direction(string direction)
        {
            this._direction = direction;
            if (this == null) throw new Exception("Method SvgStyle.Direction resulted in a null value.");
            _attributeStack.Add("direction:" + _direction);
            return this;
        }

        /// <Display />
        /// <summary>
        /// <para>The ‘display’ property only affects the direct rendering of a given element, </para>
        /// <para>whereas it does not prevent elements from being referenced by other elements. </para>
        /// <para>For example, setting display: none on a ‘path’ element will prevent that </para>
        /// <para>element from getting rendered directly onto the canvas, but the ‘path’ </para>
        /// <para>element can still be referenced.</para>
        /// </summary>
        /// <param name="display"><para>inline | block | list-item | run-in | compact | marker | table | inline-table |</para>
        /// <para> table-row-group | table-header-group | table-footer-group | table-row | table-column-group |</para>
        /// <para> table-column | table-cell | table-caption | none | inherit</para></param>
        /// <returns></returns>
        public SvgStyle Display(string display)
        {
            this._display = display;
            if (this == null) throw new Exception("Method SvgStyle.Display resulted in a null value.");
            _attributeStack.Add("display:" + _display);
            return this;
        }

        /// <DominantBaseline />
        /// <summary>
        /// <para>The "dominant-baseline" property is used to determine or re-determine a scaled</para>
        /// <para>-baseline-table. A scaled-baseline-table is a compound value with three </para>
        /// <para>components: a baseline-identifier for the dominant-baseline, </para>
        /// <para>a baseline-table and a baseline-table font-size.</para>
        /// </summary>
        /// <param name="dominant_baseline"><para>auto | use-script | no-change | reset-size | ideographic | alphabetic |</para>
        /// <para>hanging | mathematical | central | middle | text-after-edge | text-before-edge | inherit</para></param>
        /// <returns></returns>
        public SvgStyle DominantBaseline(string dominant_baseline)
        {
            this._dominant_baseline = dominant_baseline;
            if (this == null) throw new Exception("Method SvgStyle.Dominant_Baseline resulted in a null value.");
            _attributeStack.Add("dominant-baseline:" + _dominant_baseline);
            return this;
        }

        /// <EnableBackground />
        /// <summary>
        /// <para>SVG content must explicitly indicate to the SVG user agent that the </para>
        /// <para>document needs access to the background image before BackgroundImage </para>
        /// <para>and BackgroundAlpha pseudo input images can be used. </para>
        /// <para>‘enable-background’ is only applicable to container elements</para>
        /// <para> and specifies how the SVG user agents manages the accumulation </para>
        /// <para>of the background image.</para>
        /// </summary>
        /// <param name="enable_background">accumulate | new [ (x) (y) (width) (height) ] | inherit</param>
        /// <returns></returns>
        public SvgStyle EnableBackground(string enable_background)
        {
            this._enable_background = enable_background;
            if (this == null) throw new Exception("Method SvgStyle.Enable_Background resulted in a null value.");
            _attributeStack.Add("enable-background:" + _enable_background);
            return this;
        }

        /// <Fill />
        /// <summary>
        /// <para>The ‘fill’ property paints the interior of the given graphical element. </para>
        /// <para>The area to be painted consists of any areas inside the outline of </para>
        /// <para>the shape. To determine the inside of the shape, all subpaths are </para>
        /// <para>considered, and the interior is determined according to the rules </para>
        /// <para>associated with the current value of the ‘fill-rule’ property.</para>
        /// </summary>
        /// <param name="fill">[paint]</param>
        /// <returns></returns>
        public SvgStyle Fill(string fill)
        {
            this._fill = fill;
            if (this == null) throw new Exception("Method SvgStyle.Fill resulted in a null value.");
            _attributeStack.Add("fill:" + _fill);
            return this;
        }

        /// <FillOpacity />
        /// <summary>
        /// <para>‘fill-opacity’ specifies the opacity of the painting operation used to </para>
        /// <para>paint the interior the current object. </para>
        /// </summary>
        /// <param name="fill_opacity">[opacity-value] | inherit</param>
        /// <returns></returns>
        public SvgStyle FillOpacity(string fill_opacity)
        {
            this._fill_opacity = fill_opacity;
            if (this == null) throw new Exception("Method SvgStyle.Fill_Opacity resulted in a null value.");
            _attributeStack.Add("fill-opacity:" + _fill_opacity);
            return this;
        }

        /// <FillRule />
        /// <summary>
        /// <para>The ‘fill-rule’ property indicates the algorithm which is to be used to </para>
        /// <para>determine what parts of the canvas are included inside the shape. </para>
        /// <para>For a simple, non-intersecting path, it is intuitively clear what </para>
        /// <para>region lies "inside"; however, for a more complex path, such as a </para>
        /// <para>path that intersects itself or where one subpath encloses another, </para>
        /// <para>the interpretation of "inside" is not so obvious.</para>
        /// </summary>
        /// <param name="fill_rule">nonzero | evenodd | inherit</param>
        /// <returns></returns>
        public SvgStyle FillRule(string fill_rule)
        {
            this._fill_rule = fill_rule;
            if (this == null) throw new Exception("Method SvgStyle.Fill_Rule resulted in a null value.");
            _attributeStack.Add("fill-rule:" + _fill_rule);
            return this;
        }

        /// <Filter />
        /// <summary>
        /// <para>[funciri] A Functional IRI reference to a ‘filter’ element which defines </para>
        /// <para>the filter effects that shall be applied to this element.</para>
        /// </summary>
        /// <param name="filter">[funciri] | none | inherit</param>
        /// <returns></returns>
        public SvgStyle Filter(string filter)
        {
            this._filter = filter;
            if (this == null) throw new Exception("Method SvgStyle.Filter resulted in a null value.");
            _attributeStack.Add("filter:" + _filter);
            return this;
        }

        /// <FloodColor />
        /// <summary>
        /// <para>The ‘flood-color’ property indicates what color to use to flood the current </para>
        /// <para>filter primitive subregion. The keyword currentColor and ICC colors can </para>
        /// <para>be specified in the same manner as within a [paint] specification for </para>
        /// <para>the ‘fill’ and ‘stroke’ properties.</para>
        /// </summary>
        /// <param name="flood_color">currentColor | [color] (icccolor) | inherit</param>
        /// <returns></returns>
        public SvgStyle FloodColor(string flood_color)
        {
            this._flood_color = flood_color;
            if (this == null) throw new Exception("Method SvgStyle.Flood_Color resulted in a null value.");
            _attributeStack.Add("flood-color:" + _flood_color);
            return this;
        }

        /// <FloodOpacity />
        /// <summary>
        /// <para>The ‘flood-opacity’ property defines the opacity value to use across the </para>
        /// <para>entire filter primitive subregion.</para>
        /// </summary>
        /// <param name="flood_opacity">[opacity-value] | inherit</param>
        /// <returns></returns>
        public SvgStyle FloodOpacity(string flood_opacity)
        {
            this._flood_opacity = flood_opacity;
            if (this == null) throw new Exception("Method SvgStyle.Flood_Opacity resulted in a null value.");
            _attributeStack.Add("flood-opacity:" + _flood_opacity);
            return this;
        }

        /// <FontFamily />
        /// <summary>
        /// <para>This property indicates which font family is to be used to render the text, </para>
        /// <para>specified as a prioritized list of font family names and/or generic family names.</para>
        /// </summary>
        /// <param name="font_family">[[ (family-name) | (generic-family) ],]* [(family-name) | (generic-family)] | inherit</param>
        /// <returns></returns>
        public SvgStyle FontFamily(string font_family)
        {
            this._font_family = font_family;
            if (this == null) throw new Exception("Method SvgStyle.FontFamily resulted in a null value.");
            _attributeStack.Add("font-family:" + _font_family);
            return this;
        }

        /// <FontSize />
        /// <summary>
        /// <para>This property refers to the size of the font from baseline to baseline when </para>
        /// <para>multiple lines of text are set solid in a multiline layout environment.</para>
        /// </summary>
        /// <param name="font_size">[absolute-size] | [relative-size] | [length] | [percentage] | inherit</param>
        /// <returns></returns>
        public SvgStyle FontSize(string font_size)
        {
            this._font_size = font_size;
            if (this == null) throw new Exception("Method SvgStyle.FontSize resulted in a null value.");
            _attributeStack.Add("font-size:" + _font_size);
            return this;
        }

        /// <FontSizeAdjust />
        /// <summary>
        /// <para>This property allows authors to specify an aspect value for an element that </para>
        /// <para>will preserve the x-height of the first choice font in a substitute font.</para>
        /// </summary>
        /// <param name="font_size_adjust">[number] | none | inherit</param>
        /// <returns></returns>
        public SvgStyle FontSizeAdjust(string font_size_adjust)
        {
            this._font_size_adjust = font_size_adjust;
            if (this == null) throw new Exception("Method SvgStyle.FontSizeAdjust resulted in a null value.");
            _attributeStack.Add("font-size-adjust:" + _font_size_adjust);
            return this;
        }

        /// <FontStretch />
        /// <summary>
        /// This property indicates the desired amount of condensing or expansion in the glyphs used to render the text. 
        /// </summary>
        /// <param name="font_stretch"><para>normal | wider | narrower | ultra-condensed | extra-condensed |</para>
        /// <para> condensed | semi-condensed | semi-expanded | expanded | extra-expanded | ultra-expanded | inherit</para></param>
        /// <returns></returns>
        public SvgStyle FontStretch(string font_stretch)
        {
            this._font_stretch = font_stretch;
            if (this == null) throw new Exception("Method SvgStyle.FontStretch resulted in a null value.");
            _attributeStack.Add("font-stretch:" + _font_stretch);
            return this;
        }

        /// <FontStyle />
        /// <summary>
        /// <para>This property specifies whether the text is to be rendered using a normal,</para>
        /// <para> italic or oblique face.</para>
        /// </summary>
        /// <param name="font_style">normal | italic | oblique | inherit</param>
        /// <returns></returns>
        public SvgStyle FontStyle(string font_style)
        {
            this._font_style = font_style;
            if (this == null) throw new Exception("Method SvgStyle.FontStyle resulted in a null value.");
            _attributeStack.Add("font-style:" + _font_style);
            return this;
        }

        /// <FontWeight />
        /// <summary>
        /// <para>This property refers to the boldness or lightness of the glyphs used to </para>
        /// <para>render the text, relative to other fonts in the same font family. </para>
        /// </summary>
        /// <param name="font_weight">normal | bold | bolder | lighter | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | inherit</param>
        /// <returns></returns>
        public SvgStyle FontWeight(string font_weight)
        {
            this._font_weight = font_weight;
            if (this == null) throw new Exception("Method SvgStyle.FontWeight resulted in a null value.");
            _attributeStack.Add("font-weight:" + _font_weight);
            return this;
        }

        /// <FontVariant />
        /// <summary>
        /// <para>This property indicates whether the text is to be rendered using the normal glyphs</para>
        /// <para> for lowercase characters or using small-caps glyphs for lowercase characters.</para>
        /// </summary>
        /// <param name="font_variant">normal | small-caps | inherit</param>
        /// <returns></returns>
        public SvgStyle FontVariant(string font_variant)
        {
            this._font_variant = font_variant;
            if (this == null) throw new Exception("Method SvgStyle.FontVariant resulted in a null value.");
            _attributeStack.Add("font-variant:" + _font_variant);
            return this;
        }

        /// <GlyphOrientationHorizontal />
        /// <summary>
        /// <para>Two properties control the glyph orientation relative to the reference </para>
        /// <para>orientation for each of the two possible inline-progression-directions.</para>
        /// <para> ‘glyph-orientation-vertical’ controls glyph orientation when the </para>
        /// <para>inline-progression-direction is vertical. ‘glyph-orientation-horizontal’ </para>
        /// <para>controls glyph orientation when the inline-progression-direction is horizontal.</para>
        /// </summary>
        /// <param name="glyph_orientation_horizontal">[angle] | inherit</param>
        /// <returns></returns>
        public SvgStyle GlyphOrientationHorizontal(string glyph_orientation_horizontal)
        {
            this._glyph_orientation_horizontal = glyph_orientation_horizontal;
            if (this == null) throw new Exception("Method SvgStyle.GlyphOrientationHorizontal resulted in a null value.");
            _attributeStack.Add("glyph-orientation-horizontal:" + _glyph_orientation_horizontal);
            return this;
        }

        /// <GlyphOrientationVertical />
        /// <summary>
        /// <para>Two properties control the glyph orientation relative to the reference </para>
        /// <para>orientation for each of the two possible inline-progression-directions.</para>
        /// <para> ‘glyph-orientation-vertical’ controls glyph orientation when the </para>
        /// <para>inline-progression-direction is vertical. ‘glyph-orientation-horizontal’ </para>
        /// <para>controls glyph orientation when the inline-progression-direction is horizontal.</para>
        /// </summary>
        /// <param name="glyph_orientation_vertical">auto | [angle] | inherit</param>
        /// <returns></returns>
        public SvgStyle GlyphOrientationVertical(string glyph_orientation_vertical)
        {
            this._glyph_orientation_vertical = glyph_orientation_vertical;
            if (this == null) throw new Exception("Method SvgStyle.GlyphOrientationVerticalresulted in a null value.");
            _attributeStack.Add("glyph-orientation-vertical:" + _glyph_orientation_vertical);
            return this;
        }

        /// <ImageRendering />
        /// <summary>
        /// <para>The creator of SVG content might want to provide a hint to the implementation </para>
        /// <para>about how to make speed vs. quality tradeoffs as it performs image </para>
        /// <para>processing. The ‘image-rendering’ property provides a hint to the </para>
        /// <para>SVG user agent about how to optimize its image rendering.</para>
        /// </summary>
        /// <param name="image_rendering">auto | optimizeSpeed | optimizeQuality | inherit</param>
        /// <returns></returns>
        public SvgStyle ImageRendering(string image_rendering)
        {
            this._image_rendering = image_rendering;
            if (this == null) throw new Exception("Method SvgStyle.ImageRendering resulted in a null value.");
            _attributeStack.Add("image-rendering:" + _image_rendering);
            return this;
        }

        /// <Kerning />
        /// <summary>
        /// <para>Indicates whether the user agent should adjust inter-glyph spacing based on </para>
        /// <para>kerning tables that are included in the relevant font (i.e., enable </para>
        /// <para>auto-kerning) or instead disable auto-kerning and instead set </para>
        /// <para>inter-character spacing to a specific length (typically, zero).</para>
        /// </summary>
        /// <param name="kerning">auto | [length] | inherit</param>
        /// <returns></returns>
        public SvgStyle Kerning(string kerning)
        {
            this._kerning = kerning;
            if (this == null) throw new Exception("Method SvgStyle.Kerning resulted in a null value.");
            _attributeStack.Add("kerning:" + _kerning);
            return this;
        }

        /// <LetterSpacing />
        /// <summary>
        /// <para>Indicates an amount of space that is to be added between text characters </para>
        /// <para>supplemental to any spacing due to the ‘kerning’ property.</para>
        /// </summary>
        /// <param name="letter_spacing">normal | [length] | inherit</param>
        /// <returns></returns>
        public SvgStyle LetterSpacing(string letter_spacing)
        {
            this._letter_spacing = letter_spacing;
            if (this == null) throw new Exception("Method SvgStyle.LetterSpacing resulted in a null value.");
            _attributeStack.Add("letter-spacing:" + _letter_spacing);
            return this;
        }

        /// <LightingColor />
        /// <summary>
        /// <para>The ‘lighting-color’ property defines the color of the light source for </para>
        /// <para>filter primitives ‘feDiffuseLighting’ and ‘feSpecularLighting’.</para>
        /// </summary>
        /// <param name="lighting_color">currentColor | [color] [(icccolor)]</param>
        /// <returns></returns>
        public SvgStyle LightingColor(string lighting_color)
        {
            this._lighting_color = lighting_color;
            if (this == null) throw new Exception("Method SvgStyle.LightingColor resulted in a null value.");
            _attributeStack.Add("lighting-color:" + _lighting_color);
            return this;
        }

        /// <MarketEnd />
        /// <summary>
        /// <para>‘Marker-end’ defines the arrowhead or polymarker that shall be drawn at the final vertex.</para>
        /// </summary>
        /// <param name="marker_end">none | [funciri] | inherit </param>
        /// <returns></returns>
        public SvgStyle MarkerEnd(string marker_end)
        {
            this._marker_end = marker_end;
            if (this == null) throw new Exception("Method SvgStyle.MarkerEnd resulted in a null value.");
            _attributeStack.Add("marker-end:" + _marker_end);
            return this;
        }

        /// <MarkerMid />
        /// <summary>
        /// <para>‘Marker-mid’ defines the arrowhead or polymarker that shall be drawn at every</para>
        /// <para> other vertex (i.e., every vertex except the first and last). </para>
        /// </summary>
        /// <param name="marker_mid">none | [funciri] | inherit </param>
        /// <returns></returns>
        public SvgStyle MarkerMid(string marker_mid)
        {
            this._marker_mid = marker_mid;
            if (this == null) throw new Exception("Method SvgStyle.MarkerMid resulted in a null value.");
            _attributeStack.Add("marker-mid:" + _marker_mid);
            return this;
        }

        /// <MarkerStart />
        /// <summary>
        /// <para>‘Marker-start’ defines the arrowhead or polymarker that shall be drawn at </para>
        /// <para>the first vertex of the given ‘path’ element or basic shape. </para>
        /// </summary>
        /// <param name="marker_start">none | [funciri] | inherit </param>
        /// <returns></returns>
        public SvgStyle MarkerStart(string marker_start)
        {
            this._marker_start = marker_start;
            if (this == null) throw new Exception("Method SvgStyle.MarkerStart resulted in a null value.");
            _attributeStack.Add("marker-start:" + _marker_start);
            return this;
        }

        /// <Mask />
        /// <summary>
        /// <para>‘Mask’ elements are never rendered directly; their only usage is as something </para>
        /// <para>that can be referenced using the ‘mask’ property. The ‘display’ property does </para>
        /// <para>not apply to the ‘mask’ element; thus, ‘mask’ elements are not directly </para>
        /// <para>rendered even if the ‘display’ property is set to a value other than none, </para>
        /// <para>and ‘mask’ elements are available for referencing even when the ‘display’ </para>
        /// ]<para>property on the ‘mask’ element or any of its ancestors is set to none.</para>
        /// </summary>
        /// <param name="mask">[funciri] | none | inherit</param>
        /// <returns></returns>
        public SvgStyle Mask(string mask)
        {
            this._mask = mask;
            if (this == null) throw new Exception("Method SvgStyle.Mask resulted in a null value.");
            _attributeStack.Add("mask:" + _mask);
            return this;
        }

        /// <Opacity />
        /// <summary>
        /// <para>Object/group opacity can be thought of conceptually as a postprocessing operation. </para>
        /// <para>Conceptually, after the object/group is rendered into an RGBA offscreen </para>
        /// <para>image, the object/group opacity setting specifies how to blend the offscreen </para>
        /// <para>image into the current background.</para>
        /// </summary>
        /// <param name="opacity">[opacity-value] | inherit</param>
        /// <returns></returns>
        public SvgStyle Opacity(string opacity)
        {
            this._opacity = opacity;
            if (this == null) throw new Exception("Method SvgStyle.Opacity resulted in a null value.");
            _attributeStack.Add("opacity:" + _opacity);
            return this;
        }

        /// <Overflow />
        /// <summary>
        /// The ‘overflow’ property has the same parameter values and has the same meaning as defined in CSS2 
        /// </summary>
        /// <param name="overflow">visible | hidden | scroll | auto | inherit</param>
        /// <returns></returns>
        public SvgStyle Overflow(string overflow)
        {
            this._overflow = overflow;
            if (this == null) throw new Exception("Method SvgStyle.Overflow resulted in a null value.");
            _attributeStack.Add("overflow:" + _overflow);
            return this;
        }

        /// <PointerEvents />
        /// <summary>
        /// <para>The ‘pointer-events’ property specifies under what circumstances a given graphics </para>
        /// <para>element can be the target element for a pointer event. </para>
        /// </summary>
        /// <param name="pointer_events"><para>visiblePainted | visibleFill | visibleStroke | visible |</para>
        /// <para>painted | fill | stroke | all | none | inherit</para></param>
        /// <returns></returns>
        public SvgStyle PointerEvents(string pointer_events)
        {
            this._pointer_events = pointer_events;
            if (this == null) throw new Exception("Method SvgStyle.PointerEvents resulted in a null value.");
            _attributeStack.Add("pointer-events:" + _pointer_events);
            return this;
        }

        /// <ShapeRendering />
        /// <summary>
        /// <para>The creator of SVG content might want to provide a hint to the implementation </para>
        /// <para>about what tradeoffs to make as it renders vector graphics elements such as </para>
        /// <para>‘path’ elements and basic shapes such as circles and rectangles.</para>
        /// <para>The ‘shape-rendering’ property provides these hints.</para>
        /// </summary>
        /// <param name="shape_rendering">to | optimizeSpeed | crispEdges | geometricPrecision | inherit</param>
        /// <returns></returns>
        public SvgStyle ShapeRendering(string shape_rendering)
        {
            this._shape_rendering = shape_rendering;
            if (this == null) throw new Exception("Method SvgStyle.ShapeRendering resulted in a null value.");
            _attributeStack.Add("shape-rendering:" + _shape_rendering);
            return this;
        }

        /// <StopColor />
        /// <summary>
        /// <para>The ‘stop-color’ property indicates what color to use at that gradient stop. </para>
        /// <para>The keyword currentColor and ICC colors can be specified in the same </para>
        /// <para>manner as within a [paint] specification for the ‘fill’ and ‘stroke’ properties.</para>
        /// </summary>
        /// <param name="stop_color">currentColor | [color] [icccolor] | inherit</param>
        /// <returns></returns>
        public SvgStyle StopColor(string stop_color)
        {
            this._stop_color = stop_color;
            if (this == null) throw new Exception("Method SvgStyle.StopColor resulted in a null value.");
            _attributeStack.Add("stop-color:" + _stop_color);
            return this;
        }

        /// <StopOpacity />
        /// <summary>
        /// The ‘stop-opacity’ property defines the opacity of a given gradient stop.
        /// </summary>
        /// <param name="stop_opacity">[opacity-value] | inherit</param>
        /// <returns></returns>
        public SvgStyle StopOpacity(string stop_opacity)
        {
            this._stop_opacity = stop_opacity;
            if (this == null) throw new Exception("Method SvgStyle.StopOpacity resulted in a null value.");
            _attributeStack.Add("stop-opacity:" + _stop_opacity);
            return this;
        }

        /// <Stroke />
        /// <summary>
        /// The ‘stroke’ property paints along the outline of the given graphical element.
        /// </summary>
        /// <param name="stroke">[paint]</param>
        /// <returns></returns>
        public SvgStyle Stroke(string stroke)
        {
            this._stroke = stroke;
            if (this == null) throw new Exception("Method SvgStyle.Stroke resulted in a null value.");
            _attributeStack.Add("stroke:" + _stroke);
            return this;
        }

        /// <StrokeDashArray />
        /// <summary>
        /// <para>‘Stroke-dasharray’ controls the pattern of dashes and gaps used to stroke paths. </para>
        /// <para>[dasharray] contains a list of comma and/or white space separated [length]s</para>
        /// <para> and [percentage]s that specify the lengths of alternating dashes and gaps.</para>
        /// </summary>
        /// <param name="stroke_dasharray">none | [dasharray] | inherit</param>
        /// <returns></returns>
        public SvgStyle StrokeDashArray(string stroke_dasharray)
        {
            this._stroke_dasharray = stroke_dasharray;
            if (this == null) throw new Exception("Method SvgStyle.StrokeDashArray resulted in a null value.");
            _attributeStack.Add("stroke-dasharray:" + _stroke_dasharray);
            return this;
        }

        /// <StrokeDashOffset />
        /// <summary>
        /// <para>‘Stroke-dashoffset’ specifies the distance into the dash pattern to start the dash.</para>
        /// </summary>
        /// <param name="stroke_dashoffset">[percentage] | [length] | inherit</param>
        /// <returns></returns>
        public SvgStyle StrokeDashOffset(string stroke_dashoffset)
        {
            this._stroke_dashoffset = stroke_dashoffset;
            if (this == null) throw new Exception("Method SvgStyle.StrokeDashOffset resulted in a null value.");
            _attributeStack.Add("stroke-dashoffset:" + _stroke_dashoffset);
            return this;
        }

        /// <StrokeLinecap />
        /// <summary>
        /// <para>‘Stroke-linecap’ specifies the shape to be used at the end of open subpaths when </para>
        /// <para>they are stroked. </para>
        /// </summary>
        /// <param name="stroke_linecap">butt | round | square | inherit</param>
        /// <returns></returns>
        public SvgStyle StrokeLinecap(string stroke_linecap)
        {
            this._stroke_linecap = stroke_linecap;
            if (this == null) throw new Exception("Method SvgStyle.StrokeLinecap resulted in a null value.");
            _attributeStack.Add("stroke-linecap:" + _stroke_linecap);
            return this;
        }

        /// <StrokeLinejoin />
        /// <summary>
        /// <para>‘stroke-linejoin’ specifies the shape to be used at the corners of paths or basic </para>
        /// <para>shapes when they are stroked. </para>
        /// </summary>
        /// <param name="stroke_linejoin">miter | round | bevel | inherit</param>
        /// <returns></returns>
        public SvgStyle StrokeLinejoin(string stroke_linejoin)
        {
            this._stroke_linejoin = stroke_linejoin;
            if (this == null) throw new Exception("Method SvgStyle.StrokeLinejoin resulted in a null value.");
            _attributeStack.Add("stroke-linejoin:" + _stroke_linejoin);
            return this;
        }

        /// <StrokeMiterLimit />
        /// <summary>
        /// <para>When two line segments meet at a sharp angle and miter joins have been specified for </para>
        /// <para>‘stroke-linejoin’, it is possible for the miter to extend far beyond the thickness </para>
        /// <para>of the line stroking the path. The ‘stroke-miterlimit’ imposes a limit on the ratio </para>
        /// <para>of the miter length to the ‘stroke-width’. When the limit is exceeded, the join is </para>
        /// <para>converted from a miter to a bevel.</para>
        /// </summary>
        /// <param name="stroke_miterlimit">[miterlimit] | inherit</param>
        /// <returns></returns>
        public SvgStyle StrokeMiterLimit(string stroke_miterlimit)
        {
            this._stroke_miterlimit = stroke_miterlimit;
            if (this == null) throw new Exception("Method SvgStyle.StrokeMiterLimit resulted in a null value.");
            _attributeStack.Add("stroke-miterlimit:" + _stroke_miterlimit);
            return this;
        }

        /// <StrokeOpacity />
        /// <summary>
        /// <para>‘stroke-opacity’ specifies the opacity of the painting operation used to stroke the current object.</para>
        /// </summary>
        /// <param name="stroke_opacity">[opacity-value] | inherit</param>
        /// <returns></returns>
        public SvgStyle StrokeOpacity(string stroke_opacity)
        {
            this._stroke_opacity = stroke_opacity;
            if (this == null) throw new Exception("Method SvgStyle.StrokeOpacity resulted in a null value.");
            _attributeStack.Add("stroke-opacity:" + _stroke_opacity);
            return this;
        }

        /// <StrokeWidth />
        /// <summary>
        /// <para>This property specifies the width of the stroke on the current object. If a [percentage] is </para>
        /// <para>used, the value represents a percentage of the current viewport. </para>
        /// </summary>
        /// <param name="stroke_width">[percentage] | [length] | inherit</param>
        /// <returns></returns>
        public SvgStyle StrokeWidth(string stroke_width)
        {
            this._stroke_width = stroke_width;
            if (this == null) throw new Exception("Method SvgStyle.StrokeWidth resulted in a null value.");
            _attributeStack.Add("stroke-width:" + _stroke_width);
            return this;
        }

        /// <TextAnchor />
        /// <summary>
        /// <para>The ‘text-anchor’ property is used to align (start-, middle- or end-alignment) a string </para>
        /// <para>of text relative to a given point.</para>
        /// </summary>
        /// <param name="text_anchor">start | middle | end | inherit</param>
        /// <returns></returns>
        public SvgStyle TextAnchor(string text_anchor)
        {
            this._text_anchor = text_anchor;
            if (this == null) throw new Exception("Method SvgStyle.TextAnchor resulted in a null value.");
            _attributeStack.Add("text-anchor:" + _text_anchor);
            return this;
        }

        /// <TextDecoration />
        /// <summary>
        /// This property describes decorations that are added to the text of an element.
        /// </summary>
        /// <param name="text_decoration">none | [ underline || overline || line-through || blink (Don't EVER use this, bad, bad developer) ] | inherit</param>
        /// <returns></returns>
        public SvgStyle TextDecoration(string text_decoration)
        {
            this._text_decoration = text_decoration;
            if (this == null) throw new Exception("Method SvgStyle.TextDecoration resulted in a null value.");
            _attributeStack.Add("text-decoration:" + _text_decoration);
            return this;
        }

        /// <TextRendering />
        /// <summary>
        /// <para>The creator of SVG content might want to provide a hint to the implementation about what tradeoffs </para>
        /// <para>to make as it renders text. The ‘text-rendering’ property provides these hints.</para>
        /// </summary>
        /// <param name="text_rendering">auto | optimizeSpeed | optimizeLegibility | geometricPrecision | inherit</param>
        /// <returns></returns>
        public SvgStyle TextRendering(string text_rendering)
        {
            this._text_rendering = text_rendering;
            if (this == null) throw new Exception("Method SvgStyle.TextRendering resulted in a null value.");
            _attributeStack.Add("text-rendering:" + _text_rendering);
            return this;
        }

        /// <UnicodeBidi />
        /// <summary>
        /// ‘unicode-bidi’ property is as specified in CSS2 
        /// </summary>
        /// <param name="unicode_bidi">normal | embed | bidi-override | inherit</param>
        /// <returns></returns>
        public SvgStyle UnicodeBidi(string unicode_bidi)
        {
            this._unicode_bidi = unicode_bidi;
            if (this == null) throw new Exception("Method SvgStyle.UnicodeBidi resulted in a null value.");
            _attributeStack.Add("unicode-bidi:" + _unicode_bidi);
            return this;
        }

        /// <Visibility />
        /// <summary>
        /// <para>Note that if the ‘visibility’ property is set to hidden on a ‘tspan’, ‘tref’ or ‘altGlyph’ element,</para>
        /// <para> then the text is invisible but still takes up space in text layout calculations.</para>
        /// </summary>
        /// <param name="visibility">visible | hidden | collapse | inherit</param>
        /// <returns></returns>
        public SvgStyle Visibility(string visibility)
        {
            this._visibility = visibility;
            if (this == null) throw new Exception("Method SvgStyle.Visibility resulted in a null value.");
            _attributeStack.Add("visibility:" + _visibility);
            return this;
        }

        /// <WordSpacing />
        /// <summary>
        /// Indicates the spacing behavior between words.
        /// </summary>
        /// <param name="word_spacing">normal | [length] | inherit</param>
        /// <returns></returns>
        public SvgStyle WordSpacing(string word_spacing)
        {
            this._word_spacing = word_spacing;
            if (this == null) throw new Exception("Method SvgStyle.WordSpacing resulted in a null value.");
            _attributeStack.Add("word-spacing:" + _word_spacing);
            return this;
        }

        /// <WritingMode />
        /// <summary>
        /// <para>The ‘writing-mode’ property specifies whether the initial inline-progression-direction for a </para>
        /// <para>‘text’ element shall be left-to-right, right-to-left, or top-to-bottom. </para>
        /// </summary>
        /// <param name="writing_mode">lr-tb | rl-tb | tb-rl | lr | rl | tb | inherit</param>
        /// <returns></returns>
        public SvgStyle WritingMode(string writing_mode)
        {
            this._writing_mode = writing_mode;
            if (this == null) throw new Exception("Method SvgStyle.WritingMode resulted in a null value.");
            _attributeStack.Add("writing-mode:" + _writing_mode);
            return this;
        }


        /// <summary>
        /// Add any attribute to the chain using a key:value pair.
        /// </summary>
        /// <param name="name">[anything]</param>
        /// <param name="value">[anything]</param>
        /// <returns></returns>
        public SvgStyle AddAttribute(string name, string value)
        {
            this._otherAttributeName = name;
            this._otherAttributeValue = value;
            if (this == null) throw new Exception("Method SvgStyle.AddAttribute resulted in a null value.");
            _attributeStack.Add(name + ":" + value);
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
            StringBuilder tag = new StringBuilder(@"style=""");
            foreach (var attrib in _attributeStack)
            {
                tag.Append(attrib);
                tag.Append("; ");
            }

            int index = tag.Length;
            tag.Remove(index - 1, 1);

            tag.Append(@"""");
            return tag.ToString();
        }

    }
}

