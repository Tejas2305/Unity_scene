# Visual UI Mockup Guide

This document describes the exact visual appearance of each screen in the Challas Aath Unity UI.

## Color Palette Reference

```
Heritage Beige Background: #FDF5E6 (RGB: 253, 245, 230)
Deep Red (Primary): #7B1113 (RGB: 123, 17, 19)
Amber (Secondary): #FFC300 (RGB: 255, 195, 0)
Cream (Text on Red): #FFFBF0 (RGB: 255, 251, 240)
Green (Ready State): #228B22 (RGB: 34, 139, 34)
Gray (Waiting State): #C0C0C0 (RGB: 192, 192, 192)
Light Amber: #FFF5E1 (RGB: 255, 245, 225)
```

## Screen 1: Lobby

```
┌─────────────────────────────────────────────┐
│  VARASA                             ⚙       │  Header (Amber tint)
├─────────────────────────────────────────────┤
│                                             │
│                                             │
│             CHALLAS AATH                    │  Title (72pt, Deep Red, Bold)
│                                             │
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │    PLAY WITH FRIENDS                │   │  Button (Deep Red, Cream Text)
│  └─────────────────────────────────────┘   │
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │    PLAY WITH RANDOM PEOPLE          │   │  Button (Deep Red, Cream Text)
│  └─────────────────────────────────────┘   │
│                                             │
│         ─────  OR  ─────                    │  Divider (Amber)
│                                             │
│     Re-discover the ancient strategy game.  │  Subtitle (Gray, 28pt)
│                                             │
└─────────────────────────────────────────────┘
```

