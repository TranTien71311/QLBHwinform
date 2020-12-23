CREATE TABLE NHANVIEN
(
MaNV int IDENTITY(0306181000,1) ,
TenNhanVien nvarchar (50) not null ,
DiaChi nvarchar (50) not null ,
DienThoai nvarchar (50) not null ,
Email nvarchar (50) not null,
ChucVu nvarchar (50) not null,
Pass nvarchar (20) not null,
NgaySinh datetime not null ,
TrangThai int default 1
primary key clustered ([MaNV] ASC)
)
CREATE TABLE KHACHHANG
(
MaKH int IDENTITY(0406181000,1),
HoTen nvarchar (50) not null,
Email nvarchar (50) not null,
DiaChi nvarchar (50) not null,
DienThoai nvarchar (50) not null,
TrangThai int default 1
primary key clustered ([MaKH] ASC)
)
CREATE TABLE NHACUNGCAP
(
MaNCC int IDENTITY(0506181000,1),
TenNhaCungCap nvarchar (50) not null ,
DiaChi nvarchar (50) not null ,
Email nvarchar (50) not null ,
TrangThai int default 1
primary key clustered ([MaNCC] ASC)

)

CREATE TABLE NHASANXUAT
(
MaNSX  int IDENTITY(0606181000,1),
TenSanPham nvarchar (50) not null ,
TrangThai int default 1
primary key clustered ([MaNSX] ASC)

)
CREATE TABLE LOAISANPHAM
(
MaLSP int IDENTITY(0706181000,1) ,
TenSanPham nvarchar (50) not null ,
TrangThai int default 1
primary key clustered ([MaLSP] ASC)

)
CREATE TABLE SANPHAM
(
MaSP int IDENTITY(0806181000,1) ,
TenSanPham nvarchar (50) not null ,
MaLSP int not null ,
MaNSX int not null ,
TrangThai int default 1
primary key clustered ([MaSP] ASC),
FOREIGN KEY (MaLSP) REFERENCES dbo.LOAISANPHAM (MaLSP),
FOREIGN KEY (MaNSX) REFERENCES dbo.NHASANXUAT (MaNSX)

)
add SoLuong int
ALTER table SanPham
add  DonGia int
CREATE TABLE HOADONBANHANG
(
MaHD int IDENTITY(0106181000,1)  ,
NgayBan datetime not null,
MaNV int not null,
MaKH int not null,
TongTien float not null,
TrangThai int default 1
primary key clustered ([MaHD] ASC),
FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG (MaKH),
FOREIGN KEY (MaNV) REFERENCES dbo.NHANVIEN (MaNV)

)
CREATE TABLE CTHOADONBANHANG
(
MaHD int not null ,
MaSP int not null,
SoLuong int not null,
DonGia int not null,
ThanhTien float not null,
TrangThai int default 1
primary key clustered ([MaHD] ASC,[MaSP] ASC),
FOREIGN KEY (MaHD) REFERENCES dbo.HOADONBANHANG (MaHD),

)
CREATE TABLE HOADONNHAPHANG
(
MaHD int IDENTITY(0206181000,1) ,
MaNV int not null,
MaNCC int not null,
NgayNhap datetime ,
TongTien float not null,
TrangThai int default 1
primary key clustered ([MaHD] ASC),
FOREIGN KEY (MaNV) REFERENCES dbo.NHANVIEN(MaNV),
FOREIGN KEY (MaNCC) REFERENCES dbo.NHACUNGCAP(MaNCC)

)

CREATE TABLE CTHOADONNHAPHANG
(
MaHD int not null ,
MaSP int not null,
SoLuong int not null,
DonGia int not null,
ThanhTien float not null,
TrangThai int default 1
primary key clustered ([MaHD] ASC,[MaSP] ASC),
FOREIGN KEY (MaHD) REFERENCES dbo.HOADONNHAPHANG (MaHD),
)

