--
-- O'Reilly Baseball Hacks source example
--   browse https://resources.oreilly.com/examples/9780596009427/
--
-- SQL source updated to work on later versions of MySQL
--

-- top 10 players of all time by batting average
select f.franchName AS "First_Team",
    nameFirst, nameLast, b.yearID,
    b.AB, round(b.H/b.AB,3) as AVG
from b_and_t b inner join master m inner join teamsFranchises f
where b.idxLahman=m.idxLahman
   and substr(b.teamIDs,1,3)=f.franchID
   and b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0)
    > 3.1 * b.teamG
order by AVG DESC limit 10;

-- top 10 players over the past decade
select f.franchName AS "First_Team",
    nameFirst, nameLast, b.yearID,
    b.AB, round(b.H/b.AB,3) as AVG
from b_and_t b inner join master m inner join teamsFranchises f
where b.idxLahman=m.idxLahman
   and substr(b.teamIDs,1,3)=f.franchID
   and b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0)
    > 3.1 * b.teamG
   and b.yearID > 1994
order by AVG DESC limit 10;
