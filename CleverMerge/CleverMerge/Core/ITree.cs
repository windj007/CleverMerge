using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Core
{
    /// <summary>
    /// Declaration of base responsibilities for all tree nodes
    /// </summary>
    public interface ITree
    {
        /// <summary>
        /// Occures when it's necessary to refresh current tree node
        /// </summary>
        event EventHandler NeedRefreshView;
        /// <summary>
        /// The name displayed in TreeView
        /// </summary>
        string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// The icon displayed in TreeView near that node
        /// </summary>
        System.Drawing.Icon Icon
        {
            get;
            set;
        }

        /// <summary>
        /// The part of the file that corresponds to this tree node
        /// </summary>
        string Content
        {
            get;
            set;
        }

        /// <summary>
        /// The hint showed in TreeView when mouse howers over that node
        /// </summary>
        string Hint
        {
            get;
            set;
        }

        /// <summary>
        /// Change the current tree view corresponding to differences between current tree and other tree
        /// </summary>
        /// <param name="otherTree">The tree to compare to</param>
        void CompareTo(ITree otherTree);

        /// <summary>
        /// Prepare the IDisplay component to display current node's content
        /// </summary>
        /// <returns>Prepared component able to display current node's content</returns>
        CleverMerge.Core.DisplayBase DisplayContent();
    }
}
