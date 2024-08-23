// <copyright file="Type6Enum.cs" company="APIMatic">
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
    /// Type6Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type6Enum
    {
        /// <summary>
        /// AudioFeatures.
        /// </summary>
        [EnumMember(Value = "audio_features")]
        AudioFeatures
    }
}