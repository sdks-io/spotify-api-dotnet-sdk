// <copyright file="TrackObject.cs" company="APIMatic">
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
    /// TrackObject.
    /// </summary>
    public class TrackObject
    {
        private string previewUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "preview_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackObject"/> class.
        /// </summary>
        public TrackObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackObject"/> class.
        /// </summary>
        /// <param name="album">album.</param>
        /// <param name="artists">artists.</param>
        /// <param name="availableMarkets">available_markets.</param>
        /// <param name="discNumber">disc_number.</param>
        /// <param name="durationMs">duration_ms.</param>
        /// <param name="mExplicit">explicit.</param>
        /// <param name="externalIds">external_ids.</param>
        /// <param name="externalUrls">external_urls.</param>
        /// <param name="href">href.</param>
        /// <param name="id">id.</param>
        /// <param name="isPlayable">is_playable.</param>
        /// <param name="linkedFrom">linked_from.</param>
        /// <param name="restrictions">restrictions.</param>
        /// <param name="name">name.</param>
        /// <param name="popularity">popularity.</param>
        /// <param name="previewUrl">preview_url.</param>
        /// <param name="trackNumber">track_number.</param>
        /// <param name="type">type.</param>
        /// <param name="uri">uri.</param>
        /// <param name="isLocal">is_local.</param>
        public TrackObject(
            Models.SimplifiedAlbumObject album = null,
            List<Models.ArtistObject> artists = null,
            List<string> availableMarkets = null,
            int? discNumber = null,
            int? durationMs = null,
            bool? mExplicit = null,
            Models.ExternalIdObject externalIds = null,
            Models.ExternalUrlObject externalUrls = null,
            string href = null,
            string id = null,
            bool? isPlayable = null,
            Models.LinkedTrackObject linkedFrom = null,
            Models.TrackRestrictionObject restrictions = null,
            string name = null,
            int? popularity = null,
            string previewUrl = null,
            int? trackNumber = null,
            Models.Type3Enum? type = null,
            string uri = null,
            bool? isLocal = null)
        {
            this.Album = album;
            this.Artists = artists;
            this.AvailableMarkets = availableMarkets;
            this.DiscNumber = discNumber;
            this.DurationMs = durationMs;
            this.MExplicit = mExplicit;
            this.ExternalIds = externalIds;
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.IsPlayable = isPlayable;
            this.LinkedFrom = linkedFrom;
            this.Restrictions = restrictions;
            this.Name = name;
            this.Popularity = popularity;
            if (previewUrl != null)
            {
                this.PreviewUrl = previewUrl;
            }

            this.TrackNumber = trackNumber;
            this.Type = type;
            this.Uri = uri;
            this.IsLocal = isLocal;
        }

        /// <summary>
        /// The album on which the track appears. The album object includes a link in `href` to full information about the album.
        /// </summary>
        [JsonProperty("album", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SimplifiedAlbumObject Album { get; set; }

        /// <summary>
        /// The artists who performed the track. Each artist object includes a link in `href` to more detailed information about the artist.
        /// </summary>
        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ArtistObject> Artists { get; set; }

        /// <summary>
        /// A list of the countries in which the track can be played, identified by their [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        [JsonProperty("available_markets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        /// The disc number (usually `1` unless the album consists of more than one disc).
        /// </summary>
        [JsonProperty("disc_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscNumber { get; set; }

        /// <summary>
        /// The track length in milliseconds.
        /// </summary>
        [JsonProperty("duration_ms", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Whether or not the track has explicit lyrics ( `true` = yes it does; `false` = no it does not OR unknown).
        /// </summary>
        [JsonProperty("explicit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MExplicit { get; set; }

        /// <summary>
        /// Known external IDs for the track.
        /// </summary>
        [JsonProperty("external_ids", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExternalIdObject ExternalIds { get; set; }

        /// <summary>
        /// Known external URLs for this track.
        /// </summary>
        [JsonProperty("external_urls", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExternalUrlObject ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the track.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking) is applied. If `true`, the track is playable in the given market. Otherwise `false`.
        /// </summary>
        [JsonProperty("is_playable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlayable { get; set; }

        /// <summary>
        /// Part of the response when [Track Relinking](/documentation/web-api/concepts/track-relinking) is applied, and the requested track has been replaced with different track. The track in the `linked_from` object contains information about the originally requested track.
        /// </summary>
        [JsonProperty("linked_from", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LinkedTrackObject LinkedFrom { get; set; }

        /// <summary>
        /// Included in the response when a content restriction is applied.
        /// </summary>
        [JsonProperty("restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TrackRestrictionObject Restrictions { get; set; }

        /// <summary>
        /// The name of the track.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The popularity of the track. The value will be between 0 and 100, with 100 being the most popular.<br/>The popularity of a track is a value between 0 and 100, with 100 being the most popular. The popularity is calculated by algorithm and is based, in the most part, on the total number of plays the track has had and how recent those plays are.<br/>Generally speaking, songs that are being played a lot now will have a higher popularity than songs that were played a lot in the past. Duplicate tracks (e.g. the same track from a single and an album) are rated independently. Artist and album popularity is derived mathematically from track popularity. _**Note**: the popularity value may lag actual popularity by a few days: the value is not updated in real time._
        /// </summary>
        [JsonProperty("popularity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Popularity { get; set; }

        /// <summary>
        /// A link to a 30 second preview (MP3 format) of the track. Can be `null`
        /// </summary>
        [JsonProperty("preview_url")]
        public string PreviewUrl
        {
            get
            {
                return this.previewUrl;
            }

            set
            {
                this.shouldSerialize["preview_url"] = true;
                this.previewUrl = value;
            }
        }

        /// <summary>
        /// The number of the track. If an album has several discs, the track number is the number on the specified disc.
        /// </summary>
        [JsonProperty("track_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrackNumber { get; set; }

        /// <summary>
        /// The object type: "track".
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type3Enum? Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the track.
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// Whether or not the track is from a local file.
        /// </summary>
        [JsonProperty("is_local", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TrackObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPreviewUrl()
        {
            this.shouldSerialize["preview_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePreviewUrl()
        {
            return this.shouldSerialize["preview_url"];
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
            return obj is TrackObject other &&                ((this.Album == null && other.Album == null) || (this.Album?.Equals(other.Album) == true)) &&
                ((this.Artists == null && other.Artists == null) || (this.Artists?.Equals(other.Artists) == true)) &&
                ((this.AvailableMarkets == null && other.AvailableMarkets == null) || (this.AvailableMarkets?.Equals(other.AvailableMarkets) == true)) &&
                ((this.DiscNumber == null && other.DiscNumber == null) || (this.DiscNumber?.Equals(other.DiscNumber) == true)) &&
                ((this.DurationMs == null && other.DurationMs == null) || (this.DurationMs?.Equals(other.DurationMs) == true)) &&
                ((this.MExplicit == null && other.MExplicit == null) || (this.MExplicit?.Equals(other.MExplicit) == true)) &&
                ((this.ExternalIds == null && other.ExternalIds == null) || (this.ExternalIds?.Equals(other.ExternalIds) == true)) &&
                ((this.ExternalUrls == null && other.ExternalUrls == null) || (this.ExternalUrls?.Equals(other.ExternalUrls) == true)) &&
                ((this.Href == null && other.Href == null) || (this.Href?.Equals(other.Href) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.IsPlayable == null && other.IsPlayable == null) || (this.IsPlayable?.Equals(other.IsPlayable) == true)) &&
                ((this.LinkedFrom == null && other.LinkedFrom == null) || (this.LinkedFrom?.Equals(other.LinkedFrom) == true)) &&
                ((this.Restrictions == null && other.Restrictions == null) || (this.Restrictions?.Equals(other.Restrictions) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Popularity == null && other.Popularity == null) || (this.Popularity?.Equals(other.Popularity) == true)) &&
                ((this.PreviewUrl == null && other.PreviewUrl == null) || (this.PreviewUrl?.Equals(other.PreviewUrl) == true)) &&
                ((this.TrackNumber == null && other.TrackNumber == null) || (this.TrackNumber?.Equals(other.TrackNumber) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Uri == null && other.Uri == null) || (this.Uri?.Equals(other.Uri) == true)) &&
                ((this.IsLocal == null && other.IsLocal == null) || (this.IsLocal?.Equals(other.IsLocal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Album = {(this.Album == null ? "null" : this.Album.ToString())}");
            toStringOutput.Add($"this.Artists = {(this.Artists == null ? "null" : $"[{string.Join(", ", this.Artists)} ]")}");
            toStringOutput.Add($"this.AvailableMarkets = {(this.AvailableMarkets == null ? "null" : $"[{string.Join(", ", this.AvailableMarkets)} ]")}");
            toStringOutput.Add($"this.DiscNumber = {(this.DiscNumber == null ? "null" : this.DiscNumber.ToString())}");
            toStringOutput.Add($"this.DurationMs = {(this.DurationMs == null ? "null" : this.DurationMs.ToString())}");
            toStringOutput.Add($"this.MExplicit = {(this.MExplicit == null ? "null" : this.MExplicit.ToString())}");
            toStringOutput.Add($"this.ExternalIds = {(this.ExternalIds == null ? "null" : this.ExternalIds.ToString())}");
            toStringOutput.Add($"this.ExternalUrls = {(this.ExternalUrls == null ? "null" : this.ExternalUrls.ToString())}");
            toStringOutput.Add($"this.Href = {(this.Href == null ? "null" : this.Href)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.IsPlayable = {(this.IsPlayable == null ? "null" : this.IsPlayable.ToString())}");
            toStringOutput.Add($"this.LinkedFrom = {(this.LinkedFrom == null ? "null" : this.LinkedFrom.ToString())}");
            toStringOutput.Add($"this.Restrictions = {(this.Restrictions == null ? "null" : this.Restrictions.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Popularity = {(this.Popularity == null ? "null" : this.Popularity.ToString())}");
            toStringOutput.Add($"this.PreviewUrl = {(this.PreviewUrl == null ? "null" : this.PreviewUrl)}");
            toStringOutput.Add($"this.TrackNumber = {(this.TrackNumber == null ? "null" : this.TrackNumber.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Uri = {(this.Uri == null ? "null" : this.Uri)}");
            toStringOutput.Add($"this.IsLocal = {(this.IsLocal == null ? "null" : this.IsLocal.ToString())}");
        }
    }
}