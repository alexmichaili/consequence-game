# Consequence Game - Design Document

## 🎭 Game Overview

Consequence is a multiplayer party game where players collaboratively create stories without seeing each other's contributions until the final reveal. The game transforms the classic pen-and-paper party game into a digital, cross-platform experience.

## 🎯 Core Game Loop

### Basic Flow
1. **Lobby Phase**: Players join a game room (3-8 players)
2. **Setup Phase**: Choose story template and game settings
3. **Writing Phase**: Players take turns writing story sections
4. **Reveal Phase**: Complete story is revealed to all players
5. **Sharing Phase**: Players can rate, save, and share stories

### Turn Structure
Each player writes one section of the story:
1. **"Who"** - A character or person
2. **"Met whom"** - Another character they encounter
3. **"Where"** - The location where they meet
4. **"What happened"** - The main event or interaction
5. **"Consequence"** - The result or outcome

## 🎮 Game Mechanics

### Room System
- **Public Rooms**: Quick match with random players
- **Private Rooms**: Invite friends with room codes
- **Room Settings**: 
  - Player count (3-8)
  - Turn timer (30s - 5min)
  - Story template selection
  - Language/content filters

### Turn Management
- **Turn Timer**: Configurable time limit per turn
- **Auto-skip**: Players who don't respond in time get skipped
- **Reconnection**: Players can rejoin if disconnected
- **Spectator Mode**: Late joiners can watch ongoing games

### Story Templates
**Classic Template** (5 sections):
- Who → Met whom → Where → What happened → Consequence

**Extended Templates**:
- **Adventure**: Who → Where → Found what → What happened → How it ended
- **Romance**: Who → Met whom → Where → What they said → What happened next
- **Mystery**: Who → Discovered what → Where → Why → How it was resolved

### Scoring & Progression
- **Story Rating**: Players vote on completed stories (1-5 stars)
- **Player Stats**: Games played, stories created, average rating
- **Achievements**: Unlock titles and cosmetics
- **Leaderboards**: Top storytellers, most creative, funniest stories

## 🎨 User Interface Design

### Mobile-First Approach
- **Portrait Orientation**: Optimized for phone use
- **Large Touch Targets**: Easy finger navigation
- **Readable Fonts**: Clear text at all sizes
- **Minimal UI**: Focus on the writing experience

### Key Screens
1. **Main Menu**: Play, Profile, Settings, About
2. **Lobby Browser**: Join public rooms or create private
3. **Game Room**: Player list, chat, game status
4. **Writing Interface**: Text input with character counter
5. **Story Reveal**: Animated reveal of complete story
6. **Story Gallery**: Browse and share completed stories

### Visual Style
- **Colorful & Playful**: Bright, welcoming color palette
- **Hand-drawn Elements**: Sketchy, organic feel
- **Smooth Animations**: Polished transitions and feedback
- **Accessibility**: High contrast, colorblind-friendly

## 🌐 Multiplayer Architecture

### Client-Server Model
- **Unity Client**: Handles UI, input, and presentation
- **Node.js Server**: Manages game state and real-time communication
- **Database**: Persistent storage for users, games, and stories

### Real-time Features
- **Live Turn Updates**: Instant notification when it's your turn
- **Player Status**: See who's online, writing, or disconnected
- **Chat System**: Text chat in game rooms
- **Typing Indicators**: Show when players are actively writing

### Network Optimization
- **Minimal Data**: Only send necessary game state updates
- **Compression**: Compress text data for mobile networks
- **Offline Handling**: Graceful degradation when connection is lost
- **Regional Servers**: Reduce latency with geographic distribution

## 🎪 Social Features

### Friend System
- **Friend Lists**: Add and manage friends
- **Private Invites**: Invite friends to private rooms
- **Status Sharing**: See when friends are online and playing

### Story Sharing
- **Export Options**: Share stories as images or text
- **Social Media**: Direct sharing to Twitter, Facebook, etc.
- **Story Gallery**: Public gallery of top-rated stories
- **Collections**: Save favorite stories to personal collections

### Community Features
- **Daily Challenges**: Special themed story prompts
- **Tournaments**: Competitive storytelling events
- **User-Generated Content**: Players can create custom templates
- **Moderation**: Report inappropriate content and behavior

## 📱 Platform Considerations

### Cross-Platform Play
- **WebGL**: Browser-based play on any device
- **Android**: Native app with full feature set
- **Future iOS**: Planned after initial success

### Platform-Specific Features
**Mobile (Android)**:
- Push notifications for turn reminders
- Haptic feedback for interactions
- Voice-to-text input support
- Offline story reading

**Web (WebGL)**:
- No installation required
- Keyboard shortcuts for power users
- URL sharing for easy room joining
- Progressive Web App features

## 🚀 Monetization Strategy

### Free-to-Play Model
- **Core Game**: Completely free with all basic features
- **Premium Content**: Optional cosmetic upgrades and templates

### Premium Features (Future)
- **Custom Avatars**: Unique character representations
- **Premium Templates**: Special themed story formats
- **Ad-Free Experience**: Remove banner ads
- **Extended History**: Save unlimited stories
- **Priority Matching**: Faster room joining

### Ethical Considerations
- **No Pay-to-Win**: All gameplay features remain free
- **Fair Advertising**: Non-intrusive banner ads only
- **Privacy First**: Minimal data collection, transparent policies
- **Child Safety**: Age-appropriate content and moderation

## 📊 Success Metrics

### Engagement Metrics
- **Daily Active Users (DAU)**
- **Session Length**: Average time per game session
- **Retention Rate**: 1-day, 7-day, 30-day retention
- **Stories Created**: Total collaborative stories generated

### Quality Metrics
- **Story Completion Rate**: Percentage of games finished
- **Player Satisfaction**: Average story ratings
- **Technical Performance**: Load times, crash rates
- **Community Health**: Report rates, moderation actions

### Growth Metrics
- **User Acquisition**: New player registration rate
- **Viral Coefficient**: Organic sharing and referrals
- **Platform Distribution**: Web vs. mobile usage
- **Geographic Reach**: International player adoption

---

*This design document is a living document that will evolve as the game develops and receives player feedback.*