# DotNet practice

Una pequeña cheatsheet para ayudarme a entender .NET.

## Structure

_(WIP)_

## Variables

Declarar variables en C# es bastante sencillo.

## variables de tipo entero

```csharp
int number = 10;
```

## variables de tipo string (cadena)

```csharp
string message = "Hola";
```

## variables de tipo booleano

```csharp
bool isTrue = true;

bool isFalse = false;
```

## variables de tipo decimal

```csharp
decimal price = 1.15m;
```

## variables de tipo flotante

```csharp
float temperature = 36.6f;
```

## Nota importante

En C#, es importante especificar el tipo de dato de la variable al declararla. Esto ayuda a garantizar la seguridad de tipos en el código.

## Condicionales

En C#, las condicionales son estructuras de control de flujo que permiten tomar decisiones basadas en condiciones lógicas.

### If

Se utiliza para ejecutar un bloque de código si una condición es verdadera.

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}

```

### Else

Se usa para especificar un bloque de código que se ejecutará si la condición del if es falsa.

```csharp
int age = 16;

if (age >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}
else
{
    Console.WriteLine("Eres menor de edad.");
}
```

### Switch

Compara multiples valores, es una alternativa a if else.

```csharp
string day = "lunes";

switch (day)
{
    case "lunes":
        Console.WriteLine("Hoy es lunes.");
        break;
    case "martes":
        Console.WriteLine("Hoy es martes.");
        break;
    case "miércoles":
        Console.WriteLine("Hoy es miércoles.");
        break;
    default:
        Console.WriteLine("Día no válido.");
        break;
}
```

## For

La sentencia for en C# es una estructura de control que se utiliza para ejecutar un bloque de código un número determinado de veces.

```csharp
for (inicialización; condición; incremento/decremento)
{
    // Bloque de código a ejecutar
}
```

## Foreach

La instrucción foreach ejecuta una instrucción o un bloque de instrucciones para cada elemento.

```csharp
string[] names =
{
    "Julio","Jose","Ana","Susi","Ramon"
};

foreach (var name in names)
{
    Console.WriteLine(name);
}

```

## Arrays

Un array es una colección de elementos de un mismo tipo que se almacenan en posiciones continuas de memoria y se acceden mediante índices.

```csharp
// Declaración y asignación
int[] numbers = { 1, 2, 3, 4, 5 };

// Acceso a elementos
Console.WriteLine(numbers[0]); // Salida: 1

// Modificación de un elemento
numbers[2] = 10;
Console.WriteLine(numbers[2]); // Salida: 10

// Iterar un array
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

```

### Características de los arrays

- Los arrays tienen un tamaño fijo que se define en el momento de su creación.
- Son indexados a partir de 0.
- Puedes crear arrays de cualquier tipo de datos, incluyendo tipos definidos por el usuario.

```csharp
// Declarar un array vacío de tamaño fijo
string[] names = new string[3];
names[0] = "Ana";
names[1] = "Luis";
names[2] = "Carlos";
```

### Matrices (Arrays multidimensionales)

Una matriz en C# es un array que tiene múltiples dimensiones (filas y columnas)

```csharp
// Declaración e inicialización
int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

// Acceso a elementos
Console.WriteLine(matrix[0, 1]); // (fila 0, columna 1) = 2

// Modificación de un elemento
matrix[2, 0] = 10;

// Iterar la matriz
for (int i = 0; i < matrix.GetLength(0); i++) // Filas
{
    for (int j = 0; j < matrix.GetLength(1); j++) // Columnas
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine(); // Salto de línea
}

```

### Matrices tridimensionales

```csharp
int[,,] cube = new int[2, 2, 2];
cube[0, 0, 0] = 1;
cube[1, 1, 1] = 2;

```

### Arrays de arrays (jagged)

Un array "jagged" es un array cuyos elementos son otros arrays, lo que permite tener dimensiones de longitud variable.

```csharp
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6 };

// Acceso e iteración
foreach (var fila in jaggedArray)
{
    foreach (var elemento in fila)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}

```

## Slices (Segmentos)

En C#, los slices son partes de un array u otras estructuras similares. Utilizan la estructura ArraySegment<T> para manejar subconjuntos de datos.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

// Tomar un segmento de elementos
int[] slice = numbers[1..4]; // Elementos desde índice 1 hasta 3

foreach (int number in slice)
{
    Console.WriteLine(number); // Salida: 2, 3, 4
}

// Desde el inicio hasta un índice
int[] star = numbers[..3]; // Elementos 1, 2, 3

// Desde un índice hasta el final
int[] end = numbers[2..]; // Elementos 3, 4 , 5

```

