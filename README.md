# Práctica de Git: gestor de pendientes

Completarás con tu grupo una aplicación de consola en C#. Cada integrante
implementará una función en su propio archivo y colaborará mediante ramas,
commits, pull requests y revisión del trabajo de otra persona.

## Integrantes del grupo

Completen sus nombres antes de comenzar. Si el grupo es de tres, dejen el cuarto espacio sin completar.

- Integrante 1: Jeremy Thorp
- Integrante 2: Jheyson Araúz
- Integrante 3: Miguel Saldaña
- Integrante 4: 

## Abre y ejecuta el proyecto

Necesitas el SDK de .NET 10. Si usas Visual Studio, utiliza Visual Studio 2026
con las herramientas de desarrollo de .NET.

1. Extrae el ZIP en una carpeta de tu computadora.
2. Abre `GestorPendientes.slnx` en Visual Studio.
3. Ejecuta con Ctrl+F5. También puedes abrir una terminal en la carpeta del
   proyecto y ejecutar `dotnet run`.
4. Prueba las opciones del menú y escribe `0` para salir.

Las opciones 1 a 4 muestran inicialmente «Función pendiente de implementar».
Completarás el comportamiento de la opción que te corresponda.

El programa comienza con dos pendientes de ejemplo. Los datos se mantienen
solo durante la ejecución; al reiniciar se cargan nuevamente los ejemplos.

## Qué contiene la base

- `GestorPendientes.slnx`: solución para abrir el proyecto en Visual Studio.
- `GestorPendientes.csproj`: configuración del proyecto para .NET 10.
- `Program.cs`: clase `Program`, método `Main`, lista compartida y menú.
- `Pendiente.cs`: identificador fijo, descripción, estado, constructor y método
  `Completar()`.
- `EstadoPendiente.cs`: estados `Pendiente` y `Completado`.
- Un archivo por operación, conectado al menú y listo para que completes su
  método `Ejecutar(List<Pendiente> pendientes)`.

## Reparte el trabajo

| Operación | Archivo | Comportamiento esperado |
|---|---|---|
| Agregar | `AgregarPendiente.cs` | Solicitar descripción, volver a pedirla si está vacía, agregar un objeto válido e informar su identificador. |
| Listar | `ListarPendientes.cs` | Mostrar identificador, descripción y estado; informar si la lista está vacía, sin modificarla. |
| Completar | `CompletarPendiente.cs` | Solicitar identificador, manejar entradas incorrectas y objetos inexistentes; completar solo el elegido o informar si ya estaba completado. |
| Eliminar | `EliminarPendiente.cs` | Solicitar identificador, manejar entradas incorrectas y objetos inexistentes; mostrar el objeto, pedir confirmación y eliminar solo al confirmar. |

En grupos de cuatro, repartan las cuatro operaciones. En el grupo de tres,
repartan agregar, listar y completar; eliminar puede conservar su mensaje
inicial. Registren el reparto en este documento.

Todas las operaciones reciben la misma lista. Conserva la firma del método
y la estructura del proyecto. El identificador no es la posición en la lista:
al eliminar un objeto, los demás deben conservar sus identificadores.

## Crea el archivo .gitignore

Antes del primer commit, un integrante del grupo debe crear
un archivo llamado exactamente `.gitignore`, junto a `GestorPendientes.csproj`.
Comprueba que no se guarde como `.gitignore.txt`. Agrega este contenido:

bin/
obj/
.vs/
.vscode/
*.user
*.suo


Estas reglas permiten ignorar las carpetas de compilación y los ajustes
locales de los editores. El propio `.gitignore` sí debe incluirse en el
repositorio para que todos compartan las reglas.

Después de ejecutar el proyecto, consulta el estado del repositorio con la
herramienta de Git que elijas y comprueba que no aparecen archivos de esas
carpetas para agregar al repositorio.
Si ya registraste archivos de compilación en un commit, consulta al docente:
crear `.gitignore` no deja de seguir archivos que Git ya tiene registrados.

## Colabora sin editar el mismo archivo

1. Un integrante crea el archivo `.gitignore`, completa este README con el
   reparto y publica la base en el repositorio compartido. Invita a los demás;
   todos clonan ese repositorio antes de comenzar sus funciones.
2. Cada estudiante crea su rama `feature/<nombre-estudiante>/<tarea>` desde
   `main`. Usen nombres sin espacios ni tildes.
3. Implementa únicamente la función de tu archivo.
4. Comprueba tu función. Para observar la lista sin depender de otra función,
   utiliza el depurador. Los ajustes temporales de datos en `Program.cs` son
   solo para probar; deshaz tus ajustes antes de preparar el commit.
5. Con la herramienta de Git que elijas, revisa las diferencias de tu archivo
   y agrégalo al área de preparación (staging). Comprueba que solo preparaste
   tu contribución. No incluyas archivos de compilación ni ajustes personales
   del editor.
6. Registra y publica tus commits. Abre un pull request hacia `main` con el
   cambio, su propósito, los casos comprobados y una explicación breve de cómo
   registraste y publicaste tu contribución.
7. Revisa la contribución de otro integrante con una observación concreta y
   atiende la revisión de tu propio cambio.
