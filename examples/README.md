# Instagram dotnet request examples

Every file below is a complete single-request CLI program with environment-based authentication, all documented query options, timeout configuration, error handling and full response output. Sample defaults come from Postman; replace account names, IDs and URLs for your use case. `--help` requires no API key and makes no network request.

Set `JSONSCRAPER_INSTAGRAM_LICENSE_KEY` and install the SDK as described in the main README. Each execution makes one live request and may consume quota. None of these programs loops through a feed automatically.

## Get user info by ID

[Open the complete example](endpoints/v1_user_by_id/Program.cs) · `GET /v1/user/by/id`

```sh
dotnet run --project examples/endpoints/v1_user_by_id -- --help
```

## Get user info by username (by ID is faster)

[Open the complete example](endpoints/v1_user_by_username/Program.cs) · `GET /v1/user/by/username`

```sh
dotnet run --project examples/endpoints/v1_user_by_username -- --help
```

## Get user info by URL (by ID is faster)

[Open the complete example](endpoints/v1_user_by_url/Program.cs) · `GET /v1/user/by/url`

```sh
dotnet run --project examples/endpoints/v1_user_by_url -- --help
```

## Get info about user by ID

[Open the complete example](endpoints/v1_user_about/Program.cs) · `GET /v1/user/about`

```sh
dotnet run --project examples/endpoints/v1_user_about -- --help
```

## Get posts (chunked)

[Open the complete example](endpoints/v1_user_medias_chunk/Program.cs) · `GET /v1/user/medias/chunk`

```sh
dotnet run --project examples/endpoints/v1_user_medias_chunk -- --help
```

## Get pinned posts

[Open the complete example](endpoints/v1_user_medias_pinned/Program.cs) · `GET /v1/user/medias/pinned`

```sh
dotnet run --project examples/endpoints/v1_user_medias_pinned -- --help
```

## Get reels (chunked)

[Open the complete example](endpoints/v1_user_clips_chunk/Program.cs) · `GET /v1/user/clips/chunk`

```sh
dotnet run --project examples/endpoints/v1_user_clips_chunk -- --help
```

## Get tagged (mentions) posts

[Open the complete example](endpoints/v1_user_tag_medias_chunk/Program.cs) · `GET /v1/user/tag/medias/chunk`

```sh
dotnet run --project examples/endpoints/v1_user_tag_medias_chunk -- --help
```

## Get user stories by ID

[Open the complete example](endpoints/v1_user_stories/Program.cs) · `GET /v1/user/stories`

```sh
dotnet run --project examples/endpoints/v1_user_stories -- --help
```

## Get user stories by username (by ID is faster)

[Open the complete example](endpoints/v1_user_stories_by_username/Program.cs) · `GET /v1/user/stories/by/username`

```sh
dotnet run --project examples/endpoints/v1_user_stories_by_username -- --help
```

## Get user highlights by ID

[Open the complete example](endpoints/v1_user_highlights/Program.cs) · `GET /v1/user/highlights`

```sh
dotnet run --project examples/endpoints/v1_user_highlights -- --help
```

## Get user highlights by username (by ID is faster)

[Open the complete example](endpoints/v1_user_highlights_by_username/Program.cs) · `GET /v1/user/highlights/by/username`

```sh
dotnet run --project examples/endpoints/v1_user_highlights_by_username -- --help
```

## Search in followers list by query (not working for legacy verified accounts)

[Open the complete example](endpoints/v1_user_search_followers/Program.cs) · `GET /v1/user/search/followers`

```sh
dotnet run --project examples/endpoints/v1_user_search_followers -- --help
```

## Search in followings list by query (not working for legacy verified accounts)

[Open the complete example](endpoints/v1_user_search_following/Program.cs) · `GET /v1/user/search/following`

```sh
dotnet run --project examples/endpoints/v1_user_search_following -- --help
```

## Get user following (chunked)

