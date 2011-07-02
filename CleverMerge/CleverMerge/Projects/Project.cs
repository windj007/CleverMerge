using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Projects
{
    /// <summary>
    /// BaseDirectory class for all comparison projects.
    /// </summary>
    [Serializable]
    public class Project
    {
        /// <summary>
        /// List of actions made by user during editing project branches
        /// </summary>
        public List<Action> ChangeHistory { get; private set; }

        /// <summary>
        /// Project file name
        /// </summary>
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(Path))
                    return "";

                return System.IO.Path.GetFileNameWithoutExtension(Path);
            }
        }

        /// <summary>
        /// Full path to project file name
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// True if project was changed by user
        /// </summary>
        public bool IsDirty { get; set; }

        public Project()
        {
            ChangeHistory = new List<Action>();
        }
    }
}
