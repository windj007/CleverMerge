using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CleverMerge.GUI
{
    /// <summary>
    /// Control containing two DisplayBases during two-side comparison.  Comparison viewer for two-side project
    /// </summary>
    public partial class TwoSideComparison : ComparisonBase
    {
        public TwoSideComparison()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DisplayBase for left branch of project
        /// </summary>
        public CleverMerge.Core.DisplayBase LeftDisplay
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
        /// DisplayBase for right branch of project
        /// </summary>
        public CleverMerge.Core.DisplayBase RightDisplay
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
