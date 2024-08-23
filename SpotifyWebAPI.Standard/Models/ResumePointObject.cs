// <copyright file="ResumePointObject.cs" company="APIMatic">
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
    /// ResumePointObject.
    /// </summary>
    public class ResumePointObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePointObject"/> class.
        /// </summary>
        public ResumePointObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePointObject"/> class.
        /// </summary>
        /// <param name="fullyPlayed">fully_played.</param>
        /// <param name="resumePositionMs">resume_position_ms.</param>
        public ResumePointObject(
            bool? fullyPlayed = null,
            int? resumePositionMs = null)
        {
            this.FullyPlayed = fullyPlayed;
            this.ResumePositionMs = resumePositionMs;
        }

        /// <summary>
        /// Whether or not the episode has been fully played by the user.
        /// </summary>
        [JsonProperty("fully_played", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FullyPlayed { get; set; }

        /// <summary>
        /// The user's most recent position in the episode in milliseconds.
        /// </summary>
        [JsonProperty("resume_position_ms", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResumePositionMs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResumePointObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResumePointObject other &&                ((this.FullyPlayed == null && other.FullyPlayed == null) || (this.FullyPlayed?.Equals(other.FullyPlayed) == true)) &&
                ((this.ResumePositionMs == null && other.ResumePositionMs == null) || (this.ResumePositionMs?.Equals(other.ResumePositionMs) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FullyPlayed = {(this.FullyPlayed == null ? "null" : this.FullyPlayed.ToString())}");
            toStringOutput.Add($"this.ResumePositionMs = {(this.ResumePositionMs == null ? "null" : this.ResumePositionMs.ToString())}");
        }
    }
}