-- ====================================================================
-- SKRIP MASTER SETUP DATABASE - KOS BU IPUNG
-- Versi Final: Membuat tabel dan mengisi data dummy.
-- Aman untuk dijalankan pada database kosong atau yang sudah ada.
-- ====================================================================

-- Langkah 1: Hapus tabel lama jika ada (dengan urutan yang benar)
PRINT 'Menghapus tabel lama jika ada...';
IF OBJECT_ID('dbo.komunikasi', 'U') IS NOT NULL DROP TABLE dbo.komunikasi;
IF OBJECT_ID('dbo.penghuni', 'U') IS NOT NULL DROP TABLE dbo.penghuni;
IF OBJECT_ID('dbo.pemesanan', 'U') IS NOT NULL DROP TABLE dbo.pemesanan;
IF OBJECT_ID('dbo.kamar', 'U') IS NOT NULL DROP TABLE dbo.kamar;
IF OBJECT_ID('dbo.admin', 'U') IS NOT NULL DROP TABLE dbo.admin;
GO

-- Langkah 2: Membuat semua tabel dari awal
PRINT 'Membuat struktur tabel baru...';

CREATE TABLE admin (
    id INT PRIMARY KEY IDENTITY(1,1),
    email VARCHAR(100) NOT NULL UNIQUE,
    username VARCHAR(50) NOT NULL UNIQUE,
    passowrd VARCHAR(255) NOT NULL,
    date_created DATETIME NOT NULL
);

CREATE TABLE kamar (
    id_kamar INT PRIMARY KEY IDENTITY(1,1),
    nomor_kamar VARCHAR(10) NOT NULL UNIQUE,
    harga INT NOT NULL,
    status CHAR(1) NOT NULL CHECK (status IN ('T', 'K')),
    tipe_kamar VARCHAR(50),
    fasilitas VARCHAR(255)
);

CREATE TABLE pemesanan (
    id_pemesanan INT PRIMARY KEY IDENTITY(1,1),
    id INT NOT NULL FOREIGN KEY REFERENCES admin(id),
    username VARCHAR(50) NOT NULL,
    id_kamar INT NOT NULL FOREIGN KEY REFERENCES kamar(id_kamar),
    tanggal_pemesanan DATETIME NOT NULL,
    status_validasi CHAR(1) NOT NULL CHECK (status_validasi IN ('P', 'A', 'L', 'T', 'B')),
    metode_pembayaran VARCHAR(50),
    jumlah_bayar INT
);

CREATE TABLE penghuni (
    id_penghuni INT PRIMARY KEY IDENTITY(1,1),
    id_pemesanan INT NOT NULL FOREIGN KEY REFERENCES pemesanan(id_pemesanan),
    tanggal_masuk DATETIME NOT NULL,
    tanggal_keluar DATETIME NOT NULL,
    status_penghuni VARCHAR(10) NOT NULL DEFAULT 'Aktif'
);

CREATE TABLE komunikasi (
    id_pesan INT PRIMARY KEY IDENTITY(1,1),
    id_pemesanan INT NOT NULL FOREIGN KEY REFERENCES pemesanan(id_pemesanan) ON DELETE CASCADE,
    id_pengirim INT NOT NULL,
    nama_pengirim VARCHAR(50) NOT NULL,
    isi_pesan TEXT NOT NULL,
    waktu_kirim DATETIME NOT NULL,
    sudah_dibaca BIT NOT NULL DEFAULT 0
);
GO

-- Langkah 3: Mengisi data dummy
PRINT 'Membuat data pengguna...';
INSERT INTO admin (email, username, passowrd, date_created) VALUES
('admin@example.com', 'admin', 'admin1234', GETDATE()), -- Menambahkan akun admin standar
('budi.santoso@example.com', 'budi', '12345678', GETDATE()),
('citra.lestari@example.com', 'citra', '12345678', GETDATE()),
('doni.mahendra@example.com', 'doni', '12345678', GETDATE()),
('eka.putri@example.com', 'eka', '12345678', GETDATE()),
('fitri.handayani@example.com', 'fitri', '12345678', GETDATE());

