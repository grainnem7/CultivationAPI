using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoWebAPI.Models
{
    public class PondModel
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "pond_key")]
        public int PondID { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTimeOffset Start_Date { get; set; }

        [JsonProperty(PropertyName = "intial_population")]
        public int Intial_Population { get; set; }

        [JsonProperty(PropertyName = "intial_avg_weight")]
        public int Intial_Average_Weight { get; set; }

        [JsonProperty(PropertyName = "est_end_date")]
        public DateTimeOffset Estimated_End_Date { get; set; }

        [JsonProperty(PropertyName = "est_harvest_avg_weight")]
        public double Estimated_Harvest_Average_Weight { get; set; }

        [JsonProperty(PropertyName = "est_survival")]
        public double Estimated_Survival { get; set; }

        [JsonProperty(PropertyName = "food_type")]
        public string Food_Type { get; set; }
    }
}