[Open the complete example](endpoints/v1_user_following_chunk/Program.cs) · `GET /v1/user/following/chunk`

```sh
dotnet run --project examples/endpoints/v1_user_following_chunk -- --help
```

## Get user followers (chunked)

[Open the complete example](endpoints/v1_user_followers_chunk/Program.cs) · `GET /v1/user/followers/chunk`

```sh
dotnet run --project examples/endpoints/v1_user_followers_chunk -- --help
```

## Get media info by ID

[Open the complete example](endpoints/v1_media_by_id/Program.cs) · `GET /v1/media/by/id`

```sh
dotnet run --project examples/endpoints/v1_media_by_id -- --help
```

## Get media info by shortcode

[Open the complete example](endpoints/v1_media_by_code/Program.cs) · `GET /v1/media/by/code`

```sh
dotnet run --project examples/endpoints/v1_media_by_code -- --help
```

## Get media info by URL

[Open the complete example](endpoints/v1_media_by_url/Program.cs) · `GET /v1/media/by/url`

```sh
dotnet run --project examples/endpoints/v1_media_by_url -- --help
```

## Get media insights

[Open the complete example](endpoints/v1_media_insight/Program.cs) · `GET /v1/media/insight`

```sh
dotnet run --project examples/endpoints/v1_media_insight -- --help
```

## Get media comments (chunked)

[Open the complete example](endpoints/v1_media_comments_chunk/Program.cs) · `GET /v1/media/comments/chunk`

```sh
dotnet run --project examples/endpoints/v1_media_comments_chunk -- --help
```

## Get media likers

[Open the complete example](endpoints/v1_media_likers/Program.cs) · `GET /v1/media/likers`

```sh
dotnet run --project examples/endpoints/v1_media_likers -- --help
```

## Get author of the media

[Open the complete example](endpoints/v1_media_user/Program.cs) · `GET /v1/media/user`

```sh
dotnet run --project examples/endpoints/v1_media_user -- --help
```

## Get media oEmbed data

[Open the complete example](endpoints/v1_media_oembed/Program.cs) · `GET /v1/media/oembed`

```sh
dotnet run --project examples/endpoints/v1_media_oembed -- --help
```

## Get media code from media ID (PK) (unlimited usage)

[Open the complete example](endpoints/v1_media_code_from_pk/Program.cs) · `GET /v1/media/code/from/pk`

```sh
dotnet run --project examples/endpoints/v1_media_code_from_pk -- --help
```

## Get media ID (PK) from shortcode (unlimited usage)

[Open the complete example](endpoints/v1_media_pk_from_code/Program.cs) · `GET /v1/media/pk/from/code`

```sh
dotnet run --project examples/endpoints/v1_media_pk_from_code -- --help
```

## Get media ID (PK) from URL (unlimited usage)

[Open the complete example](endpoints/v1_media_pk_from_url/Program.cs) · `GET /v1/media/pk/from/url`

```sh
dotnet run --project examples/endpoints/v1_media_pk_from_url -- --help
```

## Get story by ID

[Open the complete example](endpoints/v1_story_by_id/Program.cs) · `GET /v1/story/by/id`

```sh
dotnet run --project examples/endpoints/v1_story_by_id -- --help
```

## Get story by URL

[Open the complete example](endpoints/v1_story_by_url/Program.cs) · `GET /v1/story/by/url`

```sh
dotnet run --project examples/endpoints/v1_story_by_url -- --help
```

## Download story by ID

[Open the complete example](endpoints/v1_story_download/Program.cs) · `GET /v1/story/download`

```sh
dotnet run --project examples/endpoints/v1_story_download -- --help
```

## Download story by direct media URL (unlimited usage)

[Open the complete example](endpoints/v1_story_download_by_url/Program.cs) · `GET /v1/story/download/by/url`

```sh
dotnet run --project examples/endpoints/v1_story_download_by_url -- --help
```

