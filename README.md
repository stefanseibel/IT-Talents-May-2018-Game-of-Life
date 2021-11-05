# Conway's Game of Life - User Manual

[![](https://i.imgur.com/SoP6XY3.png)](https://i.imgur.com/SoP6XY3.png)
This is what you're greeted with. The various buttons and elements are explained down below. Or just start clicking and playing around! Either download the .exe file or compile the ./GameOfLife folder

## Adding a grid
[![](https://i.imgur.com/MvK16RG.png)](https://i.imgur.com/MvK16RG.png)

You can create a new grid by going to Options -> New Grid. Then a window opens, where you can select the width and height of your new grid. Previous grids will remain, pressing "New Grid" will create a new tab (similar to browser tabs) with the given name.

## Set state of cell
[![](https://i.imgur.com/yVVWQ72.png)](https://i.imgur.com/yVVWQ72.png)

Simply clicking on a cell in the graphical representation changes its state from dead to alive or the other way around

## Simulate next step
[![](https://i.imgur.com/HPTiYhQ.png)](https://i.imgur.com/HPTiYhQ.png)

[![](https://i.imgur.com/TjcSB7d.png)](https://i.imgur.com/TjcSB7d.png)

[![](https://i.imgur.com/P0kSFPR.png)](https://i.imgur.com/P0kSFPR.png)

By pressing the "Next Generation" Button, the grid changes by the following rules:

1. Any live cell with fewer than two live neighbours dies, as if by underpopulation.
2. Any live cell with two or three live neighbours lives on to the next generation.
3. Any live cell with more than three live neighbours dies, as if by overpopulation.
4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

The border elements on opposite sides are considered adjencent for this calculation.

## Find recurring pattern
[![](https://i.imgur.com/anKQcmQ_d.webp?maxwidth=760&fidelity=grand)](https://i.imgur.com/anKQcmQ_d.webp?maxwidth=760&fidelity=grand)

[![](https://i.imgur.com/5vNn2Wi.png)](https://i.imgur.com/5vNn2Wi.png)

Since there only is a finite number of different states a grid could be in, there is bound to be some repetition. Clicking on "Find Pattern" finds the first recurrence of a state, the grid will just repeat all the steps between these occurences indefinitely.

## View previous generations

[![](https://i.imgur.com/ccDqcyi.png)](https://i.imgur.com/ccDqcyi.png)

There is a slider to look at previous steps of the current game. Holding the right arrow while the slider is focused makes it look like an animation of the progress of the game.

## Change Size

[![](https://i.imgur.com/ccRHAJs.png)](https://i.imgur.com/ccRHAJs.png)

You can change the size of the grid to the given width and height by pressing the "Change Size" button

## Clear Grid

[![](https://i.imgur.com/FhvIqzC.png)](https://i.imgur.com/FhvIqzC.png)

Simply sets all cells to dead.

## Delete Tab

[![](https://i.imgur.com/ByRFc1o.png)](https://i.imgur.com/ByRFc1o.png)

Deletes the current grid tab

## Invert Field

[![](https://i.imgur.com/2MfIQ9j.png)](https://i.imgur.com/2MfIQ9j.png)

Turns all alive cells dead and vice versa

## Export to png

[![](https://i.imgur.com/8SmAtFk.png)](https://i.imgur.com/8SmAtFk.png)

"Als PNG exportieren" in the options generates a PNG file in the same directory as the .exe, the name of the file is the name of the grid tab. Might not align correctly in some versions.
