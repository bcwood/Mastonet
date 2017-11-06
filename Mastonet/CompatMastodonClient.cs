﻿using System;
using System.Collections.Generic;
using System.Text;
using Mastonet.Entities;
using System.Threading.Tasks;

namespace Mastonet.Compat
{
    [Obsolete("Methods have changed")]
    public class MastodonClient : Mastonet.MastodonClient
    {
        #region Ctor

        public MastodonClient(AppRegistration appRegistration, Auth accessToken)
            : base(appRegistration, accessToken)
        {
        }

        #endregion

        #region MastodonClient.Timeline.cs

        public new async Task<IEnumerable<Status>> GetHomeTimeline(long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetHomeTimeline(maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Status>> GetHomeTimeline(ArrayOptions options)
        {
            return (await base.GetHomeTimeline(options)).Items;
        }

        public new async Task<IEnumerable<Status>> GetPublicTimeline(long? maxId = null, long? sinceId = null, int? limit = null, bool local = false)
        {
            return (await base.GetPublicTimeline(maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Status>> GetPublicTimeline(ArrayOptions options, bool local = false)
        {
            return (await base.GetPublicTimeline(options)).Items;
        }

        public new async Task<IEnumerable<Status>> GetTagTimeline(string hashtag, long? maxId = null, long? sinceId = null, int? limit = null, bool local = false)
        {
            return (await base.GetTagTimeline(hashtag, maxId, sinceId, limit, local)).Items;
        }

        public new async Task<IEnumerable<Status>> GetTagTimeline(string hashtag, ArrayOptions options, bool local = false)
        {
            return (await base.GetTagTimeline(hashtag, options, local)).Items;
        }

        #endregion

        #region MastodonClient.Account.cs

        public new async Task<IEnumerable<Account>> GetAccountFollowers(long accountId, long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetAccountFollowers(accountId, maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Account>> GetAccountFollowers(long accountId, ArrayOptions options)
        {
            return (await base.GetAccountFollowers(accountId, options)).Items;
        }

        public new async Task<IEnumerable<Account>> GetAccountFollowing(long accountId, long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetAccountFollowing(accountId, maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Account>> GetAccountFollowing(long accountId, ArrayOptions options)
        {
            return (await base.GetAccountFollowing(accountId, options)).Items;
        }

        public new async Task<IEnumerable<Status>> GetAccountStatuses(long accountId, long? maxId = null, long? sinceId = null, int? limit = null, bool onlyMedia = false, bool excludeReplies = false)
        {
            return (await base.GetAccountStatuses(accountId, maxId, sinceId, limit, onlyMedia, excludeReplies)).Items;
        }

        public new async Task<IEnumerable<Status>> GetAccountStatuses(long accountId, ArrayOptions options, bool onlyMedia = false, bool excludeReplies = false)
        {
            return (await base.GetAccountStatuses(accountId, options, onlyMedia, excludeReplies)).Items;
        }

        public new async Task<IEnumerable<Account>> GetFollowRequests(long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetFollowRequests(maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Account>> GetFollowRequests(ArrayOptions options)
        {
            return (await base.GetFollowRequests(options)).Items;
        }

        public new async Task<IEnumerable<Status>> GetFavourites(long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetFavourites(maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Status>> GetFavourites(ArrayOptions options)
        {
            return (await base.GetFavourites(options)).Items;
        }

        #endregion

        #region MastodonClient.AccountActions.cs

        public new async Task<IEnumerable<Account>> GetBlocks(long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetBlocks(maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Account>> GetBlocks(ArrayOptions options)
        {
            return (await base.GetBlocks(options)).Items;
        }

        public new async Task<IEnumerable<Account>> GetMutes(long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetMutes(maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Account>> GetMutes(ArrayOptions options)
        {
            return (await base.GetMutes(options)).Items;
        }

        public new async Task<IEnumerable<string>> GetDomainBlocks(long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetDomainBlocks(maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<string>> GetDomainBlocks(ArrayOptions options)
        {
            return (await base.GetDomainBlocks(options)).Items;
        }

        #endregion

        #region MastodonClient.Status.cs

        public new async Task<IEnumerable<Account>> GetRebloggedBy(long statusId, long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetRebloggedBy(statusId, maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Account>> GetRebloggedBy(long statusId, ArrayOptions options)
        {
            return (await base.GetRebloggedBy(statusId, options)).Items;
        }

        public new async Task<IEnumerable<Account>> GetFavouritedBy(long statusId, long? maxId = null, long? sinceId = null, int? limit = null)
        {
            return (await base.GetFavouritedBy(statusId, maxId, sinceId, limit)).Items;
        }

        public new async Task<IEnumerable<Account>> GetFavouritedBy(long statusId, ArrayOptions options)
        {
            return (await base.GetFavouritedBy(statusId, options)).Items;
        }

        #endregion
        
    }
}
