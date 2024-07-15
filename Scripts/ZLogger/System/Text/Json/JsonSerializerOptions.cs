using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;

namespace System.Text.Json
{
	public sealed class JsonSerializerOptions
	{
		[CompilerGenerated]
		private JsonIgnoreCondition _003CDefaultIgnoreCondition_003Ek__BackingField;

		public bool WriteIndented { get; set; }

		public JsonIgnoreCondition DefaultIgnoreCondition
		{
			[CompilerGenerated]
			set
			{
				_003CDefaultIgnoreCondition_003Ek__BackingField = value;
			}
		}

		public JavaScriptEncoder Encoder { get; set; }
	}
}
