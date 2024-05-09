CREATE TABLE [Users] (
    [UserId]   AUTOINCREMENT,
    [Username] TEXT (100)  NOT NULL,
    [Password] TEXT (100) NULL,
    CONSTRAINT UserId PRIMARY KEY ([UserId]),
    UNIQUE (Username)
)
