# Challas Aath - Unity Scene Setup

This Unity project recreates the React-based UI flow for the Challas Aath game lobby in the Varasa heritage app.

## 📋 Project Structure

```
Assets/
├── Scenes/
│   └── ChallasAath.unity          # Main scene file
├── Scripts/
│   └── GameManager.cs             # Core game state management
├── Textures/
│   ├── back_arrow.png             # Back button icon
│   ├── gear.png                   # Settings icon
│   ├── user_avatar.png            # Player avatar icon
│   ├── divider.png                # Decorative divider line
│   └── question.png               # Waiting player indicator
└── Prefabs/                       # (To be created in Unity Editor)
```

## 🎮 Unity Version

This project is designed for **Unity 6000.1.14f1** (Unity 6 LTS).

## 🚀 Setup Instructions

### Step 1: Open the Project
1. Open Unity Hub
2. Click "Open" and select this folder (`Unity_scene`)
3. Unity will import all assets

### Step 2: Install TextMeshPro
1. When Unity opens, it may prompt you to import TMP Essentials
2. Click "Import TMP Essentials" in the prompt window
3. Or go to: Window → TextMeshPro → Import TMP Essential Resources

### Step 3: Create the UI in the Scene

The scene requires manual setup in the Unity Editor because the UI is complex. Follow these steps:

#### A. Open the Scene
1. In the Project window, navigate to `Assets/Scenes/`
2. Double-click `ChallasAath.unity`

#### B. Create the Canvas
1. Right-click in Hierarchy → UI → Canvas
2. Set Canvas properties:
   - Render Mode: Screen Space - Overlay
   - Canvas Scaler:
     - UI Scale Mode: Scale With Screen Size
     - Reference Resolution: 1080 x 1920 (portrait mobile)
     - Match: 0.5

#### C. Create the Game Manager Object
1. Find the "GameManager" object in the Hierarchy (should already exist)
2. If not, create one: Right-click Hierarchy → Create Empty → name it "GameManager"
3. Add the GameManager component:
   - Select GameManager object
   - In Inspector, click "Add Component"
   - Search for "GameManager" and add it

#### D. Create the UI Panels

Follow this structure exactly:

```
Canvas
├── Header (Panel)
│   ├── TitleText (TextMeshPro - Text): "VARASA"
│   └── GearButton (Button with gear.png)
│
├── LobbyPanel (Panel)
│   ├── GameTitle (TextMeshPro): "CHALLS AATH"
│   ├── PlayFriendsButton (Button): "PLAY WITH FRIENDS"
│   ├── PlayRandomButton (Button): "PLAY WITH RANDOM PEOPLE"
│   ├── Divider (Image + Text "OR")
│   └── Subtitle (TextMeshPro): "Re-discover the ancient strategy game."
│
├── FriendsMenuPanel (Panel - initially disabled)
│   ├── BackButton (Button with back_arrow.png)
│   ├── Title (TextMeshPro): "START A CHALLENGE"
│   ├── CreateRoomButton (Button): "CREATE PRIVATE ROOM"
│   ├── DividerOR (Text in circle)
│   ├── JoinRoomButton (Button): "JOIN PRIVATE ROOM"
│   └── JoinRoomPanel (Panel - initially disabled)
│       ├── Label (TextMeshPro): "Enter 6-Digit Room ID"
│       ├── RoomIdInput (TMP_InputField)
│       └── GoButton (Button): "GO"
│
└── RoomWaitingPanel (Panel - initially disabled)
    ├── BackButton (Button)
    ├── Title (TextMeshPro): "ROOM CREATED"
    ├── RoomCodePanel (Panel)
    │   ├── RoomIDLabel (TextMeshPro): "Room ID"
    │   └── RoomCodeText (TextMeshPro): Large display
    ├── PlayersJoinedText (TextMeshPro): "X/2 PLAYERS JOINED"
    ├── AvatarRow (Panel)
    │   ├── Player1Avatar (Image circle)
    │   │   ├── Player1Icon (user_avatar.png)
    │   │   └── Background (Image - green when ready)
    │   └── Player2Avatar (Image circle)
    │       ├── Player2Icon (user_avatar.png)
    │       ├── Player2Question (question.png)
    │       └── Background (Image - gray when waiting)
    ├── StatusText (TextMeshPro): Status message
    └── StartGameButton (Button): "START GAME"
```

## 🎨 Color Palette (Heritage Theme)

Use these colors for UI elements:

- **Background**: `#FDF5E6` (253, 245, 230) - Warm beige
- **Primary (Buttons)**: `#7B1113` (123, 17, 19) - Deep red
- **Secondary (Accents)**: `#FFC300` (255, 195, 0) - Amber
- **Text Primary**: `#7B1113` (Deep red)
- **Text Secondary**: `#FFFBF0` (255, 251, 240) - Cream

## 🔗 Wiring the GameManager

After creating all UI elements:

