--
-- O'Reilly Baseball Hacks source example
--   browse https://resources.oreilly.com/examples/9780596009427/
--
-- SQL source updated to work on later versions of MySQL
--

-- create b_and_t as shown in [#hack measure batting with average]

-- top 10 players of all time by runs created
select f.franchName AS first_team, m.nameFirst, m.nameLast,
    b.yearID, b.PA, round(b.RC, 1) as RC
FROM (select (H + BB + HBP - CS - GIDP) *
    (H + X2B + 2 * X3B + 3 * HR + .26 * (BB - IBB + HBP )) /
    (AB + BB + HBP + SH + SF) AS RC,
    (AB + BB + HBP + SH + SF) AS PA,
    yearID, teamIDs, idxLahman
    from b_and_t
    where yearID > 1953
) b inner join master m inner join teamsFranchises f
where m.idxLahman=b.idxLahman
   and substr(b.teamIDs,1,3)=f.franchID
   -- and yearID > 1994
order by RC DESC LIMIT 10;
