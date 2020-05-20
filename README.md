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

### Devices/software used

- Desktop tests were driven in a laptop with a i7-8750H CPU, SDRAM DDR4-2666, NVMe hard drive.
- Mobile tests were driven in a Samsung Galaxy A3.
- Chrome version 81.0.4044.138 running in Windows 10 Pro.
- Firefox version: 76.0.1 running in Windows 10 Pro.

### OS

- Windows 10 Pro
- Linux Mint
- Android 8.0.0

(*) The values indicate approximately around which number of cubes the frames are dropping.

### Native builds tests

#### Windows 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1130  | 6100  |
| 30 FPS drop at: | 1160  | 7200  |

#### Windows 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1700  | 1000  |
| 30 FPS drop at: | 1750  | 1100  |

#### Linux 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1080  | 5400  |
| 30 FPS drop at: | 1170  | 6300  |

#### Linux 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1800  | 1150  |
| 30 FPS drop at: | 1900  | 1150  |

### Android tests

#### Android 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | never | 700   |
| 30 FPS drop at: | 180   | 1000  |

#### Android 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 350   |  300  |
| 30 FPS drop at: | 460   |  340  |

### WebGL tests

#### Chrome 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 345   | 1445  |
| 30 FPS drop at: | 360   | 1805  |

#### Firefox 3D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 220   | 860   |
| 30 FPS drop at: | 370   | 1575  |

#### Chrome 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 1190  | 650   |
| 30 FPS drop at: | 1430  | 1010  |

#### Firefox 2D

|                 | Godot | Unity |
| --------------- | ----- | ----- |
| 60 FPS drop at: | 950   | 720   |
| 30 FPS drop at: | 1080  | 880   |
