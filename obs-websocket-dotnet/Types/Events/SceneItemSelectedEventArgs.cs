using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneItemSelected"/>
    /// </summary>
    public class SceneItemSelectedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the scene item is in
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// Numeric ID of the scene item
        /// </summary>
        public string SceneItemId { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="sceneItemId">The scene item id</param>
        public SceneItemSelectedEventArgs(SceneIdentifier sceneIdentifier, string sceneItemId)
        {
            SceneIdentifier = sceneIdentifier;
            SceneItemId = sceneItemId;
        }
    }
}