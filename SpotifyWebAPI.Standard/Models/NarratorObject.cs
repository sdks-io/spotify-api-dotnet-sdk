// <copyright file="NarratorObject.cs" company="APIMatic">
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
    /// NarratorObject.
    /// </summary>
    public class NarratorObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NarratorObject"/> class.
        /// </summary>
        public NarratorObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NarratorObject"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        public NarratorObject(
            string name = null)
        {
            this.Name = name;
        }

        /// <summary>
        /// The name of the Narrator.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NarratorObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is NarratorObject other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}