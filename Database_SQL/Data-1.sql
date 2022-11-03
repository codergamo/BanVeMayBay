---------------------------Insert-------------------------
USE QUANLYCHUYENBAY
GO
-- thêm sân bay 
insert into SANBAY values ('SGN','Sân bay Quốc tế Tân Sơn Nhất','Hồ Chí Minh' )
insert into SANBAY values ('HAN','Sân bay Quốc tế Nội Bài ','Hà Nội' )
insert into SANBAY values ('DAD','Sân bay Quốc tế Đà Nẵng','Đà Nẵng' )
insert into SANBAY values ('CXR','Sân bay Quốc tế Cam Ranh','Khánh Hòa' )
insert into SANBAY values ('VCA','Sân bay Quốc tế Cần Thơ','Cần Thơ' )
insert into SANBAY values ('PEK','Sân bay quốc tế Bắc Kinh','Bắc Kinh' )
insert into SANBAY values ('BKK','Sân bay Quốc tế Bangkok','Bangkok' )
-- thêm tuyến bay ---------------------------------------------------------------------
--SELECT * FROM TUYENBAY
-- TỪ SÂN BAY TÂN SƠN NHẤT

insert into TUYENBAY values('SGN-HAN','SGN','HAN',NULL)
insert into TUYENBAY values('SGN-DAD','SGN','DAD',NULL)
insert into TUYENBAY values('SGN-CXR','SGN','CXR',NULL)
insert into TUYENBAY values('SGN-VCA','SGN','VCA',NULL)
insert into TUYENBAY values('SGN-BKK','SGN','BKK',NULL)
insert into TUYENBAY values('SGN-PEK','SGN','PEK','HAN')
-- TỪ SÂN BAY NỘI BÀI 
insert into TUYENBAY values('HAN-SGN','HAN','SGN',NULL)
insert into TUYENBAY values('HAN-DAD','HAN','DAD',NULL)
insert into TUYENBAY values('HAN-CXR','HAN','CXR',NULL)
insert into TUYENBAY values('HAN-VCA','HAN','VCA',NULL)
insert into TUYENBAY values('HAN-BKK','HAN','BKK',NULL)
insert into TUYENBAY values('HAN-PEK','SGN','PEK',NULL)
-- TỪ SÂN BAY ĐÀ NẴNG 
insert into TUYENBAY values('DAD-HAN','DAD','HAN',NULL)
insert into TUYENBAY values('DAD-SGN','DAD','SGN',NULL)
insert into TUYENBAY values('DAD-CXR','DAD','CXR',NULL)
insert into TUYENBAY values('DAD-VCA','DAD','VCA',NULL)
insert into TUYENBAY values('DAD-PEK','DAD','PEK','HAN')
-- TỪ SÂN BAY CAM RANH 
insert into TUYENBAY values('CXR-HAN','CXR','HAN',NULL)
insert into TUYENBAY values('CXR-SGN','CXR','SGN',NULL)
insert into TUYENBAY values('CXR-DAD','CXR','DAD',NULL)
insert into TUYENBAY values('CXR-VCA','CXR','VCA',NULL)
-- TỪ SÂN BAY CẦN THƠ 
insert into TUYENBAY values('VCA-HAN','VCA','HAN',NULL)
insert into TUYENBAY values('VCA-SGN','VCA','SGN',NULL)
insert into TUYENBAY values('VCA-DAD','VCA','DAD',NULL)
insert into TUYENBAY values('VCA-VCA','VCA','VCA',NULL)
insert into TUYENBAY values('VCA-BKK','VCA','BKK',NULL)
------------------------------------------------------------------------------------------
--select * from NHANVIEN
-- THÊM DỮ LIỆU NHÂN VIÊN 

INSERT INTO NHANVIEN VALUES('1','123456780','Vũ Xuân Huy','Nam','04-02-2002','0987466322','Bình Phước')
INSERT INTO NHANVIEN VALUES('2','123456781','Võ Như Ý','Nam','03-02-2002','0987466321','Phú Yên')
INSERT INTO NHANVIEN VALUES('3','123456782','Lê Minh Trí','Nam','02-01-2002','0987466324','Bình Định')
INSERT INTO NHANVIEN VALUES('4','123456789','Nguyên Quang Phúc','Nam','01-01-2002','0987466323','Hồ Chí Minh')

