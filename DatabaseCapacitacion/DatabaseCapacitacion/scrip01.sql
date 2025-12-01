--Reglas de negocio:
--No inscribir si el curso está lleno.
--No eliminar curso con alumnos.
--Validar edad mínima.
--Al inscribir: actualizar ambos lados (Alumno y Curso).
--Al cambiar de curso: decrementar + validar + incrementar.
--Al desinscribir: CursoId NULL + decrementar Inscritos.



CREATE TABLE Curso(
	IdCurso SERIAL PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	CupoMaximo INT NOT NULL,
	Inscritos INT NOT NULL
)


CREATE TABLE Alumno(
	IdAlumno SERIAL PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	Edad INT NOT NULL,
	Email VARCHAR NOT NULL UNIQUE,
	CursoId INT NULL,
	CONSTRAINT fk_curso FOREIGN KEY (CursoId)
	REFERENCES Curso (IdCurso)
)

INSERT INTO Curso (Nombre, CupoMaximo, Inscritos) VALUES
('Matemáticas Básicas', 8, 0),
('Programación en C#', 7, 0),
('Inglés Intermedio', 6, 0),
('Historia Universal', 5, 0),
('Bases de Datos con PostgreSQL', 7, 0),
('Introducción a Física', 8, 0),
('Diseño Web con HTML y CSS', 5, 0),
('Algoritmos y Lógica de Programación', 6, 0),
('Química General', 7, 0),
('Redes de Computadoras', 6, 0);


SELECT * FROM CURSO




