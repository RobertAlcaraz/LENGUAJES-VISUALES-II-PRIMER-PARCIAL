Este proyecto es una API RESTful para gestionar un sistema de comercio electrónico. 
Permite realizar operaciones CRUD (Crear, Leer, Actualizar, Borrar) sobre entidades como usuarios, clientes, productos y órdenes.
La API cuenta con autenticación basada en JWT (JSON Web Tokens) para proteger los endpoints.
Instalacion y uso

Clonar el repositorio:
git clone 

Abrir en Visual Studio o Visual Studio Code.

Configurar la base de datos:

Abre el archivo appsettings.json.

Cambia la DefaultConnection para que apunte a tu servidor de SQL Server.

Ejecutar migraciones de la base de datos:

Abre la consola del Administrador de paquetes (Package Manager Console) en Visual Studio.

Ejecuta Add-Migration InitialCreate

Ejecuta Update-Database

Ejecutar la aplicación:

Inicia el proyecto. La API se ejecutará en los puertos definidos en launchSettings.json.

para obtener el token se utiliza el usuario y la contraseña de tu SQL server, una vez obtengas el token
en el boton Authorize ingresas Bearer (y tu token) una vez hecho eso podras realizar las operaciones que necesiten autorizacion
