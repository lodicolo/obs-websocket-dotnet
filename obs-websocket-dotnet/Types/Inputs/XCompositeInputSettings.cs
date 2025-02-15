using Newtonsoft.Json;

namespace OBSWebsocketDotNet.Types.Inputs;

public class XCompositeInputSettings
{
    [JsonProperty("capture_window")]
    public string? CaptureWindow { get; set; }
}