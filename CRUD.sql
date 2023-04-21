CREATE DATABASE Pruaba;
GO
USE Pruaba;
GO
CREATE TABLE roles (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    descripcion VARCHAR(200)
);

CREATE TABLE usuarios (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    correo_electronico VARCHAR(100),
    contrasena VARCHAR(100),
    rol_id INT,
    FOREIGN KEY (rol_id) REFERENCES roles(id)
);

-- Agregar algunos roles
INSERT INTO roles (id, nombre, descripcion) VALUES (1, 'Administrador', 'Tiene acceso completo al sistema');
INSERT INTO roles (id, nombre, descripcion) VALUES (2, 'Usuario', 'Tiene acceso limitado al sistema');

-- Agregar algunos usuarios
INSERT INTO usuarios (id, nombre, correo_electronico, contrasena, rol_id) VALUES (1, 'Juan', 'juan@example.com', 'contrasena1', 1);
INSERT INTO usuarios (id, nombre, correo_electronico, contrasena, rol_id) VALUES (2, 'Maria', 'maria@example.com', 'contrasena2', 2);
INSERT INTO usuarios (id, nombre, correo_electronico, contrasena, rol_id) VALUES (3, 'Pedro', 'pedro@example.com', 'contrasena3', 2);
