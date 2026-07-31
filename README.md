# Galaxy Strike

Galaxy Strike is my third Unity project from the Complete C# Unity Game Developer course.

The game is inspired by space shooters such as Star Fox and is being developed as part of my studies in Unity and C#.

## Current Development

At this stage, I am expanding the first combat systems and player interactions.

So far, I have:

- Created and textured the initial terrain environment.
- Created the first Timeline sequence for the player ship.
- Added the first enemy and animated it through Timeline.
- Created a custom `PlayerInput` action map using `Vector2`.
- Implemented the `PlayerMovement` script.
- Added movement boundaries with `Mathf.Clamp()`.
- Added smooth visual rotation using `Quaternion.Lerp()`.
- Added a laser weapon using Unity's Particle System.
- Created a mouse-following crosshair.
- Used `ScreenToWorldPoint()` to convert the aiming position into world coordinates.
- Implemented dual laser firing by controlling multiple emitters with an array and `foreach`.
- Added collision detection for the player ship and enemies.
- Configured particle collisions for laser impacts.
- Created explosion particle effects from scratch.
- Instantiated explosion effects at runtime using `Instantiate()`.
- Created separate player and enemy explosion effects using Nested Prefabs and Prefab Variants.
  
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
- Controlled enemy waves using Control Tracks.
- Created and synchronized dialogue audio using Audio Tracks.
- Used Timeline Signals to trigger dialogue text updates.
- Added multiple cameras using Control Tracks for dialogue scenes.
- Synchronized dialogue subtitles, voice lines, and camera transitions.

### UI

- Created the `DialogueLines` script to update UI dialogue lines in sync with the audio.
- Added character portraits to the dialogue interface.

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

### Weapon System

- Creating a dedicated `PlayerWeapon` script.
- Using `InputValue.isPressed` to detect when the fire button is pressed or released.
- Storing the input state in a boolean variable.
- Controlling multiple laser emitters with an array and `foreach`.

### Particle System and Visual Effects

- Controlling the Particle System Emission Module through code.
- Enabling and disabling the Particle System Emission Module to control continuous laser firing.
- Using an HDR emission color with Bloom to create a glowing laser effect.
- Configuring imported materials to use compatible URP shaders.

### Combat System
- Converting screen coordinates into world coordinates with `ScreenToWorldPoint()`.
- Creating and instantiating particle effects at runtime using `Instantiate()`.
- Configuring Particle System collision modules.
- Detecting collisions with `OnTriggerEnter()`.

### Prefab Workflow
- Creating Nested Prefabs.
- Creating and using Prefab Variants.
- Organizing reusable particle effect prefabs.

### Lighting & Rendering

- Configured Lighting settings.
- Applied real-time shadows.
- Configured Post Processing effects.
- Customized the Skybox to create a more immersive space environment.

## Problems Solved

### Pink Materials After Importing an Asset

**Problem:**  
The materials from an Asset Store package appeared completely pink after being imported into the project.

**Cause:**  
The imported materials were using shaders that were incompatible with the Universal Render Pipeline used by the project.

**Solution:**  
I changed the materials to use the `Universal Render Pipeline/Lit` shader and reassigned the corresponding textures.

---

### Laser Emission Without a Glow Effect

**Problem:**  
The laser material had Emission enabled, but it did not produce the glowing effect shown in the course.

**Cause:**  
Emission makes the material brighter, but the scene did not have Bloom enabled to create the visible glow around it.

**Solution:**  
I enabled post-processing on the camera, created a Global Volume, added Bloom, and adjusted the HDR emission intensity of the laser material.

---

### Trigger Not Firing
**Problem**

The player's collision callback was never executed.

**Cause**

The player's collider was not configured as Trigger.

**Solution**

Enabled `Is Trigger` on the collider and verified the Rigidbody/Collider configuration.

---

### Large Asset Exceeded GitHub's File Size Limit

**Problem:**

GitHub Desktop warned that an imported PSD file exceeded GitHub's 100 MB file size limit and could not be pushed normally.

**Cause:**

An unused source PSD file from an imported asset package was included in the pending changes.

**Solution:**

I moved the PSD folder outside the Unity project, verified that the game did not depend on it, and added its path to `.gitignore`.

---

## Development Status

Project currently in development.

The project now includes the initial terrain environment, player movement, Timeline-based enemy animations, mouse-controlled aiming, dual laser firing, collision detection, and separate explosion effects for the player and enemies.

The next stages will focus on expanding the gameplay, adding new interactions, and improving the visual and technical polish as I progress through the project.

## Technologies

- Unity 6
- C#
- Unity Terrain
- Unity Timeline
- Unity Input System
- Git
- GitHub
- Unity Particle System
- Universal Render Pipeline

## Author

Developed by [viha-coder](https://github.com/viha-coder)
