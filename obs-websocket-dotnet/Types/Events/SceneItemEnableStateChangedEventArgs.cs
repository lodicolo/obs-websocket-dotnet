using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneItemEnableStateChanged"/>
    /// </summary>
    public class SceneItemEnableStateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the scene the item is in
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// Numeric ID of the scene item
        /// </summary>
        public int SceneItemId { get; }

        /// <summary>
        /// Whether the scene item is enabled (visible)
        /// </summary>
        public bool SceneItemEnabled { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="sceneItemId">The scene item id</param>
        /// <param name="sceneItemEnabled">Is the scene item enabled</param>
        public SceneItemEnableStateChangedEventArgs(SceneIdentifier sceneIdentifier, int sceneItemId, bool sceneItemEnabled)
        {
            SceneIdentifier = sceneIdentifier;
            SceneItemId = sceneItemId;
            SceneItemEnabled = sceneItemEnabled;
        }
    }
}