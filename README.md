# ----- Tic-Tac-Toe - MVP - Presentation Model -----

**Index**
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
        -   [Specification Start](#Specification-Start)  
        -   [Specification Play](#Specification-Play)  
        -   [Specification Resume](#Specification-Resume)  
    -   [User Interface Prototype](#User-Interface-Prototype)  
        -   [Winning Game](#Winning-Game)  
        -   [Lost Game](#Lost-Game)  
- [Analysis](#Analysis)  
    -   [Architecture Analysis](#Architecture-Analysis)  
    -   [Use Cases Analysis](#Uses-Case-Analysis)  
        -   [Analysis Start](#Analysis-Start)  
    -   [Class Analysis](#Class-Analysis) 
        -   [Analysis Views](#Analysis-Views)  
        -   [Analysis Controllers](#Analysis-Controllers)  
        -   [Analysis Models](#Analysis-Models)  
        -   [Analysis Enums](#Analysis-Enums)  
    -   [Package Analysis](#Package-Analysis)  
- [Design](#Design)  
    -   [Architecture Design](#Architecture-Design)  
    -   [Use Case Design](#Use-Cases-Design)  
        -   [Design Start](#Design-Start)  
    -   [Class Design](#Class-Design)  
        -   [Design ConsoleApp](#Design-ConsoleApp) 
        -   [Design WinFormApp](#Design-WinFormApp)  
        -   [Design Mastermind](#Design-Mastermind)  
        -   [Design GameViews](#Design-GameViews)  
        -   [Design Controllers](#Design-Controllers)  
        -   [Design Models](#Design-Models)  
        -   [Design Types](#Design-Types)  
- [Implementation View](#Implementation-View)  
- [Deployment View](#Deployment-View)  
- [Process View](#Process-View)  
## Domain Model

|  Description | Scenario |
| :------- | :------: | 
|  Tic-Tac-Toe is a game for two players who take turns marking the spaces in a three-by-three grid with X or O. <br/>The player who succeeds in placing three of their marks ina horizontal, vertical, or diagonal row is the winner. <br\>It is a solved game, with a forced draw assuming best play from both players. <br/> **Reglas** <br/> Tic-Tac-Toe's goal is. | ![image](https://user-images.githubusercontent.com/46433173/231174452-cc2cb2fb-b5a6-4772-b91d-fcaf55961145.png) |

## Vocabulary

![image](https://user-images.githubusercontent.com/46433173/230940546-84fa61b0-b6b0-4251-947b-cf5c5b46f81e.png)

## Initial State

![image](https://user-images.githubusercontent.com/46433173/231223737-c3a623fa-97ea-4211-bd7c-9130437d1c95.png)

## Final State

![image](https://user-images.githubusercontent.com/46433173/231223793-2c800f10-1b92-4778-ad66-0572787f8785.png)

## Functionalities

![image](https://user-images.githubusercontent.com/46433173/231224007-558f18e8-ab5e-4940-8ece-ab97b7475dd0.png)

## Activities

![image](https://user-images.githubusercontent.com/46433173/231224161-4067df76-831a-4117-aa8d-201d679f4371.png)

![image](https://user-images.githubusercontent.com/46433173/231224196-2cc1d258-736a-447c-881c-fc14e68a28cf.png)

## Requirements

- **Functionality:** Simple  
- **Interface:** Text  
- **Distribution:** Standalone and Graphics 
- **Persistence:** No  

### Use Cases

| Use Case View | Use Case Context |  
| :------- | :------: | 
| ![image](https://github.com/franpaulinoinfante/TicTacToe/assets/46433173/e39e78a5-69b1-4628-9cf5-3c34c08c32b5) | ![image](https://github.com/franpaulinoinfante/TicTacToe/assets/46433173/e1d640ac-85b7-4b7b-a66d-579213ad964c) |  

### Use Cases Initial Description

| Use Case | Description |  
| :------- | :------: | 
| Start    | The system allows start the game. |
| Play     | The system allows play the game. |
| Resume   | The system asks if the user wants a new game or exit. |

### Use Case Specifications

#### Specification Start

![image](https://github.com/franpaulinoinfante/TicTacToe/assets/46433173/06b8a6c6-c573-433f-9fc6-bbb5e005bfc0)

#### Specification Play

![image](https://github.com/franpaulinoinfante/TicTacToe/assets/46433173/b20ad07c-05d0-49e3-9ba7-d36ee912a4b2)

#### Specification Resume

![image](https://github.com/franpaulinoinfante/TicTacToe/assets/46433173/99051810-4eea-41ad-abbd-a319adfeec0b)

### User Interface Prototype

#### Machine vs Machine

```
--- Tic-Tac-Toe ---

```

#### Player vs Machine

```
--- Tic-Tac-Toe ---


Do you want to continue? (y/n)
```


#### Player vs Player

```
--- Tic-Tac-Toe ---


Do you want to continue? (y/n)
```

## Analysis

### Architecture Analysis

#### Analysis Start

#### Analysis Play

#### Analysis Resume

### Class Analysis 

#### Analysis Views

#### Analysis Controllers

#### Analysis Models

#### Analysis Types

### Package Analysis 

## Design

### Architecture Design

### Use Cases Design 

#### Design Start

### Class Design

#### Design ConsoleApp

#### Design WinFormApp

#### Design Mastermind

#### Design GameViews

#### Design Controllers

#### Design Models

#### Design Types

## Implementation View

## Deploymnet View

## Process View

-   There isn't concurrency 
