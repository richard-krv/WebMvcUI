--IF OBJECT_ID('dbo.sp_GetRangesForManufacturer', 'P') IS NOT NULL DROP PROCEDURE dbo.sp_GetRangesForManufacturer;
--DROP PROCEDURE IF EXISTS dbo.sp_GetRangesForManufacturer -- for 2016, sadly mine is just 2014)
--go

create  procedure sp_GetRangesForManufacturer @manufacturer varchar(50) = null
as
begin
    select 
		  r.[RangeId] 
		, r.[RangeName] 
		, r.[ManufacturerId]
		, r.[ImageFile] 
	from [range] r 
	join Manufacturer m on r.manufacturerid = m.manufacturerid
	where Manufacturername = @manufacturer 
	and @manufacturer is not null;
end
go
/*
Create table  #SpecificRanges
(   [RangeId] [int] ,
	[RangeName] [varchar](50) ,
	[ManufacturerId] [int] ,
	[ImageFile] [varchar](255) )

INSERT INTO #SpecificRanges
EXEC dbo.sp_GetRangesForManufacturer 'Ford'

select * from #SpecificRanges order by 2
drop table #SpecificRanges
*/