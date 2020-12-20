--
-- O'Reilly Baseball Hacks source example
--   browse https://resources.oreilly.com/examples/9780596009427/
--   orig. file new_structure_db.sql   (also see bbdb.sql.gz)
--
-- SQL source updated to work on later versions of MySQL
--

-- This script assumes that the old format db is called "tempdb" and 
-- the new one will be called "bbdb." Search and replace in this file 
-- to change the names.

-- 0. Create the new database
GRANT ALL ON bbdb.* to 'someone'@'localhost';
CREATE DATABASE bbdb;

-- 1. Create indexes in the from database to expedite processing

use tempdb;

create index master_idx_1 on master(playerID);
create index master_idx_2 on master(managerID);
create index batting_idx_1 on batting(yearID,teamID);
create index pitching_idx_1 on pitching(yearID,teamID);
create index fielding_idx_1 on fielding(yearID,teamID);
create index fieldingof_idx_1 on fieldingof(playerID, yearID);
create index salaries_idx_1 on salaries(playerID);
create index salaries_idx_2 on salaries(yearID,teamID);
create index managers_idx_1 on managers(managerID);
create index managers_idx_2 on managers(yearID,teamID);
create index managershalf_idx_1 on managershalf(managerID);
create index managershalf_idx_2 on managershalf(yearID,teamID);
create index allstar_idx on allstar(playerID,yearID);
create index awardsshareplayers_idx on awardsshareplayers(playerID,yearID);
create index awardssharemanagers_idx on awardssharemanagers(managerID,yearID);
create index awardsmanagers_idx on awardsmanagers(managerID,yearID);
create index awardsplayers_idx on awardsplayers(playerID,yearID);

-- 2. Create tables in new database

use bbdb;

CREATE TABLE Master (
  idxLahman int(9) NOT NULL auto_increment,
  playerID varchar(10) NOT NULL default '',
  managerID varchar(10) NOT NULL default '',
  birthYear int(4) default NULL,
  birthMonth int(2) default NULL,
  birthDay int(2) default NULL,
  birthCountry varchar(50) default NULL,
  birthState char(2) default NULL,
  birthCity varchar(50) default NULL,
  deathYear int(4) default NULL,
  deathMonth int(2) default NULL,
  deathDay int(2) default NULL,
  deathCountry varchar(50) default NULL,
  deathState char(2) default NULL,
  deathCity varchar(50) default NULL,
  nameFirst varchar(50) default NULL,
  nameLast varchar(50) NOT NULL default '',
  nameNote varchar(255) default NULL,
  nameGiven varchar(255) default NULL,
  nameNick varchar(255) default NULL,
  weight int(3) default NULL,
  height double(4,1) default NULL,
  bats enum('L','R','B') default NULL,
  throws enum('L','R','B') default NULL,
  debut date default NULL,
  finalGame date default NULL,
  PRIMARY KEY  (idxLahman),
  KEY idxLahman (idxLahman,nameLast,nameFirst),
  KEY idxLahman_2 (idxLahman,debut),
  KEY idxLahman_3 (idxLahman,birthYear,birthMonth,birthDay)
);

CREATE TABLE Teams (
  idxTeams int(9) NOT NULL auto_increment,
  yearID smallint(4) unsigned NOT NULL default '0',
  teamID char(3) NOT NULL default '',
  lgID char(2) NOT NULL default '',
  idxTeamsFranchises int(9) NOT NULL default '0',
  divID char(1) default NULL,
  Rank smallint(3) unsigned NOT NULL default '0',
  G smallint(3) unsigned default NULL,
  Ghome int(3) default NULL,
  W smallint(3) unsigned default NULL,
  L smallint(3) unsigned default NULL,
  DivWin enum('Y','N') default NULL,
  WCWin enum('Y','N') default NULL,
  LgWin enum('Y','N') default NULL,
  WSWin enum('Y','N') default NULL,
  R smallint(4) unsigned default NULL,
  AB smallint(4) unsigned default NULL,
  H smallint(4) unsigned default NULL,
  2B smallint(4) unsigned default NULL,
  3B smallint(3) unsigned default NULL,
  HR smallint(3) unsigned default NULL,
  BB smallint(4) unsigned default NULL,
  SO smallint(4) unsigned default NULL,
  SB smallint(3) unsigned default NULL,
  CS smallint(3) unsigned default NULL,
  HBP smallint(3) default NULL,
  SF smallint(3) default NULL,
  RA smallint(4) unsigned default NULL,
  ER smallint(4) default NULL,
  ERA decimal(4,2) default NULL,
  CG smallint(3) unsigned default NULL,
  SHO smallint(3) unsigned default NULL,
  SV smallint(3) unsigned default NULL,
  IPouts int(5) default NULL,
  HA smallint(4) unsigned default NULL,
  HRA smallint(4) unsigned default NULL,
  BBA smallint(4) unsigned default NULL,
  SOA smallint(4) unsigned default NULL,
  E int(5) default NULL,
  DP int(4) default NULL,
  FP decimal(5,3) default NULL,
  name varchar(50) NOT NULL default '',
  park varchar(255) default NULL,
  attendance int(7) default NULL,
  BPF int(3) default NULL,
  PPF int(3) default NULL,
  PRIMARY KEY (idxTeams)
);

