create database [QLBanVe]
--drop database [QLBanVe]
use [QLBanVe]
CREATE TABLE b_PHONG
(
  MaPhong NVARCHAR(50) NOT NULL,
  TenPhong NVARCHAR(255) NULL,
  SLGhe INT NULL,
  PRIMARY KEY (MaPhong)
);

CREATE TABLE b_NHANVIEN
(
  MaNV NVARCHAR(50) NOT NULL,
  SDT INT  NULL,
  UserName NVARCHAR(255) NOT  NULL,
  MatKhau NVARCHAR(255) NOT NULL,
  TenNV NVARCHAR(255)  NULL,
  VaiTro NVARCHAR(255) NOT NULL,
  NgayBatDau DATE  NULL,
  IsDeleted int  NULL,
  Email NVARCHAR(255)  NULL,
  GioiTinh NVARCHAR(50)  NULL,
  PRIMARY KEY (MaNV)
);

CREATE TABLE b_SANPHAM
(
  MaSP NVARCHAR(50) NOT NULL,
  TenSP NVARCHAR(255)  NULL,
  LoaiSP NVARCHAR(255)  NULL,
  AnhSP NVARCHAR(255)  NULL,
  DonGia Money  NULL,
  SL INT  NULL,
  PRIMARY KEY (MaSP)
);

CREATE TABLE b_KHACHHANG
(
  MaKH NVARCHAR(50) NOT NULL,
  TenKH NVARCHAR(255)  NULL,
  SDT INT  NULL,
  Email NVARCHAR(255)  NULL,
  PRIMARY KEY (MaKH)
);

CREATE TABLE b_GHE
(
  MaGhe NVARCHAR(50) NOT NULL,
  TrangThai int  NULL,
  DonGia Money  NULL,
  MaPhong NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaGhe),
  FOREIGN KEY (MaPhong) REFERENCES b_PHONG(MaPhong)
);

CREATE TABLE b_NuocSanXuat
(
  MaNuocSX NVARCHAR(50) NOT NULL,
  TenNuocSX NVARCHAR(255)  NULL,
  PRIMARY KEY (MaNuocSX)
);

CREATE TABLE b_TheLoai
(
  MaTheLoai NVARCHAR(50) NOT NULL,
  TenTheLoai NVARCHAR(255)  NULL,
  PRIMARY KEY (MaTheLoai)
);

CREATE TABLE b_HangSanXuat
(
  MaHangSX NVARCHAR(50) NOT NULL,
  TenHangSX NVARCHAR(255)  NULL,
  PRIMARY KEY (MaHangSX)
);

CREATE TABLE b_Voucher
(
  MaVouher NVARCHAR(50) NOT NULL,
  Code INT  NULL,
  TrangThai int  NULL,
  TenVoucher NVARCHAR(255)  NULL,
  PRIMARY KEY (MaVouher)
);

CREATE TABLE b_CT_VOUCHER
(
  NgayBatDau DATE  NULL,
  NgayKetThuc DATE  NULL,
  MaKH NVARCHAR(50) NOT NULL,
  MaVouher NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaKH, MaVouher),
  FOREIGN KEY (MaKH) REFERENCES b_KHACHHANG(MaKH),
  FOREIGN KEY (MaVouher) REFERENCES b_Voucher(MaVouher)
);

CREATE TABLE b_PHIM
(
  MaPhim NVARCHAR(50) NOT  NULL,
  TenPhim NVARCHAR(255)  NULL,
  DaoDien NVARCHAR(255)  NULL,
  NgayKhoiChieu DATE  NULL,
  NgayKetThuc DATE  NULL,
  DienVienChinh NVARCHAR(255)  NULL,
  NoiDungChinh NVARCHAR(255)  NULL,
  AnhPhim NVARCHAR(255)  NULL,
  TongThu Money  NULL,
  TongChiPhi Money  NULL,
  MaNuocSX NVARCHAR(50) NOT NULL,
  MaTheLoai NVARCHAR(50) NOT  NULL,
  MaHangSX NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaPhim),
  FOREIGN KEY (MaNuocSX) REFERENCES b_NuocSanXuat(MaNuocSX),
  FOREIGN KEY (MaTheLoai) REFERENCES b_TheLoai(MaTheLoai),
  FOREIGN KEY (MaHangSX) REFERENCES b_HangSanXuat(MaHangSX)
);

CREATE TABLE b_HOADON
(
  MaHD NVARCHAR(50) NOT NULL,
  NgayLap DATETIME NULL,
  GiamGia money  NULL,
  TongTien Money  NULL,
  MaNV NVARCHAR(50) NOT NULL,
  MaKH NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaHD),
  FOREIGN KEY (MaNV) REFERENCES b_NHANVIEN(MaNV),
  FOREIGN KEY (MaKH) REFERENCES b_KHACHHANG(MaKH)
);

