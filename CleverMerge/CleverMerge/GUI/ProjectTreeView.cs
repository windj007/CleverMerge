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
    public partial class ProjectTreeView : CleverMerge.Core.DisplayBase
    {
        public ProjectTreeView()
        {
            InitializeComponent();
        }

        public int Tree
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        public override void RefreshContent()
        {
            throw new NotImplementedException();
        }

        public override void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public override bool IsDirty()
        {
            throw new NotImplementedException();
        }
    }
}
