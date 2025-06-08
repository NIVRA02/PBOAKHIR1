create table kamar
(
	id_kamar int primary key,
	nomor_kamar varchar(10) not null,
	harga int not null,
	status char(1) not null check (status in ('T', 'K')),
);

insert into kamar (id_kamar, nomor_kamar, harga, status) values
(1, '101', 500000, 'T'),
(2, '102', 600000, 'K'),
(3, '103', 550000, 'T'),
(4, '104', 700000, 'K'),
(5, '105', 650000, 'T');