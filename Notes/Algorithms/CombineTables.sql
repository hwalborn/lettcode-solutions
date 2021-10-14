-- Weird that they threw in a random SQL thing
-- Lol, I did this on the first try. Go SQL

SELECT p.FirstName
    , p.LastName
    , a.City
    , a.State
FROM Person p
LEFT OUTER JOIN Address a ON p.PersonId = a.PersonId;