PRINT 'Membuat data kamar...';
INSERT INTO kamar (nomor_kamar, harga, status, tipe_kamar, fasilitas) VALUES
('101', 550000, 'T', 'Standard', 'Kipas Angin, Kamar Mandi Luar'),
('102', 650000, 'T', 'Standard Plus', 'Kipas Angin, Kamar Mandi Dalam'),
('103', 500000, 'K', 'Standard', 'Kipas Angin, Kamar Mandi Luar'),
('104', 900000, 'T', 'VIP', 'AC, Kamar Mandi Dalam, TV'),
('105', 950000, 'T', 'VIP', 'AC, Kamar Mandi Dalam, TV, Kulkas Mini'),
('201', 550000, 'K', 'Standard', 'Kipas Angin, Kamar Mandi Luar'),
('202', 650000, 'T', 'Standard Plus', 'Kipas Angin, Kamar Mandi Dalam'),
('203', 900000, 'K', 'VIP', 'AC, Kamar Mandi Dalam, TV'),
('204', 500000, 'T', 'Standard', 'Kipas Angin, Kamar Mandi Luar'),
('205', 650000, 'K', 'Standard Plus', 'Kipas Angin, Kamar Mandi Dalam');
GO

PRINT 'Mengambil ID dinamis dan membuat data pemesanan...';
DECLARE @admin_id INT, @budi_id INT, @citra_id INT, @doni_id INT, @eka_id INT, @fitri_id INT;
DECLARE @kamar101 INT, @kamar102 INT, @kamar104 INT, @kamar105 INT, @kamar202 INT, @kamar204 INT, @kamar205 INT;

SELECT @admin_id = id FROM admin WHERE username = 'admin';
SELECT @budi_id = id FROM admin WHERE username = 'budi';
SELECT @citra_id = id FROM admin WHERE username = 'citra';
SELECT @doni_id = id FROM admin WHERE username = 'doni';
SELECT @eka_id = id FROM admin WHERE username = 'eka';
SELECT @fitri_id = id FROM admin WHERE username = 'fitri';

SELECT @kamar101 = id_kamar FROM kamar WHERE nomor_kamar = '101';
SELECT @kamar102 = id_kamar FROM kamar WHERE nomor_kamar = '102';
SELECT @kamar104 = id_kamar FROM kamar WHERE nomor_kamar = '104';
SELECT @kamar105 = id_kamar FROM kamar WHERE nomor_kamar = '105';
SELECT @kamar202 = id_kamar FROM kamar WHERE nomor_kamar = '202';
SELECT @kamar204 = id_kamar FROM kamar WHERE nomor_kamar = '204';
SELECT @kamar205 = id_kamar FROM kamar WHERE nomor_kamar = '205';

INSERT INTO pemesanan (id, username, id_kamar, tanggal_pemesanan, status_validasi, metode_pembayaran, jumlah_bayar) VALUES
(@budi_id, 'budi', @kamar101, '2025-05-01', 'L', 'Transfer Bank', 550000),
(@citra_id, 'citra', @kamar102, '2025-05-10', 'L', 'Tunai', 650000),
(@doni_id, 'doni', @kamar104, '2025-06-01', 'L', 'E-Wallet', 900000),
(@eka_id, 'eka', @kamar202, '2025-06-05', 'L', 'Transfer Bank', 650000);

INSERT INTO pemesanan (id, username, id_kamar, tanggal_pemesanan, status_validasi) VALUES
(@fitri_id, 'fitri', @kamar204, GETDATE(), 'A'),
(@budi_id, 'budi', @kamar105, GETDATE(), 'P');
GO

PRINT 'Membuat data penghuni...';
DECLARE @pesanan_budi INT, @pesanan_citra INT, @pesanan_doni INT, @pesanan_eka INT;

SELECT @pesanan_budi = p.id_pemesanan FROM pemesanan p WHERE p.id = @budi_id AND p.status_validasi = 'L';
SELECT @pesanan_citra = p.id_pemesanan FROM pemesanan p WHERE p.id = @citra_id AND p.status_validasi = 'L';
SELECT @pesanan_doni = p.id_pemesanan FROM pemesanan p WHERE p.id = @doni_id AND p.status_validasi = 'L';
SELECT @pesanan_eka = p.id_pemesanan FROM pemesanan p WHERE p.id = @eka_id AND p.status_validasi = 'L';

INSERT INTO penghuni (id_pemesanan, tanggal_masuk, tanggal_keluar, status_penghuni) VALUES
(@pesanan_budi, '2025-05-01', '2025-06-01', 'Aktif'),
(@pesanan_citra, '2025-05-10', '2025-06-10', 'Aktif'),
(@pesanan_doni, '2025-06-01', '2025-07-01', 'Aktif'),
(@pesanan_eka, '2025-06-05', '2025-07-05', 'Aktif');
GO

PRINT 'Pembuatan data dummy selesai!';
GO