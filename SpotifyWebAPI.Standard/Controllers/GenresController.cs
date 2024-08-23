// <copyright file="GenresController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpotifyWebAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using SpotifyWebAPI.Standard;
    using SpotifyWebAPI.Standard.Exceptions;
    using SpotifyWebAPI.Standard.Http.Client;
    using SpotifyWebAPI.Standard.Http.Response;
    using SpotifyWebAPI.Standard.Utilities;
    using System.Net.Http;

    /// <summary>
    /// GenresController.
    /// </summary>
    public class GenresController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenresController"/> class.
        /// </summary>
        internal GenresController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of available genres seed parameter values for [recommendations](/documentation/web-api/reference/get-recommendations).
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.ManyGenres response from the API call.</returns>
        public ApiResponse<Models.ManyGenres> GetRecommendationGenres()
            => CoreHelper.RunTask(GetRecommendationGenresAsync());

        /// <summary>
        /// Retrieve a list of available genres seed parameter values for [recommendations](/documentation/web-api/reference/get-recommendations).
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ManyGenres response from the API call.</returns>
        public async Task<ApiResponse<Models.ManyGenres>> GetRecommendationGenresAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ManyGenres>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/recommendations/available-genre-seeds")
                  .WithAuth("oauth_2_0"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Bad or expired token. This can happen if the user revoked a token or\nthe access token has expired. You should re-authenticate the user.\n", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Bad OAuth request (wrong consumer key, bad nonce, expired\ntimestamp...). Unfortunately, re-authenticating the user won't help here.\n", (_reason, _context) => new ForbiddenException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("The app has exceeded its rate limits.\n", (_reason, _context) => new TooManyRequestsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}