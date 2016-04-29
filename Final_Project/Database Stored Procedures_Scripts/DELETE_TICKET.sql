DELIMITER //
CREATE  PROCEDURE DELETE_TICKET(IN  booking_ID int)
BEGIN 
declare flight_id int;
declare seat_id int;
declare seats_booked int;
declare flight_scheduleid int;

SELECT booking.flight_id into flight_id from booking 
where booking.booking_id = booking_ID;

SELECT booking.seat_id into seat_id from booking 
where booking.booking_id = booking_ID;

select booking.seats_booked into seats_booked from booking 
where booking.booking_id = booking_ID;

SELECT booking.flightschedule_id into flight_scheduleid from booking 
where booking.booking_id = booking_ID;

Delete from booking
where booking.booking_id = booking_ID;

update flight f 
set f.NumberOfSeats = (f.NumberOfSeats + seats_booked) 
where f.flight_id = flight_id;

update fs_seat_maptable 
SET fs_seat_maptable.seat_Count = fs_seat_maptable.seat_Count + seats_booked
where fs_seat_maptable.fs_ID = flight_scheduleid
and fs_seat_maptable.seat_ID = seat_id;

select booking_ID;

END//
DELIMITER ;
