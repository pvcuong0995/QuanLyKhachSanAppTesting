CREATE TABLE [dbo].[nhanvien] (
    [manv]     CHAR (5)      NOT NULL,
    [macv]     CHAR (2)      NOT NULL,
    [hoten]    NVARCHAR (30) NOT NULL,
    [ngaysinh] DATE          NOT NULL,
    [gioitinh] NVARCHAR (3)  NOT NULL,
    [sdt]      VARCHAR (12)  NOT NULL,
    [cmnd]     CHAR (9)      NOT NULL,
    [diachi]   NVARCHAR (50) NOT NULL,
    [email]    VARCHAR (30)  NULL,
    PRIMARY KEY CLUSTERED ([manv] ASC),
    CHECK ([cmnd] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CHECK ([email] like '[a-z]%@[a-z]%.[a-z]%'),
    CHECK ([gioitinh]=N'Nữ' OR [gioitinh]=N'Nam'),
    CHECK ([ngaysinh]<getdate()),
    CHECK ([sdt] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [sdt] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    FOREIGN KEY ([macv]) REFERENCES [dbo].[chucvu] ([macv]),
    UNIQUE NONCLUSTERED ([cmnd] ASC),
    UNIQUE NONCLUSTERED ([email] ASC)
);