## Functions

Las funciones en C# son bloques de código que realizan una tarea específica y pueden ser reutilizadas en diferentes partes de un programa.

## Tipos de funciones

- **Funciones sin retorno (void):** No devuelven ningún valor.

```csharp

void ShowMessage(){
    Console.WriteLine("Hello World");
}
```

- **Funciones con retorno:** Devuelven un valor del tipo especificado.

```csharp

int Add(int a,int b){
    return a + b;
}
```

- **Funciones con parámetros:** Reciben datos de entrada para realizar operaciones.

```csharp
void getName(string name)
{
    Console.WriteLine("Hello, " + name);
}
```

## Llamar a una función

```csharp
// funcion sin parametros
ShowMessage();

getName("Julio Cesar");

int result = Add(2,3);
```

Las funciones son fundamentales para estructurar y organizar el código, facilitando su mantenimiento y reutilización.

## Generics

Los Generics en C# son una característica que permite definir clases, interfaces y métodos que pueden operar con cualquier tipo de datos.

### ¿Por qué usar Generics?

- Reutilización de código: Puedes escribir una clase o método que funcione con diferentes tipos de datos.
- Seguridad de tipos: Detectan errores en tiempo de compilación en lugar de en tiempo de ejecución.

## Clase generica

```csharp
// Definición de una clase genérica
public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T item)
    {
        if(_list.Count < _limit)
        {
            _list.Add(item);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach(var element in _list)
        {
            content += element + ", ";
        }

        return content;
    }

}

// uso de la clase generica
var numbers = new MyList<int>(3);
var names = new MyList<string>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
Console.WriteLine(numbers.GetContent()); // salids : 1,2,3

names.Add("Ana");
names.Add("Julio");
names.Add("Mike");
Console.WriteLine(names.GetContent()); // salida: 'Ana','Julio','Mike'
```

## metodo generico

Un método genérico permite definir la lógica que funciona con tipos genéricos sin que toda la clase sea genérica.

```csharp
public class Utilidades
{
    public static void Mostrar<T>(T elemento)
    {
        Console.WriteLine($"Elemento: {elemento}");
    }
}

// Uso del método genérico
Utilidades.Mostrar<int>(5);           // Salida: Elemento: 5
Utilidades.Mostrar<string>("Hola");  // Salida: Elemento: Hola

```

## interface generica

Las interfaces genéricas permiten crear contratos para clases que usan tipos genéricos.

```csharp
public interface IRepositorio<T>
{
    void Agregar(T item);
    T Obtener(int id);
}

public class RepositorioPersonas : IRepositorio<string>
{
    private List<string> personas = new List<string>();

    public void Agregar(string persona)
    {
        personas.Add(persona);
    }

    public string Obtener(int id)
    {
        return personas[id];
    }
}

```

## Restricciones en Generics

Puedes restringir los tipos que pueden ser utilizados en un generics usando la palabra clave where.

- **where T : struct:** Solo permite tipos de valor.
- **where T : class:** Solo permite tipos de referencia.
- **where T : new():** Requiere un constructor público sin parámetros.
- **where T : BaseClass:** El tipo debe derivar de una clase base específica.
- **where T : IInterface:** El tipo debe implementar una interfaz específica

```csharp
public class Fabrica<T> where T : new()
{
    public T CrearInstancia()
    {
        return new T();
    }
}

// Uso
Fabrica<StringBuilder> fabrica = new Fabrica<StringBuilder>();
StringBuilder sb = fabrica.CrearInstancia();
Console.WriteLine(sb.GetType().Name); // Salida: StringBuilder

```

## higher-order functions

las funciones de orden superior pueden recibir otras funciones como parámetros o devolver funciones como resultado.

```csharp

var show = Show;


Some(show, "Hola");

string Show(string message)
{
    return message.ToUpper();
}

// Func resive un parametro y retorna un parametro, el ultimo elemento es el tipo de dato que retorna
void Some(Func<string, string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio");
    Console.WriteLine(fn(message));
    Console.WriteLine("Hace algo al final");
}
// salida:
// Hace algo al inicio
// HOLA
// Hace algo al final

//Func resive un parametro y retorna un parametro, el ultimo elemento es el tipo de dato que retorna
void Some(Func<string,string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio");
    Console.WriteLine(fn(message));
    Console.WriteLine("Hace algo al final");
}

Some(show, "Hola");
```

## lambdas

Una lambda es una función anónima, es decir, una función que no tiene un nombre explícito.

```csharp
Func<int,int,int> sub = (a,b) => a - b;

Console.WriteLine(sub(5,2)); // 5 - 2 = 3
```

