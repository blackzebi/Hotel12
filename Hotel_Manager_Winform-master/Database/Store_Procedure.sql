
USE QLKS
GO	

CREATE PROC CONFIRM_LOGIN @username NVARCHAR(50),@password NVARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.tbluser WHERE username=@username AND password=@password
END

GO	

CREATE PROC getManv @username nvarchar(50)
AS
BEGIN
	SELECT manv FROM dbo.tbluser
	WHERE username=@username
END  

GO	

CREATE PROC get_ListRoom 
AS
BEGIN
	SELECT * FROM dbo.tbltrangthaiphong
END 

GO	

CREATE PROC getRoomType
AS
BEGIN
	SELECT * FROM dbo.tblloaiphong
END

GO	

CREATE PROC insertRoomType @maloai nvarchar(50),@gia INT
AS
BEGIN
	INSERT INTO dbo.tblloaiphong
	        ( maloai, gia )
	VALUES  ( @maloai, -- maloai - nvarchar(50)
	          @gia  -- gia - int
	          )
END  

GO	
CREATE PROC updateRoomType @maloai nvarchar(50),@gia INT
AS
BEGIN
	UPDATE dbo.tblloaiphong SET gia=@gia
	WHERE maloai=@maloai
END

GO	

CREATE PROC deleteRoomType @maloai nvarchar(50),@gia int
AS
BEGIN
	DELETE FROM dbo.tblloaiphong WHERE maloai=@maloai
END  

GO	

CREATE PROC getListSupplies
AS
BEGIN
	SELECT tblctvattu.mavattu,tenvattu,maloai,soluong FROM dbo.tblvattu,dbo.tblctvattu
	WHERE dbo.tblvattu.mavattu=dbo.tblctvattu.mavattu
END 

GO	
  

CREATE PROC get_all_info_ListRoom
AS
BEGIN
	select maphong as [Mã phòng],maloai as[Mã loại] from tblphong
END

GO	

CREATE PROC	 getEmptyRoom
AS
BEGIN
	SELECT dbo.tblphong.maphong,dbo.tblloaiphong.maloai,gia
	FROM dbo.tblphong,tblloaiphong,dbo.tbltrangthaiphong 
	WHERE dbo.tblloaiphong.maloai=dbo.tblphong.maloai 
	AND dbo.tblphong.maphong=dbo.tbltrangthaiphong.maphong
	AND trangthai=N'Đang rảnh'
END 

GO	

CREATE PROC getRoomPrice @maphong nvarchar(50)
AS
BEGIN
	SELECT gia FROM dbo.tblphong,dbo.tblloaiphong
	WHERE dbo.tblloaiphong.maloai=dbo.tblphong.maloai
	AND maphong=@maphong
END

GO	

CREATE PROC get_ListSupplies
AS
BEGIN
	SELECT tblctvattu.mavattu,tenvattu,maloai,soluong FROM dbo.tblvattu,dbo.tblctvattu WHERE dbo.tblvattu.mavattu=dbo.tblctvattu.mavattu
END

GO	
CREATE PROC get_List_Bill
AS
BEGIN	
	SELECT * FROM dbo.tblhoadon
END 

GO	

CREATE PROC Change_Pass @username NVARCHAR(50),@password NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.tbluser SET password=@password WHERE username=@username
END

GO	

CREATE PROC getPermission @username nvarchar(50)
AS
BEGIN
	SELECT permission FROM dbo.tbluser WHERE username=@username
END

GO	


CREATE PROC updateNV @manv nvarchar(50),@tennv nvarchar(50),@gioitinh nvarchar(50),@ngaysinh nvarchar(50),@sdt nvarchar(50),@diachi nvarchar(50),@chucvu nvarchar(50)
AS
BEGIN
	UPDATE dbo.tblnhanvien SET tennv=@tennv,gioitinh=@gioitinh,ngaysinh=@ngaysinh,sdt=@sdt,diachi=@diachi,chucvu=@chucvu WHERE manv=@manv
END 

GO	

CREATE PROC insertNV @manv nvarchar(50),@tennv nvarchar(50),@gioitinh nvarchar(50),@ngaysinh nvarchar(50),@sdt nvarchar(50),@diachi nvarchar(50),@chucvu nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.tblnhanvien VALUES(@manv,@tennv,@gioitinh,@ngaysinh,@sdt,@diachi,@chucvu)
END 

GO	

CREATE PROC deleteNV @manv nvarchar(50)
AS
BEGIN
	DELETE dbo.tbluser WHERE manv=@manv
	DELETE dbo.tblnhanvien WHERE manv=@manv
