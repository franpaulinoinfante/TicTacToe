# ----- TicTacToe Domain Model Version With Machine Player -----

**Index**
- [Requirements](#Requirements)  
    -   [Use Cases](#Use-Cases)
    -   [Initial Description of Use Cases](#Initial-Description-of-Use-Cases)  
    -   [Use Case Specifications](#Use-Case-Specifications)   
        -   [Specifications Configure Players](#Specifications-Configure-Players)   
        -   [Specifications Start](#Specifications-Start)  
        -   [Specifications Play](#Specifications-Play)  
        -   [Specifications-Resume](#Specifications-Resume)  
    -   [Use Interface Prototype](#Use-Interface-Prototype)  
        -   [Machine vs Machine](#Machine-vs-Machine)  
        -   [Player vs Machine](#Player-vs-Machine)  
        -   [Player vs Player](#Player-vs-Player)  
    -   [Analysis](#Analysis)  
        -   [Analysis Architecture](#Analysis-Architecture)  
        -   [Use Case Analysis](#Use-Case-Analysis)  
            -   [Analysis Configure Player](#Analysis-Configure-Player)  
            -   [Analysis Start](#Analysis-Start)  
            -   [Analysis Play](#Analysis-Play)  
            -   [Analysis Resume](#Analysis-Resume)  
        -   [Class Analysis](#Class-Analysis) 
            -   [Class Analysis TicTacToe][#Class-Analysis-TicTacToe]  
            -   [Class Analysis Turn](#Class-Analysis-Turn) 
            -   [Class Analysis Player](#Class-Analysis-Player)  
            -   [Class Analysis Board](#Class-Analysis-Board)   
            -   [Class Analysis PlayerConfiguration](#Class-Analysis-PlayerConfiguration)  
            -   [Analysis Types](#Analysis-Types)  
            -   [Analysis Enums](#Analysis-Enums)  
        -   [Analysis Package](#Analysis-Package)  
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
| Configure Player | The system allow select one of three game options:<br/>  1. Machine vs. Machine,<br/> 2. Player vs. Machine, and<br/> 3. Player vs. Player.  | 
| Start            | The system allow start the game. | 
| Play             | The system allow play the game.  | 
| Resume           | The system asks if the user wants a new game or exit.  |  

## Use Case Specifications

## Specifications Configure Players

![image](https://user-images.githubusercontent.com/46433173/232328353-78da963c-953c-449e-bc6c-db4965e671c1.png)

### Specifications Start

![image](https://user-images.githubusercontent.com/46433173/232328321-c6724e9a-f610-48ed-af3f-8a9135d129f4.png)

### Specifications Play

![image](https://user-images.githubusercontent.com/46433173/232329012-1cd90dd3-59d6-4e6d-9666-85a2db8ca82b.png)

### Specifications Resume

![image](https://user-images.githubusercontent.com/46433173/232328263-168ba59f-081b-41c6-bb79-3f524185d063.png)

## Use Interface Prototype

### Machine vs Machine

```
--- TIC TAC TOE ---

Enter the players' number: 0
-------------
 |   |   |   |
-------------
 |   |   |   |
-------------
 |   |   |   |
-------------

Current turn: O
Random Coordinate [0, 2]
-------------
 |   |   | O |
-------------
 |   |   |   |
-------------
 |   |   |   |
-------------

Current turn: X
Random Coordinate [2, 0]
-------------
 |   |   | O |
-------------
 |   |   |   |
-------------
 | X |   |   |
-------------

Current turn: O
Random Coordinate [1, 0]
-------------
 |   |   | O |
-------------
 | O |   |   |
-------------
 | X |   |   |
-------------

Current turn: X
Random Coordinate [0, 1]
-------------
 |   | X | O |
-------------
 | O |   |   |
-------------
 | X |   |   |
-------------

Current turn: O
Random Coordinate [1, 2]
-------------
 |   | X | O |
-------------
 | O |   | O |
-------------
 | X |   |   |
-------------

Current turn: X
-------------
 |   | X | O |
-------------
 | O |   | O |
-------------
 | X |   | X |
-------------

Current turn: O
-------------
 | O | X |   |
-------------
 | O |   | O |
-------------
 | X |   | X |
-------------

Current turn: X
-------------
 | O |   |   |
-------------
 | O |   | O |
-------------
 | X | X | X |
-------------

Congratulations player: X, you WON!!!! :-)

Do you want to continue? (y/n)
```

### Player vs Machine

```
--- TIC TAC TOE ---

Introduce the players [0-2]:  1

-------------
|   |   |   |
|   |   |   |
|   |   |   |
-------------

Current turn: O
Coordinate to put: [1,1]
-------------
| O |   |   |
|   |   |   |
|   |   |   |
-------------

Current turn: X
Enter a coordinate to put a token:
Row: 2
Column: 2
-------------
| O |   |   |
|   | X |   |
|   |   |   |
-------------

Current turn: O
-------------
| O |   |   |
|   | X |   |
|   |   | O |
-------------

Current turn: X
Enter a coordinate to put a token:
Row: 3
Column: 1
-------------
| O |   |   |
|   | X |   |
| X |   | O |
-------------

Current turn: O
-------------
| O |   | O |
|   | X |   |
| X |   | O |
-------------

Current turn: X
Enter a coordinate to put a token:
Row: 3
Column: 2
-------------
| O |   | O |
|   | X |   |
| X | X | O |
-------------

Current turn: O
-------------
|   |   | O |
|   | X | O |
| X | X | O |
-------------

Congratulations player: O, you WON!!!! :-)

Do you want to continue? (y/n): y
```

### Player vs Player

```
--- TIC TAC TOE ---

Introduce the players [0-2]: 2
-------------
|   |   |   |
|   |   |   |
|   |   |   |
-------------

Current turn: X
Enter a coordinate to put a token:
Row: 5
Column: -3

-------------
Error! 
The coordinate is out range
-------------

Enter a coordinate to put a token:
Row: 2
Column: 2
-------------
|   |   |   |
|   | X |   |
|   |   |   |
-------------

Curren turn: O
Enter a coordinate to put a token:
Row: 2
Column: 2

-------------
Error!
The square is occupied
-------------

Enter a coordinate to put a token:
Row: 3
Column: 3
-------------
|   |   |   |
|   | X |   |
|   |   | O |
-------------

Current turn: X
Enter a coordinate to put a token:
Row: 1
Column: 1
-------------
| X |   |   |
|   | X |   |
|   |   | O |
-------------

Current turn: O
Enter a coordinate to put a token:
Row: 3
Column: 1
-------------
| X |   |   |
|   | X |   |
| O |   | O |
-------------

Current turn: X
Enter a coordinate to put a token:
Row: 3
Column: 2
-------------
| X |   |   |
|   | X |   |
| O | X | O |
-------------

Current turn: O
Enter a coordinate to put a token:
Row: 1
Column: 2
-------------
| X | O |   |
|   | X |   |
| O | X | O |
-------------

Current turn: X
Enter the origin coordinate to move
Row: 3
Column: 3

-------------
Error!
Token is not of current player
-------------

Enter the origin coordinate to move
Row: 1
Column: 1

Enter the target coordinate to move
Row: 1
Column: 1

-------------
Error!
The squares of origin and destination cannot be the same.
-------------

Enter the target coordinate to move
Row: 2
Column: 1
-------------
|   | O |   |
| X | X |   |
| O | X | O |
-------------

Current turn: O
Enter the origin coordinate to move
Row: 3
Column: 1

Enter the target coordinate to move
Row: 1
Column: 1
-------------
| O | O |   |
| X | X |   |
|   | X | O |
-------------

Current turn: X
Enter the origin coordinate to move
Row: 3
Column: 2

Enter the target coordinate to move
Row: 2
Column: 3
-------------
|   | O |   |
| X | X | X |
| O |   | O |
-------------

Congratulations player: X, you WON!!!! :-)

Do you want to continue? (y/n): n
Thanks, Good Bye!!
```

## Analysis

### Architecture Analysis

![image](https://user-images.githubusercontent.com/46433173/232495039-8900f0bf-9b03-4530-ac35-42a26744184f.png)

### Use Cases Analysis

#### Analysis Configure Player

![image](https://user-images.githubusercontent.com/46433173/232495472-94ff5927-befd-4b12-812c-5ef82292ecb2.png)

#### Analysis Start

![image](https://user-images.githubusercontent.com/46433173/232495570-b91c9bbd-dea4-4d22-ba28-70c8cdeede40.png)

#### Analysis Play

![image](https://user-images.githubusercontent.com/46433173/232495920-7eb0cbaa-587a-4a7d-a31b-4ab73b0924f8.png)

#### Analysis Resume

![image](https://user-images.githubusercontent.com/46433173/232496240-d8b727ea-d3c7-4f73-b357-b33ac3fd3191.png)

### Class Analysis

#### Class Analysis TicTacToe

![image](https://user-images.githubusercontent.com/46433173/233143504-f21f6a52-d72e-49cb-a572-2a458d0ea361.png)

#### Class Analysis Turn

![image](https://user-images.githubusercontent.com/46433173/233143069-a899b400-8de8-4614-b5d2-7f7a34005803.png)

#### Class Analysis Player

![image](https://user-images.githubusercontent.com/46433173/233141158-eff8f669-60d4-412d-99f0-ac66be5fc285.png)

#### Class Analysis Board

![image](https://user-images.githubusercontent.com/46433173/233140719-871d731d-6a66-4cc5-9bca-5906696326d7.png)

#### Class Analysis PlayerConfiguration

![image](https://user-images.githubusercontent.com/46433173/233140500-4e211ea1-3c70-46b8-a11c-94a22b7cfcac.png)

#### Analysis Types

![image](https://user-images.githubusercontent.com/46433173/233139732-73443f64-10cc-4236-a48d-5bc62b1a8168.png)

#### Analysis Enums

![image](https://user-images.githubusercontent.com/46433173/232498201-cf102c6f-68ca-4c2b-9a55-0ca0895167ee.png)

### Package Analysis

![image](https://user-images.githubusercontent.com/46433173/232501041-e6b982a0-72cf-4ece-978f-7692acd08c34.png)

## Design

### Architecture Design

![image](https://user-images.githubusercontent.com/46433173/232639693-7e56e744-646c-4672-93bf-722d90fc2953.png)

### Design Use Cases

#### Design Player Configuration

![image](https://user-images.githubusercontent.com/46433173/232539167-7f530937-07af-4533-92dc-fa7d4197c715.png)

#### Design Start

![image](https://user-images.githubusercontent.com/46433173/232539065-12254b45-9e27-47b9-8774-30107c0a467d.png)

#### Design Play

![image](https://user-images.githubusercontent.com/46433173/232539005-8924746f-f5c2-4218-92ab-a74797f272f4.png)

#### Design Resume

![image](https://user-images.githubusercontent.com/46433173/232538886-97b5f3a8-ab2d-4229-b05c-da70c888f626.png)

### Class Design

#### Design Class Models

![image](https://user-images.githubusercontent.com/46433173/233138814-cd474710-b9a7-485b-8246-d29c576fe0a5.png)

#### Design Class Types

![image](https://user-images.githubusercontent.com/46433173/233138680-e11d785f-c655-48b7-8720-2705e04532b4.png)

#### Design Class Enums

![image](https://user-images.githubusercontent.com/46433173/233138595-b6684e0b-0d5a-4385-b1c5-ac38d8b61659.png)

## Implementation View

![image](https://user-images.githubusercontent.com/46433173/232120697-259003de-18b6-4260-8fd9-c191c60ebde5.png)

## Deploymnet View

![image](https://user-images.githubusercontent.com/46433173/232120816-59203f69-2a86-482f-90cb-07f8c70b7a53.png)

## Process View

-   There isn't concurrency 
