# ----- Tic-Tac-Toe -----

**With Documents/Views Architecture**

## Index

- [Domain Model](#domain-model)  
    - [Vocabulary](#vocabulary)  
    - [Initial State](#initial-state)  
    - [Final State](#final-state)  
    - [Functionalities](#functionalities)  
    - [Activities](#activities)  
- [Requirements](#Requirements)  
    -   [Use Cases](#Use-Cases)
    -   [Use Cases Initial Description](#Use-Cases-Initial-Description)  
    -   [Use Case Specifications](#Use-Case-Specifications)   
        -   [Use Case Start](#Use-Case-Start)  
        -   [Use Case Play](#Use-Case-Play)  
        -   [Use Case Resume](#Use-Case-Resume)  
    -   [User Interface Prototype](#User-Interface-Prototype)  
        -   [Winning Game](#Winning-Game)  
        -   [Lost Game](#Lost-Game)  
- [Analysis](#Analysis)  
    -   [Architecture Analysis](#Architecture-Analysis)  
    -   [Use Cases Analysis](#Uses-Case-Analysis)  
        -   [Analysis Start](#Analysis-Start)  
        -   [Analysis Play](#Analysis-Play)  
        -   [Analysis Resume](#Analysis-Resume)  
    -   [Class Analysis](#Class-Analysis) 
        -   [Analysis Views](#Analysis-Views)  
        -   [Analysis Models](#Analysis-Models)  
        -   [Analysis Enums](#Analysis-Enums)  
    -   [Package Analysis](#Package-Analysis)  
- [Design](#Design)  
    -   [Architecture Design](#Architecture-Design)  
    -   [Use Case Design](#Use-Cases-Design)  
        -   [Design Start](#Design-Start)  
    -   [Class Design](#Class-Design)  
        -   [Design Views](#Design-Views)  
        -   [Design TicTacToe](#Design-TicTacToe)  
        -   [Design GameViews](#Design-GameViews)  
        -   [Design Models](#Design-Models)  
- [Implementation View](#Implementation-View)  
- [Deployment View](#Deployment-View)  
- [Process View](#Process-View)  

## Domain Model

|  Description | Scenario |
| :------- | :------: | 
|  Tic-Tac-Toe is a game for two players who take turns marking the spaces in a three-by-three grid with X or O. <br/>The player who succeeds in placing three of their marks ina horizontal, vertical, or diagonal row is the winner. <br\>It is a solved game, with a forced draw assuming best play from both players. <br/> **Reglas** <br/> Tic-Tac-Toe's goal is. | ![image](https://user-images.githubusercontent.com/46433173/231174452-cc2cb2fb-b5a6-4772-b91d-fcaf55961145.png) |

### Vocabulary

![image](https://user-images.githubusercontent.com/46433173/235680968-21d6b2ee-a5c5-4855-bfae-804b6d352884.png)

### Initial State

![image](https://user-images.githubusercontent.com/46433173/235684501-d3f87e36-aec2-4300-b3be-e0bca53df4f8.png)

### Final State

![image](https://user-images.githubusercontent.com/46433173/235684550-503ef0c4-61e4-45c7-8608-62bb1b35a7ff.png)

### Functionalities

![image](https://user-images.githubusercontent.com/46433173/235687701-f3673132-8d5b-432a-80ad-b905f363804e.png)

### Activities

**Put**
![image](https://user-images.githubusercontent.com/46433173/235684887-d55b8ee9-7d11-4e69-94f7-53ceddaf1d21.png)

**Move**
![image](https://user-images.githubusercontent.com/46433173/235685208-ec155007-32c0-4a13-8b27-8158770925f7.png)

## Requirements

- **Functionality:** Simple  
- **Interface:** Text  
- **Distribution:** Standalone  
- **Persistence:** No  

### Use Cases

| Use Case View | Use Case Context |  
| :------- | :------: | 
|    |          |  

### Use Cases Initial Description

| Use Case | Description |  
| :------- | :------: | 
| Start    | The system allows start the game. |
| Play     | The system allows play the game. |
| Resume   | The system asks if the user wants a new game or exit. |

### Use Case Specifications

#### Use Case Start

![image](https://user-images.githubusercontent.com/46433173/235729807-ae876598-70f8-4a27-8c75-4ca7071795d7.png)

#### Use Case Play

![image](https://user-images.githubusercontent.com/46433173/235729757-9c9e0ba8-e1b2-45d8-9637-66b5bc047839.png)

#### Use Case Resume

![image](https://user-images.githubusercontent.com/46433173/235729669-05df92ac-4dba-4aff-8725-36c4fecaf074.png)

### User Interface Prototype

#### Machine vs Machine

```
--- TicTacToe ---

0. Machine vs Machine
1. Player vs Machine
2. Player vs Player
Select the number of players: 0

---------
[ ][ ][ ]
[ ][ ][ ]
[ ][ ][ ]
---------

Current turn: O
---------
[ ][ ][O]
[ ][ ][ ]
[ ][ ][ ]
---------

Current turn: X
---------
[ ][ ][O]
[ ][X][ ]
[ ][ ][ ]
---------

Current turn: O
---------
[ ][ ][O]
[ ][X][ ]
[ ][ ][O]
---------

Current turn: X
---------
[ ][ ][O]
[X][X][ ]
[ ][ ][O]
---------

Current turn: O
---------
[ ][ ][O]
[X][X][O]
[ ][ ][O]
---------

Congratulations player: O, you WON!!!! :-)

Do you want to continue? (y/n)y
```

#### Player vs Machine

```
--- TicTacToe ---

0. Machine vs Machine
1. Player vs Machine
2. Player vs Player
Select the number of players: 1

---------
[ ][ ][ ]
[ ][ ][ ]
[ ][ ][ ]
---------

Current turn: O
---------
[ ][O][ ]
[ ][ ][ ]
[ ][ ][ ]
---------

Current turn: X
Enter a coordinate to put a token:
Row: 2
Column: 2
---------
[ ][O][ ]
[ ][X][ ]
[ ][ ][ ]
---------

Current turn: O
---------
[ ][O][ ]
[ ][X][ ]
[ ][O][ ]
---------

Current turn: X
Enter a coordinate to put a token:
Row: 1
Column: 1
---------
[X][O][ ]
[ ][X][ ]
[ ][O][ ]
---------

Current turn: O
---------
[X][O][ ]
[ ][X][ ]
[ ][O][O]
---------

Current turn: X
Enter a coordinate to put a token:
Row: 2
Column: 1
---------
[X][O][ ]
[X][X][ ]
[ ][O][O]
---------

Current turn: O
---------
[X][O][O]
[X][X][O]
[ ][ ][O]
---------

Current turn: XX
Enter the origin coordinate to move
Row: 2
Column: 2
Enter the target coordinate to move
Row: 3
Column: 1
---------
[X][O][O]
[X][ ][O]
[O][ ][O]
---------

Congratulations player: X, you WON!!!! :-)

Do you want to continue? (y/n)y
```

#### Player vs Player

```
--- TicTacToe ---

0. Machine vs Machine
1. Player vs Machine
2. Player vs Player
Select the number of players: 2

---------
[ ][ ][ ]
[ ][ ][ ]
[ ][ ][ ]
---------

Current turn: X
Enter a coordinate to put a token:
Row: 4
Column: 4
-------------
Error! 
The coordinate is out range
-------------

Enter a coordinate to put a token:
Row: 1
Column: 1
---------
[X][ ][ ]
[ ][ ][ ]
[ ][ ][ ]
---------

Current turn: O
Enter a coordinate to put a token:
Row: 1
Column: 1
-------------
Error!
The square is occupied
-------------

Current turn: O
Enter a coordinate to put a token:
Row: 2
Column: 2
---------
[X][ ][ ]
[ ][O][ ]
[ ][ ][ ]
---------

Current turn: X
Enter a coordinate to put a token:
Row: 3
Column: 3
---------
[X][ ][ ]
[ ][O][ ]
[ ][ ][X]
---------

Current turn: O
Enter a coordinate to put a token:
Row: 1
Column: 3
---------
[X][ ][O]
[ ][O][ ]
[ ][ ][X]
---------

Current turn: X
Enter a coordinate to put a token:
Row: 3
Column: 1
---------
[X][ ][O]
[ ][O][ ]
[X][ ][X]
---------

Current turn: O
Enter a coordinate to put a token:
Row: 3
Column: 2
---------
[X][ ][O]
[ ][O][ ]
[X][0][X]
---------

Current turn: X
Enter the origin coordinate to move:
Row: 3
Column: 2
-------------
Error!
The squares of origin and destination cannot be the same.
-------------

Enter the origin coordinate to move:
Row: 3
Column: 3
Enter the target coordinate to move
Row: 2
Column: 1
---------
[X][ ][O]
[X][O][ ]
[X][0][ ]
---------

Congratulations player: X, you WON!!!! :-)

Do you want to continue? (y/n)
```

## Analysis

### Architecture Analysis

![image](https://user-images.githubusercontent.com/46433173/236328025-e342a63c-0a8b-47ca-98ba-e48788f066c2.png)

### Use cases Analysis

#### **Analysis Start**

![image](https://user-images.githubusercontent.com/46433173/235921712-f0c13008-2592-4de2-b89c-d44204a4c945.png)

![image](https://user-images.githubusercontent.com/46433173/235921633-bc284b74-89d0-4b4f-8752-00be467666ec.png)

#### **Analysis Play**

![image](https://user-images.githubusercontent.com/46433173/236214829-5e76a60f-67c1-4e69-92a5-30e03c4067d8.png)

![image](https://user-images.githubusercontent.com/46433173/236226700-37730edb-9b43-41bc-804d-7e15ec843c76.png)

#### **Analysis Resume**

### Class Analysis 

#### **Analysis Views**

![image](https://user-images.githubusercontent.com/46433173/236310504-1ce8df80-1aaa-4b7a-bc7b-a16ab16429ee.png)

#### **Analysis Models**

![image](https://user-images.githubusercontent.com/46433173/236310439-da2d8125-ae75-48ed-9abe-964592bdce7a.png)

#### **Analysis Types**

![image](https://user-images.githubusercontent.com/46433173/235922804-e293552e-8389-449c-bd84-a2e4608585ed.png)

### Package Analysis 

## Design

### Architecture Design

**Principio de Separación Modelo-Vista (Separated Presentation Pattern), mediante la - Arquitectura Document/View -**

**Problema:**
-	¿Quién debe ser responsable de capturar entradas generada por un agente externo, “persona mediante teclado o ratón, o máquinas mediante señales de un sensor o tramas de red?
-	¿Qué tipo de visibilidad tendrían que tener otros paquetes de la capa de Presentación?
-	¿Cómo deberían de comunicarse las clases que no son ventanas con otras ventanas?

En diferentes contextos el modelo es sinónimo de la Capa del Dominio de los objetos y la vista es un sinónimo para los objetos de la presentación, tales como, ventanas, vista de webs o móviles.

**Solución:**
El Principio de Separación Modelo-Vista establece que los objetos del modelo (dominio) no deberían conocer directamente a los objetos de la vista (presentación). Asegurando que cualquier código con el objetivo de manipulas la presentación, solo haga eso “manipular la presentación”, desplazando toda la lógica del dominio y de datos en áreas separadas.<br>
Asociado al sub-patron Principio de Única Responsabilidad “SRP” de SOLID, que ayuda a definir capas lógicas y fisifcas de la arquitectura.

**Beneficios:**
Las vistas serán responsables de:<br>
-	Gestionar controles de interfaz: botones, listas, paneles, diálogos…
-	Gestionar su Estado: referidos a los datos actuales mostrados en la interfaz.
-	Gestionar su Lógica: para manipular los controles de interfaz.
-	Gestionar su Sincronización: coordinando su estado con el estado de los objetos de datos y negocio en memoria y/o persistencia

**Motivos:**
-	Dar soporte a definiciones de modelos cohesivos que se centren en los procesos del dominio, en lugar de preocuparse de las interfaces de usuario. 
-	Permitir separar el desarrollo de las capas del modelo y la interfaz de usuario.
-	Minimizar el impacto de los cambios de los requisitos de la interfaz sobre la capa del dominio.
-	Permitir que se conecten fácilmente otras vistas a una capa de dominio existente, sin afectar a la capa del dominio.
-	Permitir múltiples vistas simultáneas sobre el mismo modelo del dominio, como una vista de la información sobre las ventas en formato tabular o mediante un diagrama de barras.
-	Permitir la ejecución de la capa del modelo de manera independiente de la capa de interfaz de usuario, como en un sistema de procesamiento de mensajes o en modo de procesamiento por lotes.
-	Permitir trasladar fácilmente la capa del modelo a otro framework de interfaz de usuario.

**Arquitectura Document/View**

De forma predeterminada, se crea un esqueleto de aplicación con una clase de documento (modelo) y una clase de vista. Separando la administración de datos en estas dos clases. El documento (modelo) almacena los datos y administra la impresión de los datos y coordina la actualización de varias vistas de los datos. La vista muestra los datos y administra la interacción del usuario con ellos, incluida la selección y edición.<br>
En este modelo, un objeto lee y escribe datos en el almacenamiento persistente. El documento (modelo) también puede proporcionar una interfaz a los datos dondequiera que resida (por ejemplo, en una base de datos). Un objeto de vista independiente administra la presentación de datos, desde la representación de los datos en una ventana hasta la selección y edición de datos por parte del usuario. La vista obtiene los datos de visualización del modelo y comunica al documento los cambios en los datos.<br>
Aunque puede invalidar u omitir fácilmente la separación entre documento y vistas, hay razones atractivas para seguir este esquema en la mayoría de los casos. Una de las mejores es cuando se necesitan varias vistas del mismo documento, como una hoja de cálculo y una vista de gráfico. El modelo de documento/vista permite que un objeto de vista independiente represente cada vista de los datos, mientras que el código común a todas las vistas (como un motor de cálculo) puede residir en el documento. El documento también asume la tarea de actualizar todas las vistas cada vez que cambian los datos.<br>
La arquitectura de documentos y vistas facilitan la compatibilidad con varias vistas, varios tipos de documento, ventanas divisoras y otras características valiosas de la interfaz de usuario.<br>
Lo que busca es crear diferentes vistas para cada parte de la interacción del usuario con el sistema.<br>
Se divide en:
-	En una vista principal compuesta,
-	por una vista por cada caso de uso y cada caso de uso está compuesto,
-   por vistas de cada modelo que el caso de uso necesite interactuar (leer o escribir), y si estas vistas auxiliares también necesitan leer de otros modelos se crearan otras sub-vistas. 


### Use Cases Design 

#### Design Start

### Class Design

#### Design Views

#### TicTacToe

![image](https://user-images.githubusercontent.com/46433173/236036889-769325e6-9e46-4c4d-a6c7-64dd3ef4be8f.png)

#### GameViews

![image](https://user-images.githubusercontent.com/46433173/236036774-7613534c-365e-4819-9eb4-774329f0eca8.png)

#### Design Models

![image](https://user-images.githubusercontent.com/46433173/236036685-8f7ef216-5aa1-4235-bace-4bc47f3744aa.png)

## Implementation View

## Deploymnet View

## Process View

-   There isn't concurrency 
