 create database QLBanVe1


CREATE TABLE b_PHONG
(
  MaPhong NVARCHAR(50) NOT NULL,
  TenPhong NVARCHAR(255) ,
  SLGhe INT ,
  PRIMARY KEY (MaPhong)
);

CREATE TABLE b_NHANVIEN
(
  MaNV NVARCHAR(50) NOT NULL,
  SDT INT ,
  UserName NVARCHAR(255) ,
  MatKhau NVARCHAR(255) ,
  TenNV NVARCHAR(255),
  VaiTro NVARCHAR(255) NOT NULL,
  NgayBatDau DATE ,
  IsDeleted int ,
  Email NVARCHAR(255) ,
  GioiTinh NVARCHAR(50) ,
  Anh NVARCHAR(255),
  PRIMARY KEY (MaNV)
);

CREATE TABLE b_SANPHAM
(
  MaSP NVARCHAR(50) NOT NULL,
  TenSP NVARCHAR(255) ,
  LoaiSP NVARCHAR(255),
  AnhSP NVARCHAR(255) ,
  DonGia Money ,
  SL INT ,
  PRIMARY KEY (MaSP)
);

CREATE TABLE b_KHACHHANG
(
  MaKH NVARCHAR(50) NOT NULL,
  TenKH NVARCHAR(255) ,
  SDT INT ,
  Email NVARCHAR(255) ,
  PRIMARY KEY (MaKH)
);

CREATE TABLE b_GHE
(
  MaGhe NVARCHAR(50) NOT NULL,
  TenGhe NVARCHAR(50) ,
  DonGia Money ,
  MaPhong NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaGhe),
  FOREIGN KEY (MaPhong) REFERENCES b_PHONG(MaPhong)
);

CREATE TABLE b_NuocSanXuat
(
  MaNuocSX NVARCHAR(50) NOT NULL,
  TenNuocSX NVARCHAR(255) ,
  PRIMARY KEY (MaNuocSX)
);

CREATE TABLE b_TheLoai
(
  MaTheLoai NVARCHAR(50) NOT NULL,
  TenTheLoai NVARCHAR(255) ,
  PRIMARY KEY (MaTheLoai)
);

CREATE TABLE b_HangSanXuat
(
  MaHangSX NVARCHAR(50) NOT NULL,
  TenHangSX NVARCHAR(255) ,
  PRIMARY KEY (MaHangSX)
);

CREATE TABLE b_Voucher
(
  MaVouher NVARCHAR(50) NOT NULL,
  Code INT ,
  TrangThai INT ,
  TenVoucher NVARCHAR(255) ,
  PRIMARY KEY (MaVouher)
);

CREATE TABLE b_CT_VOUCHER
(
  NgayBatDau DATE ,
  NgayKetThuc DATE ,
  MaKH NVARCHAR(50) NOT NULL,
  MaVouher NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaKH, MaVouher),
  FOREIGN KEY (MaKH) REFERENCES b_KHACHHANG(MaKH),
  FOREIGN KEY (MaVouher) REFERENCES b_Voucher(MaVouher)
);

CREATE TABLE b_PHIM
(
  MaPhim NVARCHAR(50) NOT NULL,
  TenPhim NVARCHAR(255) ,
  DaoDien NVARCHAR(255) ,
  NgayKhoiChieu DATE ,
  NgayKetThuc DATE ,
  DienVienChinh NVARCHAR(255) ,
  NoiDungChinh NVARCHAR(255) ,
  AnhPhim NVARCHAR(255) ,
  TongThu Money ,
  TongChiPhi Money ,
  MaNuocSX NVARCHAR(50) NOT NULL,
  MaTheLoai NVARCHAR(50) NOT NULL,
  MaHangSX NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaPhim),
  FOREIGN KEY (MaNuocSX) REFERENCES b_NuocSanXuat(MaNuocSX),
  FOREIGN KEY (MaTheLoai) REFERENCES b_TheLoai(MaTheLoai),
  FOREIGN KEY (MaHangSX) REFERENCES b_HangSanXuat(MaHangSX)
);

