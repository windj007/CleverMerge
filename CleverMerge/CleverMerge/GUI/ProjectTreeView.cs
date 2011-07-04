using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CleverMerge.Core;

namespace CleverMerge.GUI
{
    /// <summary>
    /// Control for browsing and editing trees
    /// </summary>
    public partial class ProjectTreeView : DisplayBase
    {
        #region Private fields

        private TreeBase fullTree = null;

        #endregion

        #region Public properties

        /// <summary>
        /// Full tree displayed by this ProjectTreeView
        /// </summary>
        public TreeBase FullTree
        {
            get
            {
                return fullTree;
            }
            set
            {
                fullTree = value;
                RefreshContent();
            }
        }

        /// <summary>
        /// FullTree that is selected now. It's a subtree of FullTree
        /// </summary>
        public TreeBase SelectedTree
        {
            get
            {
                return treeView.SelectedNode as TreeBase;
            }
            set
            {
                treeView.SelectedNode = value;
            }
        }

        #endregion

        public ProjectTreeView()
        {
            InitializeComponent();
        }

        #region Public methods

        /// <summary>
        /// Get actual content from corresponding ITree object
        /// </summary>
        public override void RefreshContent()
        {
            treeView.Nodes.Clear();

            if (fullTree != null)
                treeView.Nodes.Add(fullTree);
        }

        /// <summary>
        /// Commit changes to corresponding ITree object
        /// </summary>
        public override void SaveChanges()
        {
        }

        /// <summary>
        /// Check whether the content in the editor was changed by user since last SaveChanges or RefreshContent call
        /// </summary>
        /// <returns>true if content was changed, false otherwise</returns>
        public override bool IsDirty()
        {
            return false;
        }
        
        #endregion

        #region Private methods

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (SelectedTreeChanged != null)
                SelectedTreeChanged(this, EventArgs.Empty);
        }

        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (NodeExpanded != null)
                NodeExpanded(this, new TreeEventArgs(e.Node as TreeBase));
        }

        private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (NodeCollapsed != null)
                NodeCollapsed(this, new TreeEventArgs(e.Node as TreeBase));
        }

        #endregion

        #region Public events

        /// <summary>
        /// Occurs when selected node changes.
        /// </summary>
        public event EventHandler SelectedTreeChanged;

        /// <summary>
        /// Occurs when node is collapsed.
        /// </summary>
        public event EventHandler<TreeEventArgs> NodeCollapsed;

        /// <summary>
        /// Occurs when node is expanded.
        /// </summary>
        public event EventHandler<TreeEventArgs> NodeExpanded;

        #endregion
    }
}
