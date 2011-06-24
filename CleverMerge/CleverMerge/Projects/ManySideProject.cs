using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Projects
{
    /// <summary>
    /// Project representing comparison of many branches with common base folder
    /// </summary>
    public class ManySideProject : Project
    {
        /// <summary>
        /// Path to the directory containing the common base version for all branches
        /// </summary>
        public string BaseDirectory
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
        /// List of paths to directories containing branches
        /// </summary>
        public List<string> Branches
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
