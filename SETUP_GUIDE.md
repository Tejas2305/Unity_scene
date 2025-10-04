# Unity UI Setup - Quick Step-by-Step Guide

This guide will help you quickly set up the Challas Aath UI in Unity Editor.

## Before You Start

1. Open Unity 6000.1.14f1
2. Import this project folder
3. Import TextMeshPro Essentials (Window → TextMeshPro → Import TMP Essential Resources)

## Quick Setup (30 minutes)

### Part 1: Canvas Setup (5 min)

1. **Create Canvas**:
   ```
   Hierarchy → Right-click → UI → Canvas
   ```
   - Canvas Scaler → UI Scale Mode: Scale With Screen Size
   - Reference Resolution: 1080 x 1920
   - Match: 0.5

2. **Set Camera Background**:
   - Select Main Camera
   - Background: RGB(253, 245, 230) - warm beige

3. **Add EventSystem** (if not auto-created):
   ```
   Hierarchy → Right-click → UI → Event System
   ```

### Part 2: Lobby Panel (10 min)

1. **Create Panel**:
   ```
   Canvas → Right-click → UI → Panel
   ```
   Name it: `LobbyPanel`
   - Background: Transparent or light beige
   - Anchor: Stretch (full screen)

2. **Add Title**:
   ```
   LobbyPanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `GameTitle`
   - Text: "CHALLS AATH"
   - Font Size: 72
   - Color: RGB(123, 17, 19) - deep red
   - Alignment: Center
   - Position: Top area

3. **Add Button 1**:
   ```
   LobbyPanel → Right-click → UI → Button - TextMeshPro
   ```
   Name: `PlayFriendsButton`
   - Text: "PLAY WITH FRIENDS"
   - Font Size: 40
   - Button Color: RGB(123, 17, 19)
   - Text Color: RGB(255, 251, 240)
   - Width: 900, Height: 120
   - Position: Center-top

4. **Add Button 2**:
   ```
   Duplicate PlayFriendsButton (Ctrl+D)
   ```
   Name: `PlayRandomButton`
   - Text: "PLAY WITH RANDOM PEOPLE"
   - Position: Below first button (100px gap)

5. **Add Divider** (Optional):
   ```
   LobbyPanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `DividerOR`
   - Text: "OR"
   - Color: Amber RGB(255, 195, 0)
   - Position: Between buttons

6. **Add Subtitle**:
   ```
   LobbyPanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `Subtitle`
   - Text: "Re-discover the ancient strategy game."
   - Font Size: 28
   - Color: Gray
   - Position: Bottom

### Part 3: Friends Menu Panel (10 min)

1. **Create Panel**:
   ```
   Canvas → Right-click → UI → Panel
   ```
   Name: `FriendsMenuPanel`
   - **IMPORTANT**: Disable this panel (uncheck in Inspector)
   - Anchor: Stretch

2. **Add Back Button**:
   ```
   FriendsMenuPanel → Right-click → UI → Button - TextMeshPro
   ```
   Name: `BackFromFriendsButton`
   - Text: "← Back"
   - Font Size: 32
   - Position: Top-left
   - Width: 200, Height: 80

3. **Add Title**:
   ```
   FriendsMenuPanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `Title`
   - Text: "START A CHALLENGE"
   - Font Size: 60
   - Color: Deep red
   - Position: Top-center

4. **Add Create Room Button**:
   ```
   FriendsMenuPanel → Right-click → UI → Button - TextMeshPro
   ```
   Name: `CreateRoomButton`
   - Text: "CREATE PRIVATE ROOM"
   - Font Size: 40
   - Button Color: RGB(255, 195, 0) - amber
   - Text Color: Deep red
   - Width: 900, Height: 120

5. **Add Join Room Button**:
   ```
   Duplicate CreateRoomButton
   ```
   Name: `JoinRoomButton`
   - Text: "JOIN PRIVATE ROOM"
   - Button Color: Deep red
   - Text Color: Cream
   - Position: Below Create button

6. **Create Join Room Panel**:
   ```
   FriendsMenuPanel → Right-click → UI → Panel
   ```
   Name: `JoinRoomPanel`
   - **IMPORTANT**: Disable this panel
   - Background: Light amber
   - Width: 900, Height: 300
   - Position: Below Join button

7. **Add Input Field**:
   ```
   JoinRoomPanel → Right-click → UI → Input Field - TextMeshPro
   ```
   Name: `RoomIdInput`
   - Placeholder: "E.g., C8H7K2"
   - Font Size: 60
   - Character Limit: 6
   - Content Type: Alphanumeric
   - Line Type: Single Line
   - Text: Uppercase
   - Width: 600

8. **Add GO Button**:
   ```
   JoinRoomPanel → Right-click → UI → Button - TextMeshPro
   ```
   Name: `GoButton`
   - Text: "GO"
   - Font Size: 48
   - Width: 150, Height: 100
   - Position: Right of input field

### Part 4: Room Waiting Panel (10 min)

1. **Create Panel**:
   ```
   Canvas → Right-click → UI → Panel
   ```
   Name: `RoomWaitingPanel`
   - **IMPORTANT**: Disable this panel
   - Anchor: Stretch

2. **Add Back Button**:
   ```
   RoomWaitingPanel → Right-click → UI → Button - TextMeshPro
   ```
   Name: `BackFromRoomButton`
   - Text: "← Back"

3. **Add Title**:
   ```
   RoomWaitingPanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `Title`
   - Text: "ROOM CREATED"
   - Font Size: 60

4. **Create Room Code Panel**:
   ```
   RoomWaitingPanel → Right-click → UI → Panel
   ```
   Name: `RoomCodePanel`
   - Background: Light amber
   - Width: 700, Height: 400
   - Border: Add Image component with rounded sprite

5. **Add Room ID Label**:
   ```
   RoomCodePanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `RoomIDLabel`
   - Text: "Room ID"
   - Font Size: 36

