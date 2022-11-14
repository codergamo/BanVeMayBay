use QUANLYCHUYENBAY
go
create view XEMNHANVIEN 
as 
	select * from NHANVIEN 
go
CREATE TRIGGER CHECK_CMND_NHANVIEN
ON NHANVIEN
INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted WHERE CMND IN
	(
	SELECT CMND
	FROM NHANVIEN
	))
	BEGIN
		PRINT N'Không được chèn 2 nhân viên cùng CMND'
		ROLLBACK TRANSACTION 
	END
	ELSE
	BEGIN
	     INSERT INTO NHANVIEN
       SELECT MaNV,CMND,TenNV,SDT,GioiTinh,Diachi,NgaySinh
       FROM inserted
	END
END
go
go
create proc ThemNV
@MaNV char(20), @CMND char(20), @TenNV nvarchar(45), @GioiTinh nvarchar(20), @NgaySinh date, @SDT  char(20),@Diachi nvarchar(100)
as
begin
	if (@MaNV ='' or @CMND='' or @TenNV= '')
		begin
			print N'THÊM NHANVIEN KHÔNG THÀNH CÔNG, DO MaNV=NULL'
		end
	else
		begin
			if exists (select * from NHANVIEN where MaNV =@MaNV)
				begin
					print N'THÊM NHANVIEN KHÔNG THÀNH CÔNG, DO TRÙNG MaNV'
				end
			else 
				begin
					if exists (select * from NHANVIEN where CMND = @CMND)
						begin
							print N'THÊM NHANVIEN KHÔNG THÀNH CÔNG, DO TRÙNG CMND'
						end
					else
						begin
							insert into NHANVIEN values(@MaNV,@CMND,@TenNV,@GioiTinh,@NgaySinh,@SDT,@Diachi)
						end
				end
		end
end
go

create proc XoaNV
@MaNV char(20)
as
begin
	if exists (select * from NHANVIEN where MaNV=@MaNV)
		begin 
			if not exists (select * from TAIKHOAN where ID_NhanVien = @MaNV)
				begin
					delete from NHANVIEN where MaNV = @MaNV
				end
			else
				begin
					print N'XÓA NHANVIEN KHÔNG THÀNH CÔNG'
				end
		end
	else
		begin
			print N'XÓA NHANVIEN KHÔNG THÀNH CÔNG'
		end
end

create proc ChinhSuaNV
@MaNV char(20), @CMND char(20), @TenNV nvarchar(45), @GioiTinh nvarchar(20), @NgaySinh date, @SDT  char(20),@Diachi nvarchar(100)
as 
begin
	if exists (select * from NHANVIEN where MaNV=@MaNV)
		begin
			update NHANVIEN
			set
			CMND =@CMND,
			TenNV = @TenNV,
			GioiTinh = @GioiTinh,
			NgaySinh = @NgaySinh,
			SDT = @SDT,
			Diachi = @Diachi
			where MaNV = @MaNV
		end
	else
		begin
			print N'CHỈNH SỬA NHANVIEN KHÔNG THÀNH CÔNG, DO KHÔNG TỒN TẠI MaNV'
		end
end
go
create function TimKiem_NV(@str nvarchar(50))
returns table
as
	return (
	select * from NHANVIEN 
	where MaNV like CONCAT('%',@str,'%') or CMND like CONCAT('%',@str,'%') or TenNV like CONCAT('%',@str,'%'))
go