# Plum Guide Exercise

## Overview

### PlumGuide.SpaceExploration.Core
This project has all the model object and types required in this exercise. Please find below a brief explanation about each one:
- `Position` is a value object that determines a two-dimensional position on an X and Y axis.
- `Facing` is an enum that determines the Rover's orientation. Possible values: `Facing.North`, `Facing.South`, `Facing.East`, `Facing.West`.
- `Rover` requires to have a `Position` and a `Facing`. It has the logic to get moved and to turn.
- `Grid` represents the planet to explore. It requires a positive width and height and also a `Rover`. It is able to check if the next position of the `Rover` is valid and also to make it effective (it it's not valid, a `MoveNotAllowedException` is thrown).


### PlumGuide.SpaceExploration.Application
This application layer has been created in order to isolate the translation of the instructions (`F`, `B`, `R`, `L`) and validation outside the `Core` project.

- `MoveRoverCommand` it is the input. The `Roadmap` property is a chain that contains all the instructions.
- `MoveRoverCommandHandler` processes all the instructions described in the `RoadMap`. If any instruction is not recognized, a `NotSupportedException` is thrown.

## Remarks

This exercise has been resolved by using TDD approach, so it is recommended to check unit tests to have a clearer picture of the implementation details.

**NOTE**: please find in the *Architectural Design.pdf* file the solution of the second part of this exercise. 
