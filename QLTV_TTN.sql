﻿								--Quản lí thư viện - Thực tập nhóm

--QLTV_TTN
--nhân viên
--sinh viên 
--sách 
--mượn trả 
--vị trí
--phiếu mượn sách
--đăng nhập 
Create Database QLTV_TTN
go
use QLTV_TTN 
go

	Create table DANGNHAP
	(
	TaiKhoan NVARCHAR(30),
	MatKhau VARCHAR(30)
	)
go

	Create table NHANVIEN
	(
	MANV VARCHAR(8) PRIMARY KEY NOT NULL,
	HOTEN NVARCHAR(50) NOT NULL,
	GIOITINH NVARCHAR(5) CHECK (GIOITINH IN (N'Nam',N'Nữ')),
	NGAYSINH DATE,
	DIENTHOAI VARCHAR(11)
	)
GO
	Create table SINHVIEN
	(
	MASV VARCHAR(8) PRIMARY KEY NOT NULL,
	HOTEN NVARCHAR(50) NOT NULL,
	GIOITINH NVARCHAR(5) CHECK (GIOITINH IN (N'Nam',N'Nữ')),
	NGAYSINH DATE,
	DIENTHOAI VARCHAR(11),
	LOP NVARCHAR(50)
	)
go

	Create table SACH
	(
	MASACH VARCHAR(8) PRIMARY KEY NOT NULL,
	TENSACH NVARCHAR(50) NOT NULL,
	TACGIA NVARCHAR(50),
	THELOAI NVARCHAR(50),
	MAVT VARCHAR(8) REFERENCES VITRISACH(MAVT) ON DELETE CASCADE,
	NXB NVARCHAR(50),
	NAMXB DATE,
	SOLUONG INT
	)
go

	Create table VITRISACH
	(
	MAVT VARCHAR(8) PRIMARY KEY NOT NULL,
	VITRI NVARCHAR(50),
	TENKE NVARCHAR(50),

	)
go
	Create table MUONTRA
	(
	 PRIMARY KEY(MAPM,MASACH),
	 MAPM VARCHAR(8) REFERENCES PHIEUMUON(MAPM) ON DELETE CASCADE,
	 MASACH VARCHAR(8) REFERENCES SACH(MASACH) ON DELETE CASCADE,
	 NGAYMUON DATE,
	 NGAYTRA DATE,
	 TIENPHAT VARCHAR(8)
	)
go
	Create table PHIEUMUON
	(
	 MAPM VARCHAR(8) PRIMARY KEY NOT NULL,
	 MANV VARCHAR(8) REFERENCES NHANVIEN(MANV) ON DELETE CASCADE,
	 MASV VARCHAR(8) REFERENCES SINHVIEN(MASV) ON DELETE CASCADE,
	 NGAYMUON DATE

	)
go
ALTER TABLE dbo.PHIEUMUON ADD MASACH VARCHAR(10)
ALTER TABLE dbo.PHIEUMUON ADD TENSACH NVARCHAR(30)

	--insert DANGNHAP
	INSERT dbo.DANGNHAP( TaiKhoan, MatKhau )
	VALUES  ( N'admin','123456'),
			( N'user1','123456')
GO

	--insert NHANVIEN
	INSERT INTO NHANVIEN VALUES ('NV01',N'Sơn Tùng','Nam','1995-2-2','0165315415');
	INSERT INTO NHANVIEN VALUES ('NV02',N'Bích Phương',N'Nữ','1992-11-22','0981413520');
	INSERT INTO NHANVIEN VALUES ('NV03',N'Đàm Vĩnh Hưng','Nam','5-2-1997','01234512852');
	INSERT INTO NHANVIEN VALUES ('NV04',N'Chi Pu','Nam','1-2-1995','0982014165');
	INSERT INTO NHANVIEN VALUES ('NV05',N'Noo Phước Thịnh','Nam','1-7-2000','0978500132');
go

	--Proc DANGNHAP
	CREATE PROC DangKy(@Taikhoan NVARCHAR(30),@Matkhau NVARCHAR(30))
	AS
	BEGIN
		INSERT dbo.DANGNHAP( TaiKhoan, MatKhau )
		VALUES  ( @Taikhoan, @Matkhau )
	END
GO

	CREATE PROC dbo.KiemTraDN(@Username VARCHAR(50),@Pass varchar(50)) AS 
	BEGIN
		SELECT * FROM dbo.DANGNHAP WHERE TaiKhoan = @Username AND MatKhau = @Pass
	END
GO
	--Proc NHANVIEN
	CREATE PROCEDURE ADD_NHANVIEN(@MANV VARCHAR(8),@HOTEN NVARCHAR(50),@GIOITINH NVARCHAR(5),@NGAYSINH DATE,@DIENTHOAI VARCHAR(11))
AS
BEGIN
		INSERT INTO NHANVIEN
		VALUES(@MANV,@HOTEN,@GIOITINH,@NGAYSINH,@DIENTHOAI)