END
GO	

CREATE PROC getListAccount
AS
BEGIN
 SELECT * FROM dbo.tbluser
END

GO	

CREATE PROC insertUserName @username nvarchar(50),@manv nvarchar(50),@password nvarchar(50),@permission nvarchar(50)
AS 
BEGIN
	INSERT	INTO dbo.tbluser
	        ( username ,
	          manv ,
	          password ,
	          permission
	        )
	VALUES  ( @username , -- username - nvarchar(50)
	          @manv , -- manv - nvarchar(50)
	          @password , -- password - nvarchar(50)
	          @permission  -- permission - nvarchar(50)
	        )
END

GO	

CREATE PROC updateUserName @username nvarchar(50),@manv nvarchar(50),@password nvarchar(50),@permission nvarchar(50)
AS 
BEGIN
	UPDATE dbo.tbluser SET manv=@manv,password=@password,permission=@permission WHERE username=@username
END

GO	

CREATE PROC deleteUserName @username nvarchar(50)
AS 
BEGIN
	DELETE FROM dbo.tbluser WHERE username=@username
END

GO	

CREATE PROC createDatPhong @mapd nvarchar(50),@maphong NVARCHAR(50)
AS 
BEGIN
	INSERT INTO dbo.tbldatphong
	        ( mapd, maphong )
	VALUES  ( @mapd, -- mapd - nvarchar(50)
	          @maphong  -- maphong - nvarchar(50)
	          )
END

GO	

CREATE PROC cancelDatPhong @mapd nvarchar(50)
AS
BEGIN
	DELETE FROM dbo.tbldatphong WHERE mapd=@mapd
END 

GO	

CREATE PROC getListDatPhong
AS
BEGIN
	SELECT tblctdatphong.mapd,makh,maphong,ngayden,ngaydi,tongtiendat,username,trangthai FROM dbo.tbldatphong,dbo.tblctdatphong 
	WHERE dbo.tblctdatphong.mapd=dbo.tbldatphong.mapd
END

GO	

CREATE PROC getListEmptyDatPhong
AS
BEGIN
	SELECT * FROM dbo.tbldatphong
	WHERE mapd NOT IN(SELECT mapd FROM dbo.tblctdatphong)
END 

GO	

CREATE PROC insertInfoDatPhong @mapd nvarchar(50),@makh nvarchar(50),@ngayden nvarchar(50),@ngaydi nvarchar(50),@tongtiendat int,@username nvarchar(50)
AS 
BEGIN
	INSERT INTO dbo.tblctdatphong
	        ( mapd ,
	          makh ,
	          ngayden ,
	          ngaydi ,
	          tongtiendat ,
	          username
	        )
	VALUES  ( @mapd , -- mapd - nvarchar(50)
	          @makh , -- makh - nvarchar(50)
	          @ngayden , -- ngayden - date
	          @ngaydi , -- ngaydi - date
	          @tongtiendat , -- tongtiendat - int
	          @username  -- username - nvarchar(50)
	        )
END

GO	

CREATE PROC updateDetailDatPhong @mapd nvarchar(50)
AS
BEGIN
	UPDATE dbo.tblctdatphong SET trangthai=N'Đã nhận'
	WHERE mapd=@mapd
END

GO	

CREATE PROC createBill @mapd nvarchar(50),
					   @makh NVARCHAR(50),
					   @manv NVARCHAR(50),
					   @tongtien int
AS 
BEGIN
	INSERT INTO dbo.tblhoadon
	        ( tongtien ,
	          mapd ,
	          makh ,
	          manv)
	VALUES  ( @tongtien,
			  @mapd,
			  @makh,
			  @manv)
END

GO	

CREATE TRIGGER updateStatusRoom 
ON tblctdatphong
FOR UPDATE,INSERT  
AS
	DECLARE @maphong NVARCHAR(50)
	SELECT @maphong=maphong FROM inserted,dbo.tbldatphong
	WHERE inserted.mapd=dbo.tbldatphong.mapd 
	UPDATE dbo.tbltrangthaiphong SET trangthai=N'Đã đặt'
	WHERE maphong=@maphong

GO	

CREATE TRIGGER updateStatusRoomD
ON tblctdatphong
FOR DELETE 
AS
	DECLARE @maphong NVARCHAR(50)
	SELECT @maphong=maphong FROM deleted,dbo.tbldatphong
	WHERE deleted.mapd=dbo.tbldatphong.mapd 
	UPDATE dbo.tbltrangthaiphong SET trangthai=N'Đang rảnh'
	WHERE maphong=@maphong