CREATE TABLE b_HOADON
(
  MaHD NVARCHAR(50) NOT NULL,
  NgayLap DATETIME,
  GiamGia money ,
  TongTien Money ,
  MaNV NVARCHAR(50) NOT NULL,
  MaKH NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaHD),
  FOREIGN KEY (MaNV) REFERENCES b_NHANVIEN(MaNV),
  FOREIGN KEY (MaKH) REFERENCES b_KHACHHANG(MaKH)
);

CREATE TABLE b_LICHCHIEU
(
  NgayChieu DATE NOT NULL,
  TGBatDauChieu Time NOT NULL,
  TGKetThucChieu Time ,
  MaLichChieu NVARCHAR(255) NOT NULL,
  MaPhong NVARCHAR(50) NOT NULL,
  MaPhim NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaLichChieu),
  FOREIGN KEY (MaPhong) REFERENCES b_PHONG(MaPhong),
  FOREIGN KEY (MaPhim) REFERENCES b_PHIM(MaPhim)
);

CREATE TABLE CT_HOADON_SP
(
  SL INT ,
  DonGia Money ,
  MaHD NVARCHAR(50) NOT NULL,
  MaSP NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaHD, MaSP),
  FOREIGN KEY (MaHD) REFERENCES b_HOADON(MaHD),
  FOREIGN KEY (MaSP) REFERENCES b_SANPHAM(MaSP)
);

CREATE TABLE b_CT_LICHCHIEU_GHE
(
  TrangThai INT NOT NULL,
  DonGia Money ,
  MaLichChieu NVARCHAR(255) NOT NULL,
  MaGhe NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaLichChieu, MaGhe),
  FOREIGN KEY (MaLichChieu) REFERENCES b_LICHCHIEU(MaLichChieu),
  FOREIGN KEY (MaGhe) REFERENCES b_GHE(MaGhe)
);

CREATE TABLE b_VE
(
  MaVe NVARCHAR(255) NOT NULL,
  MaHD NVARCHAR(50) NOT NULL,
  MaLichChieu NVARCHAR(255) NOT NULL,
  MaGhe NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaVe),
  FOREIGN KEY (MaHD) REFERENCES b_HOADON(MaHD),
  FOREIGN KEY (MaLichChieu, MaGhe) REFERENCES b_CT_LICHCHIEU_GHE(MaLichChieu, MaGhe)
);

--dữ liệu cố định
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

insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P001', N'Phòng 01', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P002', N'Phòng 02', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P003', N'Phòng 03', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P004', N'Phòng 03', 72)
insert into b_PHONG(MaPhong, TenPhong, SLGhe) values ('P005', N'Phòng 03', 72)


insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A01','A01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A02','A02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A03','A03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A04','A04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A05','A05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A06','A06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A07','A07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A08','A08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1A09','A09', 'P001', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B01','B01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B02','B02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B03','B03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B04','B04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B05','B05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B06','B06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B07','B07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B08','B08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1B09','B09', 'P001', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C01','C01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C02','C02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C03','C03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C04','C04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C05','C05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C06','C06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C07','C07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C08','C08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1C09','C09', 'P001', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D01','D01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D02','D02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D03','D03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D04','D04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D05','D05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D06','D06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D07','D07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D08','D08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1D09','D09', 'P001', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E01','E01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E02','E02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E03','E03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E04','E04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E05','E05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E06','E06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E07','E07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E08','E08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1E09','E09', 'P001', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F01','F01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F02','F02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F03','F03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F04','F04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F05','F05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F06','F06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F07','F07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F08','F08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1F09','F09', 'P001', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G01','G01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G02','G02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G03','G03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G04','G04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G05','G05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G06','G06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G07','G07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G08','G08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1G09','G09', 'P001', 50000)


insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H01','H01', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H02','H02', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H03','H03', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H04','H04', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H05','H05', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H06','H06', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H07','H07', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H08','H08', 'P001', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P1H09','H09', 'P001', 50000)

--nhập ghế cho phòng 2
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A01','A01', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A02','A02', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A03','A03', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A04','A04', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A05','A05', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A06','A06', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A07','A07', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A08','A08', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2A09','A09', 'P002', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B01','B01', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B02','B02', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B03','B03', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B04','B04', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B05','B05', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B06','B06', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B07','B07', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B08','B08', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2B09','B09', 'P002', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C01','C01', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C02','C02', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C03','C03', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C04','C04', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C05','C05', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C06','C06', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C07','C07', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C08','C08', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2C09','C09', 'P002', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D01','D01', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D02','D02', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D03','D03', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D04','D04', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D05','D05', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D06','D06', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D07','D07', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D08','D08', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2D09','D09', 'P002', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E01','E01', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E02','E02', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E03','E03', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E04','E04', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E05','E05', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E06','E06', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E07','E07', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E08','E08', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2E09','E09', 'P002', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F01','F01', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F02','F02', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F03','F03', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F04','F04', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F05','F05', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F06','F06', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F07','F07', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F08','F08', 'P002', 50000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2F09','F09', 'P002', 50000)

insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G01','G01', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G02','G02', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G03','G03', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G04','G04', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G05','G05', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G06','G06', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G07','G07', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G08','G08', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2G09','G09', 'P002', 55000)


insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H01','H01', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H02','H02', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H03','H03', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H04','H04', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H05','H05', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H06','H06', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H07','H07', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H08','H08', 'P002', 55000)
insert into b_GHE(MaGhe,TenGhe, MaPhong,  DonGia) values ('P2H09','H09', 'P002', 55000)

--dữ liệu nhập  để test
insert into b_PHIM(MaPhim, TenPhim, DaoDien,NgayKhoiChieu, NgayKetThuc,DienVienChinh,NoiDungChinh,AnhPhim,TongThu, TongChiPhi, MaNuocSX,MaTheLoai,MaHangSX) 
			values('P0001',N'Tây Du Ký',N'Dương Khiết','1996-09-01','2024-12-01',N'Lục Tiểu Linh Đồng, Từ Thiếu Hoa',N'Kể về thầy trò đường tăng đi tây trúc thỉnh kinh',null,9600000000, 5000000000, 'N04','TL02','H02')
insert into b_PHIM(MaPhim, TenPhim, DaoDien,NgayKhoiChieu, NgayKetThuc,DienVienChinh,NoiDungChinh,AnhPhim,TongThu, TongChiPhi, MaNuocSX,MaTheLoai,MaHangSX) 
			values('P0002',N'Mắt biếc',N'Thanh Hà','2021-10-09','2023-08-21',N'Ngạn, Bông',N'Kể về mối tính ngây thơ của hai học sinh',null,1200000000, 600000000, 'N01','TL01','H01')
insert into b_PHIM(MaPhim, TenPhim, DaoDien,NgayKhoiChieu, NgayKetThuc,DienVienChinh,NoiDungChinh,AnhPhim,TongThu, TongChiPhi, MaNuocSX,MaTheLoai,MaHangSX) 
			values('P0003',N'Người nhện Spidermen',N'Aler Jonh','2023-12-01','2025-10-01',N'Mr Walker, Ms Adamli',N'Cuộc giải cứu thế giới của người nhện cùng với đó là tình yêu của con người và robot',null,32000000000, 12000000000, 'N03','TL02','H03')


insert into b_NHANVIEN(MaNV,TenNV, UserName, MatKhau, VaiTro, GioiTinh,SDT, NgayBatDau,IsDeleted, Email, Anh )
			values('NV0001', N'Nguyễn Thị Thu Uyên', 'uyennguyen', '123',N'Nhân viên',N'Nữ', 0342962825, '2022-09-10', 0, 'nguyenthithuuyen03022003@gmail.com', null)
