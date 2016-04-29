/*Procedure created to create a Employee*/


DELIMITER //
CREATE PROCEDURE CREATE_EMPLOYEE(IN 
    emp_name CHAR(50),
    emp_designation CHAR(50),
    emp_age int,
    emp_gender CHAR(50),
    emp_email CHAR(45),
    emp_password CHAR(50),
    emp_crewID int)
BEGIN 
declare maxemp_id int;
Select  coalesce(max(emp_id), 0) into maxemp_id from employee;

INSERT INTO employee ()
VALUES((maxemp_id + 1),emp_name,emp_designation,emp_age,emp_gender,emp_email,emp_password,emp_crewID);

Select  e.emp_id,
e.emp_name,
e.emp_designation,
e.emp_age,
e.emp_gender,
e.emp_email,
e.emp_password,
e.crew_ID
from  employee e
where e.emp_id = (maxemp_id + 1);
END//
DELIMITER ;