### Component Details:
- **Header**: Fixed top bar, light amber background, "VARASA" on left, gear icon on right
- **Game Title**: Centered, extra large font, deep red color, serif font
- **Buttons**: 
  - Full width (with 40px margin on sides)
  - Height: 120px
  - Deep red background (#7B1113)
  - Cream text (#FFFBF0)
  - Font size: 40-48pt
  - Rounded corners (24px radius)
  - 24px vertical spacing between buttons
- **Divider**: Horizontal line with "OR" text in center, amber color
- **Subtitle**: Small text, centered, gray color

---

## Screen 2A: Friends Menu (Initial State)

```
┌─────────────────────────────────────────────┐
│  VARASA                             ⚙       │  Header
├─────────────────────────────────────────────┤
│  ← Back                                     │  Back button
│                                             │
│          START A CHALLENGE                  │  Title (60pt, Deep Red)
│                                             │
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │   CREATE PRIVATE ROOM               │   │  Button (Amber bg, Red text)
│  └─────────────────────────────────────┘   │
│                                             │
│              ( OR )                         │  Circle badge
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │   JOIN PRIVATE ROOM                 │   │  Button (Deep Red bg)
│  └─────────────────────────────────────┘   │
│                                             │
│                                             │
│                                             │
└─────────────────────────────────────────────┘
```

## Screen 2B: Friends Menu (Join Room Shown)

```
┌─────────────────────────────────────────────┐
│  VARASA                             ⚙       │  Header
├─────────────────────────────────────────────┤
│  ← Back                                     │
│                                             │
│          START A CHALLENGE                  │
│                                             │
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │   CREATE PRIVATE ROOM               │   │  Button (Amber)
│  └─────────────────────────────────────┘   │
│                                             │
│              ( OR )                         │
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │   JOIN PRIVATE ROOM                 │   │  Button (Deep Red) - DISABLED
│  └─────────────────────────────────────┘   │
│                                             │
│  ╔═════════════════════════════════════╗   │
│  ║  Enter 6-Digit Room ID              ║   │  Panel (Light amber bg,
│  ║                                     ║   │   red border, rounded)
│  ║  ┌──────────────┐  ┌──────┐        ║   │
│  ║  │   ABC123     │  │  GO  │        ║   │  Input field + Button
│  ║  └──────────────┘  └──────┘        ║   │
│  ╚═════════════════════════════════════╝   │
└─────────────────────────────────────────────┘
```

### Component Details:
- **Back Button**: Top-left, left arrow icon + "Back" text, red color
- **Title**: "START A CHALLENGE", centered, 60pt, deep red
- **Create Room Button**: 
  - Amber background (#FFC300)
  - Deep red text
  - Same size as lobby buttons
- **OR Badge**: 
  - Text in circular border
  - Deep red border and text
  - Light background
- **Join Room Button**: 
  - Deep red background when active
  - Gray when disabled (after clicked)
- **Join Room Panel** (appears after clicking Join):
  - Light amber background
  - 2px deep red border
  - 24px rounded corners
  - 32px padding
  - Contains:
    - Label: "Enter 6-Digit Room ID" (18pt)
    - Input field: 
      - Monospace font, 60pt
      - Center aligned
      - 6 character limit
      - Uppercase only
      - White background
      - Red border
    - GO button:
      - 150x100px
      - Deep red background
      - Disabled (gray) until 6 characters entered

---

## Screen 3: Room Waiting

```
┌─────────────────────────────────────────────┐
│  VARASA                             ⚙       │  Header
├─────────────────────────────────────────────┤
│  ← Back                                     │
│                                             │
│            ROOM CREATED                     │  Title (60pt)
│                                             │
│   ╔═══════════════════════════════════╗    │
│   ║         Room ID                   ║    │  Room panel
│   ║                                   ║    │  (Light amber bg,
│   ║         A B C 1 2 3               ║    │   amber border,
│   ║                                   ║    │   rounded)
│   ╚═══════════════════════════════════╝    │
│                                             │
│                                             │
│          1/2 PLAYERS JOINED                 │  Players count (48pt)
│                                             │
│       ┌───────┐       ┌───────┐            │  Player avatars
│       │   👤  │       │   ?   │            │  (circles)
│       └───────┘       └───────┘            │
│       Player 1        Player 2             │
│       (Green)         (Gray)               │
│                                             │
│    Waiting for an opponent...              │  Status text (italic)
│                                             │
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │       START GAME                    │   │  Button (DISABLED)
│  └─────────────────────────────────────┘   │
│                                             │
└─────────────────────────────────────────────┘
```

### After Player 2 Joins (3 seconds):

```
┌─────────────────────────────────────────────┐
│  VARASA                             ⚙       │  Header
├─────────────────────────────────────────────┤
│  ← Back                                     │
│                                             │
│            ROOM CREATED                     │
│                                             │
│   ╔═══════════════════════════════════╗    │
│   ║         Room ID                   ║    │
│   ║                                   ║    │
│   ║         A B C 1 2 3               ║    │
│   ║                                   ║    │
│   ╚═══════════════════════════════════╝    │
│                                             │
│                                             │
│          2/2 PLAYERS JOINED                 │  (Amber "2")
│                                             │
│       ┌───────┐       ┌───────┐            │
│       │   👤  │       │   👤  │            │  Both green
│       └───────┘       └───────┘            │
│       Player 1        Player 2             │
│       (Green)         (Green)              │
│                                             │
│         Ready to start!                    │  Status (italic)
│                                             │
│                                             │
│  ┌─────────────────────────────────────┐   │
│  │       START GAME                    │   │  Button (ENABLED/Red)
│  └─────────────────────────────────────┘   │
│                                             │
└─────────────────────────────────────────────┘
```

### Component Details:
- **Title**: "ROOM CREATED" or "SEARCHING FOR MATCH" for quick match
- **Room Code Panel**:
  - Light amber background (#FFF5E1)
  - 4px amber border (#FFC300)
  - 48px rounded corners
  - 60px padding
  - Contains:
    - Label: "Room ID" (36pt, red)
    - Code: "ABC123" (120pt, bold, monospace, deep red, wide letter spacing)
- **Players Joined Text**: 
  - "X/2 PLAYERS JOINED"
  - 48pt, bold
  - Current count in amber color
- **Player Avatars**:
  - Circular containers, 128x128px
  - Player 1 (always ready):
    - Green background (#228B22)
    - White user icon
  - Player 2 (waiting):
    - Gray background (#C0C0C0)
    - Gray "?" icon
  - Player 2 (ready):
    - Green background
    - White user icon
  - Horizontal layout with spacing
- **Status Text**:
  - "Waiting for an opponent..." when 1 player
  - "Ready to start!" when 2 players
  - 32pt, italic, red/gray color
- **Start Game Button**:
  - Full width (with margins)
  - 140px height
  - 60pt font
  - Disabled (gray) when < 2 players
  - Enabled (deep red) when 2 players

---

## Typography

### Font Sizes:
- **Headers (VARASA)**: 36pt
- **Game Title (CHALLAS AATH)**: 72pt
- **Section Titles**: 60pt
- **Main Buttons**: 40-48pt
- **Player Count**: 48pt
- **Room Code**: 120pt
- **Room ID Label**: 36pt
- **Status Text**: 32pt
- **Subtitle**: 28pt
- **Small Labels**: 18pt

### Font Styles:
- **Headers/Titles**: Bold, Serif preferred (like Georgia or similar)
- **Buttons**: Bold, Sans-serif
- **Room Code**: Bold, Monospace
- **Body Text**: Regular, Sans-serif
- **Status**: Italic

---

## Spacing

- **Screen Margins**: 40px (left/right)
- **Button Spacing**: 24px vertical gap
- **Panel Padding**: 32-60px depending on importance
- **Section Spacing**: 40-60px between major sections
- **Avatar Spacing**: 40px horizontal gap

---

## Interaction States

### Buttons:
1. **Normal**: Full color, shadow
2. **Hover**: Slightly darker (10-15%)
3. **Pressed**: Move down 2px, remove bottom shadow
4. **Disabled**: Gray background, gray text, no interaction

### Input Field:
1. **Empty**: Placeholder text in gray
2. **Typing**: Black text, uppercase conversion
3. **Valid (6 chars)**: Enables GO button
4. **Invalid**: GO button stays disabled

---

## Animations (Optional enhancements)

- **Panel transitions**: Fade in/out (0.3s)
- **Button press**: Scale down to 0.95 (0.1s)
- **Room code reveal**: Scale up from 0.8 to 1.0 (0.4s ease-out)
- **Player 2 joining**: Avatar fade from gray to green (0.5s)
- **Status text**: Fade in (0.3s)

---

## Mobile Aspect Ratio

- **Design Resolution**: 1080 x 1920 (9:16 portrait)
- **Safe Area**: Account for notches/navigation bars
- **Touch Targets**: Minimum 100x100px for buttons
- **Scrolling**: Not needed if properly laid out

---

This guide should help you recreate the exact visual appearance in Unity!
