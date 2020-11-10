CREATE PROCEDURE dbo.spOpravaZaznamu
AS
BEGIN
	declare @aktRadek int
	declare @IdPokladniZaznam int
	declare @Datum datetime
	declare @CisloPolozky int
	declare @Zustatek float
	declare @t table (
	[Index] int,
	Datum datetime,
	Cislo int,
	Zustatek float
	)


if exists (select * from PokladniZaznamy)
	begin
		insert into @t select [Index]=ROW_NUMBER() over (order by Datum), Datum, Cislo, Zustatek from PokladniZaznamy
		--select * from @t
		--select @aktRadek=1

		select top 1 @aktRadek=[Index], @Datum=Datum, @CisloPolozky=Cislo, @Zustatek=Zustatek from @t order by [Index]

		while @aktRadek is not null
			begin
					if @aktRadek = 1
					begin
						update PokladniZaznamy set Cislo=1, Zustatek=Castka, @Zustatek=Castka where IdPokladniZaznam=@IdPokladniZaznam
						select @CisloPolozky=1
					end
				else
					begin
					print (@Zustatek)
					update PokladniZaznamy set Cislo=@CisloPolozky+1, Zustatek=@Zustatek+Castka, @CisloPolozky=@CisloPolozky+1, @Zustatek=@Zustatek+ Castka where IdPokladniZaznam=@IdPokladniZaznam
					end

				select @aktRadek=min([Index]) from @t where [Index]>@aktRadek
				select @IdPokladniZaznam=IdPokladniZaznam, @Datum=Datum from @t where [Index]=@aktRadek
			end
		end


END