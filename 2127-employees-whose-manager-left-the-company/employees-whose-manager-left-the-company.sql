# Write your MySQL query statement below
Select employee_id from Employees where salary< 30000 and manager_id  NOT in (SELECT employee_id FROM Employees) ORDER BY employee_id ASC