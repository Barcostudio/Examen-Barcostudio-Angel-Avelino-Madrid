create trigger tg_prom
on calificaciones 
after insert, update
as 
begin

declare @id as int
declare @p1 as int
declare @p2 as int
declare @p3 as int
declare @promedio as int

select @id = idCali FROM calificaciones;
select @p1 = Pparcial from calificaciones;
select @p2 = Sparcial from calificaciones;
select @p3 = Tparcial from calificaciones;
select @promedio = (@p1 + @p2 + @p3)/3;

update calificaciones 
set calificaciones = @promedio where idCali=@id

end