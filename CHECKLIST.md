# Unity UI Setup Checklist

Use this checklist to track your progress while setting up the Challas Aath UI in Unity.

## ✅ Pre-Setup

- [ ] Unity 6000.1.14f1 installed
- [ ] Project opened in Unity Hub
- [ ] TextMeshPro Essentials imported
- [ ] ChallasAath.unity scene open

## 🎨 Canvas & Main Setup

- [ ] Canvas created (Screen Space - Overlay)
- [ ] Canvas Scaler configured (1080x1920, Scale With Screen Size)
- [ ] EventSystem present in scene
- [ ] Main Camera background color set to beige (#FDF5E6)

## 🏠 Lobby Panel

- [ ] LobbyPanel created and active
- [ ] GameTitle text created ("CHALLAS AATH", 72pt, deep red)
- [ ] PlayFriendsButton created ("PLAY WITH FRIENDS")
- [ ] PlayRandomButton created ("PLAY WITH RANDOM PEOPLE")
- [ ] Divider/OR text created (optional)
- [ ] Subtitle text created ("Re-discover the ancient...")

### Lobby Panel Styling
- [ ] Buttons are deep red (#7B1113) with cream text (#FFFBF0)
- [ ] Button size: ~900x120px
- [ ] Buttons have rounded corners
- [ ] Proper spacing between elements

## 👥 Friends Menu Panel

- [ ] FriendsMenuPanel created and DISABLED
- [ ] BackFromFriendsButton created ("← Back")
- [ ] Title text created ("START A CHALLENGE", 60pt)
- [ ] CreateRoomButton created ("CREATE PRIVATE ROOM")
- [ ] OR divider/badge created
- [ ] JoinRoomButton created ("JOIN PRIVATE ROOM")

### Friends Menu Styling
- [ ] CreateRoomButton is amber (#FFC300) with red text
- [ ] JoinRoomButton is deep red with cream text
- [ ] Back button positioned top-left

### Join Room Sub-Panel
- [ ] JoinRoomPanel created (child of FriendsMenuPanel) and DISABLED
- [ ] Label text created ("Enter 6-Digit Room ID")
- [ ] RoomIdInput field created (TMP_InputField)
- [ ] Input field limited to 6 characters
- [ ] Input field set to uppercase, alphanumeric only
- [ ] GoButton created ("GO")
- [ ] Panel has light amber background with red border

## 🎮 Room Waiting Panel

- [ ] RoomWaitingPanel created and DISABLED
- [ ] BackFromRoomButton created ("← Back")
- [ ] Title text created ("ROOM CREATED")
- [ ] RoomCodePanel created (nested panel)
- [ ] RoomIDLabel text created ("Room ID")
- [ ] RoomCodeText created (large, 120pt, monospace)
- [ ] PlayersJoinedText created ("X/2 PLAYERS JOINED")
- [ ] StatusText created (for status messages)

### Player Avatars
- [ ] AvatarRow container created (Horizontal Layout Group)
- [ ] Player1Avatar created (Image, circle)
- [ ] Player1Icon created (user_avatar.png)
- [ ] Player1AvatarBg image component configured
- [ ] Player2Avatar created (Image, circle)
- [ ] Player2Icon created (user_avatar.png)
- [ ] Player2Question created (question.png)
- [ ] Player2AvatarBg image component configured

### Room Waiting Styling
- [ ] RoomCodePanel has light amber bg (#FFF5E1) and amber border
- [ ] RoomCodePanel has rounded corners
- [ ] RoomCodeText is bold, monospace, deep red
- [ ] Player1Avatar background starts green (#228B22)
- [ ] Player2Avatar background starts gray (#C0C0C0)
- [ ] StartGameButton created ("START GAME")
- [ ] StartGameButton initially disabled (interactable = false)

## 🎛️ GameManager Wiring

### Find GameManager Object
- [ ] GameManager object exists in Hierarchy
- [ ] GameManager.cs script attached to GameManager object

### Assign Panels
- [ ] LobbyPanel → Lobby Panel field
- [ ] FriendsMenuPanel → Friends Menu Panel field
- [ ] RoomWaitingPanel → Room Waiting Panel field
- [ ] JoinRoomPanel → Join Room Panel field

### Assign Lobby UI
- [ ] PlayFriendsButton → Play Friends Button field
- [ ] PlayRandomButton → Play Random Button field

### Assign Friends Menu UI
- [ ] CreateRoomButton → Create Room Button field
- [ ] JoinRoomButton → Join Room Button field
- [ ] BackFromFriendsButton → Back From Friends Button field

### Assign Join Room UI
- [ ] RoomIdInput → Room Id Input field
- [ ] GoButton → Go Button field

### Assign Room Waiting UI
- [ ] RoomCodeText → Room Code Text field
- [ ] PlayersJoinedText → Players Joined Text field
- [ ] StatusText → Status Text field
- [ ] StartGameButton → Start Game Button field
- [ ] BackFromRoomButton → Back From Room Button field
- [ ] Player1Avatar → Player 1 Avatar field
- [ ] Player2Avatar → Player 2 Avatar field
- [ ] Player1Avatar Image component → Player 1 Avatar Bg field
- [ ] Player2Avatar Image component → Player 2 Avatar Bg field
- [ ] Player1Icon → Player 1 Icon field
- [ ] Player2Icon (if created) → Player 2 Icon field
- [ ] Player2Question → Player 2 Question field

## 🧪 Testing

### Initial State
- [ ] Play mode starts with LobbyPanel visible
- [ ] FriendsMenuPanel is hidden
- [ ] RoomWaitingPanel is hidden
- [ ] JoinRoomPanel is hidden

### Lobby Flow
- [ ] Clicking "Play with Friends" shows Friends Menu
- [ ] Clicking "Play with Random" shows Room Waiting (after delay)

### Friends Menu Flow
- [ ] Back button returns to Lobby
- [ ] Clicking "Create Room" shows Room Waiting with random code
- [ ] Clicking "Join Room" shows JoinRoomPanel
- [ ] JoinRoomPanel disables JoinRoomButton
- [ ] Input field only accepts uppercase alphanumeric
- [ ] Input field limited to 6 characters
- [ ] GO button disabled until 6 characters entered
- [ ] GO button shows Room Waiting when clicked

### Room Waiting Flow
- [ ] Room code displays correctly (6 uppercase alphanumeric)
- [ ] Initially shows "1/2 PLAYERS JOINED"
- [ ] Player1 avatar shows green with user icon
- [ ] Player2 avatar shows gray with question mark
- [ ] Status shows "Waiting for an opponent..."
- [ ] Start Game button is disabled
- [ ] After 3 seconds: Player2 joins
- [ ] Player count updates to "2/2 PLAYERS JOINED"
- [ ] Player2 avatar turns green with user icon
- [ ] Status updates to "Ready to start!"
- [ ] Start Game button becomes enabled
- [ ] Clicking Start Game logs message to console
- [ ] Back button returns to Lobby

### Quick Match Flow
- [ ] Clicking "Play with Random" triggers quick match
- [ ] Shows "SEARCHING FOR MATCH" or similar
- [ ] After ~1.5 seconds, generates room code
- [ ] Continues as normal Room Waiting flow

## 🎨 Polish (Optional)

- [ ] Adjust colors to exact heritage theme
- [ ] Add custom fonts (serif for headers)
- [ ] Add button hover effects
- [ ] Add button press animations
- [ ] Add panel transition animations
- [ ] Add sound effects
- [ ] Test on different screen aspect ratios
- [ ] Optimize for mobile (touch targets)

## 📱 Mobile Testing

- [ ] Tested in Game view with 9:16 aspect ratio
- [ ] Tested in Game view with 9:19.5 aspect ratio (notch devices)
- [ ] Touch targets are large enough (min 100x100px)
- [ ] Text is readable at mobile size
- [ ] No elements cut off by safe area

## 🚀 Final Steps

- [ ] Scene saved (Ctrl+S)
- [ ] No console errors
- [ ] All references assigned (no null reference errors)
- [ ] Project builds successfully (optional)
- [ ] Committed to version control

## 📊 Progress Tracking

**Estimated Time:**
- Canvas & Setup: 5 min
- Lobby Panel: 10 min
- Friends Menu Panel: 10 min
- Room Waiting Panel: 10 min
- GameManager Wiring: 5 min
- Testing: 5 min
- **Total: ~45 minutes**

**Completion:**
- [ ] 0-25% (Setup & Lobby)
- [ ] 25-50% (Friends Menu)
- [ ] 50-75% (Room Waiting)
- [ ] 75-90% (Wiring)
- [ ] 90-100% (Testing & Polish)

---

## 💡 Tips

- Save frequently (Ctrl+S)
- Use duplicate (Ctrl+D) for similar elements
- Use Alt+Shift to duplicate with alignment
- Use Anchors for responsive design
- Test in Play mode often
- Refer to VISUAL_GUIDE.md for exact layouts
- Check SETUP_GUIDE.md if stuck

## ❌ Common Issues

If you encounter issues, check:
- [ ] All panels are children of Canvas
- [ ] Only LobbyPanel is active at start (others disabled)
- [ ] All GameManager references are assigned
- [ ] TextMeshPro is imported
- [ ] Canvas has GraphicRaycaster component
- [ ] EventSystem exists in scene

---

**Good luck with your setup! 🎮**

Once complete, you'll have a fully functional Unity UI matching your React app's Challas Aath lobby!