## Download story file by story URL (IG story link)

[Open the complete example](endpoints/v1_story_download_by_story_url/Program.cs) · `GET /v1/story/download/by/story/url`

```sh
dotnet run --project examples/endpoints/v1_story_download_by_story_url -- --help
```

## Get highlight by ID

[Open the complete example](endpoints/v1_highlight_by_id/Program.cs) · `GET /v1/highlight/by/id`

```sh
dotnet run --project examples/endpoints/v1_highlight_by_id -- --help
```

## Get highlight by URL

[Open the complete example](endpoints/v1_highlight_by_url/Program.cs) · `GET /v1/highlight/by/url`

```sh
dotnet run --project examples/endpoints/v1_highlight_by_url -- --help
```

## Get location by ID

[Open the complete example](endpoints/v1_location_by_id/Program.cs) · `GET /v1/location/by/id`

```sh
dotnet run --project examples/endpoints/v1_location_by_id -- --help
```

## Get location top medias

[Open the complete example](endpoints/v1_location_medias_top/Program.cs) · `GET /v1/location/medias/top`

```sh
dotnet run --project examples/endpoints/v1_location_medias_top -- --help
```

## Get location recent medias

[Open the complete example](endpoints/v1_location_medias_recent/Program.cs) · `GET /v1/location/medias/recent`

```sh
dotnet run --project examples/endpoints/v1_location_medias_recent -- --help
```

## Get location top medias (chunked)

[Open the complete example](endpoints/v1_location_medias_top_chunk/Program.cs) · `GET /v1/location/medias/top/chunk`

```sh
dotnet run --project examples/endpoints/v1_location_medias_top_chunk -- --help
```

## Get location recent medias (chunked)

[Open the complete example](endpoints/v1_location_medias_recent_chunk/Program.cs) · `GET /v1/location/medias/recent/chunk`

```sh
dotnet run --project examples/endpoints/v1_location_medias_recent_chunk -- --help
```

## Search locations

[Open the complete example](endpoints/v1_location_search/Program.cs) · `GET /v1/location/search`

```sh
dotnet run --project examples/endpoints/v1_location_search -- --help
```

## Get hashtag by name

[Open the complete example](endpoints/v1_hashtag_by_name/Program.cs) · `GET /v1/hashtag/by/name`

```sh
dotnet run --project examples/endpoints/v1_hashtag_by_name -- --help
```

## Get hashtag top medias

[Open the complete example](endpoints/v1_hashtag_medias_top/Program.cs) · `GET /v1/hashtag/medias/top`

```sh
dotnet run --project examples/endpoints/v1_hashtag_medias_top -- --help
```

## Get hashtag top medias (chunked)

[Open the complete example](endpoints/v1_hashtag_medias_top_chunk/Program.cs) · `GET /v1/hashtag/medias/top/chunk`

```sh
dotnet run --project examples/endpoints/v1_hashtag_medias_top_chunk -- --help
```

## Get hashtag recent medias (chunked)

[Open the complete example](endpoints/v1_hashtag_medias_top_recent_chunk/Program.cs) · `GET /v1/hashtag/medias/top/recent/chunk`

```sh
dotnet run --project examples/endpoints/v1_hashtag_medias_top_recent_chunk -- --help
```

## Get hashtag clips (chunked)

[Open the complete example](endpoints/v1_hashtag_medias_clips_chunk/Program.cs) · `GET /v1/hashtag/medias/clips/chunk`

```sh
dotnet run --project examples/endpoints/v1_hashtag_medias_clips_chunk -- --help
```

## Search hashtags

[Open the complete example](endpoints/v1_search_hashtags/Program.cs) · `GET /v1/search/hashtags`

```sh
dotnet run --project examples/endpoints/v1_search_hashtags -- --help
```

## Search users

[Open the complete example](endpoints/v1_search_users/Program.cs) · `GET /v1/search/users`