1. Select the GameManager object in Hierarchy
2. In Inspector, you'll see empty references in the GameManager component
3. Drag and drop the corresponding UI elements from the Hierarchy:
   - **Panels Section**: Drag LobbyPanel, FriendsMenuPanel, RoomWaitingPanel, JoinRoomPanel
   - **Lobby UI Section**: Drag playFriendsButton, playRandomButton
   - **Friends Menu UI Section**: Drag createRoomButton, joinRoomButton, backFromFriendsButton
   - **Join Room UI Section**: Drag roomIdInput, goButton
   - **Room Waiting UI Section**: Drag all room waiting components

## 📐 Detailed UI Layout Instructions

### LobbyPanel Styling
- **GameTitle**: 
  - Font Size: 72
  - Color: Deep Red (#7B1113)
  - Font: Bold, Serif style
  - Alignment: Center
  
- **Buttons** (PlayFriendsButton, PlayRandomButton):
  - Width: Full width (with 40px margins)
  - Height: 120px
  - Font Size: 48
  - Color: Deep Red background, Cream text
  - Border Radius: 24px (use Unity UI Rounded Corners or Image with rounded sprite)
  - Margin: 24px between buttons

### FriendsMenuPanel Styling
- **CreateRoomButton**: 
  - Background: Amber (#FFC300)
  - Text Color: Deep Red
  
- **JoinRoomButton**:
  - Background: Deep Red
  - Text Color: Cream

- **JoinRoomPanel**:
  - Background: Light amber/beige
  - Border: 2px Deep Red
  - Padding: 32px
  - Border Radius: 24px

- **RoomIdInput**:
  - Font: Monospace style
  - Font Size: 60
  - Max Length: 6
  - Uppercase only
  - Center aligned
  - Border: 2px Red

### RoomWaitingPanel Styling
- **RoomCodePanel**:
  - Background: Light amber (#FFF5E1)
  - Border: 4px Amber
  - Border Radius: 48px
  - Padding: 60px

- **RoomCodeText**:
  - Font Size: 120
  - Font: Monospace, Bold
  - Color: Deep Red
  - Letter Spacing: Wide

- **Player Avatars**:
  - Size: 128x128 circle
  - Ready state: Green background (#228B22)
  - Waiting state: Gray background (#C0C0C0)

## 🎯 Game Flow

1. **Scene 1 - Lobby**: 
   - User sees "PLAY WITH FRIENDS" and "PLAY WITH RANDOM PEOPLE"
   
2. **Scene 2A - Play with Friends**:
   - Options: "CREATE PRIVATE ROOM" or "JOIN PRIVATE ROOM"
   - If "Join": Shows input field for 6-character room code
   
3. **Scene 2B - Play Random**:
   - Simulates quick match (1.5s delay)
   - Generates random room code
   
4. **Scene 3 - Room Waiting**:
   - Displays room code
   - Shows player count (1/2)
   - Simulates 2nd player joining after 3 seconds
   - "START GAME" button enabled when both players joined

## 🔧 Troubleshooting

### TextMeshPro errors
- Make sure TMP Essentials are imported
- Window → TextMeshPro → Import TMP Essential Resources

### Missing references in GameManager
- Ensure all UI elements are created and named correctly
- Drag each element to its corresponding slot in GameManager Inspector

### Buttons not working
- Check that GameManager script is attached to GameManager object
- Verify all button references are assigned in Inspector
- Make sure panels are children of Canvas

### Scene looks different on different devices
- Adjust Canvas Scaler settings
- Use Anchors properly for responsive design
- Test on different aspect ratios in Game view

## 📱 Mobile Testing

To test mobile aspect ratio:
1. In Game view, change aspect ratio to 9:16 or 9:19.5
2. Or set Free Aspect and manually resize

## 🎮 Running the Scene

1. Press Play button in Unity Editor
2. You should see the Lobby panel
3. Test the flow:
   - Click "Play with Friends" → Should show Friends Menu
   - Click "Create Private Room" → Should show Room Waiting with random code
   - Click Back → Returns to Lobby
   - Click "Play with Random" → Simulates quick match
   - In Room Waiting → Wait 3 seconds → Second player joins → Start Game enabled

## 📝 Additional Notes

- The GameManager handles all state transitions
- Room codes are 6 random uppercase alphanumeric characters
- The UI is designed for mobile portrait orientation
- Colors and spacing match the heritage theme of the Varasa app
- All textures are included in the Assets/Textures folder

## 🎨 Customization

To customize the look:
1. Replace textures in `Assets/Textures/` with your own icons
2. Modify colors in the Unity Inspector for each UI element
3. Adjust fonts by importing custom fonts and assigning to TextMeshPro components
4. Modify button sizes and spacing in RectTransform properties

## 🚀 Next Steps

After completing the UI setup:
1. Implement networking for real multiplayer (e.g., Photon, Mirror, or Unity Netcode)
2. Connect to actual game scene when "START GAME" is clicked
3. Add sound effects and animations for better UX
4. Implement proper back-end for room management
5. Add more heritage-themed visual effects and transitions

---

**Need Help?** 
- Check Unity's TextMeshPro documentation
- Review Unity UI/Canvas system tutorials
- See the GameManager.cs script for logic reference
