DELIMITER //
CREATE  PROCEDURE FLIGHT_LIST(IN 
    flight_name CHAR(50),
    flight_carrier CHAR(50),
    flight_numberofSeats int)
BEGIN 
Select 
f.flight_id,
f.flight_name, 
f.flight_carrier,
f.NumberOfSeats
from  flight f

where (isNull(flight_name)      OR flight_name = f.flight_name)
and (isnull(flight_carrier)      OR flight_carrier = f.flight_carrier)
and (isNull(flight_numberofSeats)  OR flight_numberofSeats = f.NumberOfSeats);
END//
DELIMITER ;
