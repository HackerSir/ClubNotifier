using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Contacts {

    //http://stackoverflow.com/questions/18566466/json-net-deserialize-mailaddress
    class EmailConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return objectType == typeof(MailAddress);
        }

        public override Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer) {
            JObject jsonObject = JObject.Load(reader);
            String address  = jsonObject["Address"].Value<String>();
            MailAddress mailAddress = new MailAddress(address);
            return mailAddress;
        }

        public override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer) {
            serializer.Serialize(writer, value);
        }
    }
}
