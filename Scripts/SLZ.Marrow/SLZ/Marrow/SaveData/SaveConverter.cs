using System;
using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	public class SaveConverter<TSave, TPlayerSettings, TProgression, TUnlocks> : JsonConverter<TSave> where TSave : class, ISave<TPlayerSettings, TProgression, TUnlocks>, new() where TPlayerSettings : class, IPlayerSettings, new() where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new()
	{
		private readonly SaveFlags _flags;

		public SaveConverter(SaveFlags flags)
		{
		}

		public override void WriteJson(JsonWriter writer, TSave save, JsonSerializer serializer)
		{
		}

		public override TSave ReadJson(JsonReader reader, Type objectType, TSave existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
