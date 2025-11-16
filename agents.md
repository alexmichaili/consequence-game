# Consequence Game - Project Source of Truth

## Project Overview
**Game:** Online multiplayer version of the classic "Consequences" party game
**Target:** Cross-platform (WebGL + Android) multiplayer text-based storytelling game
**Status:** Initial setup phase
**Repository:** Public on GitHub (open source)
**Google Play:** Developer account already purchased ($25 paid)

## Game Design
### Core Mechanics
- 3-8 players per game room
- Turn-based storytelling without seeing previous contributions
- Traditional structure: "Who" → "Met whom" → "Where" → "What happened" → "Consequence"
- Each player writes one section, passes to next player
- Final reveal shows complete story
- Time limits per turn to keep games moving

### Features Roadmap
**Phase 1 (MVP):**
- [ ] User registration/guest play
- [ ] Create/join game rooms with codes
- [ ] Basic 5-section game flow
- [ ] Real-time turn notifications
- [ ] Story reveal and sharing
- [ ] WebGL and Android builds

**Phase 2:**
- [ ] Friend system and private lobbies
- [ ] Custom game templates (different story structures)
- [ ] Game history and favorite stories
- [ ] Push notifications for turn reminders

**Phase 3:**
- [ ] Tournaments and leaderboards
- [ ] Story voting and rating system
- [ ] Social sharing features
- [ ] Monetization (premium templates, cosmetics)

## Technology Stack
**Game Client:** Unity 2022.3 LTS
**Networking:** Mirror Networking (free, reliable multiplayer)
**Backend:** Node.js + Express + Socket.io
**Database:** PostgreSQL (Railway free tier)
**Hosting:** Railway (backend) + Vercel (WebGL build)
**Version Control:** Git with Unity-optimized .gitignore
**CI/CD:** Unity Cloud Build (free for open source)

## Architecture Decisions
1. **Unity over web-only:** Better mobile UX, native app feel, single codebase for web+mobile
2. **Hybrid approach:** Unity client + Node.js backend for easier scaling and maintenance
3. **Open source:** Public GitHub repo for collaboration and community contributions
4. **Free-tier focused:** All services have adequate free tiers for development and early production

## Repository Structure
```
/
├── UnityProject/          # Unity game client
├── Server/               # Node.js backend server
├── Documentation/        # Game design, API docs, setup guides
├── Assets/              # Art, sounds, UI mockups
├── .github/             # GitHub workflows, issue templates
├── README.md            # Project overview and setup
├── LICENSE              # MIT license
├── .gitignore           # Unity + Node.js optimized
└── agents.md            # This file - project source of truth
```

## Development Progress
### Completed:
- [x] Project planning and technology selection
- [x] Repository structure design
- [x] Initial project setup
- [x] Complete project structure created
- [x] Node.js backend structure initialized
- [x] Documentation templates created
- [x] GitHub templates and workflows setup
- [x] Open source configuration (LICENSE, README, CONTRIBUTING)

### Current Task:
- [ ] Set up Unity project with proper settings
- [ ] Install and configure Mirror Networking
- [ ] Create basic Unity scenes and scripts
- [ ] Initialize backend server with basic endpoints

### Next Steps:
1. Initialize Unity project with Mirror Networking
2. Set up basic backend with Socket.io
3. Create game room system
4. Implement basic game flow
5. Add real-time multiplayer functionality

## Key Technical Notes
- Unity project will use Git LFS for large assets
- Environment variables for all secrets (never commit keys)
- Separate private repo for production configs and signing keys
- Mirror Networking handles client-server architecture
- PostgreSQL schema: Users, GameRooms, Stories, Templates

## Collaboration Guidelines
- MIT license for open source contributions
- Clear contribution guidelines and setup instructions
- Issue templates for bugs and feature requests
- Automated builds for pull requests
- Code review required for main branch

## Important Reminders
- Google Play developer account already purchased
- Focus on free-tier services to minimize costs
- Open source approach for community building
- Cross-platform from day 1 (WebGL + Android)
- Text-based game - keep UI simple and responsive

---
*Last updated: Initial setup*
*Next session: Continue with Unity project initialization*