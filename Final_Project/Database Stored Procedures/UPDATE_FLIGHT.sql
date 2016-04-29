DELIMITER //
CREATE  PROCEDURE UPDATE_FLIGHT(IN flight_id int,
    flight_carrier CHAR(50),
    flight_name CHAR(50),
    flight_numberofSeats int
	)
BEGIN 
UPDATE flight f 
SET
f.flight_carrier = flight_carrier,
f.flight_name = flight_name,
f.NumberOfSeats = flight_numberofSeats
where f.flight_id = flight_id;

Select Count(*) from flight;
END//
DELIMITER ;