ALTER TABLE CTHOADONNHAPHANG
 ADD CONSTRAINT fk_htk_id_sanpham
  FOREIGN KEY (MaSP)
  REFERENCES dbo.SANPHAM(MaSP)
  
  ALTER TABLE CTHOADONBANHANG
 ADD CONSTRAINT fk_MaSP
  FOREIGN KEY (MaSP)
  REFERENCES dbo.SANPHAM(MaSP)
   
 --Thêm Nhân Viên
create procedure ThemNhanVien
@TenNhanVien nvarchar (50),
@DiaChi nvarchar (50),
@NgaySinh nvarchar (50) ,
@DienThoai nvarchar (50) ,
@Email nvarchar (50) ,
@ChucVu nvarchar (50) ,
@Pass nvarchar (20)
as
begin
set nocount on
insert  NHANVIEN(TenNhanVien,DiaChi,NgaySinh,DienThoai,Email,ChucVu,Pass)
values (@TenNhanVien,@DiaChi,@NgaySinh,@DienThoai,@Email,@ChucVu,@Pass)
end
--Cập Nhật Nhân Viên
create procedure SuaNhanVien
@MaNV int,
@TenNhanVien nvarchar (50),
@DiaChi nvarchar (50),
@NgaySinh nvarchar (50) ,
@DienThoai nvarchar (50) ,
@Email nvarchar (50) ,
@ChucVu nvarchar (50) ,
@Pass nvarchar (20)
as
begin
update NHANVIEN
set 
    TenNhanVien=@TenNhanVien,
	DiaChi=@DiaChi,
	NgaySinh=@NgaySinh,
	DienThoai=@DienThoai,
	Email=@Email,
	ChucVu=@ChucVu,
	Pass=@Pass
	where MaNV=@MaNV
end
--Xóa Nhân Viên
create procedure XoaNhanVien
@MaNV int
as
begin
delete from NHANVIEN
where MaNV=@MaNV
end

--Thêm Loại Sản Phẩm
create procedure ThemLoaiSP
@TenSanPham nvarchar (50) 

as
begin
set nocount on
insert  LOAISANPHAM(TenSanPham)
values (@TenSanPham)
end
--Sửa LSP
create procedure SuaLSP
@MaLSP int,
@TenSanPham nvarchar (50)
as
begin
update LOAISANPHAM
set
    TenSanPham=@TenSanPham
	where MaLSP=@MaLSP
end
--Xóa LSP
create procedure XoaLSP
@MaLSP int
as
begin
delete from LOAISANPHAM
where MaLSP=@MaLSP
end
--Thêm NSX
create procedure ThemNSX
@TenSanPham nvarchar (50) 

as
begin
set nocount on
insert  NHASANXUAT(TenSanPham)
values (@TenSanPham)
end
--Sửa NSX
create procedure SuaNSX
@MaNSX int,
@TenSanPham nvarchar (50)
as
begin
update NHASANXUAT
set 
    TenSanPham=@TenSanPham
	where MaNSX=@MaNSX
end
--Xóa NSX
create procedure XoaNSX
@MaNSX nvarchar (50)
as
begin
delete from NHASANXUAT
where MaNSX=@MaNSX
end
--Thêm SP
create procedure ThemSanPham
@TenSanPham nvarchar (50),
@MaLSP nvarchar (50),
@MaNSX nvarchar (50) ,
@SoLuong int,
@DonGia int
as
begin
set nocount on
insert  SANPHAM(TenSanPham,MaLSP,MaNSX,SoLuong,DonGia)
values (@TenSanPham,@MaLSP,@MaNSX,@SoLuong,@DonGia)
end
--Sửa SP
create procedure SuaSanPham
@MaSP int,
@TenSanPham nvarchar (50),
@MaLSP nvarchar (50),
@MaNSX nvarchar (50) ,
@SoLuong int,
@DonGia int
as
begin
update SANPHAM
set 
    TenSanPham=@TenSanPham,
	MaLSP=@MaLSP,
	MaNSX=@MaNSX,
	SoLuong=@SoLuong,
	DonGia=@DonGia
	where MaSP=@MaSP
