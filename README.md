# ARPG 
A Unity-based **2D action role-playing game project** that demonstrates top-down movement, directional combat, enemy AI, and RPG-style progression systems.

The project explores modular gameplay programming, melee and ranged combat, enemy detection and chasing behaviour, knockback interactions, stat management, reusable prefabs, and UI-driven progression within a Unity 2D environment.

> **Status:** Ongoing development — currently focused on core movement, combat, enemy behaviour, stats, and progression systems, with planned expansion toward inventory, equipment, additional enemies, improved level design, and polished combat feedback.

## Overview

ARPG is a Unity 2D action role-playing game project that demonstrates core gameplay systems for a top-down adventure experience. The project focuses on player movement, directional combat, ranged attacks, enemy behaviour, knockback, stats, progression, and reusable UI/prefab structures.

The project is organised around separated gameplay systems rather than placing all behaviour in one script. Player, enemy, environment, and stats logic are split into dedicated folders, making the project easier to inspect, extend, and present as a portfolio piece.

## Key Features

- Top-down 2D player movement with directional facing and animation parameters
- Melee combat using an attack point, weapon range, enemy layer detection, and cooldown timing
- Ranged bow combat with directional aiming, arrow prefab spawning, and shoot cooldown control
- Enemy AI with idle, chasing, attacking, and knockback states
- Player and enemy health systems with damage and knockback interactions
- Centralised stat values for speed, damage, range, knockback force, and stun timing
- Experience, stats UI, and skill tree structure for RPG-style progression
- Environment trigger scripts for elevation entry and exit behaviour
- Reusable prefabs including arrows, skill buttons, and stat slots
- Clean Unity project layout using Assets, Scenes, Scripts, Sprites, Prefabs, Packages, and ProjectSettings

## 🌌 Current Systems

### Player: Movement and Combat

The player system combines movement, melee attacks, ranged attacks, animation switching, and knockback handling. Movement reads horizontal and vertical input, flips the character based on direction, updates animator parameters, and applies Rigidbody2D velocity using values from the shared stats manager.

- Directional movement controlled through horizontal and vertical axes
- Sprite flipping based on player movement direction
- Melee attack activation through a dedicated combat script and attack cooldown
- Area-based damage detection using Physics2D overlap checks around an attack point
- Bow aiming based on raw directional input and arrow spawning from a launch point
- Temporary movement lock while shooting to keep the ranged attack animation stable
- Knockback coroutine support for short stun/recovery windows

### Enemy: Detection, Chasing, and State Behaviour

The enemy system uses a simple state machine to control behaviour. Enemies search for the player using a detection radius, chase when the player is within range, stop to attack when close enough, and can be pushed into a knockback state through combat interactions.

- Detection radius using Physics2D overlap checks
- Chasing behaviour that follows the player transform
- Attack range and cooldown handling to prevent constant attacks
- Animator boolean switching for idle, chasing, and attacking states
- Facing-direction flipping so enemies visually track the player
- Knockback support for damage feedback and temporary interruption

### Stats, Progression, and UI

The stats system supports RPG-style balancing by keeping key gameplay values accessible from central management scripts. The repository also includes experience management, stats UI, and a SkillTree folder, supported by UI prefabs such as SkillButton and StatsSlot.

- StatsManager for shared player combat and movement values
- ExpManager for progression-related logic
- StatsUI for displaying player values
- SkillTree folder for upgrade/progression scripts
- StatsSlot and SkillButton prefabs for reusable UI elements

## 🧱 Architecture

```text
ARPG/
├── Assets/           → Unity assets, scenes, scripts, sprites, prefabs, and UI elements
├── Scenes/           → Main playable ARPG scene
├── Scripts/          → Player, enemy, environment, stats, combat, and progression logic
├── Prefabs/          → Reusable gameplay and UI objects such as arrows, skill buttons, and stat slots
├── Sprites/          → 2D visual assets used for characters, environments, and gameplay objects
├── Packages/         → Unity package dependencies
└── ProjectSettings/  → Unity project configuration
```

## Technologies

- Unity
- C#
- Unity 2D Physics
- Rigidbody2D and Collider2D systems
- Unity Animator
- TextMesh Pro
- Unity Input System / input actions
- Git and GitHub

## Core Inputs

| Input | Action |
|---|---|
| Horizontal / Vertical | Move the player and update directional animation values |
| Slash | Trigger the melee attack if combat is enabled and cooldown allows |
| Shoot | Start bow attack animation and fire an arrow when ready |
| Directional input while bow is active | Set the arrow aim direction and bow animation parameters |

## 🚀 Getting Started

### Requirements

- Unity Editor compatible with the project version
- Git or GitHub Desktop
- A desktop environment capable of running Unity 2D projects

### Steps

1. Clone or download the repository.
2. Open the project folder in Unity Hub.
3. Allow Unity to restore packages and import assets.
4. Open `Assets/Scenes/ARPG.unity`.
5. Press Play in the Unity Editor to test the project.

## 🔭 Future Work

- More enemy types with distinct AI patterns and attack behaviours
- Expanded skill tree upgrades and stat progression options
- Inventory, item pickup, and equipment management systems
- Improved level design, checkpoints, and scene transitions
- Polished UI feedback for health, experience, cooldowns, and unlocked skills
- Audio, visual effects, and hit-impact feedback for combat readability
- Code cleanup to remove unused UnityEditor imports from runtime scripts before final builds

---
