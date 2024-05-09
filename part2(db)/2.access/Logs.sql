CREATE TABLE [Logs] (
    [LogId]   AUTOINCREMENT,
    [Info] TEXT  NOT NULL,
    [Created] DateTime NOT NULL,
    [UserId] INT NOT NULL CONSTRAINT FK_UserId  REFERENCES Users (UserId),
    CONSTRAINT UserId PRIMARY KEY ([LogId])   
)
