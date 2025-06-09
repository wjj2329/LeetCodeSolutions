WITH CTE AS (
    SELECT
        *,
        ROW_NUMBER() OVER (PARTITION BY email ORDER BY id) AS rn
    FROM Person
)
DELETE FROM Person
WHERE id IN (
    SELECT id FROM CTE WHERE rn > 1
);