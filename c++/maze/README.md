# C++ Maze Game

## Overview
This repository contains a simple C++ program that simulates a maze game. The game is implemented using a class called `MazeNode` to represent the nodes in the maze.

## How to Run
1. Clone this repository.
2. Navigate to the directory containing `main.cpp`.
3. Compile the program using `g++ main.cpp -o maze_game`.
4. Run the executable with `./maze_game`.

## Features
- Maze navigation using the four cardinal directions (North, South, East, West).
- Dynamic maze generation using `MazeNode` objects.

## Code Structure
- [`main.cpp`](https://github.com/IanSkelskey/cplusplusmaze/blob/master/main.cpp): Contains the main logic for the maze game.

### MazeNode Class
The `MazeNode` class is used to represent each node in the maze. It has the following methods:
- `setDir()`: Sets the directions (N, S, E, W) that can be navigated to from the current node.
- `getN()`, `getS()`, `getE()`, `getW()`: Return the node in the respective direction.
- `canGo()`: Returns a string indicating which directions are navigable from the current node.

