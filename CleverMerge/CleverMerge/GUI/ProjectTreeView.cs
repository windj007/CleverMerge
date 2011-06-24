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
    public partial class ProjectTreeView : CleverMerge.Core.DisplayBase
    {
        public ProjectTreeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Full tree displayed by this ProjectTreeView
        /// </summary>
        public ITree FullTree
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
        /// FullTree that is selected now. It's a subtree of FullTree
        /// </summary>
        public ITree SelectedTree
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
        /// Get actual content from corresponding ITree object
        /// </summary>
        public override void RefreshContent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commit changes to corresponding ITree object
        /// </summary>
        public override void SaveChanges()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check whether the content in the editor was changed by user since last SaveChanges or RefreshContent call
        /// </summary>
        /// <returns>true if content was changed, false otherwise</returns>
        public override bool IsDirty()
        {
            throw new NotImplementedException();
        }
    }
}
