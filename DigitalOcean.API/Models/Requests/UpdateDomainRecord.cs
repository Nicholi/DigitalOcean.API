﻿using Newtonsoft.Json;

namespace DigitalOcean.API.Models.Requests {
    public class UpdateDomainRecord {
        /// <summary>
        /// The record type (A, MX, CNAME, etc).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The host name, alias, or service being defined by the record.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Variable data depending on record type.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The priority of the host (for SRV and MX records. null otherwise).
        /// </summary>
        [JsonProperty("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// The port that the service is accessible on (for SRV records only. null otherwise).
        /// </summary>
        [JsonProperty("port")]
        public int? Port { get; set; }

        /// <summary>
        /// Time to live for the record, in seconds. If not set, the default value is 1800.
        /// </summary>
        [JsonProperty("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// The weight of records with the same priority (for SRV records only. null otherwise).
        /// </summary>
        [JsonProperty("weight")]
        public int? Weight { get; set; }


        /// <summary>
        /// An unsigned integer between 0-255 used for CAA records.
        /// </summary>
        [JsonProperty("flags")]
        public int? Flags { get; set; }

        /// <summary>
        /// The parameter tag for CAA records. Valid values are "issue", "issuewild", or "iodef"
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

    }
}
