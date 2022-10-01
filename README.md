# Project

The game will be a cube sliding down a ramp with obstacles coming from the distance to knock the cube away. The goal of the game is to avoid the obstacles, the player's score is determined by how long they can avoid the obstacles.

# Plan

Have a basic red cube to represent the player with obstacles being basic black shapes. In order for this game to be infinite until the player screws up, the obstacles will be generated at the end of a long ramp and moved towards the player, to create the illusion of motion.
The camera is at a constant distance with respect to the player. A techno-ish music plays while the player plays. As the player keeps avoiding obstacles, their score is increasing and being displayed on a UI. The player screws up by either falling off of the ramp or by hitting an obstacle. When the player screws up, the game ends, their final score is displayed, and they may hit space to restart the game.

# Components

## Camera Manager

The camera manager is responsible for keeping the camera close to the player.

## Obstacle Manager

The obstacle manager is responsible for instantiating the obstacles the player will face. This instantiation takes place through an Obstacle Factory

### Obstacle factory

Responsible for instantiating obstacles

### Move Obstacle

Responsible for moving the instantiated obstacle along the track towards the player

## Score Manager

The score manager is responsible for incrementing the player's score while the game isn't over, and for delivering that information to the UI manager.

## Audio manager

Responsible for playing the correct audio given the game state

## Player input manager

Responsible for correctly processing player input given the game state

## UI Manager

Responsible for displaying the player's score at the end of the game, and telling them to press space to restart

## Game Manager

The Game Manager is responsible for starting, restarting the game, and for knowing when the game is over.
The GameManager will be notified by another component when the game is over, and will notify other components of that fact, notably:

- The UI manager to display the player's score
- The audio manager to change the music
- the obstacle manager to tell all obstacles to stop, and to stop making new obstacles
- the input manager to stop waiting for player input to move the cube, and to start waiting for spacebar input to reload the scene

When the game is reset, the game scene is reloaded.

# References

- [Project figma](https://www.figma.com/file/8z2LLfC6iTGcVCYMHcpMeH/CubeRun.Unity?node-id=0%3A1)
