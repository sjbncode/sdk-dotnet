﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ManyWho.Flow.SDK.Utils
{
    public class HttpRetryHelper
    {
        public const Int32 MAXIMUM_RETRIES = 3; // 3
        public const Int32 TIMEOUT_SECONDS_FOR_USER_INTERACTIONS = 600; // 20
        public const Int32 TIMEOUT_SECONDS_FOR_SYSTEM_INTERACTIONS = 300;

        public static Boolean IsWorthRetry(HttpStatusCode httpStatusCode)
        {
            Boolean isWorthRetry = true;

            // If we get any of these status codes, there's no point hammering the service again as the request either got there and an error
            // occurred, or we're referencing something that isn't there (though if we get a "NOT FOUND", we do try again just in case!)
            if (httpStatusCode == HttpStatusCode.Forbidden ||
                httpStatusCode == HttpStatusCode.MethodNotAllowed ||
                httpStatusCode == HttpStatusCode.Moved ||
                httpStatusCode == HttpStatusCode.MovedPermanently ||
                httpStatusCode == HttpStatusCode.NotImplemented ||
                httpStatusCode == HttpStatusCode.PreconditionFailed ||
                httpStatusCode == HttpStatusCode.ProxyAuthenticationRequired ||
                httpStatusCode == HttpStatusCode.Redirect ||
                httpStatusCode == HttpStatusCode.RedirectKeepVerb ||
                httpStatusCode == HttpStatusCode.RedirectMethod ||
                httpStatusCode == HttpStatusCode.RequestEntityTooLarge ||
                httpStatusCode == HttpStatusCode.RequestUriTooLong ||
                httpStatusCode == HttpStatusCode.SeeOther ||
                httpStatusCode == HttpStatusCode.Unauthorized ||
                httpStatusCode == HttpStatusCode.UnsupportedMediaType ||
                httpStatusCode == HttpStatusCode.UseProxy ||
                httpStatusCode == HttpStatusCode.BadRequest ||
                httpStatusCode == HttpStatusCode.InternalServerError)
            {
                isWorthRetry = false;
            }

            return isWorthRetry;
        }
    }
}