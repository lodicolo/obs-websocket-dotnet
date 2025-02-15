using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneItemListReindexed"/>
    /// </summary>
    public class SceneItemListReindexedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the scene where items where reordered
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// List of all scene items as JObject
        /// </summary>
        public List<JObject> SceneItems { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="sceneItems">The scene item data as a colleciton of JObjects</param>
        public SceneItemListReindexedEventArgs(SceneIdentifier sceneIdentifier, List<JObject> sceneItems)
        {
            SceneIdentifier = sceneIdentifier;
            SceneItems = sceneItems;
        }
    }
}