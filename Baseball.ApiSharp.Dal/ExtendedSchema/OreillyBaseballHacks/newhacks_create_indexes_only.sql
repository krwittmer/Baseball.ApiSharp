use lahmans2019db;

create index batting_pidx on batting(playerID);
create index people_idx_1 on people(playerID);
create index people_idx_2 on people(managerID);
create index pitching_idx_1 on pitching(yearID,teamID);
create index fielding_idx_1 on fielding(yearID,teamID);
create index fieldingof_idx_1 on fieldingof(playerID, yearID);
create index salaries_idx_1 on salaries(playerID);
create index salaries_idx_2 on salaries(yearID,teamID);
