using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneRemoved"/>
    /// </summary>
    public class SceneRemovedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the removed scene
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// Whether the removed scene was a group
        /// </summary>
        public bool IsGroup { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene name</param>
        /// <param name="isGroup">Is the scene name a group</param>
        public SceneRemovedEventArgs(SceneIdentifier sceneIdentifier, bool isGroup)
        {
            SceneIdentifier = sceneIdentifier;
            IsGroup = isGroup;
        }
    }
}