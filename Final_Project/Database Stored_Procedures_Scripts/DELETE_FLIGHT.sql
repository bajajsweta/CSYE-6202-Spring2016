DELIMITER //
CREATE PROCEDURE DELETE_FLIGHT(IN flight_id int)
BEGIN 
DELETE from flight
where flight.flight_id = flight_id;

Select Count(*) from flight;
END//
DELIMITER ;
