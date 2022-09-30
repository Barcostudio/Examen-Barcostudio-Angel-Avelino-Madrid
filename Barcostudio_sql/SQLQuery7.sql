insert into calificaciones(idAlumno,idMateria,Pparcial,Sparcial,Tparcial,calificaciones) values (7,3,8,7,9,0);

select * from alumno;

select * from materias;

select * from calificaciones;

select alumno.Nombre, alumno.Apellido_Pa, alumno.Apellido_Ma, calificaciones.Pparcial, calificaciones.Sparcial, calificaciones.Tparcial, calificaciones.calificaciones from calificaciones inner join alumno on calificaciones.idAlumno = alumno.idAlumno where alumno.Nombre = 'Angel' or alumno.Apellido_Pa = 'Avelino' or alumno.Apellido_Ma = 'Madrid';