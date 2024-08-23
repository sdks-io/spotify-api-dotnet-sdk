// <copyright file="IncludeExternalEnum.cs" company="APIMatic">
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
    /// IncludeExternalEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeExternalEnum
    {
        /// <summary>
        /// Audio.
        /// </summary>
        [EnumMember(Value = "audio")]
        Audio
    }
}