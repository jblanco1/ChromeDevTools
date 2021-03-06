using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveXHRBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Resource URL substring.
		/// </summary>
		public string Url { get; set; }
	}
}
