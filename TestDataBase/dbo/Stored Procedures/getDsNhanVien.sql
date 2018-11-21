
create proc [getDsNhanVien]
as
begin
	select manv,tencv,hoten,ngaysinh,gioitinh,sdt,cmnd,diachi,email
	from nhanvien,chucvu
	where nhanvien.macv = chucvu.macv
end

