// <copyright file="Type2Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpotifyWebAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using SpotifyWebAPI.Standard;
    using SpotifyWebAPI.Standard.Utilities;

    /// <summary>
    /// Type2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type2Enum
    {
        /// <summary>
        /// Album.
        /// </summary>
        [EnumMember(Value = "album")]
        Album
    }
}