CREATE TABLE b_LICHCHIEU
(
  NgayChieu DATE  NOT NULL,
  TGBatDauChieu TIME NOT  NULL,
  TGKetThucChieu TIME NOT NULL,
  MaPhong NVARCHAR(50) NOT  NULL,
  MaPhim NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaPhong, MaPhim, NgayChieu, TGBatDauChieu),
  FOREIGN KEY (MaPhong) REFERENCES b_PHONG(MaPhong),
  FOREIGN KEY (MaPhim) REFERENCES b_PHIM(MaPhim)
);

CREATE TABLE CT_HOADON_SP
(
  SL INT  NULL,
  DonGia Money  NULL,
  MaHD NVARCHAR(50) NOT  NULL,
  MaSP NVARCHAR(50) NOT  NULL,
  PRIMARY KEY (MaHD, MaSP),
  FOREIGN KEY (MaHD) REFERENCES b_HOADON(MaHD),
  FOREIGN KEY (MaSP) REFERENCES b_SANPHAM(MaSP)
);

CREATE TABLE b_VE
(
  MaVe NVARCHAR(50) NOT NULL,
  MaHD NVARCHAR(50)  NULL,
  MaPhong NVARCHAR(50) NOT NULL,
  MaPhim NVARCHAR(50)  NOT NULL,
  MaGhe NVARCHAR(50) NOT  NULL,
  NgayChieu DATE NOT NULL,
  TGBatDauChieu TIME NOT NULL,
  PRIMARY KEY (MaVe),
  FOREIGN KEY (MaHD) REFERENCES b_HOADON(MaHD),
  FOREIGN KEY (MaGhe) REFERENCES b_GHE(MaGhe),
  FOREIGN KEY (MaPhong, MaPhim, NgayChieu,TGBatDauChieu) REFERENCES b_LICHCHIEU(MaPhong, MaPhim, NgayChieu,TGBatDauChieu)
);



insert into b_NuocSanXuat(MaNuocSX, TenNuocSX) values('N01', N'VietNam')
insert into b_NuocSanXuat(MaNuocSX, TenNuocSX) values('N02', N'Hàn Quốc')
insert into b_NuocSanXuat(MaNuocSX, TenNuocSX) values('N03', N'Mỹ')
insert into b_NuocSanXuat(MaNuocSX, TenNuocSX) values('N04', N'Trung Quốc')
insert into b_NuocSanXuat(MaNuocSX, TenNuocSX) values('N05', N'Nhật Bản')

insert into b_HangSanXuat(MaHangSX, TenHangSX) values('H01',N'Truyền hình Hà Nội')
insert into b_HangSanXuat(MaHangSX, TenHangSX) values('H02',N'Sa rang he yoo')
insert into b_HangSanXuat(MaHangSX, TenHangSX) values('H03',N'Family')
insert into b_HangSanXuat(MaHangSX, TenHangSX) values('H04',N'Douyin')
insert into b_HangSanXuat(MaHangSX, TenHangSX) values('H05',N'Toyokiota')

insert into b_TheLoai(MaTheLoai, TenTheLoai) values('TL01',N'Tâm lý tình cảm')
insert into b_TheLoai(MaTheLoai, TenTheLoai) values('TL02',N'Hành động')
insert into b_TheLoai(MaTheLoai, TenTheLoai) values('TL03',N'Hoạt hình')
insert into b_TheLoai(MaTheLoai, TenTheLoai) values('TL04',N'Kinh dị')
insert into b_TheLoai(MaTheLoai, TenTheLoai) values('TL05',N'Quái thú')

insert into b_PHIM(MaPhim, TenPhim, DaoDien,NgayKhoiChieu, NgayKetThuc,DienVienChinh,NoiDungChinh,AnhPhim,TongThu, TongChiPhi, MaNuocSX,MaTheLoai,MaHangSX) 
			values('P0001',N'Tây Du Ký',N'Dương Khiết','1996-09-01','2024-12-01',N'Lục Tiểu Linh Đồng, Từ Thiếu Hoa',N'Kể về thầy trò đường tăng đi tây trúc thỉnh kinh',null,9600000000, 5000000000, 'N04','TL02','H02')
insert into b_PHIM(MaPhim, TenPhim, DaoDien,NgayKhoiChieu, NgayKetThuc,DienVienChinh,NoiDungChinh,AnhPhim,TongThu, TongChiPhi, MaNuocSX,MaTheLoai,MaHangSX) 
			values('P0002',N'Mắt biếc',N'Thanh Hà','2021-10-09','2023-08-21',N'Ngạn, Bông',N'Kể về mối tính ngây thơ của hai học sinh',null,1200000000, 600000000, 'N01','TL01','H01')
