create procedure Timkiem_tenthuoc1
@tent nvarchar(50)
as
	select * from ChiTietHoaDonNhap join Thuoc on ChiTietHoaDonNhap.MaThuoc=Thuoc.MaThuoc and Thuoc.TenThuoc like N'%'+@tent+'%'
return