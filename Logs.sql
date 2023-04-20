CREATE TABLE [dbo].[Logs] (
    [LogId]   INT            IDENTITY (1, 1) NOT NULL,
    [Info]    NVARCHAR (MAX) NOT NULL,
    [Created] DATETIME       NOT NULL,
    [UserId]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([LogId] ASC),
    CONSTRAINT [FK_Logs_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);
