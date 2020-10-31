#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Baseball.ApiSharp.Dal.Repos
{
    public class BaseballApiException : Exception
    {
        public BaseballApiException(string anErrorOccurredUpdatingTheDatabase, DbUpdateException dbUpdateException)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseballApiInvalidTagRelationshipException : Exception
    {
        public BaseballApiInvalidTagRelationshipException(string s, DbUpdateException dbUpdateException)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseballApiInvalidTagException : Exception
    {
        public BaseballApiInvalidTagException(string s, DbUpdateException dbUpdateException)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseballApiConcurrencyException : Exception
    {
        public BaseballApiConcurrencyException(string aConcurrencyErrorHappened, DbUpdateConcurrencyException dbUpdateConcurrencyException)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseballApiRetryLimitExceededException : Exception
    {
        public BaseballApiRetryLimitExceededException(string thereIsAProblemWithYouConnection, RetryLimitExceededException retryLimitExceededException)
        {
            throw new NotImplementedException();
        }
    }
}