GO	


CREATE PROC updateStatusRoomAuto @maphong nvarchar(50)
AS 
BEGIN
	DECLARE @trangthai NVARCHAR(50)
	DECLARE @ngaydi DATE
	SELECT @ngaydi=MAX(ngaydi) FROM dbo.tblctdatphong,dbo.tbldatphong WHERE dbo.tblctdatphong.mapd=dbo.tbldatphong.mapd
	AND  maphong=@maphong
	SELECT @trangthai=trangthai FROM dbo.tbltrangthaiphong WHERE maphong=@maphong
	IF(@trangthai='Đã đặt')
	BEGIN
		IF(@ngaydi<GETDATE())
		BEGIN	
		UPDATE dbo.tbltrangthaiphong SET trangthai=N'Đang rảnh' WHERE maphong=@maphong
		END
	END 
END

GO	

CREATE PROC payBill @mahd nvarchar(50)
AS
BEGIN
	UPDATE dbo.tblhoadon SET tinhtrang='Đã thanh toán'
	WHERE mahd=@mahd
END 

GO	

CREATE PROC insertKH @makh nvarchar(50),@tenkh nvarchar(50),@gioitinh nvarchar(3),@ngaysinh nvarchar(50),@cmnd nvarchar(50),@diachi nvarchar(50),@sdt nvarchar(50),@ghichu nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.tblkhachhang
	        ( makh ,
	          tenkh ,
	          gioitinh ,
	          ngaysinh ,
	          cmnd ,
	          diachi ,
	          sdt ,
	          ghichu
	        )
	VALUES  ( @makh, -- makh - nvarchar(50)
	          @tenkh , -- tenkh - nvarchar(50)
	          @gioitinh , -- gioitinh - nvarchar(3)
	          @ngaysinh , -- ngaysinh - date
	          @cmnd , -- cmnd - nvarchar(50)
	          @diachi , -- diachi - nvarchar(50)
	          @sdt , -- sdt - nvarchar(50)
	          @ghichu  -- ghichu - nvarchar(50)
	        )
END

GO	

CREATE PROC updateKH @makh nvarchar(50),@tenkh nvarchar(50),@gioitinh nvarchar(3),@ngaysinh nvarchar(50),@cmnd nvarchar(50),@diachi nvarchar(50),@sdt nvarchar(50),@ghichu nvarchar(50)
AS
BEGIN
	UPDATE dbo.tblkhachhang SET tenkh=@tenkh,gioitinh=@gioitinh,ngaysinh=@ngaysinh,cmnd=@cmnd,diachi=@diachi,sdt=@sdt,ghichu=@ghichu WHERE makh=@makh        
END

GO	

CREATE PROC deleteKH @makh nvarchar(50)
AS
BEGIN
	DELETE FROM	dbo.tblkhachhang WHERE makh=@makh		
END 

GO	

CREATE PROC getServicePrice @madv nvarchar(50)
AS
BEGIN
	SELECT gia FROM dbo.tbldichvu
	WHERE madv=@madv
END 

GO	

CREATE PROC insertService @mapd nvarchar(50) , @madv NVARCHAR(50) , @sl NVARCHAR(50) , @tien NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.tbldichvuthem
	        ( mapd, madv, soluong, tongtiendv )
	VALUES  ( @mapd, -- mapd - nvarchar(50)
	          @madv, -- madv - nvarchar(50)
	          @sl, -- soluong - int
	          @tien  -- tongtiendv - int
	          )
END  

GO	

CREATE TRIGGER addBillWithService
ON tbldichvuthem
FOR INSERT
AS 
	DECLARE @mapd NVARCHAR(50)
	DECLARE @tien INT
	SELECT @mapd=inserted.mapd,@tien=inserted.tongtiendv FROM dbo.tbldichvuthem,inserted
	WHERE dbo.tbldichvuthem.mapd=inserted.mapd
	UPDATE dbo.tblhoadon
	SET tongtien=tongtien+@tien
	WHERE mapd=@mapd

GO	

CREATE TRIGGER insertRoom
ON tblphong
FOR INSERT
AS 
	DECLARE @maphong NVARCHAR(50)
	SELECT @maphong=inserted.maphong
	FROM inserted,dbo.tblphong
	WHERE inserted.maphong=dbo.tblphong.maphong
	INSERT INTO dbo.tbltrangthaiphong
	        ( maphong, trangthai )
	VALUES  ( @maphong, -- maphong - nvarchar(50)
	          N'Đang rảnh'  -- trangthai - nvarchar(50)
	          )
GO

