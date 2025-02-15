using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types.Events;

public class InputSettingsChangedArgs : EventArgs
{
    [JsonProperty("inputName")]
    public string InputName { get; }

    [JsonProperty("inputUuid")]
    public Guid InputId { get; }

    [JsonProperty("inputSettings")]
    public JObject? InputSettings { get; }
}