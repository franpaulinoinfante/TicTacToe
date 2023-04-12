# ------------- TicTacToe Domain Model Version -------------

**Index**
- [Requirements](#Requirements)  
    -   [Use Case Specifications](#Use-Case-Specifications)   
        -   [Specifications Start](#Specifications-Start)  
        -   [Specifications Play](#Specifications-Play)  
        -   [Specifications-Resume](#Specifications-Resume)  
    -   [Use Interface Prototype](#Use-Interface-Prototype)  
    -   [Analysis](#Analysis)  
        -   [Architecture](#Architecture)  
        -   [ConsoleApp](#ConsoleApp)  
    -   [Use Case Analysis](#Use-Case-Analysis)  
        -   [Analysis Start](#Analysis-Start)  
        -   [Analysis Play](#Analysis-Play)  
        -   [Resume Analysis](#Analysis-Resume)  

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

### Architecture

### ConsoleApp

### Use Case Analysis

### Analysis Start

### Analysis Play

### Analysis Resume
