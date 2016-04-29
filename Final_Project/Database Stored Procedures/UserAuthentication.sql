DELIMITER //
CREATE PROCEDURE UserAuthentication(IN 
    empl_name CHAR(50),    
    empl_password CHAR(50))
BEGIN 
Select emp_designation 
from employee
WHERE emp_name = empl_name
and emp_password = empl_password;
END//
DELIMITER ;