```sh
dotnet run --project examples/endpoints/v1_search_users -- --help
```

## Search music

[Open the complete example](endpoints/v1_search_music/Program.cs) · `GET /v1/search/music`

```sh
dotnet run --project examples/endpoints/v1_search_music -- --help
```

## Search places

[Open the complete example](endpoints/v1_fbsearch_places/Program.cs) · `GET /v1/fbsearch/places`

```sh
dotnet run --project examples/endpoints/v1_fbsearch_places -- --help
```

## Top search

[Open the complete example](endpoints/v1_fbsearch_topsearch/Program.cs) · `GET /v1/fbsearch/topsearch`

```sh
dotnet run --project examples/endpoints/v1_fbsearch_topsearch -- --help
```

## Get user info by ID

[Open the complete example](endpoints/v2_user_by_id/Program.cs) · `GET /v2/user/by/id`

```sh
dotnet run --project examples/endpoints/v2_user_by_id -- --help
```

## Get user info by username

[Open the complete example](endpoints/v2_user_by_username/Program.cs) · `GET /v2/user/by/username`

```sh
dotnet run --project examples/endpoints/v2_user_by_username -- --help
```

## Get user info stream by ID

[Open the complete example](endpoints/v2_userstream_by_id/Program.cs) · `GET /v2/userstream/by/id`

```sh
dotnet run --project examples/endpoints/v2_userstream_by_id -- --help
```

## Get user info stream by username

[Open the complete example](endpoints/v2_userstream_by_username/Program.cs) · `GET /v2/userstream/by/username`

```sh
dotnet run --project examples/endpoints/v2_userstream_by_username -- --help
```

## Get user stories by ID

[Open the complete example](endpoints/v2_user_stories/Program.cs) · `GET /v2/user/stories`

```sh
dotnet run --project examples/endpoints/v2_user_stories -- --help
```

## Get user stories by username

[Open the complete example](endpoints/v2_user_stories_by_username/Program.cs) · `GET /v2/user/stories/by/username`

```sh
dotnet run --project examples/endpoints/v2_user_stories_by_username -- --help
```

## Get user reels by ID

[Open the complete example](endpoints/v2_user_clips/Program.cs) · `GET /v2/user/clips`

```sh
dotnet run --project examples/endpoints/v2_user_clips -- --help
```

## Get user following list

[Open the complete example](endpoints/v2_user_following/Program.cs) · `GET /v2/user/following`

```sh
dotnet run --project examples/endpoints/v2_user_following -- --help
```

## Get user followers list

[Open the complete example](endpoints/v2_user_followers/Program.cs) · `GET /v2/user/followers`

```sh
dotnet run --project examples/endpoints/v2_user_followers -- --help
```

## Get media where user is tagged

[Open the complete example](endpoints/v2_user_tag_medias/Program.cs) · `GET /v2/user/tag/medias`

```sh
dotnet run --project examples/endpoints/v2_user_tag_medias -- --help
```

## Get user highlights by ID

[Open the complete example](endpoints/v2_user_highlights/Program.cs) · `GET /v2/user/highlights`

```sh
dotnet run --project examples/endpoints/v2_user_highlights -- --help
```

## Get user highlights by username (by ID is faster)

[Open the complete example](endpoints/v2_user_highlights_by_username/Program.cs) · `GET /v2/user/highlights/by/username`

```sh
dotnet run --project examples/endpoints/v2_user_highlights_by_username -- --help
```

## Get business suggestions for user

[Open the complete example](endpoints/v2_user_explore_businesses_by_id/Program.cs) · `GET /v2/user/explore/businesses/by/id`

```sh
dotnet run --project examples/endpoints/v2_user_explore_businesses_by_id -- --help
```

## Get suggested profiles for user

[Open the complete example](endpoints/v2_user_suggested_profiles/Program.cs) · `GET /v2/user/suggested/profiles`

