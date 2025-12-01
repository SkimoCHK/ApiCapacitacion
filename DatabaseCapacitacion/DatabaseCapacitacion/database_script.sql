CREATE DATABASE CapacitacionDB

CREATE TABLE Categorias(
	IdCategoria SERIAL PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	Estatus BOOL NOT NULL
)

CREATE TABLE Productos(
	IdProducto SERIAL PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	CategoriaId INT NOT NULL,
	CONSTRAINT fk_categoria FOREIGN KEY(CategoriaId)
	REFERENCES Categorias (IdCategoria)
	ON DELETE CASCADE
)




INSERT INTO Categorias (Nombre, Estatus) VALUES
('Electrónica', TRUE),
('Ropa', TRUE),
('Juguetes', TRUE),
('Hogar', TRUE),
('Oficina', FALSE);

INSERT INTO Productos (Nombre, CategoriaId) VALUES
('Televisor LED 55"', 1),
('Laptop HP 14"', 1),
('Audífonos Bluetooth', 1),

('Playera deportiva', 2),
('Pantalón mezclilla', 2),

('Lego Star Wars', 3),
('Muñeca Barbie', 3),
('Pelota de futbol', 3),

('Silla reclinable', 4),
('Juego de sábanas', 4),

('Tinta negra HP', 5),
('Paquete de hojas tamaño carta', 5);


SELECT * FROM Productos



CREATE VIEW view_ProductoCategoria
AS
SELECT p.Nombre as "NombreProducto", c.Nombre as "NombreCategoria"
FROM Productos p
INNER JOIN Categorias c
ON p.CategoriaId = c.IdCategoria




SELECT * FROM view_ProductoCategoria



