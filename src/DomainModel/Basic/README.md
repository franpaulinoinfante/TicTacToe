# ------------- TicTacToe Domain Model Version -------------

**Index**
- [Requirements](#Requirements)  
    -   [Use Case Specifications](#Use-Case-Specifications)   
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
            -   [TicTacToe Class Design](#TicTacToe-Class-Design)  
            -   [Turn Class Design](#Turn-Class-Design)  
            -   [Player Class Design](#Player-Class-Design)  
            -   [Board Class Design](#Board-Class-Design)  
            -   [Enums Design](#Enums-Design)  
            -   [Types Class Design](#Types-Class-Design)  
    -   [Implementation View](#Implementation-View)  
    -   [Deployment View](#Deployment-View)  
    -   [Process View](#Process-View)  

## Requirements

- **Functionality:** Simple  
- **Interface:** Text  
- **Distribution:** Standalone  
- **Persistence:** No  

## Use Cases

|   Use Case View    |   Use Case Context   |
| ![image](https://user-images.githubusercontent.com/46433173/232233785-773c6b10-7d1b-4e4a-98dd-00dcf65545f8.png) |  Pic here   |
| :------ | : ------ |

## Use Case Specifications

### Specifications Start

![image](https://user-images.githubusercontent.com/46433173/231312799-5dee3926-7612-4f61-b957-57a019e9585f.png)

### Specifications Play

![image](https://user-images.githubusercontent.com/46433173/231312673-13c4b232-8897-4ef4-8006-8d63e18dafce.png)

### Specifications Resume

![image](https://user-images.githubusercontent.com/46433173/231312639-f6e3b045-4a4c-47d9-a74a-bb8b0945c294.png)

## Use Interface Prototype

```
--- TIC TAC TOE ---

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

Do you want to continue? (y/n):
n

Thanks, Good Bye!!
```

## Analysis

![image](https://user-images.githubusercontent.com/46433173/231546588-3f9a9642-d190-4139-a47f-c094756d1be5.png)

### Use Cases Analysis

### Analysis Start

![image](https://user-images.githubusercontent.com/46433173/231546804-c577d5da-91ab-421e-b751-a85b80c07dc2.png)

### Analysis Play

![image](https://user-images.githubusercontent.com/46433173/231546922-a2f653f6-81ba-4382-b06c-85d4e22f121e.png)

### Analysis Resume

![image](https://user-images.githubusercontent.com/46433173/231546979-82bc62c5-9ebb-4fde-8f5e-601702944c79.png)

### Package Analysis

![image](https://user-images.githubusercontent.com/46433173/231547056-c3a236ca-2e68-401f-8c39-da1563255800.png)

### Class Analysis

![image](https://user-images.githubusercontent.com/46433173/231547920-e4a38df2-28b3-4281-90eb-f60bd8184d34.png)

## Design

### Design Architecture

![image](https://user-images.githubusercontent.com/46433173/232083867-2bd75883-c86b-4ef9-808f-cc56a567e9ec.png)

### Design Use Cases

#### Design Start

![image](https://user-images.githubusercontent.com/46433173/232084089-0eaa56a9-0bd6-4052-84a1-5a05e940d87f.png)

#### Design Play

![image](https://user-images.githubusercontent.com/46433173/232084223-4e377ed6-a3d0-4bfa-acc4-a89ea435c116.png)

#### Design Resume

![image](https://user-images.githubusercontent.com/46433173/232084346-0a8a2668-939a-49bd-a6a9-df6114a0535d.png)

### Class Design

#### TicTacToe Class Design

![image](https://user-images.githubusercontent.com/46433173/232084527-578032c8-8bb3-43fb-a0f7-1172bce17dcb.png)

#### Turn Class Design

![image](https://user-images.githubusercontent.com/46433173/232084668-fe81456a-885d-4e1e-8871-695b8c1c77d5.png)

#### Player Class Design

![image](https://user-images.githubusercontent.com/46433173/232084767-0e81acbb-2c3c-42ff-8466-66e846aea41c.png)

#### Board Class Design

![image](https://user-images.githubusercontent.com/46433173/232084842-cb5ae4ce-aa93-4311-8bf3-747940dcccb5.png)

#### Enums Design

![image](https://user-images.githubusercontent.com/46433173/232084955-dcb09ed6-650d-4521-9693-fb1ed33991c0.png)

#### Types Class Design

![image](https://user-images.githubusercontent.com/46433173/232085042-9c3d957d-8277-4270-931e-b40f03e71d77.png)

## Implementation View

![image](https://user-images.githubusercontent.com/46433173/232120697-259003de-18b6-4260-8fd9-c191c60ebde5.png)

## Deploymnet View

![image](https://user-images.githubusercontent.com/46433173/232120816-59203f69-2a86-482f-90cb-07f8c70b7a53.png)

## Process View

-   There isn't concurrency 
