DELIMITER //
CREATE  PROCEDURE UPDATE_EMPLOYEE(IN emp_id int,
    emp_name CHAR(50),
    emp_designation CHAR(50),
    emp_age int,
    emp_gender CHAR(50),
    emp_email CHAR(50),
    emp_password CHAR(50),
    emp_crewID int)
BEGIN 
UPDATE employee e
SET
e.emp_name = emp_name,
e.emp_designation =emp_designation,
e.emp_age = emp_age,
e.emp_gender = emp_gender,
e.emp_email = emp_email,
e.emp_password = emp_password,
e.crew_ID = emp_crewID
where e.emp_id = emp_id;

Select Count(*) from employee;
END//
DELIMITER ;