## LINQ

El lenguaje integrado de consultas (LINQ) en C# utiliza funciones de orden superior como Select, Where, Aggregate, etc.

```csharp
string[] names =
{
    "Julio","Jose","Ana","Susi","Ramon"
};



var namesResult = from n in names
                  where n.Length > 3 && n.Length<5
                  orderby n descending
                  select n;

foreach (var name in namesResult)
{
    Console.WriteLine(name);
}

// concatenacion de funciones
var namesResult2 = names.Where(n => n.Length > 3 && n.Length <5)
                        .OrderByDescending(n => n)
                        .Select(d=>d);

foreach (var name in namesResult2)
{
    Console.WriteLine(name);
}
```

## CLI

### Información del entorno

- **dotnet --info:**

  - Descripción: Muestra información detallada sobre la instalación de .NET, incluyendo la versión del SDK, los runtimes instalados y detalles del sistema operativo.

  - Uso: Útil para verificar la configuración del entorno y solucionar problemas.

- **dotnet --version:**

  - Descripción: Imprime la versión del SDK de .NET instalada.
  - Uso: Útil para confirmar la versión del SDK que estás utilizando.

- **dotnet --list-sdks:**

  - Descripción: Lista todos los SDKs de .NET instalados en el sistema.
  - Uso: Ayuda a identificar qué versiones del SDK están disponibles.

- **dotnet --list-runtimes:**

  - Descripción: Lista todos los runtimes de .NET instalados en el sistema.
  - Uso: Útil para ver qué versiones del runtime están disponibles para ejecutar aplicaciones.

### Trabajando con proyectos

- **dotnet new [template]:**

  - Descripción: Crea un nuevo proyecto o archivo de código fuente basado en una plantilla específica (por ejemplo, console, webapi, mvc).
  - Uso: dotnet new console crea un nuevo proyecto de consola.

- **dotnet restore:**

  - Descripción: Restaura las dependencias y herramientas de un proyecto especificadas en el archivo de proyecto.
  - Uso: Se utiliza generalmente después de clonar un repositorio para descargar todas las dependencias necesarias.

- **dotnet build:**

  - Descripción: Compila el proyecto y todas sus dependencias.
  - Uso: Genera los archivos binarios necesarios para ejecutar la aplicación.

- **dotnet run:**

  - Descripción: Compila y ejecuta el proyecto.
  - Uso: Útil para probar rápidamente la aplicación durante el desarrollo.

- **dotnet publish:**

  - Descripción: Publica el proyecto, preparándolo para su despliegue. Incluye todos los archivos necesarios para ejecutar la aplicación en un entorno de producción.
  - Uso: dotnet publish -c Release -o ./publicado publica el proyecto en modo Release en la carpeta ./publicado.

- **dotnet clean:**

  - Descripción: Limpia los archivos generados por la compilación.
  - Uso: Útil para asegurarse de que una compilación se realice desde cero sin archivos residuales.

### Pruebas y paquetes

- **dotnet test:**

  - Descripción: Ejecuta las pruebas unitarias del proyecto utilizando un framework de pruebas compatible.

  - Uso: dotnet test ejecuta todas las pruebas definidas en el proyecto.

- **dotnet pack:**

  - Descripción: Crea un paquete NuGet del proyecto.
  - Uso: dotnet pack -c Release crea un paquete en modo Release.

- **dotnet add package [nombre-del-paquete]:**

  - Descripción: Agrega un paquete NuGet al proyecto.
  - Uso: dotnet add package Newtonsoft.Json agrega el paquete Newtonsoft.Json al proyecto.

- **dotnet add reference [ruta-del-proyecto]:**

  - Descripción: Agrega una referencia a otro proyecto dentro de la solución.
  - Uso: dotnet add reference ../OtroProyecto/OtroProyecto.csproj agrega una referencia al proyecto OtroProyecto.

### Ayuda y documentación

- **dotnet --help:**

  - Descripción: Muestra ayuda general sobre la CLI de .NET.

  - Uso: Útil para obtener una visión general de los comandos disponibles.

- **dotnet [comando] --help:**

  - Descripción: Muestra ayuda específica sobre un comando en particular.
  - Uso: dotnet build --help muestra detalles y opciones disponibles para el comando build.

## API

### controller

Un controlador es una clase que se encarga de manejar las solicitudes (requests) entrantes desde el cliente (un navegador web), procesarlas y devolver una respuesta adecuada (response). Es el intermediario entre el modelo (los datos y la lógica de negocio) y la vista (la interfaz de usuario).

