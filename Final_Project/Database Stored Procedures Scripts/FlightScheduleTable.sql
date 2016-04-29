DELIMITER //
CREATE  PROCEDURE FlightScheduleTable()
BEGIN 
Select *
from flight_schedule;
select count(*) from flight_schedule;
END//
DELIMITER ;