-- tài khoản nhân viên -------------------------------------
insert into TAIKHOAN values('1','123456',1,'NV')
insert into TAIKHOAN values('2','123456',2,'NV')
insert into TAIKHOAN values('3','123456',3,'NV')
insert into TAIKHOAN values('4','123456',4,'NV')
insert into TAIKHOAN values ('admin','admin',NULL,'ADMIN')
-- insert into TAIKHOAN values ('admin','123456')
--select * from dbo.taikhoan
-- thêm khách hanngf 
--select * from KHACHHANG
insert into KHACHHANG values('221552880','Ngô Quang Huy','02453678947','Nam','Hòa An-Phú Hòa-Phú Yên','2002-11-09')
insert into KHACHHANG values('221552881','Vũ Xuân An','03453678947','Nam','Phú Túc-Bình Đông-Ninh Thuận','1999-06-09')
insert into KHACHHANG values('221552882','Ngô Quang A','01453678947','Nam','Linh Trung-Thủ Đức-Hồ Chí Minh','2002-02-09')
insert into KHACHHANG values('221552883','Nguyễn Tố Uyên','0145789447','Nữ','Phú Mỹ-Châu Thành-Long An','2000-11-15')
insert into KHACHHANG values('221552884','Ngô Quang C','01453622947','Nam','a','1999-07-09')
insert into KHACHHANG values('221552885','Ngô Quang D','01429678947','Nam','b','1998-11-10')

-- thêm vào máy bay ----------------------------------------------
--select * from MAYBAY
insert into MAYBAY values('B787-01','Máy bay Boeing 787',160)
insert into MAYBAY values('B747-01','Máy bay Boeing 747',200)
insert into MAYBAY values('A350-01','Máy bay Airbus 350',220)
insert into MAYBAY values('A321-01','Máy bay Airbus 321',210)
insert into MAYBAY values('A320-01','Máy bay Airbus 320',200)
insert into MAYBAY values('A350-02','Máy bay Airbus 350',220)
insert into MAYBAY values('A321-02','Máy bay Airbus 321',210)
insert into MAYBAY values('A320-02','Máy bay Airbus 320',200)

-- thêm chuyến bay ----------------------------------------------

