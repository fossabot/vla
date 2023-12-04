﻿using Vla.Abstractions;
using Vla.Abstractions.Attributes;

namespace Vla.Nodes.Math;

[Node("Power")]
[NodeCategory("Math")]
[NodeTags("Power", "Exponent", "Exponential", "Pow", "^")]
public class PowerMathNode : INode
{
	public string Name => "Math Power";

	public void Execute([NodeInput("Base")] double value, [NodeInput("Exponent")] double power, [NodeOutput("Result")] out double result)
	{
		result = System.Math.Pow(value, power);
	}
}