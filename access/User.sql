CREATE TABLE [Users] (
    [UserId]   AUTOINCREMENT,
    [Username] VARCHAR (100)  NOT NULL,
    [Password] VARCHAR (100) NULL,
    CONSTRAINT UserId_PK PRIMARY KEY ([UserId]),
    UNIQUE ([Username])
)
