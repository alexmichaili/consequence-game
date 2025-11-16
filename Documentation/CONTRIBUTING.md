# Contributing to Consequence Game

Thank you for your interest in contributing to Consequence Game! This document provides guidelines and information for contributors.

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3 LTS or later
- Node.js 18+ and npm
- Git with LFS support
- Basic knowledge of C# (Unity) and JavaScript (backend)

### Development Setup
1. Fork the repository
2. Clone your fork: `git clone https://github.com/yourusername/consequence-game.git`
3. Open `UnityProject/` in Unity Hub
4. Navigate to `Server/` and run `npm install`
5. Copy `.env.example` to `.env` and configure local settings

## 🎯 How to Contribute

### Reporting Bugs
- Use the bug report template in GitHub Issues
- Include Unity version, platform, and steps to reproduce
- Attach logs and screenshots when helpful

### Suggesting Features
- Use the feature request template
- Explain the use case and expected behavior
- Consider if it fits the game's core vision

### Code Contributions
1. Create a feature branch: `git checkout -b feature/your-feature-name`
2. Make your changes following our coding standards
3. Test your changes thoroughly
4. Commit with clear, descriptive messages
5. Push to your fork and create a Pull Request

## 📝 Coding Standards

### Unity/C# Guidelines
- Follow Unity's C# coding conventions
- Use PascalCase for public methods and properties
- Use camelCase for private fields and local variables
- Add XML documentation for public APIs
- Keep MonoBehaviour classes focused and single-purpose

### Backend/JavaScript Guidelines
- Use ESLint configuration provided in the project
- Follow async/await patterns for asynchronous code
- Use meaningful variable and function names
- Add JSDoc comments for complex functions

### General Guidelines
- Write self-documenting code
- Keep functions small and focused
- Use consistent naming conventions
- Add comments for complex business logic only

## 🧪 Testing

### Unity Testing
- Write unit tests for game logic using Unity Test Framework
- Test UI interactions manually on different screen sizes
- Verify multiplayer functionality with multiple clients

### Backend Testing
- Write unit tests for API endpoints
- Test real-time functionality with multiple connections
- Verify database operations and data integrity

## 📋 Pull Request Process

1. **Before submitting:**
   - Ensure all tests pass
   - Update documentation if needed
   - Verify builds work for both WebGL and Android

2. **PR Requirements:**
   - Clear title and description
   - Reference related issues
   - Include screenshots/videos for UI changes
   - Add tests for new functionality

3. **Review Process:**
   - At least one maintainer review required
   - Address feedback promptly
   - Keep PR scope focused and manageable

## 🏗️ Project Structure

```
├── UnityProject/
│   ├── Assets/
│   │   ├── Scripts/          # Game logic and UI
│   │   ├── Scenes/           # Game scenes
│   │   ├── Prefabs/          # Reusable game objects
│   │   └── Materials/        # Visual materials
│   └── ProjectSettings/      # Unity project configuration
├── Server/
│   ├── src/
│   │   ├── routes/           # API endpoints
│   │   ├── models/           # Database models
│   │   ├── services/         # Business logic
│   │   └── utils/            # Helper functions
│   └── tests/                # Backend tests
└── Documentation/            # Project documentation
```

## 🎮 Game Design Principles

When contributing, keep these principles in mind:
- **Simplicity**: The game should be easy to learn and play
- **Accessibility**: Support different devices and screen sizes
- **Performance**: Maintain smooth gameplay on lower-end devices
- **Fun First**: Features should enhance the core entertainment value

## 🤝 Community Guidelines

- Be respectful and inclusive in all interactions
- Help newcomers get started with the project
- Share knowledge and learn from others
- Focus on constructive feedback and solutions

## 📞 Getting Help

- **Discord**: [Join our development Discord](#) (coming soon)
- **GitHub Discussions**: For general questions and ideas
- **Issues**: For specific bugs or feature requests
- **Email**: [maintainer@email.com](#) for sensitive matters

## 🏆 Recognition

Contributors will be recognized in:
- README.md contributors section
- In-game credits
- Release notes for significant contributions

Thank you for helping make Consequence Game awesome! 🎭