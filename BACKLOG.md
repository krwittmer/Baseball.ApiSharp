# Overview

The overall focus of this .NET Core project is on player search, tagging (along with tagged browsing) and exporting (select exports of data in CSV, JSON and language-specific structures)
Exporting of data includes tagged data (to CSV, Excel, Google Sheets, Python (data sets) and R)

# Development backlog:

Add basic GraphQL support for batters, pitchers, and games (spike this before integration!)
Get the startup and unit tests working from Oracle Linux; prepare for a multi-DB environment (3)
See Microsoft docs to source an example of using EF Core with migrations from a console context
This example also quickly illustrates how to handle DI from a console context

Revise logging factory injection  (remaining classes - borrow from Phil's approach)
Round-out TagHelper into TagRepository class (including tests!) - allow tag to be used for any type of entity
Implement MyFavorites to manage list of favorites & MyTags API to tag baseball stats or data (including teams, players and/or *dates*); implement thru
Dockerize the API together with DB files (custom Docker image) - include other data sets such as retro sheets

Finally, for tag supporting, introduce [FromServices]. For example, to bring in a repo instance
Impl. [FromServices] ICategoryRepo repo - check out the example from Phil Japiske for a good example of using [FromServices]

Add config for data sets: include 10 all-time greats, my teams, MySQL external, Azure external
Round-off basic search impl. (players, batters, hitters, ..search by name || player-id) w/revised unit tests
Adjust unit tests to run (green) independent of Azure, MySQL, in-memory DB

Upgrade the associated data generation .NET project - add support for MongoDB (including practices of schema design). Also Redis, Python and R.

Continue to apply the labs from VSL-Chicago, propagate to all types/APIs:
Add in connection string to appsettings.Development.json - see lab 6 from VSL-Chicago labs
Add reset identity with DBCC CHECKPOINT - see lab 4
Custom repository types (one repo for each major type) - consider lab 5
As a part of this, derived a basic repo class (RepoBase class)
Apply aspects of Microsoft microservices architecture - probably the best out there

# The extended backlog includes:

Add/revise traits to integration tests - only run in-mem DB tests from Azure DevOps
Apply examples from Pluralsight xunit examples
Improve quality of unit tests (FIRST, BICEP, CORRECT, .. ) along with project test coverage - see source from the JUnit book
See/review chapter 7 "iloveyouboss/16/test" for examples of CORRECT
Categories, players and teams - lookup by API user or profile id
Implement the majority of Web API guidelines (of best practices for API impl. - from Microsoft, Paypal, etc.)
MyFavoritePlayers, MyTags, MyFanProfile and MyFandomNetwork.
Make a 2nd pass at HATEOS link generation -- follow other blog examples -- implement for simple types such FanProfile, Roster, etc. (ref. PT API project as reference)
Also, support looking up player and team photos using Microsoft Bing APIs

Build a new Docker image derived from Oracle adding in .NET Core 3.x
Release Docker image for hub.docker.io by end of Q1, 2021

# Other links

Online baseball data from Retrosheets
https://www.retrosheet.org/game.htm

CSV data files posted here
https://github.com/chadwickbureau/baseballdatabank/tree/master/core

Baseball on a Stick
https://sourceforge.net/projects/baseballonastic/

And the O'Reilly Baseball Hacks book:
https://www.oreilly.com/pub/pr/1520
