
# Getting Started with Spotify Web API

## Introduction

You can use Spotify's Web API to discover music and podcasts, manage your Spotify library, control audio playback, and much more. Browse our available Web API endpoints using the sidebar at left, or via the navigation bar on top of this page on smaller screens.

In order to make successful Web API requests your app will need a valid access token. One can be obtained through <a href="https://developer.spotify.com/documentation/general/guides/authorization-guide/">OAuth 2.0</a>.

The base URI for all Web API requests is `https://api.spotify.com/v1`.

Need help? See our <a href="https://developer.spotify.com/documentation/web-api/guides/">Web API guides</a> for more information, or visit the <a href="https://community.spotify.com/t5/Spotify-for-Developers/bd-p/Spotify_Developer">Spotify for Developers community forum</a> to ask questions and connect with other developers.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package SpotifyApiSDK --version 1.0.0
```

You can also view the package at:
https://www.nuget.org/packages/SpotifyApiSDK/1.0.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `AuthorizationCodeAuth` | [`AuthorizationCodeAuth`](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/auth/oauth-2-authorization-code-grant.md) | The Credentials Setter for OAuth 2 Authorization Code Grant |

The API client can be initialized as follows:

```csharp
SpotifyWebAPI.Standard.SpotifyWebAPIClient client = new SpotifyWebAPI.Standard.SpotifyWebAPIClient.Builder()
    .AuthorizationCodeAuth(
        new AuthorizationCodeAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret",
            "OAuthRedirectUri"
        )
        .OAuthScopes(
            new List<OAuthScopeEnum>
            {
                OAuthScopeEnum.AppRemoteControl,
                OAuthScopeEnum.PlaylistReadPrivate,
            })
        .Build())
    .Environment(SpotifyWebAPI.Standard.Environment.Production)
    .Build();
```

API calls return an `ApiResponse` object that includes the following fields:

| Field | Description |
|  --- | --- |
| `StatusCode` | Status code of the HTTP response |
| `Headers` | Headers of the HTTP response as a Hash |
| `Data` | The deserialized body of the HTTP response as a String |

## Authorization

This API uses the following authentication schemes.

* [`oauth_2_0 (OAuth 2 Authorization Code Grant)`](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/auth/oauth-2-authorization-code-grant.md)

## List of APIs

* [Albums](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/albums.md)
* [Artists](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/artists.md)
* [Audiobooks](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/audiobooks.md)
* [Categories](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/categories.md)
* [Chapters](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/chapters.md)
* [Episodes](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/episodes.md)
* [Genres](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/genres.md)
* [Markets](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/markets.md)
* [Player](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/player.md)
* [Playlists](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/playlists.md)
* [Search](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/search.md)
* [Shows](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/shows.md)
* [Tracks](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/tracks.md)
* [Users](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/controllers/users.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/spotify-api-dotnet-sdk/tree/1.0.0/doc/api-exception.md)

