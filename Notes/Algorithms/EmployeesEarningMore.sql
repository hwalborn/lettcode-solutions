-- Pretty easy, just employees that earn more than their managers

SELECT ee.Name as Employee
FROM Employee ee
INNER JOIN Employee er ON ee.ManagerId = er.Id
WHERE ee.Salary > er.Salary;