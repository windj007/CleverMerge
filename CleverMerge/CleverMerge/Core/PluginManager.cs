using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverMerge.Core
{
    /// <summary>
    /// Utility class that loads plugins
    /// </summary>
    public class PluginManager
    {
        /// <summary>
        /// Current plugin manager instance
        /// </summary>
        private static PluginManager instance = null;

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

        private PluginManager()
        {

        }

        /// <summary>
        /// Find and load all plugins in the specified directory
        /// </summary>
        /// <param name="pluginDirrectory">The directory where plugins are situated</param>
        /// <returns>List of all loaded plugins</returns>
        public System.Collections.Generic.IEnumerable<CleverMerge.Core.IPlugin> LoadPlugins(string pluginDirrectory)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Unload all plugins and load them from the same directory
        /// </summary>
        public void RefreshPlugins()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Choose the plugin that can handle the specified file
        /// </summary>
        /// <param name="fileName">The file that must be handled</param>
        public IPlugin ChoosePluginForFile(string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}
