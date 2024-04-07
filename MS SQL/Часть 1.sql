--Таблица "rooms"

IF NOT EXISTS (SELECT*FROM sysobjects WHERE name='rooms')
CREATE TABLE dbo.rooms (
	room_id INT IDENTITY(1,1) NOT NULL,
	room_number INT NOT NULL,
	room_type NVARCHAR(50) NOT NULL,
	price_per_night MONEY NOT NULL,
	availability INT NOT NULL,
	CONSTRAINT PK_rooms_id_room PRIMARY KEY(room_id)
	)

--Таблица "customers"

IF NOT EXISTS ( SELECT * FROM sysobjects WHERE name ='customers')
CREATE TABLE dbo.customers(
	 customer_id INT IDENTITY(1,1) NOT NULL,
	 first_name NVARCHAR(50) NOT NULL,
	 last_name NVARCHAR(50) NOT NULL,
	 email NVARCHAR(50) NOT NULL,
     phone_number NVARCHAR(50) NOT NULL,
	 CONSTRAINT PK_customers_id_customer PRIMARY KEY(customer_id)
	)

--Таблица "bookings"

IF NOT EXISTS ( SELECT * FROM sys.objects WHERE name ='bookings')
CREATE TABLE dbo.bookings(
	 booking_id INT IDENTITY(1,1) NOT NULL,
	 customer_id INT NOT NULL,
	 room_id INT NOT NULL,
	 check_in_date DATE NOT NULL,
     check_out_date DATE NOT NULL,
	 CONSTRAINT PK_bookings_id_booking PRIMARY KEY(booking_id),
	 CONSTRAINT FK_bookings_id_customer
		FOREIGN KEY (customer_id) REFERENCES dbo.customers (customer_id),
	 CONSTRAINT FK_bookings_id_room
		FOREIGN KEY (room_id) REFERENCES dbo.rooms (room_id)
	)

--Таблица "facilities"

IF NOT EXISTS ( SELECT * FROM sysobjects WHERE name ='facilities')
CREATE TABLE dbo.facilities(
	 facility_id INT IDENTITY(1,1) NOT NULL,
	 facility_name NVARCHAR(50) NOT NULL,
	 CONSTRAINT PK_facilities_id_facility PRIMARY KEY(facility_id)
	)

-- Таблица "roomstofacilities"

IF NOT EXISTS ( SELECT * FROM sysobjects WHERE name ='roomtofacilities')
CREATE TABLE dbo.roomtofacilities(
	 room_id INT NOT NULL,
	 facility_id INT NOT NULL,
	 CONSTRAINT PK_roomtofacilities_id_roomtofacilities PRIMARY KEY(room_id, facility_id),
	 CONSTRAINT FK_roomtofacilities_id_room
		FOREIGN KEY (room_id) REFERENCES dbo.rooms(room_id),
	 CONSTRAINT FK_roomtofacilities_id_facilities
		FOREIGN KEY (facility_id) REFERENCES dbo.facilities(facility_id)
	)

-- Добавление информации о номерах

INSERT INTO rooms (room_number, room_type, price_per_night, availability)
VALUES
    (11, N'Одноместный', 1000.00, 1),
    (12, N'Одноместный', 1000.00, 1),
    (13, N'Одноместный', 1000.00, 1),
    (21, N'Двухместный', 2000.00, 1),
    (22, N'Двухместный', 2000.00, 1),
    (23, N'Двухместный', 2000.00, 1),
    (31, N'Люкс', 5000.00, 1),
    (31, N'Люкс', 5000.00, 1),
    (33, N'Люкс', 5000.00, 1)

--Добавление информации о клиентах

INSERT INTO customers (first_name, last_name, email, phone_number)
VALUES
    (N'Иван', N'Иванов', N'ivan@test.ru', '89991111111'),
    (N'Петр', N'Петров', N'petr@test.ru', '89992222222'),
    (N'Александр', N'Александров', N'alexandr@test.ru', '89993333333'),
    (N'Михаил', N'Михайлов', N'michail@test.net', '89994444444'),
    (N'Роман', N'Романов', N'roman@test.net', '89995555555'),
    (N'Андрей', N'Андреев', N'andrey@test.net', '89996666666'),
    (N'Анна', N'Аннова', N'anna@test.com', '89997777777'),
    (N'Мария', N'Мариева', N'mariya@test.com', '89998888888'),
    (N'Елена', N'Еленова', N'elena@test.com', '89999999999')

-- Добавление информации о бронированиях

INSERT INTO bookings (customer_id, room_id, check_in_date, check_out_date)
VALUES
    (1, 1, '2024-04-07', '2024-04-08'),
    (2, 2, '2024-04-09', '2024-04-12'),
    (3, 3, '2024-04-10', '2024-04-11'),
    (4, 4, '2024-04-07', '2024-04-15'),
    (5, 5, '2024-04-15', '2024-04-17'),
    (6, 6, '2024-04-20', '2024-04-28'),
    (7, 7, '2024-04-15', '2024-04-20'),
    (8, 8, '2024-04-08', '2024-04-14'),
    (9, 9, '2024-04-13', '2024-04-15')

--Добавление информации об удобствах

INSERT INTO facilities (facility_name)
VALUES
    (N'Wi-Fi'),
    (N'Кондиционер'),
    (N'Мини-бар'),
    (N'Цифровое тв'),
    (N'Мини-холодильник'),
    (N'Фен'),
    (N'Кулер на этаже'),
    (N'Ванная комната'),
    (N'Две полутороспальные кровати'),
    (N'Кровать «King size»')

--Добавление информации об удобствах в номерах

INSERT INTO roomtofacilities (room_id, facility_id)
VALUES
    (1, 1),
    (1, 2),
    (2, 3),
    (2, 4),
    (3, 5),
    (3, 6),
    (4, 7),
    (4, 8),
    (5, 9),
    (5, 10),
    (5, 1),
    (6, 2),
    (6, 3),
    (7, 4),
    (7, 5),
    (8, 6),
    (8, 7),
    (9, 8),
    (9, 9)