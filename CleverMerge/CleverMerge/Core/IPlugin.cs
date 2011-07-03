using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CleverMerge.Core
{
    /// <summary>
    /// The interface that all plugins must provide
    /// </summary>
    public interface IPlugin
    {
        #region Properties

        /// <summary>
        /// The name of the plugin. Dicplayed in plugins configuration window
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The icon of the plugin. Displayed in plugins configuration window
        /// </summary>
        Icon Icon { get; }

        /// <summary>
        /// The description of the plugin. Displayed in plugins configuration window
        /// </summary>
        string Description { get; }
        
        #endregion

        /// <summary>
        /// Build tree representation of the specified file.
        /// </summary>
        /// <remarks>Generally that tree is similar to abstract syntax tree of the program in that file.</remarks>
        /// <returns>FullTree representing file structure</returns>
        TreeBase BuildFileTree(string fileName);

        /// <summary>
        /// Check whether the file can be handled by that plugin
        /// </summary>
        /// <returns>true if the file can be handled by that plugin, false otherwise</returns>
        bool IsYourFile(string fileName);

        /// <summary>
        /// Initialize plugin
        /// </summary>
        void Initialize();

        /// <summary>
        /// Change specified trees to show differences between them
        /// </summary>
        /// <param name="left">A tree to compare</param>
        /// <param name="right">A tree to compare</param>
        void SymmetricCompareTrees(TreeBase left, TreeBase right);

        /// <summary>
        /// Change newTree to show the changes made in newTree in respect to baseTree
        /// </summary>
        /// <param name="baseTree">Ancestor tree</param>
        /// <param name="newTree">Changed tree</param>
        void AsymmetricCompareTrees(TreeBase baseTree, TreeBase newTree);
    }
}
