
create proc [getDsHoaDon]
	@madp char(5)
as
begin
	select hd.mahd,hd.ngaylap,dp.madp,dp.makh,kh.hoten,dp.tenloaiphong,dp.soluong,dp.ngayden,dp.ngaydi,hd.tongtien
	from hoadon as hd,datphong as dp,khachhang as kh
	where hd.madp=dp.madp and dp.makh = kh.makh and hd.madp = @madp
end

