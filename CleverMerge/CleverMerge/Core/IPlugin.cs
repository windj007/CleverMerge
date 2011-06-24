using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Core
{
    /// <summary>
    /// The interface that all plugins must provide
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// The name of the plugin. Dicplayed in plugins configuration window
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The icon of the plugin. Displayed in plugins configuration window
        /// </summary>
        System.Drawing.Icon Icon
        {
            get;
            set;
        }

        /// <summary>
        /// The description of the plugin. Displayed in plugins configuration window
        /// </summary>
        string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Build tree representation of the specified file.
        /// </summary>
        /// <remarks>Generally that tree is similar to abstract syntax tree of the program in that file.</remarks>
        /// <returns>FullTree representing file structure</returns>
        ITree BuildFileTree(string fileName);

        /// <summary>
        /// Check whether the file can be handled by that plugin
        /// </summary>
        /// <returns>true if the file can be handled by that plugin, false otherwise</returns>
        bool IsYourFile(string fileName);

        /// <summary>
        /// Initialize plugin
        /// </summary>
        void Initialize();
    }
}