insert into b_NHANVIEN(MaNV,TenNV, UserName, MatKhau, VaiTro, GioiTinh,SDT, NgayBatDau,IsDeleted, Email, Anh )
			values('NV0002', N'Đào Minh Quang', 'minhquang', '12345',N'Quản lý',N'Nam', 0964625712, '2010-05-07', 0, 'quangdao@gmail.com',null)

insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP001', N'Bỏng ngô', N'Đồ ăn',null, 30000, 56)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP002', N'Nước pepsi', N'Đồ uống',null, 16000, 30)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP003', N'Nước Miranda',N'Đồ uống', null, 12000, 100)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP004', N'Snack Khoai Tây',N'Đồ ăn', null, 15000, 33)
insert into b_SANPHAM(MaSP,TenSP,LoaiSP,AnhSP,DonGia,SL) values('SP005', N'Porcorn',N'Đồ ăn', 'porcorn1.jpg', 15000, 33)

insert into b_KHACHHANG(MaKH, TenKH, SDT, Email) values ('KH0001', N'Nguyễn Thị Thu Hà', 0965587423, null)
insert into b_KHACHHANG(MaKH, TenKH, SDT, Email) values ('KH0002', N'Vũ Thị Thu Hiền', 0378753648, null)
insert into b_KHACHHANG(MaKH, TenKH, SDT, Email) values ('KH0003', N'Nguyễn Thị Ngọc', 0469255873, null)
--*****QUẢN LÍ GHÊ: thay đổi tiền giá ghế ở bảng ghê thì CT_LICHCHIEU_GHE dongia cung thay doi
CREATE OR ALTER TRIGGER trg_AfterUpdateGiaGhe
ON b_GHE
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra xem cột DonGia có được cập nhật không
    IF UPDATE(DonGia)
    BEGIN
        -- Cập nhật giá trong bảng CT_LICHCHIEU_GHE
        UPDATE CT_LICHCHIEU_GHE
        SET DonGia = i.DonGia
        FROM CT_LICHCHIEU_GHE c
        INNER JOIN inserted i ON c.MaGhe = i.MaGhe;
    END
END;
--****QUẢN LÍ LỊCH CHIẾU
--B1: thêm lịch chiếu
--B2: sau khi thêm lịch chiếu thì update lại CT_LICHCHIEU_GHE
-- thêm tất cả các mã ghế vào chi tiết lịch chiếu với mã lịch chiếu là mã vừa tạo với trang thái là 0
--va update lại đơn giá bằng với giá ghế ở bàng b_ghe
CREATE or alter TRIGGER trg_AfterInsertLICHCHIEU
ON b_LICHCHIEU
AFTER INSERT
AS
BEGIN
    -- Insert dữ liệu vào b_CT_LICHCHIEU_GHE
    INSERT INTO b_CT_LICHCHIEU_GHE (MaLichChieu, MaGhe, TrangThai, DonGia)
    SELECT
        i.MaLichChieu,
        g.MaGhe,
        0 AS TrangThai,
        (select DonGia from b_GHE where MaGhe=g.MaGhe) AS DonGia -- Bạn có thể cập nhật giá trị này theo nhu cầu của mình
    FROM
        INSERTED i
    CROSS JOIN
        b_GHE g
    WHERE
        g.MaPhong = i.MaPhong;
END;

-- xóa CT_LICHCHIEU_GHE khi xóa b_LICHCHIEU
CREATE OR ALTER TRIGGER trg_AfterDeleteLICHCHIEU
ON b_LICHCHIEU
AFTER DELETE
AS
BEGIN
    -- Xóa dữ liệu từ b_CT_LICHCHIEU_GHE sau khi xóa từ b_LICHCHIEU
    DELETE FROM b_CT_LICHCHIEU_GHE
    WHERE MaLichChieu IN (SELECT MaLichChieu FROM DELETED);
