using System;
using Newtonsoft.Json;

namespace OBSWebsocketDotNet.Types;

public record struct SceneIdentifier(
    [property: JsonProperty("sceneName")] string? Name,
    [property: JsonProperty("sceneUuid")] Guid Id
)
{
    public SceneIdentifier(Guid id) : this(null, id)
    {
    }
}