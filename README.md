# Unity 2D Action RPG

A modern Unity gameplay project that demonstrates component-based architecture, data-driven gameplay systems and modular Action RPG design.

Unity 2D Action RPG explores the implementation of a Zelda-inspired Action RPG through interconnected gameplay systems including player combat, enemy artificial intelligence, character progression, world interaction and ScriptableObject-driven skills. Rather than embedding gameplay logic within large monolithic behaviours, the project organises mechanics into focused Unity components that collaborate to deliver a cohesive gameplay experience.

The project focuses on gameplay engineering rather than producing a finished game, demonstrating how complex gameplay mechanics can be structured using modular systems while providing the foundation for a future architectural refactor that reflects my own software engineering practices.

---

## The Engineering Problem

Modern Action RPGs combine numerous gameplay systems that must operate together in real time. Combat, movement, enemy AI, progression, equipment, animation, user interfaces and environmental interaction all depend upon one another, making architectural complexity increase rapidly as projects evolve.

Unity 2D Action RPG addresses this challenge by organising gameplay into focused component-based systems that separate responsibilities while leveraging Unity's architecture. The completed implementation will later be refactored into a cleaner, more modular design that further improves maintainability, scalability and separation of concerns.

---

## Project Architecture

<p align="center">
  <img width="500" alt="Unity2DActionRPG" src="https://github.com/user-attachments/assets/f7773c31-7580-417a-a2bb-d50be0feefc7" />
</p>

The project is organised into distinct gameplay layers that separate presentation, gameplay systems, progression, data management and Unity engine services. Gameplay features remain encapsulated within focused components while configurable data is managed independently through reusable assets, allowing systems to evolve without unnecessary coupling.

---

## Architecture Goals

The project was designed to demonstrate:

- Component-based architecture
- Gameplay system integration
- Data-driven gameplay design
- ScriptableObject architecture
- Modular gameplay systems
- Character progression
- Enemy AI implementation
- Separation of concerns

Although demonstrated using Unity, these engineering principles are transferable to other game engines, interactive simulations and component-oriented software architectures.

---

## Key Features

- Real-time player movement and combat systems
- Melee, ranged and projectile combat mechanics
- Enemy AI, combat and health systems
- Character statistics and experience progression
- ScriptableObject-based skill implementation
- Equipment and inventory management
- Interactive world and elevation systems
- Modular gameplay systems organised through Unity components

---

## Technologies & Engineering Practices

### Development

- Unity
- C#
- Visual Studio 2022
- Git

### Engineering Practices

- Component-Based Architecture
- Gameplay System Architecture
- Data-Driven Development
- ScriptableObject Design
- Object-Oriented Design
- Separation of Concerns
- Modular Architecture
- State-Driven Behaviour

---

## Architecture Highlights

- Layered gameplay architecture
- Component-based gameplay systems
- ScriptableObject-driven configuration
- Modular combat and progression systems
- Clear separation between gameplay logic and configurable data

---

## Engineering Outcome

Unity 2D Action RPG demonstrates how a modern Unity project can organise combat, progression, enemy AI and world systems into modular gameplay components while maintaining clear architectural boundaries. By combining data-driven design with Unity's component architecture, the project provides a maintainable gameplay foundation that supports future extension and serves as the basis for a comprehensive architectural refactor using my own software engineering approach.

---
