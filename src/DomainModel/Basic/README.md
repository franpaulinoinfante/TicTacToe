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

## Requirements

- **Functionality:** Simple  
- **Interface:** Text  
- **Distribution:** Standalone  
- **Persistence:** No  

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

![image](https://user-images.githubusercontent.com/46433173/231547188-b2788d18-44a5-4df2-bb4a-7a207dbccf7c.png)

## Design

### Design Architecture

### Design Use Cases

### Design Start

### Design Play

### Design Resume
