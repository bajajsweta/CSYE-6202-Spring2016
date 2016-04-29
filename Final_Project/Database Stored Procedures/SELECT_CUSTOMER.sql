DELIMITER //
CREATE  PROCEDURE SELECT_CUSTOMER()
BEGIN 
Select distinct
customer_name
from customer ;
END//
DELIMITER ;
