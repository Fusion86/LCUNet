using Newtonsoft.Json;

namespace LCUNet
{
    public abstract class JsonSerializable
    {
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, LeagueClientApi.JsonSerializerSettings);
        }
    }
}
