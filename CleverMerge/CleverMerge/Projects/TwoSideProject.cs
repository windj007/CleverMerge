using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Projects
{
    /// <summary>
    /// Project representing comparison of two folders
    /// </summary>
    [Serializable]
    public class TwoSideProject : Project
    {
        /// <summary>
        /// Path to directory displayed in the left of comparison viewer
        /// </summary>
        public string LeftDirectory { get; set; }

        /// <summary>
        /// Path to directory displayed in the right of comparison viewer
        /// </summary>
        public string RightDirectory { get; set; }
    }
}
