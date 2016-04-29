/*Procedure created to book a ticket*/

DELIMITER //
CREATE PROCEDURE BOOKING_TICKET(IN  flight_scheduleid int,
     customer_name CHAR(50),
     emp_name CHAR(50),
	 seats_booked int,
     seat_type CHAR(10),
	 price_perTicket float,
     total_price float)
BEGIN 
declare maxbook_id int;
declare flight_id int;
declare emp_id int;
declare customer_id int;
declare seat_id int;

Select  coalesce(max(b.booking_id), 0) into maxbook_id from booking b;

SELECT fs.flight_id into flight_id from flight_schedule fs
where fs.flightSchedule_id = flight_scheduleid;

SELECT e.emp_id into emp_id from employee e where e.emp_name = emp_name;

SELECT c.customer_id into customer_id from customer c where c.customer_name = customer_name;

SELECT s.seat_id into seat_id from seat s where s.seat_type = seat_type;

Insert into booking() values ((maxbook_id + 1), flight_id, flight_scheduleid, seat_id, emp_id, customer_id, now(), seats_booked,price_perTicket,total_price);

update flight f 
set f.NumberOfSeats = (f.NumberOfSeats - seats_booked) 
where f.flight_id = flight_id;

update fs_seat_maptable 
SET fs_seat_maptable.seat_Count = fs_seat_maptable.seat_Count - seats_booked
where fs_seat_maptable.fs_ID = flight_scheduleid
and fs_seat_maptable.seat_ID = seat_id;

select (maxbook_id + 1);

END//
DELIMITER ;