CREATE TABLE TeamsFranchises (
  idxTeamsFranchises int(9) NOT NULL auto_increment,
  franchID char(3) NOT NULL default '',
  franchName varchar(50) NOT NULL default '',
  active enum('Y','N','NA') NOT NULL default 'Y',
  NAassoc char(3) default NULL,
  PRIMARY KEY  (idxTeamsFranchises)
);

CREATE TABLE TeamsHalf (
  idxTeamsHalf int(9) NOT NULL auto_increment,
  idxTeams int(9) NOT NULL default '0',
  Half enum('1','2','') NOT NULL default '',
  DivWin enum('Y','N') NOT NULL default 'N',
  Rank smallint(3) unsigned NOT NULL default '0',
  G smallint(3) unsigned default NULL,
  W smallint(3) unsigned default NULL,
  L smallint(3) unsigned default NULL,
  PRIMARY KEY  (idxTeamsHalf)
);

CREATE TABLE Batting (
  idxBatting int(9) NOT NULL auto_increment,
  idxLahman int(9) NOT NULL default '0',
  stint int(2) NOT NULL default '0',
  idxTeams int(9) NOT NULL default '0',
  G smallint(3) unsigned default NULL,
  AB smallint(3) NOT NULL default '0',
  R smallint(3) unsigned default NULL,
  H smallint(3) unsigned default NULL,
  2B smallint(3) unsigned default NULL,
  3B smallint(3) unsigned default NULL,
  HR smallint(3) unsigned NOT NULL default '0',
  RBI smallint(3) unsigned default NULL,
  SB smallint(3) unsigned default NULL,
  CS smallint(3) unsigned default NULL,
  BB smallint(3) unsigned default NULL,
  SO smallint(3) unsigned default NULL,
  IBB smallint(3) unsigned default NULL,
  HBP smallint(3) unsigned default NULL,
  SH smallint(3) unsigned default NULL,
  SF smallint(3) unsigned default NULL,
  GIDP smallint(3) unsigned default NULL,
  PRIMARY KEY  (idxBatting),
  KEY idxBatting (idxBatting,idxLahman),
  KEY idxTeams (idxTeams,idxLahman),
  KEY idxLahman (idxLahman,stint,idxTeams)
);

CREATE TABLE Pitching (
  idxPitching int(9) NOT NULL auto_increment,
  idxLahman int(9) NOT NULL default '0',
  stint int(2) NOT NULL default '0',
  idxTeams int(9) NOT NULL default '0',
  W smallint(2) unsigned default NULL,
  L smallint(2) unsigned default NULL,
  G smallint(3) unsigned default NULL,
  GS smallint(3) unsigned default NULL,
  CG smallint(3) unsigned default NULL,
  SHO smallint(3) unsigned default NULL,
  SV smallint(3) unsigned default NULL,
  IPouts int(5) unsigned default NULL,
  H smallint(3) unsigned default NULL,
  ER smallint(3) unsigned default NULL,
  HR smallint(3) unsigned default NULL,
  BB smallint(3) unsigned default NULL,
  SO smallint(3) unsigned default NULL,
  BAopp decimal(5,3) unsigned default NULL,
  ERA decimal(5,2) unsigned default NULL,
  IBB smallint(3) unsigned default NULL,
  WP smallint(3) unsigned default NULL,
  HBP smallint(3) unsigned default NULL,
  BK smallint(3) unsigned default NULL,
  BFP smallint(6) unsigned default NULL,
  GF smallint(3) unsigned default NULL,
  R smallint(3) unsigned default NULL,
  PRIMARY KEY  (idxPitching),
  KEY idxPitching (idxPitching,idxLahman),
  KEY idxLahman (idxLahman,stint,idxTeams),
  KEY idxTeams (idxTeams,idxLahman)
);

