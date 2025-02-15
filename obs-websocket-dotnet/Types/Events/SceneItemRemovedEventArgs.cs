using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneItemRemoved"/>
    /// </summary>
    public class SceneItemRemovedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the scene where the item was removed from
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// Name of the concerned item
        /// </summary>
        public string SourceName { get; }

        /// <summary>
        /// Numeric ID of the scene item
        /// </summary>
        public int SceneItemId { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="sourceName">The source name</param>
        /// <param name="sceneItemId">The scene items id</param>
        public SceneItemRemovedEventArgs(SceneIdentifier sceneIdentifier, string sourceName, int sceneItemId)
        {
            SceneIdentifier = sceneIdentifier;
            SourceName = sourceName;
            SceneItemId = sceneItemId;
        }
    }
}