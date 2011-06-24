using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CleverMerge.Projects;

namespace CleverMerge.GUI
{
    /// <summary>
    /// Control containing two DisplayBases during two-side comparison.  Comparison viewer for two-side project
    /// </summary>
    public partial class TwoSideComparison : ComparisonBase
    {
        #region Public properties

        /// <summary>
        /// DisplayBase for left branch of project
        /// </summary>
        public CleverMerge.Core.DisplayBase LeftDisplay { get; private set; }

        /// <summary>
        /// DisplayBase for right branch of project
        /// </summary>
        public CleverMerge.Core.DisplayBase RightDisplay { get; private set; }
        
        #endregion

        public TwoSideComparison(Project project)
            : base(project)
        {
            InitializeComponent();
        }

        public override void RefreshContent()
        {

        }
    }
}
