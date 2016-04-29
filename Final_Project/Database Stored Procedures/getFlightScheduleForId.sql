DELIMITER //
CREATE  PROCEDURE getFlightScheduleForId(IN flightSchedule_id int)
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
fs.crew_ID
from flight_schedule fs
left join flight f
on f.flight_id = fs.flight_id
inner join fs_seat_maptable smap
on smap.fs_ID = fs.flightSchedule_id
inner join seat s
on s.seat_id = smap.seat_ID
where fs.flightSchedule_id = flightSchedule_id;
END//
DELIMITER ;
