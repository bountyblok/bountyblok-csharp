using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace bountyblok.client
{
    public class TaskProgressViewModel
    {
        [JsonProperty("task_id")]
        public Guid TaskID { get; set; }

        [JsonProperty("task_name")]
        public string TaskName { get; set; }

        [JsonProperty("quantity_required")]
        public decimal? QuantityRequired { get; set; }

        [JsonProperty("quantity_completed")]
        public decimal QuantityCompleted { get; set; }
    }
}
