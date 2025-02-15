using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneItemLockStateChanged"/>
    /// </summary>
    public class SceneItemLockStateChangedEventArgs : EventArgs
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
        /// Whether the scene item is locked (visible)
        /// </summary>
        public bool SceneItemLocked { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="sceneItemId">The scene item id</param>
        /// <param name="sceneItemLocked">is the scene item locked</param>
        public SceneItemLockStateChangedEventArgs(SceneIdentifier sceneIdentifier, int sceneItemId, bool sceneItemLocked)
        {
            SceneIdentifier = sceneIdentifier;
            SceneItemId = sceneItemId;
            SceneItemLocked = sceneItemLocked;
        }
    }
}