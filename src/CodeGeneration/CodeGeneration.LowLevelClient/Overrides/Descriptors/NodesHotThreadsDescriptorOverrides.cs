﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneration.LowLevelClient.Overrides.Descriptors
{
	public class NodesHotThreadsDescriptorOverrides : IDescriptorOverrides
	{
		public IEnumerable<string> SkipQueryStringParams
		{
			get
			{
				return new string[]
				{
					"fielddata"
				};
			}
		}
		public IDictionary<string, string> RenameQueryStringParams
		{
			get
			{
				return new Dictionary<string, string>
				{
					{ "type", "thread_type"}
				};
			}
		}
	}
}