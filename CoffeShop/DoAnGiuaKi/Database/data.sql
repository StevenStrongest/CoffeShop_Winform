create database QuanLyNhaHang;
go
use QuanLyNhaHang;
go
--Tạo bảng Tầng--
create table Tang(
idTang int IDENTITY primary key,
tenTang nvarchar(100) NOT NULL
);
go
--Tạo bảng Bàn--
create table Ban(
idBan int IDENTITY primary key,
tenBan nvarchar(100) NOT NULL,
trangthai nvarchar(100) NOT NULL,
idTang int NOT NULL,
Foreign key(idTang) references Tang(idTang)
);
go
--Tạo bảng Loại thức ăn--
create table LoaiThucAn(
idLoaiTA int IDENTITY primary key,
tenLoai nvarchar(500) NOT NULL
);
go
--Tạo bảng Loại thức ăn--
create table ThucAn(
idTA int IDENTITY primary key,
tenTA nvarchar(550) NOT NULL,
gia int NOT NULL,
idLoaiTA int NOT NULL,
Foreign key(idLoaiTA) references LoaiThucAn(idLoaiTA)
);
go
--Tạo bảng Hóa Đơn--
create table HoaDon(
idHoaDon int IDENTITY primary key,
idBan int NOT NULL,
ngayNhan date,
trangthai nvarchar(100) NOT NULL,
Foreign key(idBan) references Ban(idBan)
);
go
--Tạo bảng Thông tin Hóa Đơn--
create table thongtinHoaDon(
idThontin int IDENTITY primary key,
idHoaDon int NOT NULL,
idTA int NOT NULL,
soluong int NOT NULL,
Foreign key(idHoaDon) references HoaDon(idHoaDon),
Foreign key(idTA) references ThucAn(idTA)
);
go
--Tạo bảng Tài khoản--
create  table TaiKhoan(
tenTaiKhoan nvarchar(200) primary key,
matkhau nvarchar(1000) NOT NULL,
loaiTK int DEFAULT 2 --1: Admin , 2: Nhan Vien Đặt Món ,3: Đầu Bếp --
);
go


