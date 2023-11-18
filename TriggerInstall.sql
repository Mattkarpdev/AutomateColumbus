
CREATE TRIGGER calculate_install
ON dbo.user_input
AFTER INSERT 
AS
    UPDATE dbo.user_input
 SET cost_install = (SELECT num_windows * ((SELECT installation_cost
    FROM device
    WHERE device_id = 1))
	WHERE input_id = input_id)
	+
	(SELECT num_doors * ((SELECT installation_cost
    FROM device
    WHERE device_id = 1))
WHERE input_id = input_id)
	+
	--
	(SELECT video_doorbell * ((SELECT installation_cost
    FROM device
    WHERE device_id = 5))
	WHERE input_id = input_id)
	--
	+
 (2 * ((SELECT installation_cost
    FROM device
    WHERE device_id = 2)))
	+
	((SELECT installation_cost
    FROM device
    WHERE device_id = 3))
	+
	 ((SELECT installation_cost
    FROM device
    WHERE device_id = 4));



    