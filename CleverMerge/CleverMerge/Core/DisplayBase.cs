using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CleverMerge.Core
{
    /// <summary>
    /// BaseDirectory class for all controls which display ITree content
    /// </summary>
    public abstract class DisplayBase : Control
    {
        /// <summary>
        /// Get actual content from corresponding ITree object
        /// </summary>
        public abstract void RefreshContent();

        /// <summary>
        /// Commit changes to corresponding ITree object
        /// </summary>
        public abstract void SaveChanges();

        /// <summary>
        /// Check whether the content in the editor was changed by user since last SaveChanges or RefreshContent call
        /// </summary>
        /// <returns>true if content was changed, false otherwise</returns>
        public abstract bool IsDirty();
    }
}