```sh
dotnet run --project examples/endpoints/v2_user_suggested_profiles -- --help
```

## Get media info by ID

[Open the complete example](endpoints/v2_media_info_by_id/Program.cs) · `GET /v2/media/info/by/id`

```sh
dotnet run --project examples/endpoints/v2_media_info_by_id -- --help
```

## Get media info by shortcode

[Open the complete example](endpoints/v2_media_info_by_code/Program.cs) · `GET /v2/media/info/by/code`

```sh
dotnet run --project examples/endpoints/v2_media_info_by_code -- --help
```

## Get media info by URL

[Open the complete example](endpoints/v2_media_info_by_url/Program.cs) · `GET /v2/media/info/by/url`

```sh
dotnet run --project examples/endpoints/v2_media_info_by_url -- --help
```

## Get media comments

[Open the complete example](endpoints/v2_media_comments/Program.cs) · `GET /v2/media/comments`

```sh
dotnet run --project examples/endpoints/v2_media_comments -- --help
```

## Get media likers

[Open the complete example](endpoints/v2_media_likers/Program.cs) · `GET /v2/media/likers`

```sh
dotnet run --project examples/endpoints/v2_media_likers -- --help
```

## Check comment for offensiveness

[Open the complete example](endpoints/v2_media_comment_offensive/Program.cs) · `GET /v2/media/comment/offensive`

```sh
dotnet run --project examples/endpoints/v2_media_comment_offensive -- --help
```

## Get comment replies

[Open the complete example](endpoints/v2_media_comments_replies/Program.cs) · `GET /v2/media/comments/replies`

```sh
dotnet run --project examples/endpoints/v2_media_comments_replies -- --help
```

## Get story by ID

[Open the complete example](endpoints/v2_story_by_id/Program.cs) · `GET /v2/story/by/id`

```sh
dotnet run --project examples/endpoints/v2_story_by_id -- --help
```

## Get music feed by canonical ID

[Open the complete example](endpoints/v2_track_by_canonical_id/Program.cs) · `GET /v2/track/by/canonical/id`

```sh
dotnet run --project examples/endpoints/v2_track_by_canonical_id -- --help
```

## Get music feed by ID

[Open the complete example](endpoints/v2_track_by_id/Program.cs) · `GET /v2/track/by/id`

```sh
dotnet run --project examples/endpoints/v2_track_by_id -- --help
```

## Get hashtag by name

[Open the complete example](endpoints/v2_hashtag_by_name/Program.cs) · `GET /v2/hashtag/by/name`

```sh
dotnet run --project examples/endpoints/v2_hashtag_by_name -- --help
```

## Get hashtag top medias

[Open the complete example](endpoints/v2_hashtag_medias_top/Program.cs) · `GET /v2/hashtag/medias/top`

```sh
dotnet run --project examples/endpoints/v2_hashtag_medias_top -- --help
```

## Get hashtag recent medias

[Open the complete example](endpoints/v2_hashtag_medias_recent/Program.cs) · `GET /v2/hashtag/medias/recent`

```sh
dotnet run --project examples/endpoints/v2_hashtag_medias_recent -- --help
```

## Get highlight by ID

[Open the complete example](endpoints/v2_highlight_by_id/Program.cs) · `GET /v2/highlight/by/id`

```sh
dotnet run --project examples/endpoints/v2_highlight_by_id -- --help
```

## Search hashtags

[Open the complete example](endpoints/v2_search_hashtags/Program.cs) · `GET /v2/search/hashtags`

```sh
dotnet run --project examples/endpoints/v2_search_hashtags -- --help
```

## Search music

[Open the complete example](endpoints/v2_search_music/Program.cs) · `GET /v2/search/music`

```sh
dotnet run --project examples/endpoints/v2_search_music -- --help
```

## Search accounts (users)

[Open the complete example](endpoints/v2_fbsearch_accounts/Program.cs) · `GET /v2/fbsearch/accounts`

