create procedure cargaralu 
as 
select idAlumno,Nombre,Apellido_Pa,Apellido_Ma from alumno
go 


exec cargaralu