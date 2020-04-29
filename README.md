# Godot VS Unity Performance Benchmark

The objective of this project is to compare the performance of Godot Engine and Unity Engine using object instantiation.

The requirements for the 3D benchmark are:

- To display a window of 1280x720.
- To instantiate a cube each 0.1 seconds and let it drop to a physical plane.

The requirements for the 2D benchmark will be pretty similar:

- To display a window of 1280x720.
- To instantiate a 2D ball each 0.1 seconds and let it drop to a box.

The measurements will be:

- With how many cubes the demo starts dropping clearly below 60 FPS.
- With how many cubes the demo starts dropping clearly below 30 FPS.

## Technologies under test

- [Godot 3.2.1](https://godotengine.org/)
  - OpenGL 2.0
- [Unity 2019.3.7f1](https://unity.com/)

## Test results

### Tests devices

- Desktop tests were driven in a laptop with a i7-8750H CPU, SDRAM DDR4-2666, NVMe hard drive.
- Mobile tests were driven in a Samsung Galaxy A3.

### OS

- Windows 10 Pro
- Linux Mint
- Android 8.0.0

(*) The values indicate approximately around which number of cubes the frames are dropping.

### Windows 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1130  | 6100  |
| 30 FPS drop at: | 1160  | 7200  |

### Windows 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1700  | 1000  |
| 30 FPS drop at: | 1750  | 1100  |

### Linux 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1080  | 5400  |
| 30 FPS drop at: | 1170  | 6300  |

### Linux 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1800  | 1150  |
| 30 FPS drop at: | 1900  | 1150  |

### Android 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | never | 700   |
| 30 FPS drop at: | 180   | 1000  |

### Android 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 350   |  300  |
| 30 FPS drop at: | 460   |  340  |
