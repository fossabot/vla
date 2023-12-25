﻿using System.Collections.Immutable;
using Newtonsoft.Json;

namespace Vla.Abstractions.Instance;

public readonly struct NodeInstance()
{ 
    [JsonProperty("id")]
    public string Id { get; init; } = Guid.NewGuid().ToString();

    [JsonProperty("nodeType")]
    public Type NodeType { get; init; } = typeof(object);

    [JsonProperty("properties")]
    public ImmutableArray<PropertyInstance> Properties { get; init; } = ImmutableArray<PropertyInstance>.Empty;

    [JsonProperty("inputs")]
    public ImmutableArray<ParameterInstance> Inputs { get; init; } = ImmutableArray<ParameterInstance>.Empty;
    
    [JsonProperty("metadata")]
    public Metadata Metadata { get; init; } = new();
}

public readonly struct NodeExecutionResult(Exception? exception = null)
{
    [JsonProperty("outputs")]
    public ImmutableArray<ParameterInstance> Outputs { get; init; } = ImmutableArray<ParameterInstance>.Empty;

    [JsonProperty("exception")] public Exception? Exception { get; init; } = exception;
}