```sh
dotnet run --project examples/endpoints/v2_fbsearch_accounts -- --help
```

## Search places (locations)

[Open the complete example](endpoints/v2_fbsearch_places/Program.cs) · `GET /v2/fbsearch/places`

```sh
dotnet run --project examples/endpoints/v2_fbsearch_places -- --help
```

## Top search

[Open the complete example](endpoints/v2_fbsearch_topsearch/Program.cs) · `GET /v2/fbsearch/topsearch`

```sh
dotnet run --project examples/endpoints/v2_fbsearch_topsearch -- --help
```

## Search reels (clips)

[Open the complete example](endpoints/v2_fbsearch_reels/Program.cs) · `GET /v2/fbsearch/reels`

```sh
dotnet run --project examples/endpoints/v2_fbsearch_reels -- --help
```

## Get comments list by media ID (chunked)

[Open the complete example](endpoints/gql_comments_chunk/Program.cs) · `GET /gql/comments/chunk`

```sh
dotnet run --project examples/endpoints/gql_comments_chunk -- --help
```

## Get threaded replies list by comment ID (chunked)

[Open the complete example](endpoints/gql_comments_threaded_chunk/Program.cs) · `GET /gql/comments/threaded/chunk`

```sh
dotnet run --project examples/endpoints/gql_comments_threaded_chunk -- --help
```

## Get comment likers list by comment ID (chunked)

[Open the complete example](endpoints/gql_comment_likers_chunk/Program.cs) · `GET /gql/comment/likers/chunk`

```sh
dotnet run --project examples/endpoints/gql_comment_likers_chunk -- --help
```

## Search top content by keyword

[Open the complete example](endpoints/gql_topsearch/Program.cs) · `GET /gql/topsearch`

```sh
dotnet run --project examples/endpoints/gql_topsearch -- --help
```

## Get media likers by media ID

[Open the complete example](endpoints/gql_media_likers/Program.cs) · `GET /gql/media/likers`

```sh
dotnet run --project examples/endpoints/gql_media_likers -- --help
```

## Get video usertags by media IDs

[Open the complete example](endpoints/gql_media_usertags/Program.cs) · `GET /gql/media/usertags`

```sh
dotnet run --project examples/endpoints/gql_media_usertags -- --help
```

## Get user followers (chunked)

[Open the complete example](endpoints/gql_user_followers_chunk/Program.cs) · `GET /gql/user/followers/chunk`

```sh
dotnet run --project examples/endpoints/gql_user_followers_chunk -- --help
```

## Get user following (chunked)

[Open the complete example](endpoints/gql_user_following_chunk/Program.cs) · `GET /gql/user/following/chunk`

```sh
dotnet run --project examples/endpoints/gql_user_following_chunk -- --help
```

## Get user reposts

[Open the complete example](endpoints/gql_user_reposts/Program.cs) · `GET /gql/user/reposts`

```sh
dotnet run --project examples/endpoints/gql_user_reposts -- --help
```

## Get user clips (reels)

[Open the complete example](endpoints/gql_user_clips/Program.cs) · `GET /gql/user/clips`

```sh
dotnet run --project examples/endpoints/gql_user_clips -- --help
```

## Get user profile media (grid)

[Open the complete example](endpoints/gql_user_medias/Program.cs) · `GET /gql/user/medias`

```sh
dotnet run --project examples/endpoints/gql_user_medias -- --help
```

## Search users

[Open the complete example](endpoints/v3_fbsearch_accounts/Program.cs) · `GET /v3/fbsearch/accounts`

```sh
dotnet run --project examples/endpoints/v3_fbsearch_accounts -- --help
```

## Search places (locations)

[Open the complete example](endpoints/v3_fbsearch_places/Program.cs) · `GET /v3/fbsearch/places`

```sh
dotnet run --project examples/endpoints/v3_fbsearch_places -- --help
```