CREATE TABLE Fielding (
  idxFielding int(9) NOT NULL auto_increment,
  idxLahman int(9) NOT NULL default '0',
  stint int(2) NOT NULL default '0',
  idxTeams int(9) NOT NULL default '0',
  POS char(2) NOT NULL default '',
  G smallint(3) unsigned default NULL,
  GS int(3) default NULL,
  Innouts int(5) default NULL,
  PO smallint(3) unsigned default NULL,
  A smallint(3) unsigned default NULL,
  E smallint(2) unsigned default NULL,
  DP smallint(3) unsigned default NULL,
  PB int(3) default NULL,
  ZR double(5,3) default NULL,
  PRIMARY KEY  (idxFielding),
  KEY idxFielding (idxFielding,idxLahman,stint,idxTeams),
  KEY idxLahman (idxLahman,stint,idxTeams),
  KEY idxTeams (idxTeams,idxLahman),
  KEY idxLahman_2 (idxLahman,POS),
  KEY idxTeams_2 (idxTeams,POS)
);

CREATE TABLE FieldingOF (
  idxFieldingOF int(9) NOT NULL auto_increment,
  idxFielding int(9) NOT NULL default '0',
  Glf int(3) default NULL,
  Gcf int(3) default NULL,
  Grf int(3) default NULL,
  PRIMARY KEY  (idxFieldingOF),
  KEY idxFielding (idxFielding,idxFieldingOF)
);

CREATE TABLE Salaries (
  idxSalaries int(9) NOT NULL auto_increment,
  idxLahman int(9) NOT NULL default '0',
  idxTeams int(9) NOT NULL default '0',
  salary double(10,2) NOT NULL default '0.00',
  PRIMARY KEY  (idxSalaries),
  KEY idxLahman (idxLahman,idxTeams),
  KEY idxTeams (idxTeams,idxLahman)
);

CREATE TABLE Transactions (
  tranID int(9) NOT NULL auto_increment,
  date date NOT NULL default '0000-00-00',
  transTime varchar(55) default NULL,
  approxIndic char(2) default NULL,
  retroTranID int(9) NOT NULL default '0',
  retroID varchar(255) NOT NULL default '',
  type varchar(5) NOT NULL default '',
  teamIDfrom varchar(55) default NULL,
  lgIDfrom varchar(55) default NULL,
  teamIDto varchar(55) default NULL,
  lgIDto varchar(55) default NULL,
  draftType varchar(5) NOT NULL default '',
  draftRound int(3) NOT NULL default '0',
  pickNumber int(5) NOT NULL default '0',
  info varchar(255) default NULL,
  PRIMARY KEY  (tranID),
  KEY teamFrom (teamIDfrom,lgIDfrom),
  KEY teamTo (teamIDto,lgIDto),
  KEY date (date,teamIDto),
  KEY date2 (date,teamIDfrom)
);

CREATE TABLE Managers (
  idxManagers int(9) NOT NULL auto_increment,
  idxLahman int(9) NOT NULL default '0',
  idxTeams int(9) NOT NULL default '0',
  inseason smallint(1) NOT NULL default '1',
  G smallint(3) NOT NULL default '0',
  W smallint(3) NOT NULL default '0',
  L smallint(3) NOT NULL default '0',
  rank smallint(1) NOT NULL default '0',
  plyrMgr enum('Y','N') default 'N',
  PRIMARY KEY  (idxManagers),
  KEY idxTeams (idxTeams,inseason),
  KEY idxLahman (idxLahman,idxTeams,inseason)
);

CREATE TABLE ManagersHalf (
  idxManagersHalf int(9) NOT NULL auto_increment,
  idxManagers int(9) NOT NULL default '0',
  Half smallint(1) NOT NULL default '1',
  G smallint(3) NOT NULL default '0',
  W smallint(3) NOT NULL default '0',
  L smallint(3) NOT NULL default '0',
  rank smallint(3) NOT NULL default '0',
  inseason smallint(3) NOT NULL default '0',
  PRIMARY KEY  (idxManagersHalf),
  KEY idxManagers (idxManagers,idxManagersHalf)
);

CREATE TABLE Allstar (
  idxAllstar int(9) NOT NULL auto_increment,
  yearID smallint(4) unsigned NOT NULL default '0',
  lgID char(2) NOT NULL default '',
  idxLahman int(9) NOT NULL default '0',
  PRIMARY KEY  (idxAllstar)
);

CREATE TABLE AwardsVotes (
  idxAwardsVotes int(9) NOT NULL auto_increment,
  awardID varchar(255) NOT NULL default '',
  yearID smallint(4) NOT NULL default '0',
  lgID char(2) NOT NULL default '',
  idxLahman int(9) NOT NULL default '0',
  pointsWon int(4) default NULL,
  pointsMax int(4) default NULL,
  votesFirst int(4) default NULL,
  PRIMARY KEY  (idxAwardsVotes)
);

