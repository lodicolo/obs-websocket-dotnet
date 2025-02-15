using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneItemTransformChanged"/>
    /// </summary>
    public class SceneItemTransformEventArgs : EventArgs
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
        /// Transform data
        /// </summary>
        public SceneItemTransformInfo Transform { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="sceneItemId">The scene item id</param>
        /// <param name="transform">The transform data</param>
        public SceneItemTransformEventArgs(SceneIdentifier sceneIdentifier, string sceneItemId, SceneItemTransformInfo transform)
        {
            SceneIdentifier = sceneIdentifier;
            SceneItemId = sceneItemId;
            Transform = transform;
        }
    }
}