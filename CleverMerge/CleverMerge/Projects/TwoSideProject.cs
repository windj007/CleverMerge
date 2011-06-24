using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Projects
{
    /// <summary>
    /// Project representing comparison of two folders
    /// </summary>
    public class TwoSideProject : Project
    {
        /// <summary>
        /// Path to directory displayed in the left of comparison viewer
        /// </summary>
        public string LeftDirectory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Path to directory displayed in the right of comparison viewer
        /// </summary>
        public string RightDirectory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
