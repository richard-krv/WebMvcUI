--IF OBJECT_ID('dbo.vw_manufacture_range', 'V') IS NOT NULL DROP VIEW dbo.vw_manufacture_range;
--go

create view vw_manufacture_range as
select 
   m.ManufacturerId
 , ManufacturerName
 , r.RangeId
 , RangeName
from Manufacturer m join [Range] r on r.manufacturerid = m.manufacturerid
--order by 1, 4
go

--select * from vw_manufacture_range order by 1, 4
