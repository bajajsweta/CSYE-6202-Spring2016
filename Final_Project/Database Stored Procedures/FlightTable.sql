DELIMITER //
CREATE PROCEDURE FlightTable()
BEGIN 
Select *
from flight;
select count(*) from flight;
END//
DELIMITER ;
