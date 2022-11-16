--create proc PHANQUYEN 
--@Username char(20)
--as 
--begin
--	declare @role char(20)
--	set @role = (select PHANLOAI from TAIKHOAN where TenTaiKhoan = @Username)
--
--	if @role = '1'
--		print N'Bạn có quyền Admin'
--	else print N'Bạn có quyền Employee'
--end

create function Dang_Nhap(@Username char(20), @Password char(20))
returns table 
as 
	return (select * from TAIKHOAN where TenTaiKhoan = @Username and MatKhau = @Password)
select * from Dang_Nhap('','')
