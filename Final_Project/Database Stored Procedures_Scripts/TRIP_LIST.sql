DELIMITER //
CREATE PROCEDURE TRIP_LIST(IN flying_from CHAR(50),
    flying_to CHAR(50),
    departing date,
    numberofSeats int,
    seat_type CHAR(50)
    )
BEGIN 
Select 
fs.flightSchedule_id, 
f.flight_name, 
f.flight_carrier,
f.NumberOfSeats,
fs.flight_from, 
fs.flight_to,
fs.flight_departureTime, 
fs.flight_arrivalTime,
fs.flight_duration, 
f.flight_id,
s.seat_type,
smap.seat_Count,
crew_ID
from flight_schedule fs
left join flight f
on f.flight_id = fs.flight_id
inner join fs_seat_maptable smap
on smap.fs_ID = fs.flightSchedule_id
inner join seat s
on s.seat_id = smap.seat_ID
where (isnull(flight_from) OR flight_from = fs.flight_from)
and (isNull(flying_to)      OR flying_to = fs.flight_to)
and (isnull(departing)      OR departing >= DATE(fs.flight_departureTime))
and (isNull(numberofSeats)  OR numberofSeats <= f.NumberOfSeats)
and (isNull(seat_type)      OR   seat_type = s.seat_type);
END//
DELIMITER ;
