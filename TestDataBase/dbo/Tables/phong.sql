CREATE TABLE [dbo].[phong] (
    [maphong]      CHAR (4)     NOT NULL,
    [tenloaiphong] VARCHAR (10) NULL,
    [tinhtrang]    BIT          NULL,
    PRIMARY KEY CLUSTERED ([maphong] ASC),
    FOREIGN KEY ([tenloaiphong]) REFERENCES [dbo].[loaiphong] ([tenloaiphong])
);

