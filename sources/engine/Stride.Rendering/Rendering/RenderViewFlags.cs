// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;

namespace Stride.Rendering
{
    [Flags]
    public enum RenderViewFlags
    {
        /// <summary>
        /// Nothing special.
        /// </summary>
        None = 0,

        /// <summary>
        /// Not being drawn directly (i.e. shared view for VR eyes).
        /// </summary>
        NotDrawn = 1,
    }
}
