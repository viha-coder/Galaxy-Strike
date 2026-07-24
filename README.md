# Galaxy Strike

Galaxy Strike is my third Unity project from the Complete C# Unity Game Developer course.

The game is inspired by space shooters such as Star Fox and is being developed as part of my studies in Unity and C#.

## Current Development

At this stage, I am building the initial environment and implementing the first gameplay systems.

So far, I have:

- Created and textured the initial terrain environment.
- Created the first Timeline sequence for the player ship.
- Added the first enemy and animated it through Timeline.
- Created a custom `PlayerInput` action map using `Vector2`.
- Implemented the `PlayerMovement` script.
- Added movement boundaries with `Mathf.Clamp()`.
- Added smooth visual rotation using `Quaternion.Lerp()`.

## Concepts Learned

### Unity Terrain

- Creating and configuring a Terrain.
- Shaping mountains, valleys, and other terrain features with brushes.
- Adjusting Brush Size and Brush Strength.
- Using Terrain Layers to control the textures painted across the environment.
- Combining different textures to create a more natural-looking landscape.

### Timeline

- Creating a Timeline asset.
- Using the Playable Director.
- Adding an Animation Track.
- Creating a short animated sequence.
- Controlling an object's movement through Timeline.
- Added the enemy to an Animation Track.
- Learned how to trim and reposition Timeline clips.
- Used Timeline Curves to fine-tune animation values.
- Adjusted the enemy's rotation at specific moments.
- Improved the timing and control of the enemy animation.

### Player Input

- Creating a custom Input System configuration.
- Reading two-dimensional input values with `Vector2`.
- Connecting input actions to the player movement script.

### Player Movement

- Moving the player with horizontal and vertical input.
- Using `Mathf.Clamp()` to restrict the ship's position.
- Keeping the player inside the visible gameplay area.

### Rotation and Smoothing

- Using `Quaternion` to represent and control rotations.
- Using `Quaternion.Lerp()` to smoothly transition between rotation values.
- Applying player input to the visual rotation of the ship.

## Development Status

Project currently in development.

More gameplay systems, visual effects, enemies, shooting mechanics, and improvements will be added as I progress through the project.

## Technologies

- Unity 6
- C#
- Unity Terrain
- Unity Timeline
- Unity Input System
- Git
- GitHub

## Author

Developed by [viha-coder](https://github.com/viha-coder)
