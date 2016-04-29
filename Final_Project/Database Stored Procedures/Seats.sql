DELIMITER //
CREATE  PROCEDURE Seats()
BEGIN 
Select distinct
seat_type
from seat ;
END//
DELIMITER ;
