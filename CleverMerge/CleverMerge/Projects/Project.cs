using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Projects
{
    /// <summary>
    /// BaseDirectory class for all comparison projects.
    /// </summary>
    public class Project
    {
        public List<Action> ChangeHistory
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
        /// Project file name
        /// </summary>
        public string Name
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
        /// Full path to project file name
        /// </summary>
        public string Path
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
