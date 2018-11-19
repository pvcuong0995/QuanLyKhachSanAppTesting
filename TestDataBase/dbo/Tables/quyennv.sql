CREATE TABLE [dbo].[quyennv] (
    [manv]    CHAR (5) NOT NULL,
    [id]      CHAR (1) NOT NULL,
    [matkhau] CHAR (3) NOT NULL,
    PRIMARY KEY CLUSTERED ([manv] ASC, [id] ASC),
    FOREIGN KEY ([id]) REFERENCES [dbo].[phanquyen] ([id]),
    FOREIGN KEY ([manv]) REFERENCES [dbo].[nhanvien] ([manv])
);

