create database I_Route
go

use I_Route
go


create table (
 id int IDENTITY(1,1) NOT NULL,
 contrase�a varchar(50),
 nombreCuenta varchar(50),
 nombrePersona varchar(50)
)


INSERT INTO [dbo].[tbl_user]
           ([contrase�a]
           ,[nombreCuenta]
           ,[nombrePersona])
     VALUES
           ('kevin0123'
           ,'kevendara'
           ,'Kevin Endara')
GO


select * from tbl_user









