--������� 1

SELECT * FROM rooms r
JOIN bookings b ON b.room_id = r.room_id
WHERE ('2024-04-07' NOT BETWEEN b.check_in_date AND b.check_out_date ) 
AND availability = 1

--������� 2

SELECT * FROM customers
WHERE last_name Like 'S%'

--������� 3

SELECT * FROM bookings b
JOIN  customers as c ON c.customer_id = b.customer_id
WHERE c.first_name = N'����' OR c.email = 'ivan@test.ru'

--������� 4

SELECT * FROM bookings b
JOIN rooms r ON r.room_id = b.room_id
WHERE r.room_number = 113

--�������5

SELECT * FROM rooms r
JOIN bookings b ON b.room_id = r.room_id
WHERE ('2024-04-08' NOT BETWEEN b.check_in_date AND b.check_out_date ) 
AND availability = 1