END
GO
	--Sua
CREATE PROCEDURE ALTER_NHANVIEN(@MANV VARCHAR(8),@HOTEN NVARCHAR(50),@GIOITINH NVARCHAR(5),@NGAYSINH DATE,@DIENTHOAI VARCHAR(11))
AS
BEGIN
	UPDATE NHANVIEN
	SET HOTEN=@HOTEN,GIOITINH=@GIOITINH,NGAYSINH=@NGAYSINH,DIENTHOAI =@DIENTHOAI
	WHERE MANV=@MANV
			
END	
GO	
	--Xoa
CREATE PROCEDURE D_NHANVIEN(@MANV VARCHAR(8))
AS
BEGIN 
	DELETE FROM NHANVIEN
	WHERE MANV=@MANV
END		
GO
 

-----------------Sach
	--Them
CREATE PROCEDURE ThemSach(@MASACH VARCHAR(8),@TENSACH NVARCHAR(50),@TACGIA NVARCHAR(50),@THELOAI NVARCHAR(50),@MAVT VARCHAR(8),@NXB NVARCHAR(50),@NAMXB DATE,@SOLUONG INT)
AS
BEGIN
		INSERT INTO SACH
		VALUES(@MASACH,@TENSACH,@TACGIA,@THELOAI,@MAVT,@NXB,@NAMXB,@SOLUONG)
END
GO
	--Sua
CREATE PROCEDURE SuaSach(@MASACH VARCHAR(8),@TENSACH NVARCHAR(50),@TACGIA NVARCHAR(50),@THELOAI NVARCHAR(50),@MAVT VARCHAR(8),@NXB NVARCHAR(50),@NAMXB DATE,@SOLUONG INT)
AS
BEGIN
	UPDATE SACH
	SET MASACH=@MASACH,TENSACH=@TENSACH,TACGIA=@TACGIA,THELOAI=@THELOAI,MAVT=@MAVT,NXB=@NXB,NAMXB=@NAMXB,SOLUONG=@SOLUONG
	WHERE MASACH=@MASACH			
END	
GO	
	--Xoa
CREATE PROCEDURE XoaSach(@MASACH VARCHAR(8))
AS
BEGIN 
	DELETE FROM SACH
	WHERE MASACH=@MASACH
END		
GO


CREATE PROC MuonSach( @MAPM varchar(8), @MANV varchar(8), @MASV varchar(8), @NGAYMUON DATE,@MASACH varchar(10),@TENSACH NVARCHAR(50)) AS
BEGIN
	INSERT INTO dbo.PHIEUMUON 
	VALUES( @MAPM, @MANV, @MASV, @NGAYMUON,@MASACH,@TENSACH ) 
END
GO

-----------------Sinhvien
    --Them
CREATE PROCEDURE ThemSV(@MASV VARCHAR(8),@HOTEN NVARCHAR(50),@GIOITINH NVARCHAR(5),@NGAYSINH DATE,@DIENTHOAI VARCHAR(11),@LOP NVARCHAR(50))
AS
BEGIN
		INSERT INTO SINHVIEN
		VALUES(@MASV,@HOTEN,@GIOITINH,@NGAYSINH,@DIENTHOAI,@LOP)
END
GO
	--Sua
CREATE PROCEDURE SuaSV(@MASV VARCHAR(8),@HOTEN NVARCHAR(50),@GIOITINH NVARCHAR(5),@NGAYSINH DATE,@DIENTHOAI VARCHAR(11),@LOP NVARCHAR(50))
AS
BEGIN
	UPDATE SINHVIEN
	SET MASV=@MASV,HOTEN=@HOTEN,GIOITINH=@GIOITINH,NGAYSINH=@NGAYSINH,DIENTHOAI=@DIENTHOAI,LOP=@LOP
	WHERE MASV=@MASV			
END	
GO	
	--Xoa
CREATE PROCEDURE XoaSV(@MASV VARCHAR(8))
AS
BEGIN 
	DELETE FROM SINHVIEN
	WHERE MASV=@MASV
END		
GO
CREATE PROCEDURE ThemVT(@MAVT VARCHAR(8),@VITRI NVARCHAR(50),@TENKE NVARCHAR(50))
AS
BEGIN
	INSERT INTO VITRISACH
	VALUES (@MAVT,@VITRI,@TENKE)
END
GO
CREATE PROCEDURE SuaVT(@MAVT VARCHAR(8),@VITRI NVARCHAR(50),@TENKE NVARCHAR(50))
AS
BEGIN
	UPDATE VITRISACH
	SET VITRI=@VITRI, TENKE=@TENKE
	WHERE MAVT=@MAVT
END
GO
CREATE PROCEDURE XoaVT(@MAVT VARCHAR(8))
AS
BEGIN
	DELETE FROM VITRISACH
	WHERE MAVT=@MAVT
END