END;

--****QUản LÍ SẢN PhÂM-HÓA ĐƠN
-- mỗi khi thêm, update, xóa chi tiết sản phẩm thì tự động  update lại tổng tiền hóa đơn,sl sản phẩm
CREATE OR ALTER TRIGGER trg_AfterInsertUpdateDeleteCT_HOADON_SP
ON CT_HOADON_SP
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @MaHD NVARCHAR(50), @MaSP NVARCHAR(50), @SL int;
	IF EXISTS (SELECT 1 FROM inserted)
	begin
		-- Lấy MaHD từ bảng CT_HOADON_SP
		SELECT @MaHD = MaHD, @MaSP = MaSP,@SL = SL FROM INSERTED;

		--update lai dongia chitiet hoa don sp
		update CT_HOADON_SP
		set DonGia = b_SANPHAM.DonGia
		from b_SANPHAM
		where b_SANPHAM.MaSP= @MaSP

		-- Cập nhật tổng tiền hóa đơn
		UPDATE b_HOADON
		SET TongTien = isnull(isnull(TongTien,0) + isnull(DonGia, 0) * @SL,0)
		from b_HOADON inner join CT_HOADON_SP on b_HOADON.MaHD = CT_HOADON_SP.MaHD
		WHERE b_HOADON.MaHD = @MaHD and MaSP = @MaSP

		--update lại SL trong bảng sản phẩm 
		update b_SANPHAM
		set SL = SL -@SL 
		where MaSP = @MaSP
	end
	else IF EXISTS (SELECT 1 FROM deleted)
	begin
	-- Lấy MaHD từ bảng CT_HOADON_SP
		SELECT @MaHD = MaHD, @MaSP = MaSP,@SL = SL FROM deleted;

		-- Cập nhật tổng tiền hóa đơn
		UPDATE b_HOADON
		SET TongTien = isnull(isnull(TongTien,0) - isnull(DonGia, 0) * @SL,0)
		from b_HOADON inner join deleted on b_HOADON.MaHD = deleted.MaHD
		WHERE b_HOADON.MaHD = @MaHD and MaSP = @MaSP

		--update lại SL trong bảng sản phẩm 
		update b_SANPHAM
		set SL = SL + @SL 
		where MaSP = @MaSP
	end
    
END;
--**QUẢN LÍ VÉ-HÓA ĐƠN
--trigger sau khi thêm , xoa vé trong hóa đơn, cập nhật lại trang thái của b_CT_LICHCHIEU_GHE
CREATE or alter TRIGGER trg_AfterInsertDeleteVE
ON b_VE
AFTER INSERT, DELETE
AS
begin
	declare @maHD nvarchar(50), @tienVe money,  @maGhe nvarchar(50), @maLichChieu nvarchar(100)
	IF EXISTS (SELECT 1 FROM inserted)
	begin
		select @maHD= inserted.MaHD, @maGhe=inserted.MaGhe, @maLichChieu=inserted.MaLichChieu from inserted
		select @tienVe = DonGia from b_CT_LICHCHIEU_GHE where MaLichChieu = @maLichChieu and MaGhe= @maGhe

		update b_HOADON
		set TongTien = TongTien + @tienVe 
		where MaHD = @maHD

		update b_CT_LICHCHIEU_GHE
		set TrangThai = 1
		where MaGhe = @maGhe and MaLichChieu = @maLichChieu
		
	end
	else IF EXISTS (SELECT 1 FROM deleted)
	begin
		select @maHD= deleted.MaHD, @maGhe=deleted.MaGhe, @maLichChieu=deleted.MaLichChieu from deleted
		select @tienVe = DonGia from deleted inner join b_CT_LICHCHIEU_GHE on deleted.MaLichChieu = b_CT_LICHCHIEU_GHE.MaLichChieu and deleted.MaGhe = b_CT_LICHCHIEU_GHE.MaGhe

		update b_HOADON
		set TongTien = TongTien - @tienVe 
		where MaHD = @maHD

		update b_CT_LICHCHIEU_GHE
		set TrangThai = 0
		where MaGhe = @maGhe and MaLichChieu = @maLichChieu
	end
