
DROP TRIGGER calculate_install
DROP TRIGGER calculate_equipment

DROP TABLE dbo.device
DROP TABLE dbo.quote_input
DROP TABLE dbo.user_input


/****** Object:  Table [dbo].[device]    Script Date: 8/9/2023 7:19:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[device](
	[device_id] [int] IDENTITY (1,1) NOT NULL,
	[device_name] [varchar](50) NOT NULL,
	[device_price] [money] NOT NULL,
	[installation_cost] [money] NOT NULL
	CONSTRAINT PK_device_id PRIMARY KEY (device_id)
) ON [PRIMARY]


GO
CREATE TABLE [dbo].[user_input](
	[input_id] [int] IDENTITY (1,1) NOT NULL,
	[date] [date] DEFAULT GETDATE(),
	[num_windows] [int] NULL,
	[num_doors] [int] NULL,
	[video_doorbell] [int] NULL,
	[cost_install] [int] NULL,
    [cost_equipment] [int] NULL,
	CONSTRAINT PK_input_id PRIMARY KEY (input_id)
) ON [PRIMARY] 
GO
CREATE TABLE [dbo].[quote_input](
	[quote_input_id] [int] IDENTITY (1,1) NOT NULL,
	[input_id] [int],
	[email] [varchar](max) NULL,
	[phone_number] [nvarchar](max) NULL,
	[name] [varchar](50) NULL,
	CONSTRAINT PK_quote_input_id PRIMARY KEY (quote_input_id),
	CONSTRAINT FK_input_id FOREIGN KEY (input_id)
    REFERENCES user_input(input_id)
) ON [PRIMARY] 
GO


INSERT INTO device (device_name, device_price, installation_cost)
VALUES ('Contact Sensor', 30, 15)
INSERT INTO device (device_name, device_price, installation_cost)
VALUES ('Motion Sensor', 40, 20)
INSERT INTO device (device_name, device_price, installation_cost)
VALUES ('Alarm Hub', 300, 50)
INSERT INTO device (device_name, device_price, installation_cost)
VALUES ('Keypad', 100, 50)
INSERT INTO device (device_name, device_price, installation_cost)
VALUES ('Video Doorbell', 200, 100)

INSERT INTO quote_input (email, phone_number, name)
VALUES ('email@1.com', '100-100-1001', 'Bobo')
INSERT INTO quote_input (email, phone_number, name)
VALUES ('email@2.com', '100-100-1002', 'John')
INSERT INTO quote_input (email, phone_number, name)
VALUES ( 'email@3.com', '100-100-1003', 'Steve')
INSERT INTO quote_input (email, phone_number, name)
VALUES ('email@4.com', '100-100-1004', 'Briant')
INSERT INTO quote_input (email, phone_number, name)
VALUES ('email@5.com', '100-100-1005', 'Parker')

INSERT INTO user_input (date, num_doors, num_windows, video_doorbell)
VALUES ('2023-07-14', 3, 6, 1)
INSERT INTO user_input (date, num_doors, num_windows, video_doorbell)
VALUES ('2023-08-21', 1, 8, 1)
INSERT INTO user_input (date, num_doors, num_windows, video_doorbell)
VALUES ('2023-08-20', 2, 10, 1)
INSERT INTO user_input (date, num_doors, num_windows, video_doorbell)
VALUES ('2023-05-01', 3, 3, 2)
INSERT INTO user_input (date, num_doors, num_windows, video_doorbell)
VALUES ('2023-05-14', 4, 14, 1)


