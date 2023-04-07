# OpenAIconCSharp
Descripción

Este proyecto es una aplicación de consola en C# que utiliza la API de OpenAI para obtener una respuesta basada en el modelo GPT-3.5 Turbo. La aplicación realiza una solicitud HTTP POST con un mensaje de usuario y muestra la respuesta en la consola.
Requisitos

    .NET 5 o superior.
    Una API Key de OpenAI.
    Visual Studio (opcional para la compilación y ejecución).

Instalación

    Clone este repositorio en su máquina local.
    Asegúrese de tener instalado el SDK de .NET 5 o superior.

Configuración

    Reemplace la variable apiKey en el código con su propia API Key de OpenAI:


string apiKey = "Tu-ApiKey-de-OpenAI";

Ejecución
Opción 1: Usando la terminal

    Abra una terminal y navegue hasta el directorio del proyecto.
    Ejecute el siguiente comando para compilar y ejecutar la aplicación:


dotnet run

    La aplicación realizará una solicitud a la API de OpenAI con el mensaje de usuario y mostrará la respuesta en la consola.

Opción 2: Usando Visual Studio

    Abra el proyecto en Visual Studio.
    Asegúrese de que el proyecto esté configurado como proyecto de inicio.
    Presione F5 o haga clic en Debug > Start Debugging para compilar y ejecutar la aplicación.
    La aplicación realizará una solicitud a la API de OpenAI con el mensaje de usuario y mostrará la respuesta en la consola.

Código

El archivo Program.cs contiene el código principal de la aplicación. La función Main es el punto de entrada y realiza las siguientes acciones:

    Define la API Key, la URL de la API y los datos de la solicitud.
    Serializa los datos de la solicitud en formato JSON.
    Crea un objeto HttpClient y configura el encabezado de autorización con la API Key.
    Realiza una solicitud HTTP POST a la API de OpenAI con los datos de la solicitud.
    Si la solicitud es exitosa, extrae y muestra la respuesta en la consola. De lo contrario, muestra el código de error y la frase de motivo.

Licencia

Este proyecto se encuentra bajo la licencia MIT.
