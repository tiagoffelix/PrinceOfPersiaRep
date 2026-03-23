# Prince of Persia — Unity Remake

A 3D action-adventure game inspired by the classic **Prince of Persia** franchise, built with **Unity 2021.3 LTS** and **C#**. The game features platforming, melee combat, a day/night survival cycle, resource gathering, and a progression system.

---

## Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Screenshots](#screenshots)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Opening the Project](#opening-the-project)
- [Controls](#controls)
- [Gameplay Overview](#gameplay-overview)
- [Project Structure](#project-structure)
- [Built With](#built-with)
- [License](#license)

---

## About the Project

This is a tribute / remake project recreating the feel of the original Prince of Persia in a fully 3D environment. Players navigate a Persian-themed castle world, fight skeleton warriors and mummies, collect resources, and survive each night to advance deeper into the story.

---

## Features

- **3D Platforming** — navigate floors, falling platforms, and spike traps
- **Melee Combat** — sword-based attack system with hitboxes
- **Day / Night Cycle** — each night increases enemy count and difficulty
- **Health & Armor System** — two-layer defense (armor absorbs damage before health)
- **Resource Gathering** — collect Wood, Rock, and Metal
- **Shop / Upgrade System** — spend resources between nights
- **Dual Camera Modes** — toggle between first-person and third-person perspectives
- **Pause Menu** — full pause / resume with stats and controls overlay
- **In-game Timer** — 90-second day (9 AM – 8 PM in-game time)
- **Boss Encounters** — boss fight tracking and special music
- **Volume Control** — real-time audio slider
- **Cinematic Intro** — skippable intro video

---

## Screenshots

> _Add screenshots or GIFs here once available._
---

## Getting Started

### Prerequisites

| Tool | Version |
|------|---------|
| [Unity Hub](https://unity.com/download) | Latest |
| Unity Editor | **2021.3.20f1** (LTS) |
| Visual Studio / VS Code | Any recent version |

> The project was created with **Unity 2021.3.20f1**. Opening it with a different version may trigger an upgrade prompt — proceed with caution to avoid breaking compatibility.
### Opening the Project

1. **Clone the repository**
   ```bash
   git clone https://github.com/tiagoffelix/PrinceOfPersiaRep.git
   ```

2. **Open Unity Hub** and click **"Add project from disk"**.

3. **Browse** to the cloned folder and select the **`Prince of Persia`** sub-directory (the folder that contains the `Assets` directory).

4. Unity will import all assets automatically. This may take several minutes on first open.

5. In the **Project** window, open `Assets/Scenes/Game.unity`.

6. Press ▶ **Play** in the Unity Editor to run the game.

---

## Controls

| Action | Key / Button |
|--------|-------------|
| Move Left / Right | `←` / `→` Arrow Keys |
| Jump | `↑` Arrow Key |
| Attack | _(configured in-scene)_ |
| Toggle Camera | Camera switch UI button |
| Pause | Pause button / `Escape` |
| Skip Intro | Press any key (at intro screen) |

---

## Gameplay Overview

1. **Day Phase** (90 seconds) — explore the level, collect resources (Wood, Rock, Metal), and visit the shop to upgrade your equipment.
2. **Night Phase** — survive waves of skeleton warriors and mummies. Each night increases enemy count.
3. **Health & Armor** — your Paladin has 100 HP and 100 Armor. Armor absorbs hits first; restore health with collected Health Bottles.
4. **Progression** — defeat the boss encounter to reach the game's ending.

---

## Project Structure

```
PrinceOfPersiaRep/
└── Prince of Persia/          # Unity project root
    ├── Assets/
    │   ├── Scripts/           # C# gameplay scripts
    │   │   ├── PlayerMovement.cs
    │   │   ├── PlayerStats.cs
    │   │   ├── PauseMenu3D.cs
    │   │   ├── CameraSwitch.cs
    │   │   ├── VolumeController.cs
    │   │   ├── VolumeSlider.cs
    │   │   └── PressToSkip.cs
    │   ├── Scenes/            # Game scenes (Game.unity)
    │   ├── Animations/        # Character FBX animations & controllers
    │   ├── Prefabs/           # Reusable game objects (39 prefabs)
    │   └── Assets/            # Third-party art packs
    │       ├── Low Poly Pack - Environment Lite/
    │       ├── Historic environment/
    │       ├── Castle assets package/
    │       ├── Skeleton Warrior/
    │       ├── Mummy/
    │       └── RPG Pack/
    ├── Packages/              # Unity package manifest
    ├── ProjectSettings/       # Engine & platform settings
    └── Nivel e sons/          # Level design resources & audio notes
```

---

## Built With

- [Unity 2021.3 LTS](https://unity.com/) — game engine
- **C#** — scripting language
- [ProBuilder](https://unity.com/features/probuilder) — in-editor level design
- [TextMeshPro](https://docs.unity3d.com/Packages/com.unity.textmeshpro@latest) — UI text rendering
- [Unity Timeline](https://docs.unity3d.com/Packages/com.unity.timeline@latest) — cinematic sequences
- [Unity Visual Scripting](https://unity.com/features/unity-visual-scripting) — node-based scripting support

---

## License

This project is for educational and portfolio purposes. All third-party assets (environment packs, character models, audio) remain the property of their respective creators and are subject to their own licenses.