6. **Add Room Code Display**:
   ```
   RoomCodePanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `RoomCodeText`
   - Text: "ABC123" (placeholder)
   - Font Size: 120
   - Font: Bold, Monospace
   - Color: Deep red

7. **Add Players Joined Text**:
   ```
   RoomWaitingPanel → Right-click → UI → Text - TextMeshPro
   ```
   Name: `PlayersJoinedText`
   - Text: "1/2 PLAYERS JOINED"
   - Font Size: 48

8. **Create Avatar Row**:
   ```
   RoomWaitingPanel → Right-click → UI → Horizontal Layout Group
   ```
   Name: `AvatarRow`

9. **Add Player 1 Avatar**:
   ```
   AvatarRow → Right-click → UI → Image
   ```
   Name: `Player1Avatar`
   - Width/Height: 128
   - Image: Circle sprite (or create rounded)
   - Color: Green RGB(34, 139, 34)
   
   Then add icon:
   ```
   Player1Avatar → Right-click → UI → Image
   ```
   Name: `Player1Icon`
   - Sprite: user_avatar.png (from Assets/Textures)
   - Keep aspect ratio
   - Size: 80x80

10. **Add Player 2 Avatar**:
    ```
    Duplicate Player1Avatar
    ```
    Name: `Player2Avatar`
    - Background Color: Gray RGB(192, 192, 192)
    
    Add question mark:
    ```
    Player2Avatar → Right-click → UI → Image
    ```
    Name: `Player2Question`
    - Sprite: question.png
    - Size: 80x80

11. **Add Status Text**:
    ```
    RoomWaitingPanel → Right-click → UI → Text - TextMeshPro
    ```
    Name: `StatusText`
    - Text: "Waiting for an opponent..."
    - Font Size: 32
    - Style: Italic

12. **Add Start Game Button**:
    ```
    RoomWaitingPanel → Right-click → UI → Button - TextMeshPro
    ```
    Name: `StartGameButton`
    - Text: "START GAME"
    - Font Size: 60
    - Width: 900, Height: 140
    - Position: Bottom
    - **IMPORTANT**: Disable interactable initially

### Part 5: Connect to GameManager (5 min)

1. **Select GameManager** object in Hierarchy

2. **Assign Panels**:
   - Drag `LobbyPanel` → Lobby Panel field
   - Drag `FriendsMenuPanel` → Friends Menu Panel field
   - Drag `RoomWaitingPanel` → Room Waiting Panel field
   - Drag `JoinRoomPanel` → Join Room Panel field

3. **Assign Lobby UI**:
   - Drag `PlayFriendsButton` → Play Friends Button field
   - Drag `PlayRandomButton` → Play Random Button field

4. **Assign Friends Menu UI**:
   - Drag `CreateRoomButton` → Create Room Button field
   - Drag `JoinRoomButton` → Join Room Button field
   - Drag `BackFromFriendsButton` → Back From Friends Button field

5. **Assign Join Room UI**:
   - Drag `RoomIdInput` → Room Id Input field
   - Drag `GoButton` → Go Button field

6. **Assign Room Waiting UI**:
   - Drag `RoomCodeText` → Room Code Text field
   - Drag `PlayersJoinedText` → Players Joined Text field
   - Drag `StatusText` → Status Text field
   - Drag `StartGameButton` → Start Game Button field
   - Drag `BackFromRoomButton` → Back From Room Button field
   - Drag `Player1Avatar` → Player 1 Avatar field
   - Drag `Player2Avatar` → Player 2 Avatar field
   - Drag `Player1Avatar` background → Player 1 Avatar Bg field
   - Drag `Player2Avatar` background → Player 2 Avatar Bg field
   - Drag `Player1Icon` → Player 1 Icon field
   - Drag `Player2Avatar/Player2Icon` (if created) → Player 2 Icon field
   - Drag `Player2Question` → Player 2 Question field

## Testing

1. **Press Play**
2. **Test Flow**:
   - ✓ Should see Lobby
   - ✓ Click "Play with Friends" → Friends Menu appears
   - ✓ Click "Create Room" → Room Waiting shows with code
   - ✓ Wait 3 seconds → Player 2 joins, button enables
   - ✓ Click Back → Returns to Lobby
   - ✓ Click "Play Random" → Quick match simulation

## Common Issues

### "NullReferenceException"
- Missing assignment in GameManager
- Check all fields are filled in Inspector

### "Panels not showing"
- Make sure only LobbyPanel is active at start
- Other panels should be disabled

### "Buttons not clickable"
- Add EventSystem if missing
- Check Canvas has GraphicRaycaster

### "Text looks wrong"
- Import TMP Essentials
- Assign TMP fonts in components

## Tips

- Use Alt+Shift to duplicate aligned objects
- Use Anchors for responsive design
- Test in different aspect ratios (Game view)
- Save scene frequently (Ctrl+S)

## Final Checklist

- [ ] Canvas created with proper scaler
- [ ] LobbyPanel active with 2 buttons
- [ ] FriendsMenuPanel disabled, has Create/Join buttons
- [ ] JoinRoomPanel disabled, has input field
- [ ] RoomWaitingPanel disabled, has room code display
- [ ] All references assigned in GameManager
- [ ] Scene saved
- [ ] Tested play flow

---

**Estimated Time**: 30-40 minutes
**Difficulty**: Intermediate Unity UI

After completing this setup, your scene will match the React app's functionality!
