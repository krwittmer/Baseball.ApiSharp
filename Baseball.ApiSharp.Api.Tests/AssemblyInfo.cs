#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Xunit;
[assembly: CollectionBehavior(DisableTestParallelization = true)]

/*
 * Information on the above configuration is described (briefly) here:
 * https://xunit.net/docs/running-tests-in-parallel
 * Also, stackoverflow has the following posting on executing unit tests serially:
 * https://stackoverflow.com/questions/1408175/execute-unit-tests-serially-rather-than-in-parallel
 *
 * .NET Core testing with xUnit, see https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
 * Docs on xUnit, see https://xunit.net/
 *
 * Run unit tests using the filter switch, see https://docs.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=xunit.
 * dotnet test --filter FieldingApi
 */
