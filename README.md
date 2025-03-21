Стратегии за съпоставяне на класове към таблици на база данни
#### [Inheritance with EF Code First: Part 1 – Table per Hierarchy (TPH)](https://asp-blogs.azurewebsites.net/manavi/inheritance-mapping-strategies-with-entity-framework-code-first-ctp5-part-1-table-per-hierarchy-tph)
#### [Inheritance with EF Code First: Part 2 – Table per Type (TPT)](https://asp-blogs.azurewebsites.net/manavi/inheritance-mapping-strategies-with-entity-framework-code-first-ctp5-part-2-table-per-type-tpt)
#### [Inheritance with EF Code First: Part 3 – Table per Concrete Type (TPC)](https://asp-blogs.azurewebsites.net/manavi/inheritance-mapping-strategies-with-entity-framework-code-first-ctp5-part-3-table-per-concrete-type-tpc-and-choosing-strategy-guidelines)

CREATE TABLE [dbo].[Table1] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [Number] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TRIGGER [dbo].[InsertTable]
ON Table1
FOR INSERT
AS 
BEGIN
	SELECT * FROM inserted;
	DECLARE @ROWCOUNT INT
	SET @ROWCOUNT = @@ROWCOUNT
	SET NOCOUNT ON;
	IF @ROWCOUNT = 1
	BEGIN
		IF (SELECT COUNT(*) FROM Table1 WHERE Table1.[Number] = 
		(SELECT inserted.[Number] FROM inserted)) > 3
		BEGIN
			ROLLBACK
			RETURN
		END
	END
	ELSE
	BEGIN
		PRINT '';
	END
END

insert into Table1 (Number)
values (3)
