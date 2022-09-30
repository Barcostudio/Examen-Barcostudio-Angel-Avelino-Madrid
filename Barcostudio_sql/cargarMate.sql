create procedure cargarmat
as 
select idMateria,Descripcion from materias
go 


exec cargarmat