using System;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.CurrentProgramSceneChanged"/>
    /// </summary>
    public class ProgramSceneChangedEventArgs : EventArgs
    {
        /// <summary>
        /// The new scene identifier
        /// </summary>
        public SceneIdentifier SceneIdentifier { get; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sceneIdentifier">The scene identifier</param>
        public ProgramSceneChangedEventArgs(SceneIdentifier sceneIdentifier)
        {
            SceneIdentifier = sceneIdentifier;
        }
    }
}