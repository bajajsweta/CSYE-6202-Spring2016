DELIMITER //
CREATE  PROCEDURE FlightToProc()
BEGIN 
Select distinct
flight_to
from flight_schedule ;
END//
DELIMITER ;
