# ------------- TicTacToe Domain Model Version -------------

**Index**
- [Requirements](#Requirements)  
    -   [Use Cases](#Use-Cases)
    -   [Initial Description of Use Cases](#Initial-Description-of-Use-Cases)  
    -   [Use Case Specifications](#Use-Case-Specifications)   
        -   [Configure Players](#Configure-Players)   
        -   [Specifications Start](#Specifications-Start)  
        -   [Specifications Play](#Specifications-Play)  
        -   [Specifications-Resume](#Specifications-Resume)  
    -   [Use Interface Prototype](#Use-Interface-Prototype)  
    -   [Analysis](#Analysis)  
        -   [Analysis Architecture](#Analysis-Architecture)  
        -   [Use Case Analysis](#Use-Case-Analysis)  
            -   [Analysis Start](#Analysis-Start)  
            -   [Analysis Play](#Analysis-Play)  
            -   [Analysis Resume](#Analysis-Resume)  
        -   [Package Analysis](#Package-Analysis)  
        -   [Class Analysis](#Class-Analysis)
        -   [Package](#Package)  
    - [Design](#Design)  
        -   [Design Architecture](#Design-Architecture)  
        -   [Design Use Cases](#Design-Use-Cases)  
            -   [Design Start](#Start-Start)  
            -   [Design Play](#Play-Play)  
            -   [Design Resume](#Design-Resume)  
        -   [Class Design](#Class-Design)  
    -   [Implementation View](#Implementation-View)  
    -   [Deployment View](#Deployment-View)  
    -   [Process View](#Process-View)  

## Requirements

- **Functionality:** Simple  
- **Interface:** Text  
- **Distribution:** Standalone  
- **Persistence:** No  

## Use Cases

| Use Case View | Use Case Context |  
| :------- | :------: | 
| ![image](https://user-images.githubusercontent.com/46433173/232233785-773c6b10-7d1b-4e4a-98dd-00dcf65545f8.png) | ![image](https://user-images.githubusercontent.com/46433173/232234032-ac7baa56-abba-453d-97af-50ee7721d64e.png) |  

## Initial Description of Use Cases

| Use Case | Description |  
| :------- | :------: | 
| Configure Player | The system allow select one of three game options: 1. Machine vs. Machine, 2. Player vs. Machine, and 3. Player vs. Player.  | 
| Start            | The system allow start the game. | 
| Play             | The system allow play the game.  | 
| Resume           | The system asks if the user wants a new game or exit.  |  

## Use Case Specifications

## Configure Players

![image](https://user-images.githubusercontent.com/46433173/232328353-78da963c-953c-449e-bc6c-db4965e671c1.png)

### Specifications Start

![image](https://user-images.githubusercontent.com/46433173/232328321-c6724e9a-f610-48ed-af3f-8a9135d129f4.png)

### Specifications Play

![image](https://user-images.githubusercontent.com/46433173/232328278-c357d51e-9548-40cc-92bf-431654771aa1.png)

### Specifications Resume

![image](https://user-images.githubusercontent.com/46433173/232328263-168ba59f-081b-41c6-bb79-3f524185d063.png)

## Use Interface Prototype

## Analysis

#### Use Cases Analysis

#### Analysis Start

#### Analysis Play

#### Analysis Resume

### Package Analysis

### Class Analysis

## Design

### Design Architecture

### Design Use Cases

#### Design Start

#### Design Play

#### Design Resume

### Class Design

#### TicTacToe Class Design

#### Turn Class Design

#### Player Class Design

#### Board Class Design

#### Enums Design

#### Types Class Design

## Implementation View

![image](https://user-images.githubusercontent.com/46433173/232120697-259003de-18b6-4260-8fd9-c191c60ebde5.png)

## Deploymnet View

![image](https://user-images.githubusercontent.com/46433173/232120816-59203f69-2a86-482f-90cb-07f8c70b7a53.png)

## Process View

-   There isn't concurrency 
