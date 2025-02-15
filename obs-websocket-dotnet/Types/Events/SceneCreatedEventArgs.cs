using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneCreated"/>
    /// </summary>
    public class SceneCreatedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the new scene
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// Whether the new scene is a group
        /// </summary>
        public bool IsGroup { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="isGroup">Is the scene item a group</param>
        public SceneCreatedEventArgs(SceneIdentifier sceneIdentifier, bool isGroup)
        {
            SceneIdentifier = sceneIdentifier;
            IsGroup = isGroup;
        }
    }
}