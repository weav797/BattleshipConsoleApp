# BattleshipConsoleApp

### **General flow**

- Two users open up the console
- Ask user 1 where to place their ships
- Ask user 2 where to place their ships
- Ask user 1 for a shot
    - Determine hit or miss
    - Determine if the game is over
- Ask user 2 for a shot
    - Determine hit or miss
    - Determine if the game is over
- Repeat until someone wins
- Identify who winner is
- Exit the application

### **Additional Questions/Requirements**

- Is it the same console or two different consoles working together?
    - **Same console**
- Does the other player get one last chance after being sunk?
    - **No**
- Do we want to capture/display statistics such as hit/miss ratio, etc.?
    - **Just how many shots it took to win**
- Only one ship per spot
    - **Yes**
- Do we allow a player to shoot the same spot twice?
    - **No**
- Do we show a visual of the grid?
    - **Yes**
- Do we store game data?
    - **No**
- Are we ever going to change the number of players?
    - **Maybe**
- Will we add a computer player?
    - **Maybe**
 


I think we should have a greeting message in the opening part.

Ex. ***Welcome to the game of Battleship!***

***We will ask both users 1 & 2 to place their ships in a grid of A1-E5.***

***Do not let the other player see your picks!***

|  | 1 | 2 | 3 | 4 | 5 |
| --- | --- | --- | --- | --- | --- |
| A |  |  |  |  |  |
| B |  |  |  | X |  |
| C | X |  | X |  |  |
| D |  |  |  |  | X |
| E |  | X |  |  |  |

Cont. Ex. ***Pick your first spot user 1: C3***

Prompt will repeat 5 times until all 5 ships have been selected. Next screen pops up and will look similar except will prompt differently.      Ex. ***Pick your first spot user 2***

Subsequential prompts should say:         Ex. ***Pick your next spot: A5***

And final selection should say:                Ex. ***Pick your final spot: E1***

As the game progresses, hits & misses are recorded on the player’s screens.

Ex. 

**X** = miss

**O** = hit

|  | 1 | 2 | 3 | 4 | 5 |
| --- | --- | --- | --- | --- | --- |
| A | X |  |  |  |  |
| B |  |  |  | X |  |
| C |  | O |  |  |  |
| D |  |  |  |  |  |
| E |  |  |  |  |  |

Hits: 1

Misses: 2





Once we have the basic UI set up, need to think about the logic.

Users will have picked their spots at this point. Maybe a random coin flip feature can be added to determine who goes first. Once that happens, user who won will select what spot to hit. If hit, continue onwards. If not, user passes to opponent. This will go on and on until all 5 ships are sunk and we have a winner.

### **Flow**

Welcome message ➡️ initial grid ➡️ Ask user 1 to select ships ➡️

Same for user 2 ➡️ Coin flip ➡️ 

Winner goes first ➡️ 

*-if hit, continue*

*-if miss, pass to opponent*

next user’s turn ➡️

*-Same logic applies*

Repeat until users 1 or 2 (not both) have all 5 ships lost. ➡️ Winner!!





In our additional list of requirements, it’s said that we **MAY** change the number of players later on. So we need to write the code in a way that doesn’t hard-code the amount of players. So maybe we’ll add a class library dedicated to the user itself. 

Ex. 

```csharp
public class User 
{
	Name property
	Winner boolean property
	amount of turns property
	amount of ships property
	hit amount property
	miss amount property
	ship position property? // not sure if it belongs in this class
}
```
