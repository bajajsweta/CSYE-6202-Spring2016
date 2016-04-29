DELIMITER //
CREATE  PROCEDURE FlightFromProc()
BEGIN 
Select distinct
flight_from
from flight_schedule ;
END//
DELIMITER ;
