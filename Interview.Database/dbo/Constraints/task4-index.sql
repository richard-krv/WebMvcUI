-- There are thre things to consider when filtering on a text field:
--
-- 1 - conventional situation when an index is needed to seek through varchars
CREATE INDEX ix_filt_ManufacturerName ON dbo.Manufacturer (ManufacturerName ASC) 
WITH(ONLINE=ON);
go
-- 2
-- indexing such a small table could be an overhead, as just scanning 3 rows table could be faster than
-- involving optimizer and maintaining the index when data changes
/*
-- 3 
-- we could use a filtered index on one or several most busy fields like so
CREATE INDEX ix_filt_ManufacturerName ON dbo.Manufacturer (ManufacturerName ASC) 
WHERE ManufacturerName = 'Ford'
WITH(ONLINE=ON);
go
*/

/*
SELECT *
FROM Manufacturer
WHERE ManufacturerName = 'Ford'
go

SELECT *
FROM Manufacturer
WHERE ManufacturerName = 'Audi'
*/