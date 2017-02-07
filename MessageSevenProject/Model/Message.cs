using Newtonsoft.Json;
using System;
namespace MessageSevenProject.Model
{
    public class Message
    {
        [JsonProperty(PropertyName = "Id")]
        public long Id {get; set; }
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "LastUpdated")]
        public DateTime LastUpdated { get; set; }
        [JsonProperty(PropertyName = "ActivityStatus")]
        public string ActivityStatus { get; set; }
        [JsonProperty(PropertyName = "BusinessRiskRating")]
        public string BusinessRiskRating { get; set; }
        [JsonProperty(PropertyName = "InformationRiskRating")]
        public string InformationRiskRating { get; set; }
        [JsonProperty(PropertyName = "OwnerMail")]
        public string OwnerMail { get; set; }
        [JsonProperty(PropertyName = "ApproverMail")]
        public string ApproverMail { get; set; }
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }
    }
}
