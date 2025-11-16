# Development Setup Guide

This guide will help you set up the Consequence Game development environment on your local machine.

## Prerequisites

### Required Software
- **Unity Hub** and **Unity 2022.3 LTS** (latest patch)
- **Node.js 18+** and **npm**
- **Git** with **Git LFS** support
- **PostgreSQL 14+** (for local database)
- **Code Editor**: Visual Studio Code (recommended) or Visual Studio

### Optional Tools
- **Postman** or **Insomnia** (for API testing)
- **pgAdmin** (PostgreSQL GUI)
- **Redis** (for session caching, optional)

## Initial Setup

### 1. Clone the Repository
```bash
git clone https://github.com/yourusername/consequence-game.git
cd consequence-game
```

### 2. Backend Setup
```bash
cd Server
npm install
cp .env.example .env
```

Edit the `.env` file with your local configuration:
```env
PORT=3000
DATABASE_URL=postgresql://username:password@localhost:5432/consequence_game
JWT_SECRET=your-local-development-secret
```

### 3. Database Setup
Create a PostgreSQL database:
```sql
CREATE DATABASE consequence_game;
CREATE USER consequence_user WITH PASSWORD 'your_password';
GRANT ALL PRIVILEGES ON DATABASE consequence_game TO consequence_user;
```

### 4. Unity Project Setup
1. Open Unity Hub
2. Click "Add" and select the `UnityProject` folder
3. Open the project with Unity 2022.3 LTS
4. Wait for initial import and compilation

## Running the Application

### Start the Backend Server
```bash
cd Server
npm run dev
```
The server will start on `http://localhost:3000`

### Test the Unity Client
1. Open the Unity project
2. Open the `MainMenu` scene
3. Click Play in the Unity Editor
4. The client should connect to your local server

## Development Workflow

### Backend Development
- **Hot Reload**: Use `npm run dev` for automatic restarts
- **Testing**: Run `npm test` for unit tests
- **Linting**: Run `npm run lint` to check code style
- **API Testing**: Use Postman collection (coming soon)

### Unity Development
- **Play Mode**: Test in Unity Editor for rapid iteration
- **WebGL Build**: Build for web testing
- **Android Build**: Test on device or emulator

### Database Management
- **Migrations**: Database schema changes (coming soon)
- **Seeding**: Test data population scripts (coming soon)
- **Backup**: Regular backups for development data

## Common Issues and Solutions

### Unity Issues
**Problem**: Mirror Networking not found
**Solution**: Install Mirror from Package Manager or Asset Store

**Problem**: Build errors on WebGL
**Solution**: Check Player Settings for WebGL compatibility

### Backend Issues
**Problem**: Database connection failed
**Solution**: Verify PostgreSQL is running and credentials are correct

**Problem**: Port already in use
**Solution**: Change PORT in .env or kill existing process

### Network Issues
**Problem**: Unity can't connect to server
**Solution**: Check firewall settings and server URL in Unity

## Project Structure

```
consequence-game/
├── UnityProject/           # Unity game client
│   ├── Assets/
│   │   ├── Scripts/        # C# game logic
│   │   ├── Scenes/         # Unity scenes
│   │   └── Prefabs/        # Reusable objects
│   └── ProjectSettings/    # Unity configuration
├── Server/                 # Node.js backend
│   ├── src/
│   │   ├── routes/         # API endpoints
│   │   ├── models/         # Database models
│   │   ├── services/       # Business logic
│   │   └── utils/          # Helper functions
│   └── tests/              # Backend tests
└── Documentation/          # Project docs
```

## Environment Configuration

### Development Environment
- Local PostgreSQL database
- Unity Editor for client testing
- Hot reload for rapid development

### Testing Environment
- Separate test database
- Automated testing pipeline
- WebGL builds for browser testing

### Production Environment
- Railway/Render hosting
- Production database
- Optimized builds

## Next Steps

1. **Run the setup**: Follow this guide to get everything working
2. **Explore the code**: Check out existing scripts and documentation
3. **Make a test change**: Try modifying something small
4. **Read the contributing guide**: Understand our development process
5. **Join the community**: Connect with other contributors

## Getting Help

- **GitHub Issues**: For bugs and feature requests
- **GitHub Discussions**: For questions and ideas
- **Documentation**: Check other files in `/Documentation`
- **Code Comments**: Most complex code is documented inline

Happy coding! 🎮