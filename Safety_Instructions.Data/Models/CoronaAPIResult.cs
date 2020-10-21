namespace Safety_Instructions.Data.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class CoronaApiResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("update_date_time")]
        public DateTimeOffset UpdateDateTime { get; set; }

        [JsonProperty("local_new_cases")]
        public long LocalNewCases { get; set; }

        [JsonProperty("local_total_cases")]
        public long LocalTotalCases { get; set; }

        [JsonProperty("local_total_number_of_individuals_in_hospitals")]
        public long LocalTotalNumberOfIndividualsInHospitals { get; set; }

        [JsonProperty("local_deaths")]
        public long LocalDeaths { get; set; }

        [JsonProperty("local_new_deaths")]
        public long LocalNewDeaths { get; set; }

        [JsonProperty("local_recovered")]
        public long LocalRecovered { get; set; }

        [JsonProperty("local_active_cases")]
        public long LocalActiveCases { get; set; }

        [JsonProperty("global_new_cases")]
        public long GlobalNewCases { get; set; }

        [JsonProperty("global_total_cases")]
        public long GlobalTotalCases { get; set; }

        [JsonProperty("global_deaths")]
        public long GlobalDeaths { get; set; }

        [JsonProperty("global_new_deaths")]
        public long GlobalNewDeaths { get; set; }

        [JsonProperty("global_recovered")]
        public long GlobalRecovered { get; set; }

        [JsonProperty("total_pcr_testing_count")]
        public long TotalPcrTestingCount { get; set; }

        [JsonProperty("daily_pcr_testing_data")]
        public List<DailyPcrTestingDatum> DailyPcrTestingData { get; set; }

        [JsonProperty("hospital_data")]
        public List<HospitalDatum> HospitalData { get; set; }
    }

    public partial class DailyPcrTestingDatum
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("count")]

        public long Count { get; set; }
    }

    public partial class HospitalDatum
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("hospital_id")]
        public long HospitalId { get; set; }

        [JsonProperty("cumulative_local")]
        public long CumulativeLocal { get; set; }

        [JsonProperty("cumulative_foreign")]
        public long CumulativeForeign { get; set; }

        [JsonProperty("treatment_local")]
        public long TreatmentLocal { get; set; }

        [JsonProperty("treatment_foreign")]
        public long TreatmentForeign { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public object UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("cumulative_total")]
        public long CumulativeTotal { get; set; }

        [JsonProperty("treatment_total")]
        public long TreatmentTotal { get; set; }

        [JsonProperty("hospital")]
        public Hospital Hospital { get; set; }
    }

    public partial class Hospital
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_si")]
        public string NameSi { get; set; }

        [JsonProperty("name_ta")]
        public string NameTa { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }
    }
}
