﻿using Newtonsoft.Json;
using Vla.Helpers;

namespace Vla.Nodes.Structure;

public readonly struct InputParameterStructure(string id, string name, Type type, object? defaultValue = null)
    : IParameterStructure
{
    [JsonProperty("id")]
    public string Id { get; init; } = id;

    [JsonProperty("name")]
    public string Name { get; init; } = name;

    [JsonProperty("type")] public Type Type { get; init; } = type;

    [JsonProperty("defaultValue")]
    public string DefaultValue { get; init; } = JsonConvert.SerializeObject(defaultValue is DBNull ? type.GetDefaultValueForType() : defaultValue);
}