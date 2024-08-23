// <copyright file="AudiobookObject.cs" company="APIMatic">
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
    /// AudiobookObject.
    /// </summary>
    public class AudiobookObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudiobookObject"/> class.
        /// </summary>
        public AudiobookObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiobookObject"/> class.
        /// </summary>
        /// <param name="authors">authors.</param>
        /// <param name="availableMarkets">available_markets.</param>
        /// <param name="copyrights">copyrights.</param>
        /// <param name="description">description.</param>
        /// <param name="htmlDescription">html_description.</param>
        /// <param name="mExplicit">explicit.</param>
        /// <param name="externalUrls">external_urls.</param>
        /// <param name="href">href.</param>
        /// <param name="id">id.</param>
        /// <param name="images">images.</param>
        /// <param name="languages">languages.</param>
        /// <param name="mediaType">media_type.</param>
        /// <param name="name">name.</param>
        /// <param name="narrators">narrators.</param>
        /// <param name="publisher">publisher.</param>
        /// <param name="type">type.</param>
        /// <param name="uri">uri.</param>
        /// <param name="totalChapters">total_chapters.</param>
        /// <param name="chapters">chapters.</param>
        /// <param name="edition">edition.</param>
        public AudiobookObject(
            List<Models.AuthorObject> authors,
            List<string> availableMarkets,
            List<Models.CopyrightObject> copyrights,
            string description,
            string htmlDescription,
            bool mExplicit,
            Models.ExternalUrlObject externalUrls,
            string href,
            string id,
            List<Models.ImageObject> images,
            List<string> languages,
            string mediaType,
            string name,
            List<Models.NarratorObject> narrators,
            string publisher,
            Models.Type9Enum type,
            string uri,
            int totalChapters,
            Models.PagingSimplifiedChapterObject chapters,
            string edition = null)
        {
            this.Authors = authors;
            this.AvailableMarkets = availableMarkets;
            this.Copyrights = copyrights;
            this.Description = description;
            this.HtmlDescription = htmlDescription;
            this.Edition = edition;
            this.MExplicit = mExplicit;
            this.ExternalUrls = externalUrls;
            this.Href = href;
            this.Id = id;
            this.Images = images;
            this.Languages = languages;
            this.MediaType = mediaType;
            this.Name = name;
            this.Narrators = narrators;
            this.Publisher = publisher;
            this.Type = type;
            this.Uri = uri;
            this.TotalChapters = totalChapters;
            this.Chapters = chapters;
        }

        /// <summary>
        /// The author(s) for the audiobook.
        /// </summary>
        [JsonProperty("authors")]
        public List<Models.AuthorObject> Authors { get; set; }

        /// <summary>
        /// A list of the countries in which the audiobook can be played, identified by their [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        [JsonProperty("available_markets")]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        /// The copyright statements of the audiobook.
        /// </summary>
        [JsonProperty("copyrights")]
        public List<Models.CopyrightObject> Copyrights { get; set; }

        /// <summary>
        /// A description of the audiobook. HTML tags are stripped away from this field, use `html_description` field in case HTML tags are needed.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A description of the audiobook. This field may contain HTML tags.
        /// </summary>
        [JsonProperty("html_description")]
        public string HtmlDescription { get; set; }

        /// <summary>
        /// The edition of the audiobook.
        /// </summary>
        [JsonProperty("edition", NullValueHandling = NullValueHandling.Ignore)]
        public string Edition { get; set; }

        /// <summary>
        /// Whether or not the audiobook has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        [JsonProperty("explicit")]
        public bool MExplicit { get; set; }

        /// <summary>
        /// External URLs for this audiobook.
        /// </summary>
        [JsonProperty("external_urls")]
        public Models.ExternalUrlObject ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the audiobook.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the audiobook.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The cover art for the audiobook in various sizes, widest first.
        /// </summary>
        [JsonProperty("images")]
        public List<Models.ImageObject> Images { get; set; }

        /// <summary>
        /// A list of the languages used in the audiobook, identified by their [ISO 639](https://en.wikipedia.org/wiki/ISO_639) code.
        /// </summary>
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }

        /// <summary>
        /// The media type of the audiobook.
        /// </summary>
        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// The name of the audiobook.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The narrator(s) for the audiobook.
        /// </summary>
        [JsonProperty("narrators")]
        public List<Models.NarratorObject> Narrators { get; set; }

        /// <summary>
        /// The publisher of the audiobook.
        /// </summary>
        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type9Enum Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the audiobook.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// The number of chapters in this audiobook.
        /// </summary>
        [JsonProperty("total_chapters")]
        public int TotalChapters { get; set; }

        /// <summary>
        /// The chapters of the audiobook.
        /// </summary>
        [JsonProperty("chapters")]
        public Models.PagingSimplifiedChapterObject Chapters { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AudiobookObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is AudiobookObject other &&                ((this.Authors == null && other.Authors == null) || (this.Authors?.Equals(other.Authors) == true)) &&
                ((this.AvailableMarkets == null && other.AvailableMarkets == null) || (this.AvailableMarkets?.Equals(other.AvailableMarkets) == true)) &&
                ((this.Copyrights == null && other.Copyrights == null) || (this.Copyrights?.Equals(other.Copyrights) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.HtmlDescription == null && other.HtmlDescription == null) || (this.HtmlDescription?.Equals(other.HtmlDescription) == true)) &&
                ((this.Edition == null && other.Edition == null) || (this.Edition?.Equals(other.Edition) == true)) &&
                this.MExplicit.Equals(other.MExplicit) &&
                ((this.ExternalUrls == null && other.ExternalUrls == null) || (this.ExternalUrls?.Equals(other.ExternalUrls) == true)) &&
                ((this.Href == null && other.Href == null) || (this.Href?.Equals(other.Href) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Images == null && other.Images == null) || (this.Images?.Equals(other.Images) == true)) &&
                ((this.Languages == null && other.Languages == null) || (this.Languages?.Equals(other.Languages) == true)) &&
                ((this.MediaType == null && other.MediaType == null) || (this.MediaType?.Equals(other.MediaType) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Narrators == null && other.Narrators == null) || (this.Narrators?.Equals(other.Narrators) == true)) &&
                ((this.Publisher == null && other.Publisher == null) || (this.Publisher?.Equals(other.Publisher) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Uri == null && other.Uri == null) || (this.Uri?.Equals(other.Uri) == true)) &&
                this.TotalChapters.Equals(other.TotalChapters) &&
                ((this.Chapters == null && other.Chapters == null) || (this.Chapters?.Equals(other.Chapters) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Authors = {(this.Authors == null ? "null" : $"[{string.Join(", ", this.Authors)} ]")}");
            toStringOutput.Add($"this.AvailableMarkets = {(this.AvailableMarkets == null ? "null" : $"[{string.Join(", ", this.AvailableMarkets)} ]")}");
            toStringOutput.Add($"this.Copyrights = {(this.Copyrights == null ? "null" : $"[{string.Join(", ", this.Copyrights)} ]")}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.HtmlDescription = {(this.HtmlDescription == null ? "null" : this.HtmlDescription)}");
            toStringOutput.Add($"this.Edition = {(this.Edition == null ? "null" : this.Edition)}");
            toStringOutput.Add($"this.MExplicit = {this.MExplicit}");
            toStringOutput.Add($"this.ExternalUrls = {(this.ExternalUrls == null ? "null" : this.ExternalUrls.ToString())}");
            toStringOutput.Add($"this.Href = {(this.Href == null ? "null" : this.Href)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Images = {(this.Images == null ? "null" : $"[{string.Join(", ", this.Images)} ]")}");
            toStringOutput.Add($"this.Languages = {(this.Languages == null ? "null" : $"[{string.Join(", ", this.Languages)} ]")}");
            toStringOutput.Add($"this.MediaType = {(this.MediaType == null ? "null" : this.MediaType)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Narrators = {(this.Narrators == null ? "null" : $"[{string.Join(", ", this.Narrators)} ]")}");
            toStringOutput.Add($"this.Publisher = {(this.Publisher == null ? "null" : this.Publisher)}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Uri = {(this.Uri == null ? "null" : this.Uri)}");
            toStringOutput.Add($"this.TotalChapters = {this.TotalChapters}");
            toStringOutput.Add($"this.Chapters = {(this.Chapters == null ? "null" : this.Chapters.ToString())}");
        }
    }
}