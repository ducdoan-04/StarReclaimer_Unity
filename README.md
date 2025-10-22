# Lab1: Star Reclaimer

A Unity learning project focused on game development fundamentals and Unity engine features.

## 📋 Project Overview

Star Reclaimer is a Unity-based game project developed as part of a learning lab exercise. The project demonstrates various Unity concepts including scene management, UI systems, input handling, and game state management.

## 🎮 Game Structure

### Scenes
- **MainMenu** - Main menu interface
- **Intro** - Introduction/opening sequence with animated elements
- **Gameplay** - Core gameplay scene
- **EndGame** - Game conclusion scene

### Key Features
- Scene transition system
- Animated intro sequence with light effects and logo fade
- Input system integration
- UI component management
- Universal Render Pipeline (URP) implementation

## 🛠️ Technical Details

### Unity Version
This project is built with Unity (check `ProjectSettings/ProjectVersion.txt` for exact version)

### Rendering Pipeline
- **Universal Render Pipeline (URP)** - Modern, optimized rendering pipeline
- Custom volume profiles for post-processing effects

### Input System
- **New Unity Input System** - Modern input handling system
- Input actions configured in `Assets/InputSystem_Actions.inputactions`

### Project Structure
```
Assets/
├── Art/           # Visual assets and artwork
├── Audio/         # Sound effects and music
├── Fonts/         # Typography assets
├── Prefabs/       # Reusable game objects
├── Scenes/        # Game scenes
├── Scripts/       # C# scripts and game logic
├── Settings/      # Project configuration files
├── TextMesh Pro/  # Text rendering assets
└── UI/           # User interface elements
```

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3 LTS or later (recommended)
- Visual Studio or Visual Studio Code with Unity extensions

### Setup Instructions
1. Clone or download this repository
2. Open Unity Hub
3. Click "Open" and navigate to the project folder
4. Select the `Lab1_StarReclaimer` folder
5. Unity will import and compile the project

### Running the Game
1. Open the `MainMenu` scene in `Assets/Scenes/`
2. Press the Play button in the Unity Editor
3. Use the configured input actions to interact with the game

## 📝 Scripts Overview

### Core Scripts
- **IntroManager.cs** - Manages the introduction sequence flow
- **IntroLightPulse.cs** - Handles animated light effects in intro
- **LogoFade.cs** - Controls logo fade animations
- **ImageComponentController.cs** - Manages UI image components

## 🎯 Learning Objectives

This lab project demonstrates:
- ✅ Unity scene management and transitions
- ✅ Animation and visual effects implementation
- ✅ UI system integration and management
- ✅ Input system configuration and handling
- ✅ Universal Render Pipeline setup
- ✅ Project organization and structure best practices

## 🔧 Development Notes

### Render Pipeline
The project uses Unity's Universal Render Pipeline (URP) for optimized rendering performance across multiple platforms.

### Input Handling
Modern Unity Input System is implemented for flexible and platform-agnostic input management.

### Scene Flow
The game follows a structured scene progression:
MainMenu → Intro → Gameplay → EndGame

## 📚 Resources

- [Unity Documentation](https://docs.unity3d.com/)
- [Universal Render Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest)
- [Unity Input System](https://docs.unity3d.com/Packages/com.unity.inputsystem@latest)

## 📄 License

This is a learning project. Please refer to your course materials for usage guidelines.

---

**Lab Project**: Unity Game Development Fundamentals  
**Project Name**: Star Reclaimer  
**Type**: Learning Exercise