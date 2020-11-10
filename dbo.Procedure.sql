CREATE PROCEDURE dbo.spOpravaZaznamu
AS
BEGIN
	declare @CisloPolozky int
	declare @Zustatek float


if exists (select * from PokladniZaznamy)
	begin
		select [Index]=ROW_NUMBER() over (order by Datum), Cislo, Zustatek from PokladniZaznamy
		while 1=2
			begin
				select 0
			end
		end


END