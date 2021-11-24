-- a,b
CREATE TABLE data_staff(
	nik int PRIMARY KEY,
	nama VARCHAR(50) NULL,
	alamat VARCHAR(200) NULL,
	handphone varchar(15) NULL
);


-- c,d
INSERT INTO data_staff (nik,nama,alamat,handphone)
	VALUES('10001', 'John', 'Tangerang Selatan', '0221039385'),
	('10002', 'Doe', 'Kebon Jeruk', '0221038563'),
	('10003', 'Judy', 'BSD', '0221285735'),
	('10004', 'Bolay', 'Sawangan', '0221920576');

SELECT * FROM data_staff;


-- e
ALTER TABLE data_staff ADD joindate DATE NULL;

INSERT INTO data_staff (nik,nama,alamat,handphone,joindate)
	VALUES('10005', 'Jamal', 'Jakarta Barat', '0221184056','10-11-2021');

UPDATE data_staff SET joindate = '2021-11-11' WHERE nik = '10001';
UPDATE data_staff SET joindate = '2021-11-12' WHERE nik = '10002';
UPDATE data_staff SET joindate = '2021-11-15' WHERE nik = '10003';
UPDATE data_staff SET joindate = '2021-11-21' WHERE nik = '10004';
UPDATE data_staff SET joindate = '2021-11-22' WHERE nik = '10005';


-- f
SELECT TOP 2 * FROM data_staff;


-- g
SELECT TOP 3 * FROM data_staff;


-- h
CREATE TABLE staffoutsource(
	nik int PRIMARY KEY,
	nama VARCHAR(50) NULL,
	alamat VARCHAR(200) NULL,
	handphone varchar(15) NULL
);

-- Lupa add column joindate saat create table staffoutsource
ALTER TABLE staffoutsource ADD joindate DATE NULL;

INSERT INTO staffoutsource (nik,nama,alamat,handphone,joindate)
	VALUES('10001', 'John', 'Tangerang Selatan', '0221039385', '2021-11-11');

INSERT INTO staffoutsource (nik,nama,alamat,joindate)
	VALUES('10002', 'Doe', 'Kebon Jeruk', '2021-11-12');

INSERT INTO staffoutsource (nik,nama,alamat,handphone)
	VALUES('10003', 'Judy', 'BSD', '0221285735');

INSERT INTO staffoutsource (nik,nama,alamat,handphone,joindate)
	VALUES('10004', 'Bolay', 'Sawangan', '0221920576', '2021-11-21');

INSERT INTO staffoutsource (nik,nama,alamat,handphone,joindate)
	VALUES('10005', 'Jamal', 'Jakarta Barat', '0221184056', '2021-11-22');

SELECT * FROM staffoutsource;


-- i
INSERT INTO staffoutsource (nik,nama,alamat,handphone,joindate) VALUES
	('10006', 'Boboho', 'Jakarta Selatan', '0221183905', '2021-11-13'),
	('10007', 'Kesu', 'Jakarta Timur', '0221836591', '2021-11-14'),
	('10008', 'Jean', 'Alam Sutera', '0221902745', '2021-11-16'),
	('10009', 'Pepe', 'Jakarta Utara', '0221375891', '2021-11-17'),
	('100010', 'Ben', 'Jakarta Pusat', '0221893546', '2021-11-18'),
	('10011', 'Sommers', 'Sudirman', '0221590174', '2021-11-19'),
	('10012', 'Amuro', 'Kuningan', '0221284912', '2021-11-20'),
	('10013', 'Kira', 'Kasablanka', '0221601835', '2021-11-23'),
	('10014', 'Athrun', 'Banjar', '0221274017', '2021-11-10'),
	('10015', 'Neil', 'Pondok Labu', '0221793750', '2021-11-09');


-- j
SELECT * FROM data_staff d LEFT JOIN staffoutsource s ON d.nik = s.nik
	WHERE d.joindate = s.joindate;


-- k
SELECT * FROM data_staff ds	RIGHT JOIN staffoutsource st on st.nama=ds.nama



-- l
SELECT * FROM data_staff
	EXCEPT
SELECT * FROM staffoutsource;


-- m
SELECT * FROM data_staff
	UNION ALL
SELECT * FROM staffoutsource;