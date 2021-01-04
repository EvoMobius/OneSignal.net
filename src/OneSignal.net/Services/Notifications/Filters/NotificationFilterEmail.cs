using Newtonsoft.Json;

namespace OneSignal {
    public class NotificationFilterEmail : NotificationFilter {
        public NotificationFilterEmail() {
            Field = "email";
        }

        /// <summary>
        /// Only for sending Push Notifications. To send emails to specific email addresses use IncludeEmailTokens parameter.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
