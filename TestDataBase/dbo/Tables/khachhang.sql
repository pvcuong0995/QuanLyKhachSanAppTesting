CREATE TABLE [dbo].[khachhang] (
    [makh]   CHAR (5)      NOT NULL,
    [hoten]  NVARCHAR (30) NOT NULL,
    [cmnd]   CHAR (9)      NOT NULL,
    [sdt]    VARCHAR (12)  NOT NULL,
    [email]  VARCHAR (30)  NULL,
    [diachi] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([makh] ASC),
    CHECK ([cmnd] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CHECK ([email] like '[a-z]%@[a-z]%.[a-z]%'),
    CHECK ([sdt] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [sdt] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    UNIQUE NONCLUSTERED ([cmnd] ASC),
    UNIQUE NONCLUSTERED ([email] ASC)
);

