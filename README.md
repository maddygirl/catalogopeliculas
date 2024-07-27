
README
Catálogo de Películas
Este proyecto consiste en una aplicación de escritorio desarrollada en Visual Basic que permite gestionar un catálogo de películas. Utiliza una base de datos en SQL Server para almacenar información sobre usuarios y películas.

Características
•	Registro de Usuarios: Permite registrar nuevos usuarios con roles de administrador o usuario estándar.
•	Autenticación: Inicio de sesión seguro utilizando encriptación SHA-256 para contraseñas.
•	Gestión de Películas: Funcionalidades para agregar, modificar, buscar y eliminar películas del catálogo.
•	Validaciones: Validación de campos como el año de la película y correo electrónico utilizando funciones específicas.
•	Interfaz Gráfica: Diseño intuitivo con formularios para diferentes roles (administrador y usuario).

Requisitos Previos
Visual Studio: Se requiere Visual Studio con soporte para Visual Basic.
https://visualstudio.microsoft.com/es/vs/community/

SQL Server: Base de datos en SQL Server con las siguientes tablas:
https://www.microsoft.com/en-us/sql-server/sql-server-downloads

1.	Usuario: Almacena información de usuarios como ID, nombre de usuario, correo electrónico, contraseña (encriptada) y rol.
2.	Peliculas: Contiene detalles de cada película como ID, título, director, año de estreno, duración, sinopsis, género y URL del póster.
Configuración del Proyecto
Configuración de la Base de Datos:
-	linea de conexion: 
Public conexion As SqlConnection = New SqlConnection("Data source=DataBase; Initial Catalog=Catalogo_Peliculas; trusted_connection=Yes")
Uso
•	Inicio de Sesión:
Ejecuta la aplicación y utiliza las credenciales de usuario para iniciar sesión.
Dependiendo del rol (administrador o usuario), tendrás acceso a diferentes funciones.
•	Gestión de Películas:
Agregar Película: Llena los campos requeridos y agrega nuevas películas al catálogo.
Modificar Película: Actualiza la información de películas existentes.
Eliminar Película: Elimina películas del catálogo después de confirmar la operación.
•	Registro de Usuarios:
Utiliza el formulario de registro para crear nuevas cuentas de usuario.
El sistema valida la existencia previa de usuarios y correos electrónicos para evitar duplicados.

Contribuciones
Este proyecto es de código abierto y las contribuciones son bienvenidas. Si deseas contribuir, por favor:



