using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleverMerge.Utils;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace CleverMerge.Projects
{
    /// <summary>
    /// Utility class that handles projects
    /// </summary>
    public class ProjectManager
    {
        #region Private fields

        /// <summary>
        /// Current project manager instance
        /// </summary>
        private static ProjectManager instance = null;

        private List<Project> recentProjects = new List<Project>();
        private int recentHistCount = 0;
        private Project curProject = null;

        #endregion

        #region Public properties

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

        /// <summary>
        /// Recent projects list
        /// </summary>
        public IEnumerable<Project> RecentProjects
        {
            get
            {
                return recentProjects;
            }
        }

        /// <summary>
        /// Capacity of recent projects list
        /// </summary>
        public int RecentHistoryCount
        {
            get
            {
                return recentHistCount;
            }
            set
            {
                if (value < 0)
                    return;

                recentHistCount = value;
                recentProjects.Capacity = recentHistCount;
            }
        }

        /// <summary>
        /// Current project
        /// </summary>
        public Project CurrentProject
        {
            get
            {
                return curProject;
            }
        }
        
        #endregion

        private ProjectManager()
        {
        }

        #region Public methods

        /// <summary>
        /// Ask user for file name and open project from the specified file.
        /// Current project will be closed.
        /// </summary>
        public Project OpenProject()
        {
            // ask user for file name
            var fileName = "";

            var dialog = new OpenFileDialog();
            dialog.Filter = "Clever merge project (*.cmp)|*.cmp";
            dialog.CheckFileExists = true;
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                fileName = dialog.FileName;
            else
                return null;

            // load project
            Project bufProj = null;

            try
            {
                bufProj = SerializationUtility.DeserializeFromFile<Project>(fileName);
            }
            catch (SerializationException /*ex*/)
            {
                MessageBox.Show("File has wrong format");
                return null;
            }

            curProject = bufProj;
            curProject.Path = fileName;

            PushIntoHistory(curProject);

            return curProject;
        }

        /// <summary>
        /// Close current project. Asks user if project must be saved
        /// </summary>
        public void CloseProject()
        {
            if (curProject.IsDirty)
                SaveProject();

            curProject = null;
        }

        /// <summary>
        /// Save current project in the same location.
        /// If location was not specified earlier user will be asked for file name.
        /// </summary>
        public void SaveProject()
        {
            if (string.IsNullOrEmpty(curProject.Path) || !File.Exists(curProject.Path))
                SaveProjectAs();

            SerializationUtility.SerializeToFile(curProject.Path, curProject);
        }

        /// <summary>
        /// Request user for file name and save current project in the specified location
        /// </summary>
        public void SaveProjectAs()
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Clever merge project (*.cmp)|*.cmp";
            dialog.OverwritePrompt = true;
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                curProject.Path = dialog.FileName;

            SerializationUtility.SerializeToFile(curProject.Path, curProject);
        }

        /// <summary>
        /// Create new two-side comparison project. Current project will be closed.
        /// </summary>
        public Project CreateTwoWayProject()
        {
            if (curProject != null)
                SaveProject();

            curProject = new TwoWayProject
            {
                Path = "NewTwoSideProject"
            };

            PushIntoHistory(curProject);

            return curProject;
        }
        
        #endregion

        #region Private methods

        /// <summary>
        /// Push specified project to history list
        /// </summary>
        /// <param name="curProject">Project to push to list</param>
        private void PushIntoHistory(Project curProject)
        {
            recentProjects.Add(curProject);

            if (HistoryChanged != null)
                HistoryChanged(this, EventArgs.Empty);
        }
        
        #endregion

        #region Public events

        public event EventHandler HistoryChanged;

        #endregion
    }
}
