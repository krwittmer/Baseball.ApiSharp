 
drop index batting_pidx on batting;
create index batting_pidx on batting(playerID);

drop index people_idx_1 on people;
create index people_idx_1 on people(playerID);

REM check for managerID
drop index people_idx_2 on people;
create index people_idx_2 on people(managerID);

drop index batting_idx_1 on batting;
create index batting_idx_1 on batting(yearID,teamID);

drop index pitching_idx_1 on pitching;
create index pitching_idx_1 on pitching(yearID,teamID);

drop index fielding_idx_1 on fielding;
create index fielding_idx_1 on fielding(yearID,teamID);

drop index fieldingof_idx_1 on fieldingof_idx_1;
create index fieldingof_idx_1 on fieldingof(playerID, yearID);

drop index salaries_idx_1 on salaries;
create index salaries_idx_1 on salaries(playerID);

drop index salaries_idx_2 on salaries_idx_2;
create index salaries_idx_2 on salaries(yearID,teamID);

REM managerID does not exist
drop managers_idx_1 on managers;
create index managers_idx_1 on managers(managerID);

REM managerID does not exist
drop managers_idx_2 on managers;
create index managers_idx_2 on managers(yearID,teamID);

REM managerID does not exist
drop managershalf_idx_1 on managershalf;
create index managershalf_idx_1 on managershalf(managerID);

REM managerID does not exist
drop managershalf_idx_2 on managershalf;
create index managershalf_idx_2 on managershalf(yearID,teamID);

REM allstart does not exist
drop allstar_idx on allstar;
create index allstar_idx on allstar(playerID,yearID);

drop awardsshareplayers_idx on awardsshareplayers;
create index awardsshareplayers_idx on awardsshareplayers(playerID,yearID);

REM managerID does not exist
drop awardssharemanagers_idx on awardssharemanagers;
create index awardssharemanagers_idx on awardssharemanagers(managerID,yearID);

drop awardsmanagers_idx on awardsmanagers;
create index awardsmanagers_idx on awardsmanagers(managerID,yearID);

drop awardsplayers_idx on awardsplayers;
create index awardsplayers_idx on awardsplayers(playerID,yearID);
