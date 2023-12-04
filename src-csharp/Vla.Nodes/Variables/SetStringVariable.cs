﻿using Vla.Abstractions;
using Vla.Abstractions.Attributes;

namespace Vla.Nodes.Variables;

[Node("Set string variable")]
[NodeCategory("Variables")]
[NodeTags("Set", "String", "Save")]
public class SetStringVariable(VariableManager variableManager) : INode
{
	public string Name => "Set string variable";
	
	public void Execute([NodeInput("Variable")] string variable, [NodeInput("Value")] string value)
	{
		variableManager.SetVariable(variable, value);
	}
}