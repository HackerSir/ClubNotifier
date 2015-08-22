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
    //這個類別是參考上面的文章修改
    //我把 email 用 String 儲存
    class EmailConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return objectType == typeof(MailAddress);
        }

        public override Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer) {
            MailAddress mailAddress = null;
            try {
                mailAddress = new MailAddress((String)reader.Value);
            }
            catch (Exception e) {

            }

            return mailAddress;
        }

        public override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer) {
            serializer.Serialize(writer, ((MailAddress)value).Address);
        }
    }
}
