﻿using Vla.Abstractions;
using Vla.Nodes;
using Vla.Nodes.Attributes;

namespace Vla.Extensions.Core.Variables;

[Node("Get boolean variable")]
[NodeCategory("Variables")]
[NodeTags("Get", "Boolean", "Bool", "Load")]
public class GetBooleanVariable(VariableManager variableManager) : INode
{
    public string Name => "Get boolean variable";

    public void Execute([NodeInput("Variable")] string variable, [NodeOutput("Value")] out bool value)
    {
        value = variableManager.GetVariable<bool>(variable);
    }
}