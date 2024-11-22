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
