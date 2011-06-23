using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Projects
{
    /// <summary>
    /// Utility class that handles projects
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Current project manager instance
        /// </summary>
        private static ProjectManager instance = null;

        /// <summary>
        /// Current project manager instance
        /// </summary>
        public static ProjectManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProjectManager();

                return instance;
            }
        }

        public IEnumerable<Project> RecentProjects
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int RecentHistoryCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Project CurrentProject
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
        /// Open project from the specified file. Current project will be closed.
        /// </summary>
        public Project OpenProject()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Close current project. Asks user if project must be saved
        /// </summary>
        public void CloseProject()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Save current project in the same location
        /// </summary>
        public void SaveProject()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Save current project in the specified location
        /// </summary>
        public void SaveProjectAs()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Create new project. Current project will be closed.
        /// </summary>
        public Project CreateProject()
        {
            throw new System.NotImplementedException();
        }
    }
}
