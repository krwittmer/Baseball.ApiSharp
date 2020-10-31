--
-- O'Reilly Baseball Hacks source example
--   browse https://resources.oreilly.com/examples/9780596009427/
--
-- SQL source updated to work on later versions of MySQL
--

-- create b_and_t as shown in hack 40

-- top ten players all time by OBP
select f.franchName AS "First_Team", b.yearID, nameFirst, nameLast,
    b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0) as PA,
     round((b.H + ifnull(b.BB, 0) + ifnull(b.HBP, 0)) /
             (b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0))
        ,3) as OBP
from b_and_t b inner join master m inner join teamsFranchises f
where b.idxLahman=m.idxLahman and
   substr(b.teamIDs,1,3)=f.franchID
   and b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0)
     > 3.1 * b.teamG
order by OBP DESC limit 10;