insert into b_PHIM(MaPhim, TenPhim, DaoDien,NgayKhoiChieu, NgayKetThuc,DienVienChinh,NoiDungChinh,AnhPhim,TongThu, TongChiPhi, MaNuocSX,MaTheLoai,MaHangSX) 
			values('P0003',N'Người nhện Spidermen',N'Aler Jonh','2023-12-01','2025-10-01',N'Mr Walker, Ms Adamli',N'Cuộc giải cứu thế giới của người nhện cùng với đó là tình yêu của con người và robot',null,32000000000, 12000000000, 'N03','TL02','H03')

insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P001', N'Phòng 01', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P002', N'Phòng 02', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P003', N'Phòng 03', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P004', N'Phòng 03', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P005', N'Phòng 03', 72)

insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('A09', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('B09', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('C09', 'P001', 0 , 50000)


insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('D09', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('E09', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F09', 'P001', 0 , 50000)

insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('G09', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('H09', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F01', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F02', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F03', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F04', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F05', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F06', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F07', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F08', 'P001', 0 , 50000)
insert into b_GHE(MaGhe, MaPhong, TrangThai, DonGia) values ('F09', 'P001', 0 , 50000)

insert into b_NHANVIEN(MaNV,TenNV, UserName, MatKhau, VaiTro, GioiTinh,SDT, NgayBatDau,IsDeleted, Email )
			values('NV0001', N'Nguyễn Thị Thu Uyên', 'uyennguyen', '123',N'Nhân viên',N'Nữ', 0342962825, '2022-09-10', 0, 'nguyenthithuuyen03022003@gmail.com')
insert into b_NHANVIEN(MaNV,TenNV, UserName, MatKhau, VaiTro, GioiTinh,SDT, NgayBatDau,IsDeleted, Email )
			values('NV0002', N'Đào Minh Quang', 'minhquang', '12345',N'Quản lý',N'Nam', 0964625712, '2010-05-07', 0, 'quangdao@gmail.com')


insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP001', N'Bỏng ngô', N'Đồ ăn',null, 30000, 56)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP002', N'Nước pepsi', N'Đồ uống',null, 16000, 30)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP003', N'Nước Miranda',N'Đồ uống', null, 12000, 100)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP004', N'Snack Khoai Tây',N'Đồ ăn', null, 15000, 33)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP005', N'Porcorn',N'Đồ ăn', 'porcorn1.jpg', 15000, 33)




insert into b_KHACHHANG(MaKH, TenKH, SDT, Email) values ('KH0001', N'Nguyễn Thị Thu Hà', 0965587423, null)
insert into b_KHACHHANG(MaKH, TenKH, SDT, Email) values ('KH0002', N'Vũ Thị Thu Hiền', 0378753648, null)
insert into b_KHACHHANG(MaKH, TenKH, SDT, Email) values ('KH0003', N'Nguyễn Thị Ngọc', 0469255873, null)

insert into b_HOADON(MaHD, NgayLap, GiamGia, TongTien, MaNV, MaKH) values ('HD0001','2022-10-11 20:10:00',0,0,'NV0001','KH0003')

insert into CT_HOADON_SP(MaHD, MaSP, SL, DonGia) values ('HD0001', 'SP002', 2, 16000)

insert into b_LICHCHIEU(MaPhong, MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu) values ('P001', 'P0001', '2022-10-12', '19:00:00', '21:00:00')
insert into b_LICHCHIEU(MaPhong, MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu) values ('P001', 'P0001', '2022-10-12', '21:30:00', '23:30:00')
insert into b_LICHCHIEU(MaPhong, MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu) values ('P002', 'P0001', '2022-10-12', '21:30:00', '23:30:00')
insert into b_LICHCHIEU(MaPhong, MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu) values ('P002', 'P0001', '2022-10-12', '15:30', '17:30:00')

insert into b_VE(MaVe, MaHD, MaGhe, MaPhong, MaPhim, NgayChieu, TGBatDauChieu) values('V0001', 'HD0001', 'A01','P001','P0001','2022-10-12','19:00:00')
insert into b_VE(MaVe, MaHD, MaGhe, MaPhong, MaPhim, NgayChieu, TGBatDauChieu) values('V0002', 'HD0001', 'A02','P001','P0001','2022-10-12','19:00:00')

select b_HOADON.MaHD,b_HOADON.NgayLap ,b_HOADON.MaNV, b_HOADON.MaKH, CT_HOADON_SP.MaSP, CT_HOADON_SP.SL, CT_HOADON_SP.DonGia, b_VE.MaVe, b_VE.NgayChieu, b_VE.MaPhong, b_VE.TGBatDauChieu, b_VE.MaGhe
from b_HOADON inner join CT_HOADON_SP on CT_HOADON_SP.MaHD = b_HOADON.MaHD
	inner join b_VE on b_HOADON.MaHD = b_VE.MaHD


select *
from b_SANPHAM

use QLBanVe
create or alter view DanhSachPhim
select TenPhim, DaoDien, TenNuocSX, TenTheLoai, NgayKhoiChieu
from b_Phim inner join b_NuocSanXuat on b_PHIM.MaNuocSX = b_NuocSanXuat.MaNuocSX
			inner join b_TheLoai on b_PHIM.MaTheLoai = b_TheLoai.MaTheLoai
		
select * 
from b_PHONG



select TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu
from b_LICHCHIEU 
	inner join b_PHIM on b_LICHCHIEU.MaPhim = b_PHIM.MaPhim
		inner  join b_PHONG on b_LICHCHIEU.MaPhong = b_PHONG.MaPhong
where b_PHONG.MaPhong='P001' 

select *
from b_PHONG

SELECT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu
FROM b_LICHCHIEU
INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim
INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong
WHERE b_PHONG.MaPhong = 'P001';


select TenPhim, MaPhong, NgayChieu, TGBatDauChieu
from b_LICHCHIEU inner join b_PHIM on b_LICHCHIEU.MaPhim = b_PHIM.MaPhim
where b_PHIM.MaPhim='P0001'

select distinct b_LICHCHIEU.MaPhong, TenPhong from b_PHONG inner join b_LICHCHIEU on b_PHONG.MaPhong = b_LICHCHIEU.MaPhong where b_LICHCHIEU.MaPhim ='P0001'
	

select TGBatDauChieu from b_LICHCHIEU where MaPhong ='P001' and MaPhim ='P0001'


select distinct b_LichChieu.MaPhim, TenPhim, AnhPhim, MaTheLoai
from b_Phim inner join b_LICHCHIEU on b_PHIM.MaPhim = b_LICHCHIEU.MaPhim
where NgayChieu='2022-10-12'



select *
from b_LICHCHIEU 
where MaPhong = 'P001' and NgayChieu ='2022-10-12' 
		and ((TGBatDauChieu < '17:00:00' and TGKetThucChieu > '17:00:00') 
		or (TGBatDauChieu < '20:00:00' and TGKetThucChieu > '20:00:00'))

insert into b_LICHCHIEU(MaPhong, MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu) values ('P002', 'P0002', '2023-11-05', '15:30', '17:30:00')

update b_LICHCHIEU set TGBatDauChieu ='19:00:00' , TGKetThucChieu ='21:00:00'
where MaPhong ='P001' and MaPhim='P0001' and NgayChieu ='2022-10-12'

select *
from b_NHANVIEN

update  b_SANPHAM set TenSP = N'Pepsi'
where MaSP='SP002'


select * from b_SANPHAM

update b_SANPHAM set AnhSP =N'Orange_Miranda.jpg'
where MaSP ='SP003'


 select * from b_GHE
 where MaPhong='P001'

 update b_GHE set TrangThai=1 where MaGhe = 'A01'

 select distinct b_Phim.MaPhim, TenPhim from b_LICHCHIEU inner join b_PHIM  on b_LICHCHIEU.MaPhim = b_PHIM.MaPhim where b_LICHCHIEU.NgayChieu ='2022-10-12'


 select b_Phong.TenPhong, MaGhe, TrangThai, b_LICHCHIEU.MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu
 from b_LICHCHIEU inner join b_PHONG on b_LICHCHIEU.MaPhong = b_PHONG.MaPhong
		inner join b_GHE on b_PHONG.MaPhong = b_GHE.MaPhong
where b_lichchieu.MaPhong='P001' and NgayChieu = '2022-10-12' and TGBatDauChieu='19:00:00'

-- tạo view ghe trong phong chieu tai mot lich chieu nao do
create or alter view GheLichChieu as
select b_Phong.TenPhong,b_Lichchieu.MaPhong, MaGhe, TrangThai, b_LICHCHIEU.MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu
from b_LICHCHIEU inner join b_PHONG on b_LICHCHIEU.MaPhong = b_PHONG.MaPhong
		inner join b_GHE on b_PHONG.MaPhong = b_GHE.MaPhong

select *
from GheLichChieu
where MaPhong='P001' and NgayChieu = '2022-10-12' and TGBatDauChieu='21:30:00'

update GheLichChieu
set TrangThai = 1
where MaGhe = 'A02' and MaPhong='P001' and NgayChieu = '2022-10-12' and TGBatDauChieu='19:00:00'

select *
from b_GHE