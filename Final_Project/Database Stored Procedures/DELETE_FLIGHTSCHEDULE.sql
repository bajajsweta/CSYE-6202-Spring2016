DELIMITER //
CREATE PROCEDURE DELETE_FLIGHTSCHEDULE(IN flightSchedule_ID int)
BEGIN 

DELETE  from flight_schedule 
WHERE flight_schedule.flightSchedule_id = flightSchedule_ID;

DELETE from fs_seat_maptable 
where fs_seat_maptable.fs_ID = flightSchedule_ID;


select count(*) from flight_schedule;

END//
DELIMITER ;
