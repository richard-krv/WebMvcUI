-- task 1
alter table dbo.[range] add constraint fk_range_manufacturer foreign key ([ManufacturerId]) 
	references dbo.manufacturer([ManufacturerId])
