# Unity Project
A project used to practice using C# in an environment that allows immediate feedback

## Location of Code
Code I have written is inside the `Assets\Scripts` folder
- There are 3 files that contain the code for the unity project

## PlayerMovement.cs
- Allows the player to move forwards and backwards
- Allows the player to jump up to a max jump count

## MovingObject.cs
- Allows for moving objects to move horizontally or vertically
- Based on the direction, the moving objects will move to a target position and then reverse back to its starting position
- Changes speed of moving objects based on input of user

### DestroyMovingObject.cs
- Inherits from the Moving Object class
- When a moving object reaches the target position, the object is destroyed. 