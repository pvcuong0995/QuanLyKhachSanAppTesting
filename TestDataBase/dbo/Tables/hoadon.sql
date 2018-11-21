CREATE TABLE [dbo].[hoadon] (
    [mahd]     CHAR (5) NOT NULL,
    [madp]     CHAR (5) NOT NULL,
    [ngaylap]  DATE     DEFAULT (getdate()) NOT NULL,
    [tongtien] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([mahd] ASC),
    FOREIGN KEY ([madp]) REFERENCES [dbo].[datphong] ([madp])
);

