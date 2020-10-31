--
-- O'Reilly Baseball Hacks source example
--   browse https://resources.oreilly.com/examples/9780596009427/
--
-- SQL source updated to work on later versions of MySQL
--

-- create b_and_t as shown in [#hack measure batting with average]
-- top 10 players of all time by SLG
select f.franchName AS "First_Team", nameFirst, nameLast, b.yearID,
  b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0) as PA,
  round((b.H + b.X2B + 2 * b.X3B + 3 * b.HR)/b.AB,3) as SLG
from b_and_t b inner join master m inner join teamsFranchises f
where b.idxLahman=m.idxLahman
    and substr(b.teamIDs,1,3)=f.franchID
    and b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0)
    > 3.1 * b.teamG
order by SLG DESC limit 10;
