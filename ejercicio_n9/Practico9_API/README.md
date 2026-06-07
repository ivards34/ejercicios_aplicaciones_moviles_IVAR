# Práctico 9: Consumir una API REST con .NET MAUI

Este proyecto implementa los 4 ejercicios del práctico 9 de Programación III - Aplicaciones Móviles con .NET MAUI.

## Ejercicios Implementados

### Ejercicio 1: Mostrar una lista de posts (GET básico) - 30 puntos
- Consumir la API gratuita JSONPlaceholder
- Mostrar una lista de 100 posts en pantalla
- API: https://jsonplaceholder.typicode.com/posts

### Ejercicio 2: Mostrar usuarios con imágenes - 25 puntos
- Consumir la API Reqres.in que devuelve usuarios con avatar
- Mostrar usuarios con foto, nombre y email
- API: https://reqres.in/api/users?page=1

### Ejercicio 3: Buscar posts por ID - 25 puntos
- Agregar un Entry y un Button para buscar un post específico
- Buscar post por ID (1-100)
- API: https://jsonplaceholder.typicode.com/posts/{id}

### Ejercicio 4: Manejar error de sin internet - 20 puntos
- Verificar conectividad antes de hacer la petición
- Manejar errores de conexión y timeout
- Mostrar mensajes amigables al usuario

## Estructura del Proyecto

```
Practico9_API/
├── Models/
│   ├── Post.cs              # Modelo para posts
│   ├── Usuario.cs           # Modelo para usuarios
│   └── RespuestaUsuarios.cs # Modelo de respuesta de usuarios
├── Services/
│   └── ApiService.cs        # Servicio para consumir APIs
├── MainPage.xaml           # Interfaz con tabs para los 4 ejercicios
├── MainPage.xaml.cs        # Code-behind con la lógica
└── Practico9_API.csproj    # Archivo de proyecto
```

## Cómo Ejecutar

### Requisitos Previos
- .NET 10.0 SDK instalado
- Visual Studio 2022 o VS Code con extensión MAUI
- Conexión a internet para probar las APIs

### Pasos

1. **Abrir el proyecto:**
   ```bash
   cd Practico9_API
   ```

2. **Restaurar dependencias:**
   ```bash
   dotnet restore
   ```

3. **Compilar el proyecto:**
   ```bash
   dotnet build
   ```

4. **Ejecutar en Windows:**
   ```bash
   dotnet build -t:Run -f net10.0-windows10.0.19041.0
   ```

5. **O ejecutar desde Visual Studio:**
   - Abrir `Practico9_API.csproj`
   - Seleccionar Windows Machine como destino
   - Presionar F5 o clic en "Iniciar"

## Uso de la Aplicación

La aplicación tiene 4 tabs, uno por cada ejercicio:

1. **Posts:** Presiona "Cargar Posts" para ver la lista de 100 posts
2. **Usuarios:** Presiona "Cargar Usuarios" para ver 6 usuarios con sus avatares
3. **Buscar:** Ingresa un ID (1-100) y presiona "Buscar" para ver un post específico
4. **Errores:** Prueba desconectando internet y presionando "Cargar Posts" para ver el manejo de errores

## Tecnologías Utilizadas

- .NET MAUI
- C# 10
- System.Text.Json para deserialización
- HttpClient para peticiones HTTP
- Connectivity para verificar conexión a internet

## APIs Utilizadas

- **JSONPlaceholder:** https://jsonplaceholder.typicode.com/ (API gratuita de posts)
- **Reqres.in:** https://reqres.in/ (API gratuita de usuarios)

## Notas

- Las APIs son gratuitas y no requieren API Key
- Cada ejercicio está en un tab separado para facilitar la navegación
- El manejo de errores incluye verificación de conectividad, timeout y errores de servidor
- Se usa System.Text.Json que viene incluido con .NET
