CREATE TABLE pemesanan (
    id_pemesanan INT PRIMARY KEY IDENTITY(1,1),
    id INT NOT NULL,
    id_kamar INT NOT NULL,
    tanggal_pesan DATE NOT NULL,
    bukti_pembayaran VARCHAR(255),
    status_pembayaran VARCHAR(50) NOT NULL,
);