# Instagram API endpoint reference

97 unique GET routes from the published Postman collection. Configure `license_key` on the client. Query parameters below use the same names as the API; check Postman for required/optional rules.

| SDK method | GET path | Query parameters | Purpose |
| --- | --- | --- | --- |
| `V1UserByIdAsync` | `/v1/user/by/id` | `id`, `cache_timeout` | Get user info by ID |
| `V1UserByUsernameAsync` | `/v1/user/by/username` | `username`, `cache_timeout` | Get user info by username (by ID is faster) |
| `V1UserByUrlAsync` | `/v1/user/by/url` | `url`, `cache_timeout` | Get user info by URL (by ID is faster) |
| `V1UserAboutAsync` | `/v1/user/about` | `id`, `cache_timeout` | Get info about user by ID |
| `V1UserMediasChunkAsync` | `/v1/user/medias/chunk` | `user_id`, `end_cursor`, `cache_timeout` | Get posts (chunked) |
| `V1UserMediasPinnedAsync` | `/v1/user/medias/pinned` | `user_id`, `amount`, `cache_timeout` | Get pinned posts |
| `V1UserClipsChunkAsync` | `/v1/user/clips/chunk` | `user_id`, `end_cursor`, `cache_timeout` | Get reels (chunked) |
| `V1UserTagMediasChunkAsync` | `/v1/user/tag/medias/chunk` | `user_id`, `max_id`, `cache_timeout` | Get tagged (mentions) posts |
| `V1UserStoriesAsync` | `/v1/user/stories` | `user_id`, `amount`, `force`, `cache_timeout` | Get user stories by ID |
| `V1UserStoriesByUsernameAsync` | `/v1/user/stories/by/username` | `username`, `amount`, `force`, `cache_timeout` | Get user stories by username (by ID is faster) |
| `V1UserHighlightsAsync` | `/v1/user/highlights` | `user_id`, `amount`, `force`, `cache_timeout` | Get user highlights by ID |
| `V1UserHighlightsByUsernameAsync` | `/v1/user/highlights/by/username` | `username`, `amount`, `force`, `cache_timeout` | Get user highlights by username (by ID is faster) |
| `V1UserSearchFollowersAsync` | `/v1/user/search/followers` | `user_id`, `query`, `force`, `cache_timeout` | Search in followers list by query (not working for legacy verified accounts) |
| `V1UserSearchFollowingAsync` | `/v1/user/search/following` | `user_id`, `query`, `force`, `cache_timeout` | Search in followings list by query (not working for legacy verified accounts) |
| `V1UserFollowingChunkAsync` | `/v1/user/following/chunk` | `user_id`, `max_id`, `cache_timeout` | Get user following (chunked) |
| `V1UserFollowersChunkAsync` | `/v1/user/followers/chunk` | `user_id`, `max_id`, `cache_timeout` | Get user followers (chunked) |
| `V1MediaByIdAsync` | `/v1/media/by/id` | `id`, `cache_timeout` | Get media info by ID |
| `V1MediaByCodeAsync` | `/v1/media/by/code` | `code`, `cache_timeout` | Get media info by shortcode |
| `V1MediaByUrlAsync` | `/v1/media/by/url` | `url`, `cache_timeout` | Get media info by URL |
| `V1MediaInsightAsync` | `/v1/media/insight` | `media_id`, `cache_timeout` | Get media insights |
| `V1MediaCommentsChunkAsync` | `/v1/media/comments/chunk` | `id`, `min_id`, `max_id`, `can_support_threading`, `cache_timeout` | Get media comments (chunked) |
| `V1MediaLikersAsync` | `/v1/media/likers` | `id`, `cache_timeout` | Get media likers |
| `V1MediaUserAsync` | `/v1/media/user` | `media_id`, `cache_timeout` | Get author of the media |
| `V1MediaOembedAsync` | `/v1/media/oembed` | `url`, `cache_timeout` | Get media oEmbed data |
| `V1MediaCodeFromPkAsync` | `/v1/media/code/from/pk` | `pk`, `cache_timeout` | Get media code from media ID (PK) (unlimited usage) |
| `V1MediaPkFromCodeAsync` | `/v1/media/pk/from/code` | `code`, `cache_timeout` | Get media ID (PK) from shortcode (unlimited usage) |
| `V1MediaPkFromUrlAsync` | `/v1/media/pk/from/url` | `url`, `cache_timeout` | Get media ID (PK) from URL (unlimited usage) |
| `V1StoryByIdAsync` | `/v1/story/by/id` | `id`, `cache_timeout` | Get story by ID |
| `V1StoryByUrlAsync` | `/v1/story/by/url` | `url`, `cache_timeout` | Get story by URL |
| `V1StoryDownloadAsync` | `/v1/story/download` | `id` | Download story by ID |
| `V1StoryDownloadByUrlAsync` | `/v1/story/download/by/url` | `url` | Download story by direct media URL (unlimited usage) |
| `V1StoryDownloadByStoryUrlAsync` | `/v1/story/download/by/story/url` | `url` | Download story file by story URL (IG story link) |
| `V1HighlightByIdAsync` | `/v1/highlight/by/id` | `id`, `cache_timeout` | Get highlight by ID |
| `V1HighlightByUrlAsync` | `/v1/highlight/by/url` | `url`, `cache_timeout` | Get highlight by URL |
| `V1LocationByIdAsync` | `/v1/location/by/id` | `id`, `cache_timeout` | Get location by ID |
| `V1LocationMediasTopAsync` | `/v1/location/medias/top` | `location_pk`, `amount`, `cache_timeout` | Get location top medias |
| `V1LocationMediasRecentAsync` | `/v1/location/medias/recent` | `location_pk`, `amount`, `cache_timeout` | Get location recent medias |
| `V1LocationMediasTopChunkAsync` | `/v1/location/medias/top/chunk` | `location_pk`, `max_id`, `cache_timeout` | Get location top medias (chunked) |
| `V1LocationMediasRecentChunkAsync` | `/v1/location/medias/recent/chunk` | `location_pk`, `max_id`, `cache_timeout` | Get location recent medias (chunked) |
| `V1LocationSearchAsync` | `/v1/location/search` | `lat`, `lng`, `cache_timeout` | Search locations |
| `V1HashtagByNameAsync` | `/v1/hashtag/by/name` | `name`, `cache_timeout` | Get hashtag by name |
| `V1HashtagMediasTopAsync` | `/v1/hashtag/medias/top` | `name`, `amount`, `cache_timeout` | Get hashtag top medias |
| `V1HashtagMediasTopChunkAsync` | `/v1/hashtag/medias/top/chunk` | `name`, `max_id`, `cache_timeout` | Get hashtag top medias (chunked) |
| `V1HashtagMediasTopRecentChunkAsync` | `/v1/hashtag/medias/top/recent/chunk` | `name`, `max_id`, `cache_timeout` | Get hashtag recent medias (chunked) |
| `V1HashtagMediasClipsChunkAsync` | `/v1/hashtag/medias/clips/chunk` | `name`, `max_id`, `cache_timeout` | Get hashtag clips (chunked) |
| `V1SearchHashtagsAsync` | `/v1/search/hashtags` | `query`, `cache_timeout` | Search hashtags |
| `V1SearchUsersAsync` | `/v1/search/users` | `query`, `cache_timeout` | Search users |
| `V1SearchMusicAsync` | `/v1/search/music` | `query`, `cache_timeout` | Search music |
| `V1FbsearchPlacesAsync` | `/v1/fbsearch/places` | `query`, `lat`, `lng`, `cache_timeout` | Search places |
| `V1FbsearchTopsearchAsync` | `/v1/fbsearch/topsearch` | `query`, `cache_timeout` | Top search |
| `V2UserByIdAsync` | `/v2/user/by/id` | `id`, `cache_timeout` | Get user info by ID |
| `V2UserByUsernameAsync` | `/v2/user/by/username` | `username`, `cache_timeout` | Get user info by username |
| `V2UserstreamByIdAsync` | `/v2/userstream/by/id` | `id`, `cache_timeout` | Get user info stream by ID |
| `V2UserstreamByUsernameAsync` | `/v2/userstream/by/username` | `username`, `cache_timeout` | Get user info stream by username |
| `V2UserStoriesAsync` | `/v2/user/stories` | `user_id`, `force`, `safe_int`, `cache_timeout` | Get user stories by ID |
| `V2UserStoriesByUsernameAsync` | `/v2/user/stories/by/username` | `username`, `force`, `safe_int`, `cache_timeout` | Get user stories by username |
| `V2UserClipsAsync` | `/v2/user/clips` | `user_id`, `page_id`, `safe_int`, `cache_timeout` | Get user reels by ID |
| `V2UserFollowingAsync` | `/v2/user/following` | `user_id`, `page_id`, `cache_timeout` | Get user following list |
| `V2UserFollowersAsync` | `/v2/user/followers` | `user_id`, `page_id`, `cache_timeout` | Get user followers list |
| `V2UserTagMediasAsync` | `/v2/user/tag/medias` | `user_id`, `page_id`, `cache_timeout` | Get media where user is tagged |
| `V2UserHighlightsAsync` | `/v2/user/highlights` | `user_id`, `amount`, `force`, `cache_timeout` | Get user highlights by ID |
| `V2UserHighlightsByUsernameAsync` | `/v2/user/highlights/by/username` | `username`, `amount`, `force`, `cache_timeout` | Get user highlights by username (by ID is faster) |
| `V2UserExploreBusinessesByIdAsync` | `/v2/user/explore/businesses/by/id` | `user_id`, `cache_timeout` | Get business suggestions for user |
| `V2UserSuggestedProfilesAsync` | `/v2/user/suggested/profiles` | `user_id`, `expand_suggestion`, `cache_timeout` | Get suggested profiles for user |
| `V2MediaInfoByIdAsync` | `/v2/media/info/by/id` | `id`, `cache_timeout` | Get media info by ID |
| `V2MediaInfoByCodeAsync` | `/v2/media/info/by/code` | `code`, `cache_timeout` | Get media info by shortcode |
| `V2MediaInfoByUrlAsync` | `/v2/media/info/by/url` | `url`, `cache_timeout` | Get media info by URL |
| `V2MediaCommentsAsync` | `/v2/media/comments` | `id`, `page_id`, `can_support_threading`, `cache_timeout` | Get media comments |
| `V2MediaLikersAsync` | `/v2/media/likers` | `id`, `cache_timeout` | Get media likers |
| `V2MediaCommentOffensiveAsync` | `/v2/media/comment/offensive` | `media_id`, `comment`, `cache_timeout` | Check comment for offensiveness |
| `V2MediaCommentsRepliesAsync` | `/v2/media/comments/replies` | `media_id`, `comment_id`, `min_id`, `cache_timeout` | Get comment replies |
| `V2StoryByIdAsync` | `/v2/story/by/id` | `id`, `cache_timeout` | Get story by ID |
| `V2TrackByCanonicalIdAsync` | `/v2/track/by/canonical/id` | `canonical_id`, `page_id`, `cache_timeout` | Get music feed by canonical ID |
| `V2TrackByIdAsync` | `/v2/track/by/id` | `track_id`, `page_id`, `cache_timeout` | Get music feed by ID |
| `V2HashtagByNameAsync` | `/v2/hashtag/by/name` | `name`, `cache_timeout` | Get hashtag by name |
| `V2HashtagMediasTopAsync` | `/v2/hashtag/medias/top` | `name`, `page_id`, `cache_timeout` | Get hashtag top medias |
| `V2HashtagMediasRecentAsync` | `/v2/hashtag/medias/recent` | `name`, `page_id`, `cache_timeout` | Get hashtag recent medias |
| `V2HighlightByIdAsync` | `/v2/highlight/by/id` | `id`, `cache_timeout` | Get highlight by ID |
| `V2SearchHashtagsAsync` | `/v2/search/hashtags` | `query`, `page_token`, `cache_timeout` | Search hashtags |
| `V2SearchMusicAsync` | `/v2/search/music` | `query`, `next_max_id`, `cache_timeout` | Search music |
| `V2FbsearchAccountsAsync` | `/v2/fbsearch/accounts` | `query`, `page_token`, `cache_timeout` | Search accounts (users) |
| `V2FbsearchPlacesAsync` | `/v2/fbsearch/places` | `query`, `cache_timeout` | Search places (locations) |
| `V2FbsearchTopsearchAsync` | `/v2/fbsearch/topsearch` | `query`, `next_max_id`, `cache_timeout` | Top search |
| `V2FbsearchReelsAsync` | `/v2/fbsearch/reels` | `query`, `reels_max_id`, `cache_timeout` | Search reels (clips) |
| `GqlCommentsChunkAsync` | `/gql/comments/chunk` | `media_id`, `sort_order`, `end_cursor`, `cache_timeout` | Get comments list by media ID (chunked) |
| `GqlCommentsThreadedChunkAsync` | `/gql/comments/threaded/chunk` | `media_id`, `comment_id`, `end_cursor`, `cache_timeout` | Get threaded replies list by comment ID (chunked) |
| `GqlCommentLikersChunkAsync` | `/gql/comment/likers/chunk` | `comment_id`, `end_cursor`, `cache_timeout` | Get comment likers list by comment ID (chunked) |
| `GqlTopsearchAsync` | `/gql/topsearch` | `query`, `cache_timeout` | Search top content by keyword |
| `GqlMediaLikersAsync` | `/gql/media/likers` | `media_id`, `cache_timeout` | Get media likers by media ID |
| `GqlMediaUsertagsAsync` | `/gql/media/usertags` | `media_ids`, `cache_timeout` | Get video usertags by media IDs |
| `GqlUserFollowersChunkAsync` | `/gql/user/followers/chunk` | `user_id`, `force`, `end_cursor`, `cache_timeout` | Get user followers (chunked) |
| `GqlUserFollowingChunkAsync` | `/gql/user/following/chunk` | `user_id`, `force`, `end_cursor`, `cache_timeout` | Get user following (chunked) |
| `GqlUserRepostsAsync` | `/gql/user/reposts` | `user_id`, `repost_next_max_id`, `flat`, `cache_timeout` | Get user reposts |
| `GqlUserClipsAsync` | `/gql/user/clips` | `user_id`, `max_id`, `sort_by_views`, `flat`, `cache_timeout` | Get user clips (reels) |
| `GqlUserMediasAsync` | `/gql/user/medias` | `user_id`, `profile_grid_items_cursor`, `flat`, `cache_timeout` | Get user profile media (grid) |
| `V3FbsearchAccountsAsync` | `/v3/fbsearch/accounts` | `query`, `page_token`, `cache_timeout` | Search users |
| `V3FbsearchPlacesAsync` | `/v3/fbsearch/places` | `query`, `cache_timeout` | Search places (locations) |
