DELIMITER //
CREATE  PROCEDURE UPDATE_FLIGHTSCHEDULE(IN flightSchedule_ID int,
    flight_name CHAR(50),
    flying_from CHAR(50),
    flying_to CHAR(50),
    departing datetime,
    arrival datetime,
    seat_businessCount int,
    crew_id int
    )
BEGIN 
declare maxFs_ID int;
declare flight_id int;
declare flightTotalNumberOfSeats int;
declare bseat_id int;
declare eseat_id int;
declare fs_seat_map_id int;

select seat_id into bseat_id from seat where seat_type = 'Business';

select seat_id into eseat_id from seat where seat_type = 'Economy';

select coalesce(max(map_ID), 0) into fs_seat_map_id from fs_seat_maptable;

Select  coalesce(max(flightSchedule_id), 0) into maxFs_ID from flight_schedule;

Select flight.flight_id into flight_id   from flight where flight_name = flight.flight_name;

Select flight.NumberOfSeats into flightTotalNumberOfSeats from flight where flight_name = flight.flight_name;

UPDATE flight_schedule fschedule
SET fschedule.flight_id = flight_id,
	fschedule.flight_from = flying_from,
    fschedule.flight_to = flying_to,
    fschedule.flight_departureTime = departing,
    fschedule.flight_arrivalTime = arrival,
    fschedule.flight_duration = time_format(timediff(arrival,departing),'%H'),
    fschedule.crew_ID = crew_id
WHERE fschedule.flightSchedule_id = flightSchedule_ID;

UPDATE fs_seat_maptable seatMap
SET seatMap.seat_Count = seat_businessCount
where seatMap.fs_ID = flightSchedule_ID AND seatMap.seat_ID = bseat_id;

UPDATE fs_seat_maptable seatMap
SET seatMap.seat_Count = flightTotalNumberOfSeats-seat_businessCount
where seatMap.fs_ID = flightSchedule_ID AND seatMap.seat_ID = eseat_id;

select (maxFs_ID+1);

END//
DELIMITER ;
