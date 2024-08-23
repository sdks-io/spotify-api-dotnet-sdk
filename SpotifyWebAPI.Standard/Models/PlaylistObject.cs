// <copyright file="PlaylistObject.cs" company="APIMatic">
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
    /// PlaylistObject.
    /// </summary>
    public class PlaylistObject
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistObject"/> class.
        /// </summary>
        public PlaylistObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistObject"/> class.
        /// </summary>
        /// <param name="collaborative">collaborative.</param>
        /// <param name="description">description.</param>
        /// <param name="externalUrls">external_urls.</param>
        /// <param name="followers">followers.</param>
        /// <param name="href">href.</param>
        /// <param name="id">id.</param>
        /// <param name="images">images.</param>
        /// <param name="name">name.</param>
        /// <param name="owner">owner.</param>
        /// <param name="mPublic">public.</param>
        /// <param name="snapshotId">snapshot_id.</param>
        /// <param name="tracks">tracks.</param>
        /// <param name="type">type.</param>
        /// <param name="uri">uri.</param>
        public PlaylistObject(
            bool? collaborative = null,
            string description = null,
            Models.ExternalUrlObject externalUrls = null,
            Models.FollowersObject followers = null,
            string href = null,
            string id = null,
            List<Models.ImageObject> images = null,
            string name = null,
            Models.PlaylistOwnerObject owner = null,
            bool? mPublic = null,
            string snapshotId = null,
            Models.PagingPlaylistTrackObject tracks = null,
            string type = null,
            string uri = null)
        {
            this.Collaborative = collaborative;
            if (description != null)
            {
                this.Description = description;
            }

            this.ExternalUrls = externalUrls;
            this.Followers = followers;
            this.Href = href;
            this.Id = id;
            this.Images = images;
            this.Name = name;
            this.Owner = owner;
            this.MPublic = mPublic;
            this.SnapshotId = snapshotId;
            this.Tracks = tracks;
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// `true` if the owner allows other users to modify the playlist.
        /// </summary>
        [JsonProperty("collaborative", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collaborative { get; set; }

        /// <summary>
        /// The playlist description. _Only returned for modified, verified playlists, otherwise_ `null`.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Known external URLs for this playlist.
        /// </summary>
        [JsonProperty("external_urls", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExternalUrlObject ExternalUrls { get; set; }

        /// <summary>
        /// Information about the followers of the playlist.
        /// </summary>
        [JsonProperty("followers", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FollowersObject Followers { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the playlist.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) for the playlist.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Images for the playlist. The array may be empty or contain up to three images. The images are returned by size in descending order. See [Working with Playlists](/documentation/web-api/concepts/playlists). _**Note**: If returned, the source URL for the image (`url`) is temporary and will expire in less than a day._
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ImageObject> Images { get; set; }

        /// <summary>
        /// The name of the playlist.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The user who owns the playlist
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlaylistOwnerObject Owner { get; set; }

        /// <summary>
        /// The playlist's public/private status: `true` the playlist is public, `false` the playlist is private, `null` the playlist status is not relevant. For more about public/private status, see [Working with Playlists](/documentation/web-api/concepts/playlists)
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MPublic { get; set; }

        /// <summary>
        /// The version identifier for the current playlist. Can be supplied in other requests to target a specific playlist version
        /// </summary>
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The tracks of the playlist.
        /// </summary>
        [JsonProperty("tracks", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PagingPlaylistTrackObject Tracks { get; set; }

        /// <summary>
        /// The object type: "playlist"
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// The [Spotify URI](/documentation/web-api/concepts/spotify-uris-ids) for the playlist.
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PlaylistObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
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
            return obj is PlaylistObject other &&                ((this.Collaborative == null && other.Collaborative == null) || (this.Collaborative?.Equals(other.Collaborative) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ExternalUrls == null && other.ExternalUrls == null) || (this.ExternalUrls?.Equals(other.ExternalUrls) == true)) &&
                ((this.Followers == null && other.Followers == null) || (this.Followers?.Equals(other.Followers) == true)) &&
                ((this.Href == null && other.Href == null) || (this.Href?.Equals(other.Href) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Images == null && other.Images == null) || (this.Images?.Equals(other.Images) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Owner == null && other.Owner == null) || (this.Owner?.Equals(other.Owner) == true)) &&
                ((this.MPublic == null && other.MPublic == null) || (this.MPublic?.Equals(other.MPublic) == true)) &&
                ((this.SnapshotId == null && other.SnapshotId == null) || (this.SnapshotId?.Equals(other.SnapshotId) == true)) &&
                ((this.Tracks == null && other.Tracks == null) || (this.Tracks?.Equals(other.Tracks) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Uri == null && other.Uri == null) || (this.Uri?.Equals(other.Uri) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Collaborative = {(this.Collaborative == null ? "null" : this.Collaborative.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.ExternalUrls = {(this.ExternalUrls == null ? "null" : this.ExternalUrls.ToString())}");
            toStringOutput.Add($"this.Followers = {(this.Followers == null ? "null" : this.Followers.ToString())}");
            toStringOutput.Add($"this.Href = {(this.Href == null ? "null" : this.Href)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Images = {(this.Images == null ? "null" : $"[{string.Join(", ", this.Images)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Owner = {(this.Owner == null ? "null" : this.Owner.ToString())}");
            toStringOutput.Add($"this.MPublic = {(this.MPublic == null ? "null" : this.MPublic.ToString())}");
            toStringOutput.Add($"this.SnapshotId = {(this.SnapshotId == null ? "null" : this.SnapshotId)}");
            toStringOutput.Add($"this.Tracks = {(this.Tracks == null ? "null" : this.Tracks.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Uri = {(this.Uri == null ? "null" : this.Uri)}");
        }
    }
}