end
--Xóa Sp
create procedure XoaSanPham
@MaSP int
as
begin
delete from SANPHAM
where MaSP=@MaSP
end
--Thêm KH
create procedure ThemKhachHang
@TenKH nvarchar (50),
@Email nvarchar (50),
@DiaChi nvarchar (50) ,
@DienThoai int
as
begin
set nocount on
insert  KHACHHANG(HoTen,Email,DiaChi,DienThoai)
values (@TenKH,@Email,@DiaChi,@DienThoai)
end
--Sửa KH
create procedure SuaKhachHang
@MaKH int,
@TenKH nvarchar (50),
@Email nvarchar (50),
@DiaChi nvarchar (50) ,
@DienThoai int
as
begin
update KHACHHANG
set 
    HoTen=@TenKH,
	Email=@Email,
	DiaChi=@DiaChi,
	DienThoai=@DienThoai
	where MaKH=@MaKH
end
--Xóa KH
create procedure XoaKhachHang
@MaKH int
as
begin
delete from KHACHHANG
where MaKH=@MaKH
end
--Thêm NCC
create procedure ThemNhaCC
@TenNhaCungCAp nvarchar (50) ,
@DiaChi nvarchar (50) ,
@Email nvarchar (50) 
as
begin
set nocount on
insert NHACUNGCAP (TenNhaCungCAp,DiaChi,Email)
values (@TenNhaCungCAp,@DiaChi,@Email)
end
--Sửa NCC
create procedure SuaNhaCC
@MaNCC int,
@TenNhaCungCAp nvarchar (50) ,
@DiaChi nvarchar (50) ,
@Email nvarchar (50) 
as
begin
update NHACUNGCAP
set 
    TenNhaCungCAp=@TenNhaCungCAp,
	DiaChi=@DiaChi,
	Email=@Email
	where MaNCC=@MaNCC
end
--Xóa NCC
create procedure XoaNhaCC
@MaNCC nvarchar (50)
as
begin
delete from NHACUNGCAP
where MaNCC=@MaNCC
end

--Tao HD Nhập
create procedure TaoHoaDonNhap
@MaNV int ,
@MaNCC int ,
@NgayNhap datetime ,
@TongTien float
as
begin
set nocount on
insert HOADONNHAPHANG(MaNV,MaNCC,NgayNhap,TongTien)
values (@MaNV,@MaNCC,@NgayNhap,@TongTien)
end
--Thêm HD Nhập
alter procedure ThemCTHoaDonNhap
@MaHD int,
@MaSP int ,
@SoLuong int  ,
@SoLuongc int  ,
@DonGia int,
@ThanhTien float
as
begin
set nocount on
insert CTHOADONNHAPHANG(MaHD,MaSP,SoLuong,DonGia,ThanhTien)
values (@MaHD,@MaSP,@SoLuong,@DonGia,@ThanhTien)
update SANPHAM
set SoLuong = @SoLuongc
where MaSP = @MaSP
end
--Tổng Tiền Nhập
create procedure TongTienNhap
@MaHD int,
@TongTien float
as
begin
update HOADONNHAPHANG
set TongTien = @TongTien
where MaHD = @MaHD
end
--Lưu HD Nhập
create procedure LuuHDNhap
@MaHD int,
@MaNV int ,
@MaNCC int ,
@NgayNhap datetime ,
@TongTien float
as
begin
update HOADONNHAPHANG 
set 
    MaNCC=@MaNCC,
	MaNV=@MaNV,
	NgayNhap=@NgayNhap,
	TongTien=@TongTien
	
where MaHD = @MaHD
update CTHOADONNHAPHANG
set TrangThai =0
where MaHD = @MaHD
end
--Tạo HD Ban
alter procedure TaoHoaDon
@MaNV int ,
@MaKH int ,
@NgayBan datetime ,
@TongTien float
as
begin
set nocount on
insert HOADONBANHANG(MaNV,MaKH,NgayBan,TongTien)
values (@MaNV,@MaKH,@NgayBan,@TongTien)
end
--Thêm CTHD
create procedure ThemCTHoaDon
@MaHD int,
@MaSP int ,
@SoLuong int  ,
@SoLuongc int  ,
@DonGia int,
@ThanhTien float
as
begin
set nocount on
insert CTHOADONBANHANG(MaHD,MaSP,SoLuong,DonGia,ThanhTien)
values (@MaHD,@MaSP,@SoLuong,@DonGia,@ThanhTien)
update SANPHAM
set SoLuong = @SoLuongc
where MaSP = @MaSP
end
--Tong tien HD
create procedure TongTien
@MaHD int,
@TongTien float
as
begin
update HOADONBANHANG
set TongTien = @TongTien
where MaHD = @MaHD
end
--Luu HD
create procedure LuuHD
@MaHD int,
@MaNV int,
@MaKH int ,
@NgayBan datetime ,
@TongTien float
as
begin
update HOADONBANHANG 
set 
    MaKH=@MaKH,
	MaNV=@MaNV,
	NgayBan=@NgayBan,
	TongTien=@TongTien
	