CREATE TABLE AwardsWinners (
  idxAwardsWinners int(9) NOT NULL auto_increment,
  awardID varchar(255) NOT NULL default '',
  yearID smallint(4) NOT NULL default '0',
  lgID char(2) NOT NULL default '',
  idxLahman int(9) NOT NULL default '0',
  tie char(1) default NULL,
  notes varchar(100) default NULL,
  PRIMARY KEY  (idxAwardsWinners),
  KEY idxLahman (idxLahman),
  KEY awardID (awardID)
);

-- 3. Copy data into new tables

INSERT INTO bbdb.Master (
	 idxLahman, playerID, managerID,
	 birthYear, birthMonth, birthDay,
	 birthCountry, birthState, birthCity,deathYear,
	 deathMonth, deathDay, deathCountry, deathState,
	 deathCity, nameFirst, nameLast, nameGiven,
	 nameNick, weight, height, bats, throws, debut,
	 finalGame
) SELECT
   lahmanID, playerID, managerID,
	 birthYear, birthMonth, birthDay,
	 birthCountry, birthState, birthCity,deathYear,
	 deathMonth, deathDay, deathCountry, deathState,
	 deathCity, nameFirst, nameLast, nameGiven,
	 nameNick, weight, height, bats, throws, debut,
	 finalGame
  FROM tempdb.Master;

INSERT INTO bbdb.TeamsFranchises (
   franchID, franchName, active
) SELECT
   franchID, franchName, active
  FROM tempdb.TeamsFranchises;

INSERT INTO bbdb.Teams (
   yearID, teamID, lgID, idxTeamsFranchises, divID,
   Rank, G, Ghome, W, L, DivWin, WCWin, LgWin, WSWin,
   R, AB, H, 2B, 3B, HR, BB,
   SO, SB, CS, HBP, SF,
   RA, ER, ERA, CG, SHO, SV, IPouts,
   HA, HRA, BBA, SOA, E, DP, FP,
   name, park, attendance, BPF, PPF
) SELECT
   l.yearID, l.teamID, l.lgID, r.idxTeamsFranchises, l.divID,
   l.Rank, l.G, l.Ghome, l.W, l.L,
   l.DivWin, l.WCWin, l.LgWin, l.WSWin,
   l.R, l.AB, l.H, l.2B, l.3B, l.HR, l.BB,
   l.SO, l.SB, l.CS, l.HBP, l.SF,
   l.RA, l.ER, l.ERA, l.CG, l.SHO, l.SV, l.IPouts,
   l.HA, l.HRA, l.BBA, l.SOA, l.E, l.DP, l.FP,
   l.name, l.park, l.attendance, l.BPF, l.PPF
  FROM tempdb.Teams l inner join TeamsFranchises r
   ON l.franchID=r.franchID;

INSERT INTO bbdb.TeamsHalf (
   idxTeams, Half, DivWin, Rank, G, W, L
) SELECT
   r.idxTeams, l.Half, l.DivWin, l.Rank, l.G, l.W, l.L
  FROM tempdb.teamsHalf l inner join bbdb.teams r
   ON (l.yearID=r.yearID AND l.teamID=r.teamID);

create index teams_idx_1 on teams(yearID,teamID);

INSERT INTO bbdb.batting (
   idxLahman, stint, idxTeams, G,
   AB, R, H, 2B, 3B, HR, RBI, SB, CS,
   BB, SO, IBB, HBP, SH, SF, GIDP
) SELECT
   m.idxLahman, b.stint, t.idxTeams, b.G,
   b.AB, b.R, b.H, b.2B, b.3B, b.HR, b.RBI, b.SB, b.CS,
   b.BB, b.SO, b.IBB, b.HBP, b.SH, b.SF, b.GIDP
  FROM (tempdb.batting b inner join bbdb.teams t
   ON (b.yearID=t.yearID AND b.teamID=t.teamID))
   inner join bbdb.master m ON b.playerID=m.playerID;

INSERT INTO bbdb.pitching (
   idxLahman, stint, idxTeams, W, L,
   G, GS, CG, SHO, SV, IPouts,
   H, ER, HR, BB, SO,
   BAopp, ERA, IBB, WP,
   HBP, BK, BFP, GF, R
) SELECT
   m.idxLahman, p.stint, t.idxTeams, p.W, p.L,
   p.G, p.GS, p.CG, p.SHO, p.SV, p.IPouts,
   p.H, p.ER, p.HR, p.BB, p.SO,
   p.BAopp, p.ERA, p.IBB, p.WP,
   p.HBP, p.BK, p.BFP, p.GF, p.R
  FROM (tempdb.pitching p inner join bbdb.teams t
   ON (p.yearID=t.yearID AND p.teamID=t.teamID))
	 inner join bbdb.master m ON m.playerID=p.playerID;