### Funciones del controlador:

- **Recibir solicitudes HTTP:** Los controladores manejan solicitudes como GET, POST, PUT o DELETE que provienen del cliente.
- **Procesar datos:** Puede interactuar con el modelo para recuperar o modificar datos.
- **Seleccionar vistas:** Decide qué vista devolver al cliente, proporcionando datos para que sean mostrados.
- **Generar respuestas:** No siempre se devuelve una vista; también puede generar respuestas como JSON, XML o mensajes de estado HTTP.

```csharp
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
// Acción para manejar solicitudes GET en la ruta "/"
[HttpGet]
public IActionResult Index()
{
// Devuelve la vista "Index"
return View();
}

    // Acción para manejar solicitudes GET en la ruta "/about"
    [HttpGet("about")]
    public IActionResult About()
    {
        // Devuelve un mensaje como respuesta JSON
        return Json(new { Message = "About us page", Date = DateTime.Now });
    }

}
```

### Partes

- **Decoradores ([HttpGet], [HttpPost], etc.):** Indican el tipo de solicitud que maneja cada acción.
- **Métodos de acción (Index, About):** Procesan la lógica específica para una solicitud.
- **Respuestas (View(), Json()):** Indican qué debe enviarse al cliente.

### ActionResult

Es una clase base abstracta que proporciona una manera flexible de devolver diferentes tipos de respuestas HTTP desde una acción.

### Ventajas

- **Flexibilidad:** Permite devolver diferentes tipos de resultados (como vistas, datos JSON, errores, archivos, etc.) desde una misma acción.
- **Consistencia:** Hace que el código sea más legible y coherente al unificar cómo se manejan los resultados de las acciones.
- **Control sobre la respuesta HTTP:** Facilita establecer códigos de estado HTTP (como 200, 404, 500), encabezados personalizados, y más.

¡Claro! Aquí tienes el texto transformado en una tabla en Markdown:

| Clase                     | Propósito                                                              |
| ------------------------- | ---------------------------------------------------------------------- |
| ViewResult                | Devuelve una vista renderizada.                                        |
| JsonResult                | Devuelve datos JSON (normalmente para API o llamadas AJAX).            |
| ContentResult             | Devuelve contenido de texto plano o HTML.                              |
| FileResult                | Devuelve un archivo (como FileContentResult, FileStreamResult, etc.).  |
| RedirectResult            | Redirige a otra URL.                                                   |
| RedirectToActionResult    | Redirige a otra acción dentro del mismo controlador u otro.            |
| EmptyResult               | Devuelve una respuesta vacía.                                          |
| BadRequestResult          | Devuelve un error 400 (Bad Request).                                   |
| NotFoundResult            | Devuelve un error 404 (Not Found).                                     |
| OkResult / OkObjectResult | Devuelve una respuesta 200 (OK), opcionalmente con un objeto de datos. |
| UnauthorizedResult        | Devuelve un error 401 (Unauthorized).                                  |
| ForbidResult              | Devuelve un error 403 (Forbidden).                                     |
| StatusCodeResult          | Devuelve un código de estado HTTP personalizado.                       |

## IActionResult

Es una interfaz que permite devolver diferentes tipos de resultados de acción, como vistas, JSON, archivos, etc.

### Ejemplos

```csharp
public IActionResult Index()
{
    return View(); // Devuelve la vista asociada
}

public IActionResult GetData()
{
    var data = new { Name = "Juan", Age = 30 };
    return Json(data); // Devuelve datos JSON
}

public IActionResult GetItem(int id)
{
    var item = database.Find(id);
    if (item == null)
    {
        return NotFound(); // Devuelve un error 404
    }
    return Ok(item); // Devuelve el objeto con código 200 (OK)
}

public IActionResult GoToHome()
{
    return RedirectToAction("Index", "Home"); // Redirige a Home/Index
}

public IActionResult DownloadFile()
{
    byte[] fileBytes = System.IO.File.ReadAllBytes("ruta/del/archivo.pdf");
    return File(fileBytes, "application/pdf", "archivo.pdf"); // Devuelve un archivo
}

```

## Inyección de dependencias (Dependency Injection)

La inyección de dependencias es un patrón de diseño que permite gestionar las dependencias de un objeto desde el exterior, en lugar de que el objeto las cree directamente.

- **Dependencia:** Una clase (o servicio) que otro objeto necesita para realizar su trabajo.
- **Inversión de Control (IoC):** Se refiere a delegar el control de creación de objetos a un framework o contenedor (como el de .NET).
- **Inyección de Dependencias:** El proceso de pasar (inyectar) las dependencias a una clase en lugar de que esta las cree internamente.