where MaHD = @MaHD
update CTHOADONBANHANG
set TrangThai =0
where MaHD = @MaHD
end
--NV Ban Tốt
create procedure TimNVBanTot
as
SELECT n.TenNhanVien as 'Tên Nhân Viên',SUM(TongTien)as 'Tổng Tiền Bán Được'

FROM (NHANVIEN n INNER JOIN HOADONBANHANG h

        ON n.MaNV=h.MaNV)

        INNER JOIN CTHOADONBANHANG c

        ON h.MaHD=c.MaHD

GROUP BY n.TenNhanVien

HAVING SUM(TongTien)>= ALL

         (SELECT sum(TongTien)

            FROM (NHANVIEN n INNER JOIN HOADONBANHANG h

                    ON n.MaNV=h.MaNV)

                    INNER JOIN CTHOADONBANHANG c ON

                    h.MaHD=c.MaHD

            GROUP BY n.TenNhanVien)
--Tim KH Mua Nhieu Nhat
create procedure TimKHVip
as
SELECT k.MAKH as 'Mã Khách Hàng',HoTen as 'Tên Khách Hàng',COUNT(MaHD)as'Số Lần Mua'
FROM KHACHHANG k ,HOADONBANHANG c
WHERE k.MAKH = (SELECT TOP 1 MAKH
FROM HOADONBANHANG
GROUP BY MAKH
ORDER BY COUNT(DISTINCT MaHD) DESC) and k.MaKH=c.MaKH
group by  k.MAKH, HOTEN
--Thong Ke San Pham
create procedure ThogKe
as
select TenSanPham as 'Tên Sản Phẩm',n.SoLuong as'Số Lượng Nhập',n.DonGia as'Giá Nhập',Sum(c.SoLuong) as'Đã Bán Được',s.DonGia as'Giá Bán',(s.DonGia-n.DonGia)*Sum(c.SoLuong) as'Tiền Lời'
from SANPHAM s,CTHOADONBANHANG c,CTHOADONNHAPHANG n
where s.MaSP=c.MaSP and s.MaSP=n.MaSP and c.MaSP=n.MaSP
group by TenSanPham ,n.SoLuong ,n.DonGia,s.DonGia
--DoanhThu ngay
create procedure DoanhThuNgay
as
SELECT Day(NgayBan) as 'Ngày', SUM(TongTien) AS 'Doanh Thu'
FROM HOADONBANHANG
GROUP BY day(NgayBan)
--DoanhThu Thang
create procedure DoanhThuThang
as
SELECT MONTH(NgayBan) AS 'Tháng', SUM(TongTien) AS 'Doanh Thu'
FROM HOADONBANHANG
GROUP BY MONTH(NgayBan)
--Doanh Thu Nam
create procedure DoanhThuNam
as
SELECT year(NgayBan) as 'Năm', SUM(TongTien) AS 'Doanh Thu'
FROM HOADONBANHANG
GROUP BY year(NgayBan)
--Tong Bán
create procedure TongBan 
as
select sum(c.TongTien)as'Tổng Số Tiền Nhập'
from HOADONNHAPHANG c
--Tong Nhap
create procedure TongNhap
as
select sum(b.TongTien)'Tổng Số Tiền Bán'
from HOADONBANHANG b

SELECT MaSP as'Mã Sản Phẩm' ,TenSanPham as'Tên Sản Phẩm'
 FROM SANPHAM