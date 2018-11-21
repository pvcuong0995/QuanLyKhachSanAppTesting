CREATE TABLE [dbo].[chitietphongdat] (
    [madp]    CHAR (5) NOT NULL,
    [maphong] CHAR (4) NOT NULL,
    PRIMARY KEY CLUSTERED ([madp] ASC, [maphong] ASC),
    FOREIGN KEY ([maphong]) REFERENCES [dbo].[phong] ([maphong]),
    CONSTRAINT [FK__ctphongdat__madp__32E0915F] FOREIGN KEY ([madp]) REFERENCES [dbo].[datphong] ([madp]) ON DELETE CASCADE ON UPDATE CASCADE
);

