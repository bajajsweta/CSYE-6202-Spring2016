DELIMITER //
CREATE PROCEDURE DELETE_EMPLOYEE(IN empl_id int)
BEGIN 
DELETE FROM employee 
where
employee.emp_id = empl_id;
Select Count(*) from employee;
END//
DELIMITER ;
