## Base de Datos 



# Sistema de Calificación de Libros

Este proyecto implementa una base de datos MySQL con Visual Basic .NET para gestionar usuarios, libros y calificaciones de libros. La aplicación tiene un diseño en capas (DAL, BLL y PL) y permite realizar operaciones CRUD en las tablas de `Usuario` y `Libro`. También permite calificar libros y obtener el promedio de calificaciones.

---

## Creación de Base de Datos y Tablas

Ejecuta el siguiente código SQL en tu base de datos MySQL para configurar las tablas:

```sql
-- Crear base de datos
CREATE DATABASE Biblioteca;
USE Biblioteca;

-- Crear tabla `Usuario`
CREATE TABLE Usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL
);

-- Crear tabla `Libro`
CREATE TABLE Libro (
    id INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(200) NOT NULL,
    autor VARCHAR(100) NOT NULL
);

-- Crear tabla `Calificacion`
CREATE TABLE Calificacion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    libro_id INT,
    calificacion INT CHECK (calificacion BETWEEN 1 AND 5),
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id),
    FOREIGN KEY (libro_id) REFERENCES Libro(id),
    UNIQUE (usuario_id, libro_id)  -- Asegura que un usuario solo pueda calificar un libro una vez
);
``` 

# Procedimientos Almacenados para Calificaciones de Libros

Este archivo describe los procedimientos almacenados en MySQL para gestionar y consultar calificaciones de libros en una base de datos.

## Procedimientos

### 1. `CalificarLibro`

Este procedimiento se utiliza para agregar o actualizar la calificación de un libro por parte de un usuario. Si el usuario ya ha calificado el libro previamente, su calificación será actualizada; de lo contrario, se agregará una nueva calificación.

#### Definición

```sql
CREATE DEFINER=`root`@`localhost` PROCEDURE `CalificarLibro`(
    IN p_usuario_id INT,
    IN p_libro_id INT,
    IN p_calificacion INT
)
BEGIN
    DECLARE existe INT;
    
    -- Verificar si el usuario ya ha calificado el libro
    SELECT COUNT(*) INTO existe
    FROM Calificacion
    WHERE usuario_id = p_usuario_id AND libro_id = p_libro_id;
    
    IF existe > 0 THEN
        -- Si ya existe la calificación, se actualiza
        UPDATE Calificacion
        SET calificacion = p_calificacion
        WHERE usuario_id = p_usuario_id AND libro_id = p_libro_id;
    ELSE
        -- Si no existe, se inserta una nueva calificación
        INSERT INTO Calificacion (usuario_id, libro_id, calificacion)
        VALUES (p_usuario_id, p_libro_id, p_calificacion);
    END IF;

    -- Calcular el nuevo promedio de calificaciones para el libro
    SELECT AVG(calificacion) INTO @nuevo_promedio
    FROM Calificacion
    WHERE libro_id = p_libro_id;

    -- Devolver el promedio calculado
    SELECT @nuevo_promedio AS PromedioCalificacion;
END;
```  
```sql
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPromedioCalificacion`(
    IN p_libro_id INT
)
BEGIN
    -- Calcular el promedio de calificación para el libro especificado
    SELECT AVG(calificacion) AS PromedioCalificacion
    FROM Calificacion
    WHERE libro_id = p_libro_id;
END;
```



# Proyecto: Gestión de Usuarios y Libros

Este proyecto permite la administración de usuarios y libros, incluyendo funcionalidades de CRUD (Crear, Leer, Actualizar, Eliminar) para ambos. Además, cuenta con una sección de calificación para los libros que permite asignar una valoración a cada uno de ellos.

## Instrucciones de Implementación

### Estructura BLL (Capa de Lógica de Negocios)

1. **Clases `LibroBLL` y `UsuarioBLL`**
   - Agrega las siguientes funciones en ambas clases para la gestión de datos:
     - **Insertar:** Método para agregar un nuevo registro.
     - **Actualizar:** Método para modificar un registro existente.
     - **Eliminar:** Método para borrar un registro.

### Estructura de la Interfaz Gráfica

Utiliza un componente `TabControl` que contenga tres pestañas (`TabPage`), cada una con un `DataGridView` y un conjunto de controles específicos según la funcionalidad requerida.

#### Panel 1: Gestión de Usuarios
   - **Carga de datos:** Al iniciar, carga todos los usuarios en el `DataGridView`.
   - **CRUD de usuarios:** Permite seleccionar un usuario para:
     - **Actualizar:** Modifica la información del usuario seleccionado.
     - **Eliminar:** Borra el usuario seleccionado.
   - **Campo txtUsuarioId:** Al seleccionar un usuario en el `DataGridView`, pasa su ID al campo `txtUsuarioId`. Este ID se utilizará posteriormente para asignar calificaciones a un libro.

#### Panel 2: Gestión de Libros
   - **Carga de datos:** Al iniciar, carga todos los libros en el `DataGridView`.
   - **CRUD de libros:** Permite seleccionar un libro para:
     - **Insertar:** Agrega un nuevo libro a la base de datos.
     - **Actualizar:** Modifica la información del libro seleccionado.
     - **Eliminar:** Borra el libro seleccionado.

#### Panel 3: Calificación de Libros
   - **Carga de datos:** Al iniciar, carga todos los libros en el `DataGridView`.
   - **Campo txtLibroId:** Al seleccionar un libro, pasa su ID al campo `txtLibroId`.
   - **Asignación de calificación:** Permite asignar una calificación al libro seleccionado.
   - **Estética de la calificación:** Dependiendo del libro seleccionado, se mostrarán estrellas en un `PictureBox`, y el `Label` actualizará su valor para reflejar la calificación. (Esta parte será implementada posteriormente).

### Mejora de Estética
   - Optimiza el diseño visual de la interfaz, cuidando que los elementos sean accesibles y que los valores sean legibles en pantalla.

## Notas Finales

1. **Validaciones:** Asegúrate de realizar todas las validaciones necesarias antes de ejecutar cada acción CRUD.
2. **Eventos en `DataGridView`:** Usa los eventos de selección para actualizar los campos `txtUsuarioId` y `txtLibroId` de forma dinámica.

---

### Ejemplo de Código en Visual Basic .NET

Aquí tienes una base de cómo podrías estructurar el código para cada uno de los CRUD en `LibroBLL` y `UsuarioBLL`:

```vbnet
' Ejemplo de CRUD en UsuarioBLL
Public Class UsuarioBLL
    Public Sub InsertarUsuario(usuario As Usuario)
        ' Implementación para insertar usuario
    End Sub

    Public Sub ActualizarUsuario(usuario As Usuario)
        ' Implementación para actualizar usuario
    End Sub

    Public Sub EliminarUsuario(usuarioId As Integer)
        ' Implementación para eliminar usuario
    End Sub
End Class

' Ejemplo de CRUD en LibroBLL
Public Class LibroBLL
    Public Sub InsertarLibro(libro As Libro)
        ' Implementación para insertar libro
    End Sub

    Public Sub ActualizarLibro(libro As Libro)
        ' Implementación para actualizar libro
    End Sub

    Public Sub EliminarLibro(libroId As Integer)
        ' Implementación para eliminar libro
    End Sub
End Class
