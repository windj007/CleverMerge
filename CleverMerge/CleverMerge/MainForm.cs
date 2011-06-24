using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CleverMerge.GUI;
using CleverMerge.Projects;

namespace CleverMerge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Private methods

        /// <summary>
        /// Create window for the specified project
        /// </summary>
        /// <param name="project">Project to create window for</param>
        private void CreateWindowForProject(Project project)
        {
            var form = new ProjectForm(project);
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            windowsTabs.RegisterWindow(form);
        }
        
        #endregion

        #region Menu events handlers

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWindowForProject(ProjectManager.Instance.CreateProject());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var project = ProjectManager.Instance.OpenProject();

            if (project == null)
                return;

            CreateWindowForProject(project);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.Instance.SaveProject();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.Instance.SaveProjectAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.Instance.CloseProject();
            Close();
        }
        
        #endregion
    }
}
