DELIMITER //
CREATE  PROCEDURE CREATE_FLIGHTSCHEDULE(IN flight_name CHAR(50),
    flying_from CHAR(50),
    flying_to CHAR(50),
    departing datetime,
    arrival datetime,
    seat_businessCount int,
    crew_id int
   /* ,seat_economicCount int */
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

Insert into flight_schedule () Values ((maxFs_ID+1),flight_id,flying_from,flying_to,departing,arrival,time_format(timediff(arrival,departing),'%H'));

Insert into fs_seat_maptable() values  ((fs_seat_map_id + 1), (maxFs_ID + 1), bseat_id, seat_businessCount);

Insert into fs_seat_maptable() values  ((fs_seat_map_id + 2), (maxFs_ID + 1), eseat_id, flightTotalNumberOfSeats-seat_businessCount );

select (maxFs_ID+1);


END//
DELIMITER ;
