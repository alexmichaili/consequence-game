# Consequence Game 🎭

An online multiplayer version of the classic "Consequences" party game. Write collaborative stories with friends without seeing what others have written until the hilarious reveal!

## 🎮 Game Overview

Consequence is a turn-based storytelling game where 3-8 players create stories together:
1. Each player writes part of a story (Who, Met whom, Where, What happened, Consequence)
2. Players can't see previous contributions
3. Stories are revealed at the end for maximum entertainment
4. Play with friends or match with other players online

## 🚀 Features

- **Cross-platform**: Play on web browsers or Android devices
- **Real-time multiplayer**: Instant turn notifications and live gameplay
- **Room system**: Create private rooms or join public matches
- **Custom templates**: Different story structures beyond the classic format
- **Story sharing**: Save and share your favorite collaborative stories

## 🛠️ Technology Stack

- **Client**: Unity 2022.3 LTS (WebGL + Android)
- **Networking**: Mirror Networking
- **Backend**: Node.js + Express + Socket.io
- **Database**: PostgreSQL
- **Hosting**: Railway (backend) + Vercel (web client)

## 📁 Project Structure

```
├── UnityProject/     # Unity game client
├── Server/          # Node.js backend
├── Documentation/   # Game design and API docs
├── Assets/         # Art and design assets
└── .github/        # CI/CD and issue templates
```

## 🏗️ Development Setup

### Prerequisites
- Unity 2022.3 LTS
- Node.js 18+
- Git with LFS support

### Quick Start
1. Clone the repository
2. Open `UnityProject/` in Unity Hub
3. Navigate to `Server/` and run `npm install`
4. Follow setup guides in `Documentation/`

## 🤝 Contributing

We welcome contributions! Please see our [Contributing Guidelines](Documentation/CONTRIBUTING.md) for details.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🎯 Roadmap

- [x] Project setup and architecture
- [ ] Basic multiplayer game rooms
- [ ] Core game mechanics
- [ ] WebGL and Android builds
- [ ] Advanced features and polish

---

**Status**: 🚧 In Development | **Version**: 0.1.0-alpha