CREATE TRIGGER calculate_equipment
ON dbo.user_input
AFTER INSERT 
AS
    UPDATE dbo.user_input
    SET cost_equipment = (SELECT num_windows * (
    SELECT device_price
    FROM device
    WHERE device_id = 1
    )
	WHERE input_id = input_id)

	+
	(SELECT num_doors * (
    SELECT device_price
    FROM device
    WHERE device_id = 1
)
WHERE input_id = input_id)
	+
	--
	(SELECT video_doorbell * (
    SELECT device_price
    FROM device
    WHERE device_id = 5
)
	WHERE input_id = input_id)
	--
	+
 (2 * (
    SELECT device_price
    FROM device
    WHERE device_id = 2
))
	+
	(SELECT device_price
    FROM device
    WHERE device_id = 3
)
	+
	 (SELECT device_price
    FROM device
    WHERE device_id = 4
);