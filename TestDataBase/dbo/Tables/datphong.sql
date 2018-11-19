CREATE TABLE [dbo].[datphong] (
    [madp]         CHAR (5)     NOT NULL,
    [manv]         CHAR (5)     NOT NULL,
    [makh]         CHAR (5)     NOT NULL,
    [tenloaiphong] VARCHAR (10) NOT NULL,
    [ngaydat]      DATE         DEFAULT (getdate()) NOT NULL,
    [ngayden]      DATE         DEFAULT (getdate()) NOT NULL,
    [ngaydi]       DATE         DEFAULT (getdate()) NOT NULL,
    [tiendatcoc]   INT          NULL,
    [soluong]      INT          NOT NULL,
    [trangthai]    BIT          NULL,
    PRIMARY KEY CLUSTERED ([madp] ASC),
    FOREIGN KEY ([makh]) REFERENCES [dbo].[khachhang] ([makh]),
    FOREIGN KEY ([manv]) REFERENCES [dbo].[nhanvien] ([manv]),
    FOREIGN KEY ([tenloaiphong]) REFERENCES [dbo].[loaiphong] ([tenloaiphong])
);