-- Mã chuyến bay được tạo gồm : (Mã tuyến bay (Dổi dấu cách thành Ngang)) + Ngày Bay(4 chữ số giữa) + Kí hiệu(3 chữ số cuối(hàm sinh có thể tạo ra số,chữ hoặc kí tự đặc biệt))
-- VD : SGN_HAN(Mã Tuyến bay) + 1010 (ngày bay 10 tháng 10 -> tháng trước ngày sau ) + jhk(tự sinh) -> GN_HAN1010jhk
insert into CHUYENBAY values('SGN_HAN1010jhk','2022-10-10','08:00:00','00:15:00','08:15:00',40,160,'SGN-HAN','A320-01')
insert into CHUYENBAY values('SGN_HAN1110Hk9','2022-10-11','10:00:00','00:15:00','10:15:00',40,160,'SGN-HAN','A320-01')
insert into CHUYENBAY values('SGN_HAN111045K','2022-10-11','09:00:00','00:15:00','09:15:00',50,160,'SGN-HAN','A321-01')
insert into CHUYENBAY values('QTSGN_BKK1210AXC','2022-10-12','13:30:00','00:20:00','13:55:00',40,160,'SGN-BKK','A320-01')
insert into CHUYENBAY values('QTHAN_PEK1310Kgh','2022-10-13','08:00:00','00:15:00','08:15:00',43,130,'HAN-PEK','A350-01')
insert into CHUYENBAY values('HAN_SGN1410Ko7','2020-10-14','07:00:00','00:15:00','07:15:00',30,,'SGN-HAN','B787-01')
insert into CHUYENBAY values('CXR_AXD1410K78','2020-10-14','08:00:00','00:15:00','08:15:00',40,160,'CXR-DAD','A350-01')
--------------------------------- thêm hạng vé
-- Mã vé được tạo từ : Mã Chuyến bay + Mã Hạng vé (HV01 hoặc HV02)
-- Giá vé từ từ cập nhật lại :V 
insert into HANGVE values ('SGN_HAN1010jhkHV01','SGN_HAN1010jhk',1000000,7)
insert into HANGVE values ('SGN_HAN1010jhkHV02','SGN_HAN1010jhk',800000,7)
insert into HANGVE values ('SGN_HAN1110Hk9HV01','SGN_HAN1110Hk9',1200000,7)
insert into HANGVE values ('SGN_HAN1110Hk9HV02','SGN_HAN1110Hk9',900000,7)
insert into HANGVE values ('SGN_HAN111045KHV01','SGN_HAN111045K',1100000,7)
insert into HANGVE values ('SGN_HAN111045KHV02','SGN_HAN111045K',750000,7)
insert into HANGVE values ('QTSGN_BKK1210AXHV01','QTSGN_BKK1210AXC',1500000,7)
insert into HANGVE values ('QTSGN_BKK1210AXHV02','QTSGN_BKK1210AXC',1000000,7)
insert into HANGVE values ('QTHAN_PEK1310KghHV01','QTHAN_PEK1310Kgh',1300000,7)
insert into HANGVE values ('QTHAN_PEK1310KghHV02','QTHAN_PEK1310Kgh',1000000,7)
insert into HANGVE values ('HAN_SGN1410Ko7HV01','HAN_SGN1410Ko7',1000000,7)
insert into HANGVE values ('HAN_SGN1410Ko7HV02','HAN_SGN1410Ko7',800000,7)
insert into HANGVE values ('CXR_AXD1410K78HV01','CXR_AXD1410K78',900000,7)
insert into HANGVE values ('CXR_AXD1410K78HV02','CXR_AXD1410K78',600000,7)
--------------------------------------- Phiếu Đặt chỗ -----------
-- Mã Phiếu : Tạo từ hàm sinh mã  phiếu đặt chỗ ngẫu nhiên(số chữ hoặc kí tự) 
select * from CHUYENBAY
insert into PHIEUDATCHO values ('txd12KZO','2022-09-10 06:36:25','25','HV01','SGN_HAN1010jhk','221552880',7)
insert into PHIEUDATCHO values ('1123ZXH7','2022-09-10 07:38:25','26A','HV01','SGN_HAN1010jhk','221552881',7)
insert into PHIEUDATCHO values ('84875KH1','2022-10-06 09:36:25','87B','HV02','SGN_HAN1010jhk','221552882',7)
insert into PHIEUDATCHO values ('txd13kahd','2022-10-10 08:22:25','105B','HV02','SGN_HAN111045K','221552885',7)
insert into PHIEUDATCHO values ('1148759kx','2022-10-07 12:45:25','32A','HV01','SGN_HAN111045K','221552884',7)

------------------------- Phieu Hoa Don --------
-- Tạo mã Hóa đơn : Tạo tự hàm sinh mã hóa đơn ngẫu nhiên (có số chữ hoặc kí tự )
insert into HOADON values ('txrt101A','txd12KZO',1000000,'2022-09-10 06:37:40','1','221552880')
insert into HOADON values ('txrt1bbA','1123ZXH7',1000000,'2022-09-10 07:39:20','3','221552881')
insert into HOADON values ('ta3t154a','84875KH1',800000,'2022-10-06 09:38:40','2','221552882')
insert into HOADON values ('gHxrt1aa','txd13kahd',1200000,'2022-10-10 08:22:40','4','221552885')
insert into HOADON values ('KIHw193A','1148759kx',1200000,'2022-10-07 12:45:40','1','221552884')


------------------------- theem phiếu chuyến bay 
-- Mã vé chuyeenbay được tạo : (Mã Chuyến bay ) + Chuỗi (MV) -VD  SGN_HAN1010jhk + MV --> SGN_HAN1010jhk
-- tình trạng vé : Còn vé, hết thời gian update -> Hết hạn 

insert into VECHUYENBAY values ('SGN_HAN1010jhkMV','SGN_HAN1010jhk',200,'Còn vé')
insert into VECHUYENBAY values ('SGN_HAN1110Hk9MV','SGN_HAN1110Hk9',200,'Còn vé')
insert into VECHUYENBAY values ('SGN_HAN111045KMV','SGN_HAN111045K',210,'Còn vé')
insert into VECHUYENBAY values ('QTSGN_BKK1210AXCMV','QTSGN_BKK1210AXC',200,'Còn vé')
insert into VECHUYENBAY values ('QTHAN_PEK1310KghMV','QTHAN_PEK1310Kgh',170,'Còn vé')







