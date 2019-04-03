﻿using Newtonsoft.Json;

namespace Syrus.Plugins.DFV2Client
{
	[JsonObject]
	public class DF2Request
	{
		[JsonProperty]
		public string Session { get; set; }

		[JsonProperty]
		public DF2QueryInput QueryInput { get; set; }

		public DF2Request(string session, DF2QueryInput queryInput)
		{
			Session = session;
			QueryInput = queryInput;
		}
	}
}
