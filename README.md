# Physics Collision Simulation

This project is a physics-based collision simulation built with Unity. It demonstrates the behavior of a small box colliding with a larger, heavier box, following the principles of momentum and energy conservation. The simulation is inspired by Galperin's "Playing Pool with π" approach, where the number of collisions approximates digits of π.

## Features
- **Mass Selection**: Choose different mass values for the heavy box to observe varying collision behaviors.
- **Pi Approximation**: The number of collisions follows Galperin's method of simulating billiards to compute digits of π.
- **Accurate Collision Counting**: Detects and counts the total number of collisions based on real-time physics.
- **Real-time Physics Simulation**: Uses Unity's physics engine with fine-tuned parameters to ensure accurate interactions.
- **Replay Functionality**: Restart the simulation to test different mass values and collision scenarios.

## Mathematical Background
This simulation is based on Galperin's method, where a small box collides elastically with a much larger box and a wall. The number of collisions follows the sequence:

- 1 kg and 1 kg – 3 collisions
- 1 kg and 100 kg – 31 collisions
- 1 kg and 10,000 kg – 314 collisions

Each setup approximates additional digits of π through the number of collisions. You can read more about this fascinating concept in the paper: [Playing Pool with Pi](https://www.maths.tcd.ie/~lebed/Galperin.%20Playing%20pool%20with%20pi.pdf).

## Demo
![Simulation GIF](https://i.imgur.com/tWfYL6U.gif)
[Watch on YouTube](https://youtu.be/vP9ThSgQY9U)

## How to Play
1. Select the mass of the heavy box from the dropdown menu.
2. Start the simulation and observe the collision count.
3. Once the simulation completes, press the replay button to try again.

## Download APK
[Download APK](https://github.com/Frost2204/Pi-Collisions-Simulation/blob/main/output/piSq.apk)

## Technologies Used
- Unity Engine
- C# Scripting
- Unity Rigidbody2D Physics
- TextMeshPro for UI

## Credits
Developed by Nikunj Ranjan