--Tạo bảng Đặt Bàn--
create table DatBan(
idDat int IDENTITY primary key,
tenKhachHang nvarchar(1000),
sdt varchar(10),
idBan int,
NgayDat DateTime,
trangthai int,
Ghichu nvarchar(3000),
foreign key(idBan) references Ban(idBan)
);
go
--Thêm thông tin bảng tài khoản--
insert into TaiKhoan values(N'Admin','26042001',1);
insert into TaiKhoan values(N'Order','1234',2);
go
--Thêm thông tin bảng Tầng--
insert into Tang(tenTang) values(N'Tầng 1');
insert into Tang(tenTang) values(N'Tầng 2');
insert into Tang(tenTang) values(N'Tầng 3');
go
--Thêm thông tin bảng Bản--
--Tầng 1
DECLARE @i int = 1
WHILE(@i <= 20)
BEGIN
insert into Ban(tenBan,trangthai,idTang) values(N'Bàn' + CAST(@i as nvarchar(100)), N'Trống', 1)
SET @i = @i + 1
END
go
--Tầng 2
DECLARE @i int = 21
WHILE(@i <= 40)
BEGIN
insert into Ban(tenBan,trangthai,idTang) values(N'Bàn' + CAST(@i as nvarchar(100)), N'Trống', 2)
SET @i = @i + 1
END
go
--Tầng 3
DECLARE @i int = 41
WHILE(@i <= 60)
BEGIN
insert into Ban(tenBan,trangthai,idTang) values(N'Bàn' + CAST(@i as nvarchar(100)), N'Trống', 3)
SET @i = @i + 1
END
go
--Thêm thông tin bảng Loại thức ăn--
insert into LoaiThucAn(tenLoai) values(N'Hải Sản');
insert into LoaiThucAn(tenLoai) values(N'Đồ uống');
insert into LoaiThucAn(tenLoai) values(N'Tráng Miệng');
insert into LoaiThucAn(tenLoai) values(N'Hoa quả');
insert into LoaiThucAn(tenLoai) values(N'Combo đặc biệt');
insert into LoaiThucAn(tenLoai) values(N'Combo gia đình');
go
select * from LoaiThucAn;
select * from ThucAn;
go
--Thêm thông tin bảng Thức Ăn--
select * from ThucAn;
--Hải sản
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Cá ngừ đại dương Phú Yên',200000,1);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Sò huyết đầm Ô Loan',120000,1);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Tôm hùm Bình Ba',20000000,1);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Mực 1 nắng Phan Thiết',80000,1);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Còi biên mai Phú Quốc',50000,1);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Tôm tít Cà Mau',150000,1);
--Đồ uống--
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Sữa tươi trân châu đường đen',40000,2);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Trà đào chanh sả',25000,2);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Cafe latte',50000,2);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Trà phô mai kem sữa',35000,2);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Matcha đá xay',40000,2);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'CoCa',20000,2);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Pesi',20000,2);
--Tráng Miệng--
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Bánh đậu đỏ hấp',40000,3);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Bánh đậu xanh',20000,3);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Dâu tây đá bào',25000,3);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Soup thập cập',45000,3);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Bánh crepe lá dứa',43000,3);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Chè bắp',15000,3);
--Hoa quả--
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Cam',5000,4);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Thanh Long',10000,4);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Dâu Tây',40000,4);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Kiwi',25000,4);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Nho',45000,4);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Táo',16000,4);
--Combo đặc biệt--
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Combo Tôm Hùm Đặc Biệt',5000000,5);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Combo Cá Song Hoa',3000000,5);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Combo Shushi Đặc Biệt',3762700,5);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Combo Cua Hoàng Đế',7569999,5);
--Combo gia đình--
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Lẩu hải sản thập cẩm',200000,6);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N'Salad Kiểu Nhật',175000,6);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N' Mực trứng chiên bơ',86000,6);
insert into ThucAn(tenTA,gia,idLoaiTA) values(N' Nem hải sản hoa quả',77650,6);
go
--Thêm thông tin bảng Hóa Đơn--
insert into HoaDon(idBan,ngayNhan,trangthai) values(294628,GETDATE(),N'Đã thanh toán');
insert into HoaDon(idBan,ngayNhan,trangthai) values(294631,GETDATE(),N'Chưa thanh toán');
insert into HoaDon(idBan,ngayNhan,trangthai) values(294640,GETDATE(),N'Đã thanh toán');
--Thêm thông tin bảng Thông tin hóa đơn--
go
insert into thongtinHoaDon(idHoaDon,idTA,soluong) values(1,1,1);
insert into thongtinHoaDon(idHoaDon,idTA,soluong) values(1,12,3);
insert into thongtinHoaDon(idHoaDon,idTA,soluong) values(2,26,1);
insert into thongtinHoaDon(idHoaDon,idTA,soluong) values(2,9,2);
go
--Thêm thông tin bảng Đặt Bàn--
insert into DatBan(tenKhachHang,sdt,idBan,NgayDat,trangthai,Ghichu) values(N'Phạm Đức Mạnh', '0971439061', 294653 ,GETDATE(), 0, N'Đi một mình');
go
----Thêm cột tổng tiên cho bảng hóa đơn--
alter table HoaDon add tongtien int;
go

select * from ThucAn;
delete from ThucAn where idTA = 59;
select * from DatBan ;
select * from Ban where idBan = 294647;
Select *from HoaDon;
select * from thongtinHoaDon;
select * from HoaDon  where idBan = 294628 and trangthai = N'Chưa thanh toán';
select MAX(idHoaDon) from HoaDon;
select * from TaiKhoan;
select * from Tang
select * from DatBan;
select idDat,tenKhachHang,sdt,NgayDat,DatBan.trangthai,Ghichu,tenBan from DatBan inner join Ban on DatBan.idBan = Ban.idBan;
go
select idDat,tenKhachHang,sdt,NgayDat,DatBan.trangthai,Ghichu,tenBan from DatBan inner join Ban on DatBan.idBan = Ban.idBan
delete from DatBan where trangthai = 1;
delete from thongtinHoaDon where idThontin = 27;
select DISTINCT ThucAn.idTA from thongtinHoaDon,ThucAn where thongtinHoaDon.idTA  = ThucAn.idTA
select hd.idHoaDon, hd.ngayNhan, hd.trangthai, hd.tongtien, b.tenBan from HoaDon as hd, Ban as b where ngayNhan >= '20200903' and ngayNhan <= '20200911' and hd.trangthai = N'Đã thanh toán' and hd.idBan = b.idBan;

select idTA,COUNT(tenTA) as t from ThucAn group by idTA having count(tenTA) = 1;
select thongtinHoaDon.idTA,ThucAn.tenTA from thongtinHoaDon,ThucAn where thongtinHoaDon.idTA = 1;
select * from DatBan;
select ta.idTA,ta.tenTA,ta.gia,tt.soluong from HoaDon as hd, thongtinHoaDon as tt, ThucAn as ta where tt.idHoaDon = hd.idHoaDon and tt.idTA = ta.idTA and hd.trangthai = N'Chưa thanh toán'