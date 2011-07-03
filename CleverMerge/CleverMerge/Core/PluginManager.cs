using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleverMerge.Core.BaseTreeBuilding;

namespace CleverMerge.Core
{
    /// <summary>
    /// Utility class that loads plugins
    /// </summary>
    public class PluginManager
    {
        #region Private fields

        /// <summary>
        /// Current plugin manager instance
        /// </summary>
        private static PluginManager instance = null;

        /// <summary>
        /// Base plugin - FolderTreeBuilder
        /// </summary>
        private FolderTreeBuilder folderTreeBuilderPlugin = null;

        #endregion

        #region Public properties

        /// <summary>
        /// Current plugin manager instance
        /// </summary>
        public static PluginManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new PluginManager();

                return instance;
            }
        }

        /// <summary>
        /// All loaded plugins
        /// </summary>
        public IEnumerable<IPlugin> Plugins { get; private set; }
        
        #endregion

        private PluginManager()
        {
            folderTreeBuilderPlugin = new FolderTreeBuilder();
            folderTreeBuilderPlugin.Initialize();
        }

        #region Public methods

        /// <summary>
        /// Find and load all plugins in the specified directory
        /// </summary>
        /// <param name="pluginDirrectory">The directory where plugins are situated</param>
        /// <returns>List of all loaded plugins</returns>
        public IEnumerable<IPlugin> LoadPlugins(string pluginDirrectory)
        {
            Plugins = new List<IPlugin>();

            return Plugins;
        }

        /// <summary>
        /// Unload all plugins and load them from the same directory
        /// </summary>
        public void RefreshPlugins()
        {

        }

        /// <summary>
        /// Choose the plugin that can handle the specified file
        /// </summary>
        /// <param name="fileName">The file that must be handled</param>
        /// <returns>
        /// Plugin instance for specified file.
        /// If suitable plugin was not found the method returns null.
        /// </returns>
        public IPlugin ChoosePluginForFile(string fileName)
        {
            var suitable = Plugins.FirstOrDefault((plug) => plug.IsYourFile(fileName));

            if (suitable != null)
                return suitable;

            return folderTreeBuilderPlugin;
        }
        
        #endregion
    }
}
