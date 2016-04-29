/*ALL Stored Procedures */



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




DELIMITER //
CREATE PROCEDURE UserAuthentication(IN 
    empl_name CHAR(50),    
    empl_password CHAR(50))
BEGIN 
Select emp_designation 
from employee
WHERE emp_name = empl_name
and emp_password = empl_password;
END//
DELIMITER ;




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


DELIMITER //
CREATE  PROCEDURE UPDATE_FLIGHT(IN flight_id int,
    flight_carrier CHAR(50),
    flight_name CHAR(50),
    flight_numberofSeats int
	)
BEGIN 
UPDATE flight f 
SET
f.flight_carrier = flight_carrier,
f.flight_name = flight_name,
f.NumberOfSeats = flight_numberofSeats
where f.flight_id = flight_id;

Select Count(*) from flight;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE UPDATE_EMPLOYEE(IN emp_id int,
    emp_name CHAR(50),
    emp_designation CHAR(50),
    emp_age int,
    emp_gender CHAR(50),
    emp_email CHAR(50),
    emp_password CHAR(50),
    emp_crewID int)
BEGIN 
UPDATE employee e
SET
e.emp_name = emp_name,
e.emp_designation =emp_designation,
e.emp_age = emp_age,
e.emp_gender = emp_gender,
e.emp_email = emp_email,
e.emp_password = emp_password,
e.crew_ID = emp_crewID
where e.emp_id = emp_id;

Select Count(*) from employee;
END//
DELIMITER ;


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


DELIMITER //
CREATE  PROCEDURE TRIP(IN flying_from CHAR(50),
    flying_to CHAR(50),
    departing date,
    numberofSeats int,
    seat_type CHAR(50))
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
p.price,
s.seat_type
from flight_schedule fs
left join flight f
on f.flight_id = fs.flight_id
inner join price p 
on p.flightSchedule_id = fs.flightSchedule_id
inner join seat s
on s.seat_id = p.seat_id
where (isnull(flight_from) OR flight_from = fs.flight_from)
and (isNull(flying_to)      OR flying_to = fs.flight_to)
and (isnull(departing)      OR departing >= DATE(fs.flight_departureTime))
and (isNull(numberofSeats)  OR numberofSeats <= f.NumberOfSeats)
and (isNull(seat_type)      OR   seat_type = s.seat_type);
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE SELECT_CUSTOMER()
BEGIN 
Select distinct
customer_name
from customer ;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE Seats()
BEGIN 
Select distinct
seat_type
from seat ;
END//
DELIMITER ;


DELIMITER //
CREATE PROCEDURE LOCATION_LIST()
BEGIN 
SELECT location_name from location;
END//
DELIMITER ;


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


DELIMITER //
CREATE  PROCEDURE FlightToProc()
BEGIN 
Select distinct
flight_to
from flight_schedule ;
END//
DELIMITER ;

DELIMITER //
CREATE PROCEDURE FlightTable()
BEGIN 
Select *
from flight;
select count(*) from flight;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE FlightScheduleTable()
BEGIN 
Select *
from flight_schedule;
select count(*) from flight_schedule;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE FlightFromProc()
BEGIN 
Select distinct
flight_from
from flight_schedule ;
END//
DELIMITER ;


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


DELIMITER //
CREATE PROCEDURE EMPLOYEE_LIST(IN 
    emp_name CHAR(50),
    emp_designation CHAR(50),
    emp_age int,
    emp_gender CHAR(50),
    emp_email CHAR(50),
    emp_password CHAR(50))
BEGIN 
Select 
e.emp_id,
e.emp_name,
e.emp_designation,
e.emp_age,
e.emp_gender,
e.emp_email,
e.emp_password,
e.crew_ID
from  employee e
where (isNull(emp_name)           OR emp_name = e.emp_name)
and (isnull(emp_designation)      OR emp_designation = e.emp_designation)
and (isNull(emp_age)              OR emp_age = e.emp_age)
and (isNull(emp_gender)           OR emp_gender = e.emp_gender)
and (isNull(emp_email)            OR emp_email = e.emp_email)
and (isNull(emp_password)         OR emp_password = e.emp_password);
END//
DELIMITER ;


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


DELIMITER //
CREATE PROCEDURE DELETE_FLIGHT(IN flight_id int)
BEGIN 
DELETE from flight
where flight.flight_id = flight_id;

Select Count(*) from flight;
END//
DELIMITER ;


DELIMITER //
CREATE PROCEDURE DELETE_EMPLOYEE(IN empl_id int)
BEGIN 
DELETE FROM employee 
where
employee.emp_id = empl_id;
Select Count(*) from employee;
END//
DELIMITER ;


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


/*Procedure created to create a Employee*/


DELIMITER //
CREATE PROCEDURE CREATE_EMPLOYEE(IN 
    emp_name CHAR(50),
    emp_designation CHAR(50),
    emp_age int,
    emp_gender CHAR(50),
    emp_email CHAR(45),
    emp_password CHAR(50),
    emp_crewID int)
BEGIN 
declare maxemp_id int;
Select  coalesce(max(emp_id), 0) into maxemp_id from employee;

INSERT INTO employee ()
VALUES((maxemp_id + 1),emp_name,emp_designation,emp_age,emp_gender,emp_email,emp_password,emp_crewID);

Select  e.emp_id,
e.emp_name,
e.emp_designation,
e.emp_age,
e.emp_gender,
e.emp_email,
e.emp_password,
e.crew_ID
from  employee e
where e.emp_id = (maxemp_id + 1);
END//
DELIMITER ;


/*Procedure created to create a Customer*/

DELIMITER //
CREATE  PROCEDURE CREATE_CUSTOMER (IN 
    customer_name CHAR(50),
    customer_sex CHAR(50),
    customer_age int,
    customer_idproof CHAR(50),
    is_passenger CHAR(50),
    cust_password CHAR(50))
BEGIN 
declare maxcust_id int;
Select  coalesce(max(customer_id), 0) into maxcust_id from customer;

INSERT INTO customer ()
VALUES((maxcust_id + 1),customer_name,customer_sex,customer_age,customer_idproof,is_passenger,cust_password);
Select Count(*) from customer;
END//
DELIMITER ;


