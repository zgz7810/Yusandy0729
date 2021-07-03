CREATE TABLE [dbo].[Table]
(
	[fId] INT NOT NULL PRIMARY KEY, 
    [fUserId] NVARCHAR(50) NULL, 
    [fPwd] NVARCHAR(50) NULL, 
    [fName] NVARCHAR(50) NULL, 
    [fEmail] NVARCHAR(50) NULL, 
    [fAdress] NVARCHAR(50) NOT NULL, 
    [fTel] NVARCHAR(50) NULL
)
