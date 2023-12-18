﻿using Vla.Abstractions;
using Vla.Abstractions.Attributes;

namespace Vla.Nodes.Booleans;

[Node("NOT operator")]
[NodeCategory("Booleans")]
[NodeTags("Not", "Operator", "!", "Logic", "Gate", "Toggle")]
public class NotBooleanNode : INode
{
    public string Name => "NOT";

    public void Execute([NodeInput("Value")] bool value, [NodeOutput("Result")] out bool result)
    {
        result = !value;
    }
}