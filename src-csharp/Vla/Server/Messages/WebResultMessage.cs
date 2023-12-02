﻿using Newtonsoft.Json;
using Vla.Nodes.Web.Result;

namespace Vla.Server.Messages;

public readonly struct WebResultMessage(WebResult result) : ISocketMessage
{
	public static implicit operator WebResultMessage(WebResult result) => new(result);
	
	[JsonProperty("result")]
	public WebResult Result { get; init; } = result;
}