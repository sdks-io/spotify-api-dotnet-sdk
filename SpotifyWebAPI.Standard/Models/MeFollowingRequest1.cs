// <copyright file="MeFollowingRequest1.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpotifyWebAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using SpotifyWebAPI.Standard;
    using SpotifyWebAPI.Standard.Utilities;

    /// <summary>
    /// MeFollowingRequest1.
    /// </summary>
    public class MeFollowingRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeFollowingRequest1"/> class.
        /// </summary>
        public MeFollowingRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeFollowingRequest1"/> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        public MeFollowingRequest1(
            List<string> ids = null)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// A JSON array of the artist or user [Spotify IDs](/documentation/web-api/concepts/spotify-uris-ids). For example: `{ids:["74ASZWbe4lXaubB36ztrGX", "08td7MxkoHQkXnWAYD8d6Q"]}`. A maximum of 50 IDs can be sent in one request. _**Note**: if the `ids` parameter is present in the query string, any IDs listed here in the body will be ignored._
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MeFollowingRequest1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is MeFollowingRequest1 other &&                ((this.Ids == null && other.Ids == null) || (this.Ids?.Equals(other.Ids) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
        }
    }
}