--
-- O'Reilly Baseball Hacks source example
--   browse https://resources.oreilly.com/examples/9780596009427/
--
-- SQL source updated to work on later versions of MySQL
--

-- create b_and_t as shown in hack 40

-- top 10 players of all time by OPS
select First_Team, concat(nameLast, ', ', nameFirst, ' (', yearID, ')') as name,
    PA, SLG + OBP as OPS, SLG, OBP
FROM (select round((b.H + ifnull(b.BB, 0) + ifnull(b.HBP, 0)) /
             (b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0))
        ,3) as OBP,
        round((b.H + b.X2B + 2 * b.X3B + 3 * b.HR)/b.AB,3) as SLG,
    b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0) as PA,
    nameFirst, nameLast, b.yearID, f.franchName AS "First_Team"
    from b_and_t b inner join master m inner join teamsFranchises f
    where b.idxLahman=m.idxLahman and substr(b.teamIDs,1,3)=f.franchID
    and b.AB + ifnull(b.BB, 0) + ifnull(b.HBP, 0) + ifnull(b.SF, 0)
        > 3.1 * b.teamG) i
-- where yearID > 1994
order by OPS DESC limit 10;
