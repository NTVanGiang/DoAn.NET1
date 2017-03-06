
create trigger tg_HoaDonNhap
on HoaDonNhap
instead of delete
as
begin
	declare @MaHDN int=(select MaHDN from deleted);
	delete from ChiTietHoaDonNhap where MaHDN=@MaHDN;
	delete from HoaDonNhap where MaHDN=@MaHDN;
end