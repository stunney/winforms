// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Drawing;

namespace System.Windows.Forms
{
    /// <devdoc>
    /// Provides data for the <see cref='System.Windows.Forms.Control.Invalidate'/> event.
    /// </devdoc>
    public class InvalidateEventArgs : EventArgs
    {
        /// <devdoc>
        /// Initializes a new instance of the <see cref='System.Windows.Forms.InvalidateEventArgs'/>
        /// class.
        /// </devdoc>
        public InvalidateEventArgs(Rectangle invalidRect)
        {
            InvalidRect = invalidRect;
        }

        /// <devdoc>
        /// Gets a value indicating the <see cref='System.Drawing.Rectangle'/> that contains the
        /// invalidated window area.
        /// </devdoc>
        public Rectangle InvalidRect { get; }
    }
}
