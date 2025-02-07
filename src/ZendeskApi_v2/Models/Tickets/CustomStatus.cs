using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ZendeskApi_v2.Models.Tickets
{
    public class CustomStatus
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("status_category")]
        public string StatusCategory { get; set; }

        [JsonProperty("agent_label")]
        public string AgentLabel { get; set; }

        [JsonProperty("raw_agent_label")]
        public string RawAgentLabel { get; set; }

        [JsonProperty("end_user_label")]
        public string EndUserLabel { get; set; }

        [JsonProperty("raw_end_user_label")]
        public string RawEndUserLabel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("raw_description")]
        public string RawDescription { get; set; }

        [JsonProperty("end_user_description")]
        public string EndUserDescription { get; set; }

        [JsonProperty("raw_end_user_description")]
        public string RawEndUserDescription { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}