8. Integren los pull requests uno por uno usando **Create a merge commit**.
   Antes de integrar el siguiente, su autor incorpora el `main` actualizado
   a su rama y comprueba nuevamente su función.

Puedes usar Git directamente desde Visual Studio, Git CLI (línea de comandos)
u otra herramienta de Git para revisar cambios, preparar archivos, crear
commits, trabajar con ramas y sincronizar el repositorio.
Usa GitHub en el navegador para abrir, revisar e integrar los pull requests.
Se evaluarán tu
contribución, las comprobaciones y tu explicación de lo que hiciste.
Coordinen las ediciones del README mediante un integrante; cada autor aporta
sus enlaces y resultados en su pull request. Si aparece un conflicto antes
del ejercicio final, consulta al docente antes de descartar cambios.


## Ejercicio final: un conflicto por grupo

Resolverán un solo conflicto por grupo sobre el título del menú. Dos integrantes
preparan las ramas y uno realiza la resolución con el acuerdo del grupo; otro
revisa el resultado. La explicación y la evidencia de este ejercicio son
grupales. Pueden usar Visual Studio, Git CLI u otra herramienta de Git.

### Paso 1. Preparen dos ramas desde la misma versión

Terminen e integren las funciones en `main` y comprueben el programa. El título
debe seguir siendo `MIS PENDIENTES`. Dos integrantes actualizan su copia de
`main` y comprueban que parten del mismo commit, sin cambios sin registrar.
Uno crea y activa `conflicto/titulo-a`; el otro, `conflicto/titulo-b`.

**¿Por qué?** ambas propuestas deben partir de la misma línea original.

### Paso 2. Cambien y publiquen el título

Cada autor modifica únicamente la línea del título en `Program.cs`.

En la rama A:

```csharp
Console.WriteLine("MIS PENDIENTES PERSONALES");
```

En la rama B:

```csharp
Console.WriteLine("GESTOR DE PENDIENTES");
```

Cada autor comprueba el programa, registra el cambio en un commit y publica
su rama. Ambos deben terminar antes de integrar cualquiera de las propuestas.

### Paso 3. Integren la rama A

Su autor abre un pull request desde `conflicto/titulo-a` hacia `main`.
Otro integrante lo revisa y después lo integran con **Create a merge commit**.
Ahora `main` contiene `MIS PENDIENTES PERSONALES`.

**¿Por qué?** la propuesta B conserva un cambio distinto de la misma línea.

### Paso 4. Incorporen main a la rama B

El autor de B activa `conflicto/titulo-b`, obtiene los cambios remotos con
Fetch y combina `origin/main` dentro de su rama mediante un merge.
La dirección es: origen `origin/main`, destino `conflicto/titulo-b`.
Fetch obtiene los cambios; el merge intenta incorporarlos.

Con Git CLI, estando en la rama B, las operaciones equivalentes son:

```bash
git fetch origin
git merge origin/main
```

Git debe señalar un conflicto en `Program.cs`: ambas propuestas cambiaron
la misma línea. No utilicen rebase para este ejercicio.

### Paso 5. Acuerden y escriban el resultado

Abran el archivo conflictivo y comparen las dos versiones. La versión actual
es la de B; la entrante es la de `origin/main`, que contiene la propuesta A.
En Visual Studio pueden abrir el editor de combinación desde **Cambios de Git**.

Acuerden un título que conserve las dos ideas. Para este ejercicio utilicen:

```csharp
Console.WriteLine("GESTOR DE PENDIENTES PERSONALES");
```

El autor de B escribe el resultado. Debe quedar una sola instrucción para el
título y ninguna marca `<<<<<<<`, `=======` o `>>>>>>>`. No cambien las funciones.

**¿Por qué?** Git necesita que el grupo decida cómo combinar los dos textos.

### Paso 6. Comprueben, completen el merge e integren

Guarden el resultado y márquenlo como resuelto en la herramienta elegida.
Compilen y ejecuten el programa desde el editor o con .NET CLI:

```bash
dotnet build
dotnet run
```

Comprueben el título y las funciones. Corrijan cualquier fallo
antes de continuar. Creen el commit que completa el merge y publiquen la rama B.
Guardar el archivo no sustituye ese commit. Con Git CLI se prepara `Program.cs`
y se ejecuta `git commit`; las interfaces gráficas ofrecen la acción equivalente.

Abran el pull request de B hacia `main`. Otro integrante revisa la resolución
y lo integran con **Create a merge commit**. Actualicen `main` y comprueben
juntos que el programa conserva el título acordado y sus funciones.

### Paso 7. Dejen una explicación grupal

En la descripción del pull request de B, incluyan una sola explicación del grupo:

- Las dos versiones del título y por qué entraron en conflicto.
- El resultado acordado y qué se conserva.
- Quién realizó la resolución, quién la revisó y qué comprobaron al ejecutar.

En este documento, enlacen el pull request de B como evidencia del conflicto.
La resolución y esta explicación se evalúan por grupo. No se solicita otra
resolución ni una comprobación individual de comprensión de este ejercicio.

Entrega el enlace al repositorio del grupo en Moodle el **24 de octubre de
2026, hasta la 1:00 p. m.** Comprueba la consigna de la actividad para las
evidencias de contribución, revisión y conflicto que debe contener la entrega.
