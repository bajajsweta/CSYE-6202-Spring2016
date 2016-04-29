DELIMITER //
CREATE PROCEDURE CREATE_FLIGHT(IN flight_ID INT,
    flight_name CHAR(50),
    flight_carrier CHAR(50),
    flight_numberofSeats int)
BEGIN 
DECLARE max_id int;

Select  coalesce(max(f.flight_id), 0) into max_id from flight f;
Insert INTO flight() VALUES ((max_id+1),flight_name,flight_carrier,flight_numberofSeats);


Select 
f.flight_id,
f.flight_name, 
f.flight_carrier,
f.NumberOfSeats
from  flight f where f.flight_id = (max_id + 1);

END//
DELIMITER ;
