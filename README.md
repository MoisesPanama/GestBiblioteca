# GestBiblioteca — Sistema de Gestión Bibliotecaria
## ASP.NET Core MVC

## Módulos del sistema
- **Préstamos**: gestión de préstamos de libros (Estudiante, Libro, Fechas, Estado).
- **Productos** *(nuevo — práctica TA)*: gestión de productos con tabla HTML, validación cliente/servidor y eliminación segura con confirmación + CSRF.

## Instrucciones de ejecución

1. Clonar el repositorio:
   
    git clone https://github.com/MoisesPanama/GestBiblioteca.git


2. Entrar a la carpeta del proyecto:

   cd GestBiblioteca/GestBibliotecaApp


3. (Opcional) Cambiar a la rama de esta práctica para ver el módulo de Productos:

    git checkout feature/practica-aspnet


4. Ejecutar el proyecto:
   
    dotnet run


5. Abrir en el navegador la URL que muestre la terminal (el puerto puede variar según la máquina). En este proyecto normalmente es:
   
    http://localhost:5248/Prestamo

    http://localhost:5248/Producto

## Funcionalidades del módulo de Préstamos
- Registro de préstamos (Estudiante, Libro, Fecha de préstamo, Fecha de devolución, Estado: Activo / Devuelto / Vencido / Renovado).
- Eliminación con confirmación y protección CSRF.

## Funcionalidades del módulo de Productos (práctica TA)
- **Listado (Index):** tabla HTML con Nombre, Descripción, Precio, Stock y acciones.
- **Crear (Create):** formulario protegido con `AntiForgeryToken`, con validación cliente (jQuery Unobtrusive) y validación server-side (`ModelState.IsValid` + Data Annotations).
- **Eliminar (Delete):** flujo de dos pasos — primero una vista de confirmación (GET, no destructiva), y solo al confirmar se ejecuta el borrado real (POST protegido con `[ValidateAntiForgeryToken]`).

## Notas técnicas
- La cultura del proyecto se fijó a `en-US` en `Program.cs` para que los precios usen punto decimal y signo `$`, sin depender de la configuración regional del sistema operativo donde se ejecute.

## Flujo de Git/GitHub utilizado

### Práctica anterior (Préstamos)
Las funcionalidades extendidas (Delete con confirmación, CSRF y validación cliente) se desarrollaron en la rama `feature/extension-delete-csrf` e integradas a `main` mediante Pull Request.

### Práctica TA (Productos)
Rama de trabajo: `feature/practica-aspnet`

Commits realizados:
1. Modelo `Producto` con Data Annotations
2. `ProductoController` con Index, Create y Delete (CSRF)
3. Vistas Razor: Index (tabla HTML), Create y Delete
4. Fix de cultura en `Program.cs` para formato de precio
5. Actualización de README con instrucciones

## Autor
Panamá Murillo Moisés Antonio — Aplicaciones Web, SOFT-R-A, 5to Nivel, Corte 1