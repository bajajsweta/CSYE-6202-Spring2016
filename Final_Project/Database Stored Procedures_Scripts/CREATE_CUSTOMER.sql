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
