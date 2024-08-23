// <copyright file="EpisodeBase.cs" company="APIMatic">
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
    /// EpisodeBase.
    /// </summary>
    public class EpisodeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EpisodeBase"/> class.
        /// </summary>
        public EpisodeBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EpisodeBase"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="htmlDescription">html_description.</param>
        /// <param name="durationMs">duration_ms.</param>
        /// <param name="mExplicit">explicit.</param>
        /// <param name="externalUrls">external_urls.</param>
        /// <param name="href">href.</param>
        /// <param name="id">id.</param>
        /// <param name="images">images.</param>
        /// <param name="isExternallyHosted">is_externally_hosted.</param>
        /// <param name="isPlayable">is_playable.</param>
        /// <param name="languages">languages.</param>
        /// <param name="name">name.</param>
        /// <param name="releaseDate">release_date.</param>
        /// <param name="releaseDatePrecision">release_date_precision.</param>
        /// <param name="type">type.</param>
        /// <param name="uri">uri.</param>
        /// <param name="audioPreviewUrl">audio_preview_url.</param>
        /// <param name="language">language.</param>
        /// <param name="resumePoint">resume_point.</param>
        /// <param name="restrictions">restrictions.</param>
        public EpisodeBase(
            string description,
            string htmlDescription,
            int durationMs,
            bool mExplicit,
            Models.ExternalUrlObject externalUrls,
            string href,
            string id,
            List<Models.ImageObject> images,
            bool isExternallyHosted,
            bool isPlayable,
            List<string> languages,
            string name,
            string releaseDate,
            Models.ReleaseDatePrecisionEnum releaseDatePrecision,
            Models.Type8Enum type,
            string uri,
            string audioPreviewUrl = null,
            string language = null,
            Models.ResumePointObject resumePoint = null,
            Models.EpisodeRestrictionObject restrictions = null)
        {
            this.AudioPreviewUrl = audioPreviewUrl;
            this.Description = description;
            this.HtmlDescription = htmlDescription;
            this.DurationMs = durationMs;
            this.MExplicit = mExplicit;
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.Images = images;
            this.IsExternallyHosted = isExternallyHosted;
            this.IsPlayable = isPlayable;
            this.Language = language;
            this.Languages = languages;
            this.Name = name;
            this.ReleaseDate = releaseDate;
            this.ReleaseDatePrecision = releaseDatePrecision;
            this.ResumePoint = resumePoint;
            this.Type = type;
            this.Uri = uri;
            this.Restrictions = restrictions;
        }

        /// <summary>
        /// A URL to a 30 second preview (MP3 format) of the episode. `null` if not available.
        /// </summary>
        [JsonProperty("audio_preview_url", NullValueHandling = NullValueHandling.Include)]
        public string AudioPreviewUrl { get; set; }

        /// <summary>
        /// A description of the episode. HTML tags are stripped away from this field, use `html_description` field in case HTML tags are needed.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A description of the episode. This field may contain HTML tags.
        /// </summary>
        [JsonProperty("html_description")]
        public string HtmlDescription { get; set; }

        /// <summary>
        /// The episode length in milliseconds.
        /// </summary>
        [JsonProperty("duration_ms")]
        public int DurationMs { get; set; }

        /// <summary>
        /// Whether or not the episode has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        [JsonProperty("explicit")]
        public bool MExplicit { get; set; }

        /// <summary>
        /// External URLs for this episode.
        /// </summary>
        [JsonProperty("external_urls")]
        public Models.ExternalUrlObject ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the episode.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the episode.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The cover art for the episode in various sizes, widest first.
        /// </summary>
        [JsonProperty("images")]
        public List<Models.ImageObject> Images { get; set; }

        /// <summary>
        /// True if the episode is hosted outside of Spotify's CDN.
        /// </summary>
        [JsonProperty("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        /// <summary>
        /// True if the episode is playable in the given market. Otherwise false.
        /// </summary>
        [JsonProperty("is_playable")]
        public bool IsPlayable { get; set; }

        /// <summary>
        /// The language used in the episode, identified by a [ISO 639](https://en.wikipedia.org/wiki/ISO_639) code. This field is deprecated and might be removed in the future. Please use the `languages` field instead.
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// A list of the languages used in the episode, identified by their [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639) code.
        /// </summary>
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }

        /// <summary>
        /// The name of the episode.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The date the episode was first released, for example `"1981-12-15"`. Depending on the precision, it might be shown as `"1981"` or `"1981-12"`.
        /// </summary>
        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// The precision with which `release_date` value is known.
        /// </summary>
        [JsonProperty("release_date_precision")]
        public Models.ReleaseDatePrecisionEnum ReleaseDatePrecision { get; set; }

        /// <summary>
        /// The user's most recent position in the episode. Set if the supplied access token is a user token and has the scope 'user-read-playback-position'.
        /// </summary>
        [JsonProperty("resume_point", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResumePointObject ResumePoint { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type8Enum Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the episode.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Included in the response when a content restriction is applied.
        /// </summary>
        [JsonProperty("restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EpisodeRestrictionObject Restrictions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EpisodeBase : ({string.Join(", ", toStringOutput)})";
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
            return obj is EpisodeBase other &&                ((this.AudioPreviewUrl == null && other.AudioPreviewUrl == null) || (this.AudioPreviewUrl?.Equals(other.AudioPreviewUrl) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.HtmlDescription == null && other.HtmlDescription == null) || (this.HtmlDescription?.Equals(other.HtmlDescription) == true)) &&
                this.DurationMs.Equals(other.DurationMs) &&
                this.MExplicit.Equals(other.MExplicit) &&
                ((this.ExternalUrls == null && other.ExternalUrls == null) || (this.ExternalUrls?.Equals(other.ExternalUrls) == true)) &&
                ((this.Href == null && other.Href == null) || (this.Href?.Equals(other.Href) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Images == null && other.Images == null) || (this.Images?.Equals(other.Images) == true)) &&
                this.IsExternallyHosted.Equals(other.IsExternallyHosted) &&
                this.IsPlayable.Equals(other.IsPlayable) &&
                ((this.Language == null && other.Language == null) || (this.Language?.Equals(other.Language) == true)) &&
                ((this.Languages == null && other.Languages == null) || (this.Languages?.Equals(other.Languages) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ReleaseDate == null && other.ReleaseDate == null) || (this.ReleaseDate?.Equals(other.ReleaseDate) == true)) &&
                this.ReleaseDatePrecision.Equals(other.ReleaseDatePrecision) &&
                ((this.ResumePoint == null && other.ResumePoint == null) || (this.ResumePoint?.Equals(other.ResumePoint) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Uri == null && other.Uri == null) || (this.Uri?.Equals(other.Uri) == true)) &&
                ((this.Restrictions == null && other.Restrictions == null) || (this.Restrictions?.Equals(other.Restrictions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AudioPreviewUrl = {(this.AudioPreviewUrl == null ? "null" : this.AudioPreviewUrl)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.HtmlDescription = {(this.HtmlDescription == null ? "null" : this.HtmlDescription)}");
            toStringOutput.Add($"this.DurationMs = {this.DurationMs}");
            toStringOutput.Add($"this.MExplicit = {this.MExplicit}");
            toStringOutput.Add($"this.ExternalUrls = {(this.ExternalUrls == null ? "null" : this.ExternalUrls.ToString())}");
            toStringOutput.Add($"this.Href = {(this.Href == null ? "null" : this.Href)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Images = {(this.Images == null ? "null" : $"[{string.Join(", ", this.Images)} ]")}");
            toStringOutput.Add($"this.IsExternallyHosted = {this.IsExternallyHosted}");
            toStringOutput.Add($"this.IsPlayable = {this.IsPlayable}");
            toStringOutput.Add($"this.Language = {(this.Language == null ? "null" : this.Language)}");
            toStringOutput.Add($"this.Languages = {(this.Languages == null ? "null" : $"[{string.Join(", ", this.Languages)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.ReleaseDate = {(this.ReleaseDate == null ? "null" : this.ReleaseDate)}");
            toStringOutput.Add($"this.ReleaseDatePrecision = {this.ReleaseDatePrecision}");
            toStringOutput.Add($"this.ResumePoint = {(this.ResumePoint == null ? "null" : this.ResumePoint.ToString())}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Uri = {(this.Uri == null ? "null" : this.Uri)}");
            toStringOutput.Add($"this.Restrictions = {(this.Restrictions == null ? "null" : this.Restrictions.ToString())}");
        }
    }
}