end




----SQL TEST --ko chạy
--cập nhật lại tổng tiền hóa đơn sau khi thêm vé->> có thể tạo trigger
UPDATE b_HOADON
SET TongTien = (
    SELECT SUM(b_CT_LICHCHIEU_GHE.DonGia)
    FROM b_CT_LICHCHIEU_GHE
    INNER JOIN b_VE ON b_CT_LICHCHIEU_GHE.MaLichChieu = b_VE.MaLichChieu
                     AND b_CT_LICHCHIEU_GHE.MaGhe = b_VE.MaGhe
    WHERE b_VE.MaHD = b_HOADON.MaHD
)
WHERE EXISTS (
    SELECT 1
    FROM b_VE
    WHERE b_VE.MaHD = b_HOADON.MaHD
);

--QUẢN LÍ HÓA ĐƠN
--B1: thêm hóa đơn : bằng mã tự sinh :HD + ngày hiện tại + biến chạy
insert into b_HOADON(MaHD, NgayLap, GiamGia, TongTien, MaNV, MaKH) values ('HD0001','2022-10-11 20:10:00',0,0,'NV0001','KH0003')
--B2: thêm các vé xem phim vào hóa đơn 
-- mã vé là mã tự sinh 1,2,3,4,...
-- chọn xong vé , thì update lại trang thái cho CT_LICHCHIEU_GHE =1 tại cái malichchieu, và mã ghế đã chọn
insert into b_VE(MaVe, MaLichChieu, MaGhe, MaHD) values('1','221012P11530', 'P1A01', 'HD0001')
insert into b_VE(MaVe, MaLichChieu, MaGhe, MaHD) values('2','221012P11530', 'P1A02', 'HD0001')
insert into b_VE(MaVe, MaLichChieu, MaGhe, MaHD) values('3','221012P11530', 'P1A03', 'HD0001')
insert into b_VE(MaVe, MaLichChieu, MaGhe, MaHD) values('4','221012P11530', 'P1A04', 'HD0001')

delete b_VE
where MaVe='4'

select *
from b_HOADON

select *
from b_VE
where MaHD='HD0001'


select *
from b_SANPHAM

select *
from b_VE

delete b_VE

select *
from b_CT_LICHCHIEU_GHE

delete from b_CT_LICHCHIEU_GHE
delete b_VE
where MaVe='4'
select *
from b_HOADON

select *
from CT_HOADON_SP

select * 
from b_SANPHAM

delete b_HOADON

insert into CT_HOADON_SP(MaSP, MaHD, SL) values ('SP001', 'HD0001', 6)
delete  from CT_HOADON_SP
where MaHD = 'HD0001' and MaSP='SP001'
--tìm kiếm trang thái các ghê ở lịch chiếu 231110P11900
select *
from b_CT_LICHCHIEU_GHE
where MaLichChieu='221012P11530'


insert into b_CT_LICHCHIEU_GHE(MaLichChieu, MaGhe, TrangThai) values('221012P11530', 'P1A01', 1)
insert into b_CT_LICHCHIEU_GHE(MaLichChieu, MaGhe, TrangThai) values('221012P11530', 'P1A02', 1)
insert into b_CT_LICHCHIEU_GHE(MaLichChieu, MaGhe, TrangThai) values('221012P11530', 'P1A03', 1)
insert into b_CT_LICHCHIEU_GHE(MaLichChieu, MaGhe, DonGia, TrangThai) values('221012P11530', 'P1A04',50000, 0)

select * 
from b_PHIM
--->> đến đây khi thêm vé mới thì update lại trạng thái ghế là 1