using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.CurrentPreviewSceneChanged"/>
    /// </summary>
    public class CurrentPreviewSceneChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Identifier of the scene that was switched to
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene identifier</param>
        public CurrentPreviewSceneChangedEventArgs(SceneIdentifier sceneIdentifier)
        {
            SceneIdentifier = sceneIdentifier;
        }
    }
}