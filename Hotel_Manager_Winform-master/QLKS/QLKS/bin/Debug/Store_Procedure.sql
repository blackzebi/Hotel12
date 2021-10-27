CREATE PROC CONFIRM_LOGIN @username NVARCHAR(50),@password NVARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.tbluser WHERE username=@username AND password=@password
END
CONFIRM_LOGIN @username ='1' , @password ='1'

Go

CREATE PROC get_ListRoom 
AS
BEGIN
	SELECT * FROM dbo.tbltrangthaiphong
END 

dbo.get_ListRoom


CREATE PROC get_all_info_ListRoom
AS
BEGIN
	select maphong as [Mã phòng],maloai as[Mã loại],dadat as[Đã đặt],danhan as[Đã nhận] from tblphong
END

CREATE PROC get_ListSupplies
AS
BEGIN
	SELECT tblctvattu.mavattu,tenvattu,maloai,soluong FROM dbo.tblvattu,dbo.tblctvattu WHERE dbo.tblvattu.mavattu=dbo.tblctvattu.mavattu
END
get_ListSupplies