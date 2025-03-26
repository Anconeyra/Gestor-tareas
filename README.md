# 📌 Proyecto en Rider - Lista de Tareas

![{145331A3-3834-4BC3-8FBC-6E9981E6BA56}](https://github.com/user-attachments/assets/8cf20295-1895-434b-a557-3a19eb6fd85c)

### 📝 Descripción
Este es un proyecto web desarrollado en **ASP.NET Core MVC** que permite gestionar una lista de tareas. Los usuarios pueden agregar, editar, eliminar y marcar tareas como completadas mediante una interfaz moderna y profesional.

El proyecto utiliza **almacenamiento en memoria**, por lo que no requiere una base de datos externa.

También cuenta con integración de **Swagger**, lo que facilita la prueba y documentación de la API.

---

🔗 **Accede a la creación de este trabajo:**  
[Documentación](https://docs.google.com/document/d/1cyY6ud6-8OsS7hJiO8YyuJ9w1bF9C5lydIj11BWFc2o/edit?usp=sharing)

## 🚀 Tecnologías Utilizadas

- **ASP.NET Core MVC** - Framework backend  
- **Entity Framework Core (En memoria)** - Para gestionar los datos sin base de datos externa  
- **Bootstrap 5** - Diseño responsivo y moderno  
- **jQuery & AJAX** - Interacciones dinámicas  
- **Swagger** - Documentación interactiva de la API  

---

## 📖 Lenguajes Usados

<p align="center">
  <img src="https://github.com/user-attachments/assets/0b08308a-9859-4e94-b604-ea54b627016d" width="60"/>
  <img src="https://github.com/user-attachments/assets/c682a363-032f-4e7d-92ce-db523ae95674" width="60"/>
  <img src="https://github.com/user-attachments/assets/916b4878-6041-4a06-88d6-ad79e355380e" width="60"/>
  <img src="https://github.com/user-attachments/assets/4c345721-15e2-4749-9151-031ecb4f06d7" width="60"/>
  <img src="https://github.com/user-attachments/assets/7c4877f0-f3cf-4cbc-a846-7ed107d8fd2e" width="60"/>
</p>

---

## 🎯 Funcionalidades
✅ Agregar nuevas tareas  
✅ Marcar tareas como completadas con un solo clic  
✅ Editar tareas existentes  
✅ Eliminar tareas de la lista  
✅ Diseño moderno y responsivo  
✅ Almacenamiento en memoria sin base de datos externa  
✅ Documentación y prueba de API con Swagger  

---

## 📖 Acceso a Swagger

Una vez que la aplicación esté en ejecución, puedes acceder a **Swagger** en la siguiente URL:

🔗 `http://localhost:5000/swagger` (puede variar según tu configuración)

Desde aquí puedes probar los endpoints de la API, ver la documentación y realizar solicitudes HTTP sin necesidad de un cliente externo como Postman.

---

## 🔧 Instalación y Configuración

```bash
# 1️⃣ Clona el repositorio
git clone https://github.com/Anconeyra/Gestor-tareas.git

# 2️⃣ Accede al directorio del proyecto
cd Gestor-tarea

# 3️⃣ Restaura los paquetes NuGet
dotnet restore

# 4️⃣ Ejecuta el proyecto
dotnet run

# 5️⃣ Accede a la interfaz web y Swagger
# Interfaz web:
http://localhost:5000  
# Documentación de API (Swagger):
http://localhost:5000/swagger
