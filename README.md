\# DemoHttp (.NET MAUI + Blazor Hybrid)



Este proyecto es una aplicación de ejemplo construida con .NET MAUI y Blazor, que demuestra cómo consumir servicios HTTP y mostrar una lista de tareas (Todo List) en una interfaz multiplataforma. Se consume servicio REST para uso educativo https://jsonplaceholder.typicode.com/



\## Características



\- Arquitectura basada en .NET MAUI y Blazor.

\- Consumo de servicios HTTP para obtener datos de tareas (todos).

\- Visualización de la lista de tareas con detalles y opción de edición.

\- Navegación entre páginas usando el sistema de rutas de Blazor.

\- Código limpio y organizado, ideal como base para proyectos similares.

\- Se usa clase HttpClient implementada por Inyección de Dependencias, para conectar a Endpoints de la API



\## Estructura principal



\- \*\*DemoHttp/Components/Pages/Home.razor\*\*: Página principal que muestra la lista de tareas y detalles.

\- \*\*DemoHttp/Services/ITodoService.cs\*\*: Interfaz para el servicio de tareas.

\- \*\*DemoHttp/Services/TodoService.cs\*\*: Implementación del servicio HTTP para obtener las tareas.

\- \*\*DemoHttp/Models/Todo.cs\*\*: Modelo de datos para las tareas.



\## Requisitos



\- \[.NET 9 SDK](https://dotnet.microsoft.com/download)

\- Visual Studio 2022 (con soporte para .NET MAUI)



\## Ejecución



1\. Clona el repositorio:



git clone https://github.com/federicotrani/DemoHttp.git



2\. Abre la solución en Visual Studio 2022.

3\. Restaura los paquetes NuGet si es necesario.

4\. Selecciona la plataforma de destino (Android, iOS, Windows, MacCatalyst).

5\. Ejecuta el proyecto.



\## Uso



\- Al iniciar la aplicación, se muestra una lista de tareas.

\- Haz clic en una tarea para ver sus detalles.

\- Pulsa el botón "Editar" para navegar a la página de edición (si está implementada).



\## Créditos



Proyecto de ejemplo para demostrar el uso de .NET MAUI y Blazor con servicios HTTP.



---



Si tienes sugerencias o encuentras algún problema, por favor abre un issue en el repositorio.





