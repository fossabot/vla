﻿using Vla.Nodes.Connection;
using Vla.Nodes.Instance;
using Vla.Nodes.Structure;

namespace Vla.Nodes.Web;

public readonly struct Web
{
	public NodeInstance[] Instances { get; init; }
	
	public NodeConnection[] Connections { get; init; }
}