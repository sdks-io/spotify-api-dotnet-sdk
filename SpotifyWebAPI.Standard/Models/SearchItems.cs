// <copyright file="SearchItems.cs" company="APIMatic">
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
    /// SearchItems.
    /// </summary>
    public class SearchItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItems"/> class.
        /// </summary>
        public SearchItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItems"/> class.
        /// </summary>
        /// <param name="tracks">tracks.</param>
        /// <param name="artists">artists.</param>
        /// <param name="albums">albums.</param>
        /// <param name="playlists">playlists.</param>
        /// <param name="shows">shows.</param>
        /// <param name="episodes">episodes.</param>
        /// <param name="audiobooks">audiobooks.</param>
        public SearchItems(
            Models.PagingTrackObject tracks = null,
            Models.PagingArtistObject artists = null,
            Models.PagingSimplifiedAlbumObject albums = null,
            Models.PagingPlaylistObject playlists = null,
            Models.PagingSimplifiedShowObject shows = null,
            Models.PagingSimplifiedEpisodeObject episodes = null,
            Models.PagingSimplifiedAudiobookObject audiobooks = null)
        {
            this.Tracks = tracks;
            this.Artists = artists;
            this.Albums = albums;
            this.Playlists = playlists;
            this.Shows = shows;
            this.Episodes = episodes;
            this.Audiobooks = audiobooks;
        }

        /// <summary>
        /// Gets or sets Tracks.
        /// </summary>
        [JsonProperty("tracks", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingTrackObject Tracks { get; set; }

        /// <summary>
        /// Gets or sets Artists.
        /// </summary>
        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingArtistObject Artists { get; set; }

        /// <summary>
        /// Gets or sets Albums.
        /// </summary>
        [JsonProperty("albums", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingSimplifiedAlbumObject Albums { get; set; }

        /// <summary>
        /// Gets or sets Playlists.
        /// </summary>
        [JsonProperty("playlists", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingPlaylistObject Playlists { get; set; }

        /// <summary>
        /// Gets or sets Shows.
        /// </summary>
        [JsonProperty("shows", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingSimplifiedShowObject Shows { get; set; }

        /// <summary>
        /// Gets or sets Episodes.
        /// </summary>
        [JsonProperty("episodes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingSimplifiedEpisodeObject Episodes { get; set; }

        /// <summary>
        /// Gets or sets Audiobooks.
        /// </summary>
        [JsonProperty("audiobooks", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingSimplifiedAudiobookObject Audiobooks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchItems : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchItems other &&                ((this.Tracks == null && other.Tracks == null) || (this.Tracks?.Equals(other.Tracks) == true)) &&
                ((this.Artists == null && other.Artists == null) || (this.Artists?.Equals(other.Artists) == true)) &&
                ((this.Albums == null && other.Albums == null) || (this.Albums?.Equals(other.Albums) == true)) &&
                ((this.Playlists == null && other.Playlists == null) || (this.Playlists?.Equals(other.Playlists) == true)) &&
                ((this.Shows == null && other.Shows == null) || (this.Shows?.Equals(other.Shows) == true)) &&
                ((this.Episodes == null && other.Episodes == null) || (this.Episodes?.Equals(other.Episodes) == true)) &&
                ((this.Audiobooks == null && other.Audiobooks == null) || (this.Audiobooks?.Equals(other.Audiobooks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tracks = {(this.Tracks == null ? "null" : this.Tracks.ToString())}");
            toStringOutput.Add($"this.Artists = {(this.Artists == null ? "null" : this.Artists.ToString())}");
            toStringOutput.Add($"this.Albums = {(this.Albums == null ? "null" : this.Albums.ToString())}");
            toStringOutput.Add($"this.Playlists = {(this.Playlists == null ? "null" : this.Playlists.ToString())}");
            toStringOutput.Add($"this.Shows = {(this.Shows == null ? "null" : this.Shows.ToString())}");
            toStringOutput.Add($"this.Episodes = {(this.Episodes == null ? "null" : this.Episodes.ToString())}");
            toStringOutput.Add($"this.Audiobooks = {(this.Audiobooks == null ? "null" : this.Audiobooks.ToString())}");
        }
    }
}