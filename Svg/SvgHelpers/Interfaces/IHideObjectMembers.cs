using System;
using System.ComponentModel;

namespace Odd.Svg.SvgHelpers
{
    /// <summary>
    /// Hides the 4 system objects from intellisence to make the fluent interface cleaner to use
    /// ONLY works when referenced from a .dll. Internally or with a Project - Project reference
    /// the system objects still appear in the intellisence dropdown - aaarrrgh!
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IHideObjectMembers
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        Type GetType();

        [EditorBrowsable(EditorBrowsableState.Never)]
        int GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        string ToString();

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool Equals(object obj);
    }

}