INSERT INTO bbdb.Fielding (
   idxLahman, stint, idxTeams, POS, G, GS,
   Innouts, PO, A, E, DP, PB, ZR
) SELECT
   m.idxLahman, f.stint, t.idxTeams, f.POS, f.G, f.GS,
   f.Innouts, f.PO, f.A, f.E, f.DP, f.PB, f.ZR
  FROM (tempdb.fielding f inner join bbdb.teams t
   ON (f.yearID=t.yearID AND f.teamID=t.teamID))
   inner join bbdb.master m ON f.playerID=m.playerID;

INSERT INTO bbdb.FieldingOF (
   idxFielding, Glf, Gcf, Grf
) SELECT
   b.idxFielding, a.Glf, a.Gcf, a.Grf
  FROM bbdb.Fielding b inner join bbdb.teams c ON b.idxTeams=c.idxTeams
   inner join tempdb.FieldingOF a ON (a.stint=b.stint AND a.yearID=c.yearID)
   inner join bbdb.master d ON (a.playerID=d.playerID AND b.idxLahman=d.idxLahman)
   where a.yearID < 1996 AND b.pos="OF";

INSERT INTO bbdb.Salaries (
   idxLahman,  idxTeams,  salary
) SELECT
   m.idxLahman, t.idxTeams, s.salary
  FROM (tempdb.Salaries s inner join bbdb.teams t
   ON (s.yearID=t.yearID AND s.teamID=t.teamID))
   inner join master m ON m.playerID=s.playerID;

INSERT INTO bbdb.Managers (
   idxLahman, idxTeams, inseason,
   G, W, L, rank, plyrMgr
) SELECT
   r.idxLahman, t.idxTeams, l.inseason,
   l.G, l.W, l.L, l.rank, l.plyrMgr
  FROM (tempdb.Managers l inner join bbdb.teams t
   ON (l.yearID=t.yearID AND l.teamID=t.teamID))
   inner join bbdb.Master r ON l.managerID=r.managerID;

INSERT INTO bbdb.ManagersHalf (
   idxManagers, Half, G, W, L, rank, inseason
) SELECT
   c.idxManagers, a.Half, a.G, a.W, a.L, a.rank, a.inseason
  FROM (tempdb.ManagersHalf a inner join bbdb.master b
   ON a.managerID=b.managerID)
	inner join bbdb.Managers c
   ON b.idxLahman=c.idxLahman
	inner join bbdb.Teams d
   ON (a.yearID=d.yearID AND a.teamID=d.teamID
      AND c.idxTeams=d.idxTeams);

INSERT INTO bbdb.Allstar (
   yearID, lgID, idxLahman
) SELECT
   a.yearID, a.lgID, m.idxLahman
  FROM tempdb.Allstar a inner join bbdb.master m
   ON a.playerID=m.playerID;

INSERT INTO bbdb.AwardsVotes (
   awardID, yearID, lgID,
   idxLahman, pointsWon, pointsMax, votesFirst
) SELECT
   a.awardID, a.yearID, a.lgID,
   m.idxLahman, a.pointsWon, a.pointsMax, a.votesFirst
  FROM tempdb.AwardsSharePlayers a inner join master m
   on a.playerID=m.playerID;

INSERT INTO bbdb.AwardsVotes (
   awardID, yearID, lgID, idxLahman,
   pointsWon, pointsMax, votesFirst
) SELECT
   a.awardID, a.yearID, a.lgID, m.idxLahman,
   a.pointsWon, a.pointsMax, a.votesFirst
  FROM tempdb.AwardsShareManagers a inner join master m
   on a.managerID=m.managerID;

INSERT INTO bbdb.AwardsWinners (
   awardID,  yearID,  lgID, idxLahman,
   tie, notes
) SELECT
   a.awardID, a.yearID, a.lgID, m.idxLahman,
   a.tie, a.notes
  FROM tempdb.AwardsPlayers a inner join master m
   on a.playerID=m.playerID;

INSERT INTO bbdb.AwardsWinners (
   awardID, yearID, lgID, idxLahman,
   tie, notes
) SELECT
   a.awardID, a.yearID, a.lgID, m.idxLahman,
   a.tie, a.notes
  FROM tempdb.AwardsManagers a inner join master m
   on a.managerID=m.managerID;

