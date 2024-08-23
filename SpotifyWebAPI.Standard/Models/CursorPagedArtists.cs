// <copyright file="CursorPagedArtists.cs" company="APIMatic">
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
    /// CursorPagedArtists.
    /// </summary>
    public class CursorPagedArtists
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPagedArtists"/> class.
        /// </summary>
        public CursorPagedArtists()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPagedArtists"/> class.
        /// </summary>
        /// <param name="artists">artists.</param>
        public CursorPagedArtists(
            Models.CursorPagingSimplifiedArtistObject artists)
        {
            this.Artists = artists;
        }

        /// <summary>
        /// Gets or sets Artists.
        /// </summary>
        [JsonProperty("artists")]
        public Models.CursorPagingSimplifiedArtistObject Artists { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CursorPagedArtists : ({string.Join(", ", toStringOutput)})";
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
            return obj is CursorPagedArtists other &&                ((this.Artists == null && other.Artists == null) || (this.Artists?.Equals(other.Artists) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Artists = {(this.Artists == null ? "null" : this.Artists.ToString())}");
        }
    }
}