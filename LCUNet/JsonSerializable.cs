using Newtonsoft.Json;

namespace LCUNet
{
    public class JsonSerializable
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, LeagueClientApi.JsonSerializerSettings);
        }
    }
}
