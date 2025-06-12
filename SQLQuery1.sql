CREATE TABLE Pemesanan (
    PemesananID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL,
    NomorKamar VARCHAR(10) NOT NULL,
    TanggalPesan DATE NOT NULL,
    StatusValidasi VARCHAR(20) NOT NULL DEFAULT 'Pending'
);