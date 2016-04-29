DELIMITER //
CREATE PROCEDURE EMPLOYEE_LIST(IN 
    emp_name CHAR(50),
    emp_designation CHAR(50),
    emp_age int,
    emp_gender CHAR(50),
    emp_email CHAR(50),
    emp_password CHAR(50))
BEGIN 
Select 
e.emp_id,
e.emp_name,
e.emp_designation,
e.emp_age,
e.emp_gender,
e.emp_email,
e.emp_password,
e.crew_ID
from  employee e
where (isNull(emp_name)           OR emp_name = e.emp_name)
and (isnull(emp_designation)      OR emp_designation = e.emp_designation)
and (isNull(emp_age)              OR emp_age = e.emp_age)
and (isNull(emp_gender)           OR emp_gender = e.emp_gender)
and (isNull(emp_email)            OR emp_email = e.emp_email)
and (isNull(emp_password)         OR emp_password = e.emp_password);
END//
DELIMITER ;
