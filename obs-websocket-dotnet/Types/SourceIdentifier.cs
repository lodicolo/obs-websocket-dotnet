using System;
using Newtonsoft.Json;

namespace OBSWebsocketDotNet.Types;

public record struct SourceIdentifier(
    [property: JsonProperty("sourceName")] string? Name,
    [property: JsonProperty("sourceUuid")] Guid Id
);