## Tipos de Inyección de Dependencias

- **Por Constructor (más común y recomendado):** Las dependencias se pasan como parámetros al constructor de la clase.

- **Por Propiedad:** Las dependencias se asignan a propiedades públicas.

- **Por Método:** Las dependencias se pasan como parámetros a métodos específicos.

```csharp
// Interface para valdar un usuario
namespace Backend.Services
{
    public interface IPeopleService
    {
        public bool Validate(People people);
    }
}

// clase que implementa la interfaz
namespace Backend.Services
{
    public class PeopleService:IPeopleService
    {
        public bool Validate(People people)
        {
            if(string.IsNullOrEmpty(people.Name) || people.Name.Length > 100) return false;

            return true;
        }
    }
}
// uso de la clase PeopleService
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;
        //se inyecta peopleService para poder acceder a sus metodos
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;

        [HttpGet("{id}")]
        public ActionResult<People> Get(int id) {
            var people = Repository.People.FirstOrDefault(p => p.Id == id);

            if (people == null) { return NotFound(); }

            return Ok(people);
        }

        [HttpGet("search/{search}")]
        public List<People> Get(string search) =>
            Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();

        [HttpPost]
        public IActionResult Add(People people)
        {
            if (!_peopleService.Validate(people))
            {
                return BadRequest();
            }

            Repository.People.Add(people);

            return NoContent();
        }
    }
}
```

### Configurar el Contenedor de Dependencias

En .NET, esto se realiza en el archivo Program.cs o en el Startup.cs

```csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IPeopleService, PeopleService>();
```

### Ciclo de Vida de las Dependencias

- **Transient:** Se crea una nueva instancia cada vez que se solicita.

```csharp
builder.Services.AddTransient<IGreetingService, GreetingService>();
```

- **Scoped:** Se crea una única instancia por solicitud HTTP (útil en aplicaciones web).

```csharp
builder.Services.AddScoped<IGreetingService, GreetingService>();
```

- **Singleton:** Se crea una única instancia para toda la aplicación.

```csharp
builder.Services.AddSingleton<IGreetingService, GreetingService>();
```

## programación asincrona

La programación asíncrona en C# te permite ejecutar tareas que pueden tomar tiempo sin bloquear el hilo principal de ejecución.

C# facilita la programación asíncrona con los modificadores async y await, y su modelo se basa en Tareas (Task) del espacio de nombres System.Threading.Tasks.

### Conceptos

- async y await:

  - async: Declara que un método es asíncrono. Esto indica que el método puede usar await.
  - await: Pausa la ejecución del método hasta que la tarea asíncrona se complete, sin bloquear el hilo.

- Tareas (Task):

  - Una tarea representa una operación que se ejecuta de manera asíncrona y devuelve un resultado o no (Task<T> o Task).

- Sincrónico vs Asíncrono:

  - Sincrónico: Bloquea el hilo hasta que la operación termina.
  - Asíncrono: Libera el hilo mientras la operación está en progreso.

```csharp
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        [HttpGet("async")]
        public async Task<IActionResult> GetAsync()
        {
            var task1 = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Conexión a la base de datos terminada");
            });

            task1.Start();

            Console.WriteLine("Hago otra cosa");

            await task1;

            Console.WriteLine("Todo a terminado");

            return Ok();
        }

        [HttpGet("calcularasync")]
        public async Task<int> CalcularAsync()
        {
            await Task.Delay(2000);
            return 42; // Devuelve un resultado
        }

        //no devuelve nada
        [HttpGet("mostrarmensajeasync")]
        public async Task MostrarMensajeAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Mensaje mostrado después de 1 segundo.");
        }
    }
}

```

## DTOs (Data Transfer Objects)

son un patrón de diseño utilizado para transferir datos entre diferentes capas de una aplicación en .NET (o cualquier otra tecnología).

```csharp
public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; } // No queremos exponer esto
}

public class UserDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
}

public class UserService
{
    public UserDto GetUser(int userId)
    {
        // Supongamos que obtienes el usuario desde una base de datos
        var user = new User
        {
            Id = userId,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Password = "securepassword"
        };

        // Mapear entidad a DTO
        return new UserDto
        {
            Id = user.Id,
            FullName = $"{user.FirstName} {user.LastName}",
            Email = user.Email
        };
    }
}

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;

    public UsersController()
    {
        _userService = new UserService();
    }

    [HttpGet("{id}")]
    public ActionResult<UserDto> GetUser(int id)
    {
        var userDto = _userService.GetUser(id);
        return Ok(userDto);
    }
}
```
