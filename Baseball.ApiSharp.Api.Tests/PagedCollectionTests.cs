#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using System.Linq;
using Baseball.ApiSharp.Dal.Tests;
using Xunit;

namespace Baseball.ApiSharp.Api.Tests
{
    public class PagedCollectionTests
    {
        [Fact]
        public void GotoPageIndex1EmptyArray()
        {
            var collectionUnderTest = new PagedCollection<string>(new List<string>().AsQueryable(), 1, 12);
            Assert.True(collectionUnderTest.TotalCount == 0);
        }

        [Fact]
        public void GotoPageIndex1()
        {
            List<string> dataArray = new List<string>();
            for (int i = 0; i < 2048; i++)
            {
                dataArray.Add(RandomNumberHelper.NextInteger().ToString());
            }
            var collectionUnderTest = new PagedCollection<string>(dataArray.AsQueryable(), 1, 12);
            Assert.True(collectionUnderTest.TotalCount == 12);
        }


        [Fact]
        public void GotoPageIndex100()
        {
            List<string> dataArray = new List<string>();
            for (int i = 0; i < 65535; i++)
            {
                dataArray.Add(RandomNumberHelper.NextInteger().ToString());
            }
            var collectionUnderTest = new PagedCollection<string>(dataArray.AsQueryable(), 100, 24);
            Assert.True(collectionUnderTest.TotalCount == 24);
        }

        [Fact]
        public void GotoNegativePageIndex()
        {
            List<string> dataArray = new List<string>();
            for (int i = 0; i < 65535; i++)
            {
                dataArray.Add(RandomNumberHelper.NextInteger().ToString());
            }
            var collectionUnderTest = new PagedCollection<string>(dataArray.AsQueryable(), -1, 24);
            Assert.True(collectionUnderTest.TotalCount == 0);
        }

        /**
         * null case
        @Test(expected= IllegalArgumentException.class)
        public void throwsExceptionWhenAddingNull()
        {
        ..

         * no elements case
        @Test
        public void answersZeroWhenNoElementsAdded()
        {
        ..

         * boundary case
        @Test
        public void doesNotProperlyHandleIntegerOverflow()
        {
        ..*
          */
    }
}
