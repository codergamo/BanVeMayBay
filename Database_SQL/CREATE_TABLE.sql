create database QUANLYCHUYENBAY
go
use QUANLYCHUYENBAY
go
create table SANBAY(
MaSanBay char(20) primary key not null,
TenSanBay nvarchar(45) not null,
ViTri nvarchar(50) not null
)
go

create table TUYENBAY(
MaTuyenBay char(20) primary key not null,
SANBAYDI_MaSanBay char(20) REFERENCES SANBAY(MaSanBay),
SANBAYDEN_MaSanBay char(20) REFERENCES SANBAY(MaSanBay),
SANBAYTRUNGGIAN_MaSanBay char(20) REFERENCES SANBAY(MaSanBay)
)
go

create table NHANVIEN(
MaNV char(20) primary key not null,
CMND char(20) not null,
TenNV nvarchar(45),
GioiTinh nvarchar(20),
NgaySinh date,
SDT  char(20),
Diachi nvarchar(100)
)
go
------
create table TAIKHOAN(
 TenTaiKhoan char(20) primary key not null,
 MatKhau char (20) not null,
 ID_NhanVien CHAR(20) references NHANVIEN(MaNV) null,
 PHANLOAI char(20)
)
go

create table KHACHHANG(
CMND char(20) primary key not null,
TenKH nvarchar(45),
SDT  char(20),
GioiTinh   nvarchar(20),
Diachi nvarchar(100),
NgaySinh date
)
go

create table MAYBAY(
MaMayBay CHAR(20) primary key not null,
LoaiMayBay nvarchar(45),
SoGhe int
)
go

CREATE TABLE CHUYENBAY(
MaChuyenBay char(20) PRIMARY KEY not null,
NgayBay Date,
GioKhoiHanh TIME,
ThoiGianBay TIME,
ThoiGianDuKienDen TIME,
SoGheHang1 INT,
SoGheHang2 INT,
TUYENBAY_MaTuyenBay char(20) REFERENCES TUYENBAY(MaTuyenBay),
MaMayBay CHAR(20) references MAYBAY(MaMayBay)
------Chuyến bay đã bỏ Khối lượng
)
go
CREATE TABLE HANGVE(
MaHangVe char(20) PRIMARY KEY not null,
VECHUYENBAY char(20) REFERENCES CHUYENBAY(MaChuyenBay), -- ví dụ như tuyến tân sơn nhất nội bài ,
KhoiLuongToiDa int, -----Thêm Khối Lượng tối đa vào HangVe
DonGia Money
)
go


CREATE TABLE PHIEUDATCHO(
MaPhieu char(20) PRIMARY KEY not null,
ThoiGianDat DATETIME,
SoGhe char(5),
HangGhe char(5),
CHUYENBAY_MaChuyenBay char(20) REFERENCES CHUYENBAY(MaChuyenBay),
KHACHHANG_CMND CHAR(20) REFERENCES KHACHHANG(CMND),
MAHANGVE CHAR(20) REFERENCES HANGVE(MaHangVe),
)
GO


CREATE TABLE HOADON(
MaHD char(20) PRIMARY KEY not null,
MaPhieuDatCho char(20) references PHIEUDATCHO(MaPhieu),
ThanhTien MONEY,
NgayLap DATETIME,
NHANVIEN_MaNV CHAR(20) REFERENCES NHANVIEN(MaNV),
KHACHHANG_CMND CHAR(20) REFERENCES KHACHHANG(CMND)
)
go

CREATE TABLE VECHUYENBAY(
MaVeChuyenBay char(20)PRIMARY KEY not null,
CHUYENBAY_MaChuyenBay char(20) REFERENCES CHUYENBAY(MaChuyenBay),
SoLuongVe int,
TinhTrangVe nvarchar(10),
)

