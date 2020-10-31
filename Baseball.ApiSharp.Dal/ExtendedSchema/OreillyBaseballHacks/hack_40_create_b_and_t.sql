-- O'Reilly Baseball Hacks source example
--   browse https://resources.oreilly.com/examples/9780596009427/
--
-- SQL source updated to work on later versions of MySQL (TODO: more updates are required for indexing)

-- creates (custom) the b_and_t table used in the batting formulas;
-- TODO: add indexes as noted below (idxLahman, idxTeams, idxTeamsFranchises)

create index batting_pidx on batting(idxLahman);
create index batting_tidx on batting(idxTeams);
create index master_pidx on people(idxLahman);
create index teams_idx on teams(idxTeams);
create index teams_fidx on teams(idxTeamsFranchises);
create index teamsFranchises_idx on teamsFranchises(idxTeamsFranchises);

create table b_and_t as
select idxLahman, yearID,
    GROUP_CONCAT(franchID SEPARATOR ",") as teamIDs,
    sum(G / teamG) * sum(teamG) / count(franchID) as qualifyingG,
    sum(teamG) / count(franchID) as teamG,
    sum(G) as G, sum(AB) as AB, sum(R) as R,
    sum(H) as H, sum(2B) as X2B, sum(3B) as X3B,
    sum(HR) as HR, sum(RBI) as RBI, sum(SB) as SB,
    sum(CS) as CS, sum(BB) as BB, sum(SO) as SO,
    sum(IBB) as IBB, sum(HBP) as HBP, sum(SH) as SH,
    sum(SF) as SF, sum(GIDP) as GIDP
from  (select b.*, t.yearID, t.G as teamG, f.franchID
       from batting b inner join teams t 
		inner join TeamsFranchises f
       where b.idxTeams=t.idxTeams and 
		t.idxTeamsFranchises=f.idxTeamsFranchises) i
group by idxLahman, yearID;
