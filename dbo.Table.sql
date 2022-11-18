﻿CREATE TABLE [dbo].[USERACCOUNTTABLE]
(
    [USERNAME] NVARCHAR(15) NOT NULL, 
    [PASSWORD] NVARCHAR(15) NULL, 
    [FIRSTNAME] NCHAR(20) NULL, 
    [LASTNAME] NCHAR(20) NULL, 
    [MIDDLENAME] NCHAR(20) NULL, 
    [SEX] NCHAR(10) NULL, 
    [DOB] DATE NULL, 
    [CONTACTNO] NUMERIC NULL, 
    [EMAIL] NVARCHAR(50) NULL, 
    [ADDRESS] NVARCHAR(MAX) NULL, 
    [IMAGE] IMAGE NULL , 
    CONSTRAINT [PK_USERACCOUNTTABLE] PRIMARY KEY ([USERNAME])
)
