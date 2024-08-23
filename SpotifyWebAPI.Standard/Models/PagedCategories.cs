// <copyright file="PagedCategories.cs" company="APIMatic">
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
    /// PagedCategories.
    /// </summary>
    public class PagedCategories
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedCategories"/> class.
        /// </summary>
        public PagedCategories()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedCategories"/> class.
        /// </summary>
        /// <param name="categories">categories.</param>
        public PagedCategories(
            Models.Categories categories)
        {
            this.Categories = categories;
        }

        /// <summary>
        /// Gets or sets Categories.
        /// </summary>
        [JsonProperty("categories")]
        public Models.Categories Categories { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PagedCategories : ({string.Join(", ", toStringOutput)})";
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
            return obj is PagedCategories other &&                ((this.Categories == null && other.Categories == null) || (this.Categories?.Equals(other.Categories) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Categories = {(this.Categories == null ? "null" : this.Categories.ToString())}");
        }
    }
}