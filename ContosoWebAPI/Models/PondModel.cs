using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoWebAPI.Models
{
    public class PondModel
    {    
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "HarvestYear")]
        public string harvestYear { get; set; }

        [JsonProperty(PropertyName = "HarvestMonth")]
        public string harvestMonth { get; set; }

        [JsonProperty(PropertyName = "LocationName")]
        public string locationName { get; set; }

        [JsonProperty(PropertyName = "PondCode")]
        public string pondCode { get; set; }

        [JsonProperty(PropertyName = "PondName")]
        public string pondName { get; set; }

        [JsonProperty(PropertyName = "Hectareas")]
        public string Hectareas { get; set; }

        [JsonProperty(PropertyName = "StartDate")]
        public string startDate { get; set; }

        [JsonProperty(PropertyName = "SeedSize")]
        public string seedSize { get; set; }

        [JsonProperty(PropertyName = "HarvestDate")]
        public string harvestDate { get; set; }

        [JsonProperty(PropertyName = "Survival")]
        public string survival { get; set; }

        [JsonProperty(PropertyName = "HarvestSize")]
        public string harvestSize { get; set; }

        [JsonProperty(PropertyName = "HarvestedKg")]
        public string harvestedKg { get; set; }

        [JsonProperty(PropertyName = "JuvenileCost")]
        public string juvenileCost { get; set; }

        [JsonProperty(PropertyName = "FoodCost")]
        public string foodCost { get; set; }

        [JsonProperty(PropertyName = "OperativeCost")]
        public string operativeCost { get; set; }

        [JsonProperty(PropertyName = "TotalCost")]
        public string totalCost { get; set; }

        [JsonProperty(PropertyName = "Income")]
        public string income { get; set; }

        [JsonProperty(PropertyName = "YearMonth_key")]
        public string yearMonth_Key { get; set; }

        [JsonProperty(PropertyName = "InitialAverageWeight")]
        public string initialAverageWeight { get; set; }

        [JsonProperty(PropertyName = "EstimatedEndDate")]
        public string estimatedEndDate { get; set; }

        [JsonProperty(PropertyName = "EstimatedHarvestAverageWeight")]
        public string estimatedHarvestAverageWeight { get; set; }

        [JsonProperty(PropertyName = "EstimatedSurvival")]
        public string estimatedSurvival { get; set; }

        [JsonProperty(PropertyName = "AverageWeight")]
        public string averageWeight { get; set; }

        [JsonProperty(PropertyName = "InitialPopulation")]
        public string initialPopulation { get; set; }

        [JsonProperty(PropertyName = "FoodType")]
        public string foodType { get; set; }
    }
}
