/*Procedure Created to get List of Booked Tickets*/

DELIMITER //
CREATE PROCEDURE BOOKED_TICKETS(IN emp_name CHAR(50))
BEGIN 
declare emp_id int;

SELECT e.emp_id 
into emp_id 
from employee e where e.emp_name = emp_name;

select 
b.booking_id,
f.flight_name, 
f.flight_carrier,
fs.flight_from, 
fs.flight_to,
fs.flight_departureTime, 
fs.flight_arrivalTime,
s.seat_type,
ee.emp_name,
c.customer_name,
b.Price_Per_Ticket,
b.TotalPrice,
b.booking_time,
b.Seats_booked,
fs.flight_duration
from booking b
inner join flight_schedule fs
on b.flightSchedule_id = fs.flightSchedule_id
inner join flight f
on b.flight_id = f.flight_id
inner join fs_seat_maptable fsm
on b.flightSchedule_id =  fsm.fs_ID
and b.seat_id = fsm.seat_ID
inner join seat s
on s.seat_id = fsm.seat_ID
inner join customer c
on c.customer_id = b.customer_id
inner join employee ee
on emp_id = b.employee_id
where ee.emp_name = emp_name;
END//
DELIMITER ;
