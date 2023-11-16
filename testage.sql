SELECT TOP (1000) [device_id]
      ,[device_name]
      ,[device_price]
      ,[installation_cost]
  FROM [homeautomate].[dbo].[device]

SELECT TOP (1000) [input_id]
      ,[date]
      ,[num_windows]
      ,[num_doors]
      ,[video_doorbell]
      ,[cost]
  FROM [homeautomate].[dbo].[user_input]

 UPDATE dbo.user_input
 SET cost = (SELECT num_windows * ((
    SELECT device_price
    FROM device
    WHERE device_id = 1
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 1))
WHERE input_id = input_id);

(SELECT num_windows * ((
    SELECT device_price
    FROM device
    WHERE device_id = 1
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 1))
WHERE input_id = 1);


CREATE FUNCTION dbo.calculate_cost
(
    @input_id int
)
RETURNS INT
AS
BEGIN

    DECLARE @cost INT = 0;
    SET @cost =   (SELECT num_windows * ((
    SELECT device_price
    FROM device
    WHERE device_id = 1
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 1))
FROM dbo.user_input WHERE input_id = @input_id)
    RETURN @cost;

END


DROP TRIGGER calculate_costf

CREATE TRIGGER calculate_costf
ON dbo.user_input
AFTER INSERT 
AS
    UPDATE dbo.user_input
 SET cost = (SELECT num_windows * ((
    SELECT device_price
    FROM device
    WHERE device_id = 1
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 1))
	WHERE input_id = input_id)
	+
	(SELECT num_doors * ((
    SELECT device_price
    FROM device
    WHERE device_id = 1
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 1))
WHERE input_id = input_id)
	+
	--
	(SELECT video_doorbell * ((
    SELECT device_price
    FROM device
    WHERE device_id = 5
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 5))
	WHERE input_id = input_id)
	--
	+
 (2 * ((
    SELECT device_price
    FROM device
    WHERE device_id = 2
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 2)))
	+
	((SELECT device_price
    FROM device
    WHERE device_id = 3
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 3))
	+
	 ((SELECT device_price
    FROM device
    WHERE device_id = 4
)+(SELECT installation_cost
    FROM device
    WHERE device_id = 4));

