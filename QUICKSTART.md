# Quick Start - Challas Aath Unity Project

## What You Have

This is a complete Unity 6 project structure for the **Challas Aath** game lobby UI, matching the React app you provided.

## 📦 Project Contents

### ✅ Ready-to-use files:
- ✅ Unity scene file (`Assets/Scenes/ChallasAath.unity`)
- ✅ GameManager C# script (`Assets/Scripts/GameManager.cs`)
- ✅ 5 texture assets (icons for UI)
- ✅ Project settings for Unity 6000.1.14f1
- ✅ Complete documentation

### 📚 Documentation:
1. **README.md** - Full project overview and instructions
2. **SETUP_GUIDE.md** - Step-by-step Unity Editor setup (30 min)
3. **VISUAL_GUIDE.md** - Detailed visual mockups of each screen
4. **This file** - Quick start guide

## 🚀 How to Use This Project

### Option 1: Download as ZIP

Since this is a GitHub repository, you can:

1. **Click the green "Code" button** on GitHub
2. **Select "Download ZIP"**
3. **Extract** to your desired location
4. **Open in Unity Hub**:
   - Open Unity Hub
   - Click "Open" → Select the extracted folder
   - Unity will import the project

### Option 2: Clone the Repository

```bash
git clone https://github.com/Tejas2305/Unity_scene.git
cd Unity_scene
```

Then open in Unity Hub as above.

## ⚙️ Unity Setup (First Time)

### 1. Open Unity Hub
- Make sure you have **Unity 6000.1.14f1** installed
- If not, install it via Unity Hub → Installs → Add → Archive → Select version

### 2. Open the Project
- Unity Hub → Open → Select the `Unity_scene` folder
- Unity will import all assets (may take a few minutes first time)

### 3. Import TextMeshPro
When the project opens, Unity will prompt you to import TMP Essentials:
- Click **"Import TMP Essentials"**
- Wait for import to complete

If no prompt appears:
- Go to: **Window → TextMeshPro → Import TMP Essential Resources**

### 4. Open the Scene
- In Project window: Navigate to `Assets/Scenes/`
- Double-click **ChallasAath.unity**

## 🎨 Building the UI (Required Manual Setup)

**Important:** The UI components need to be created manually in Unity Editor because Unity's scene format is complex. The scene file provided is a starter.

**Follow the SETUP_GUIDE.md** for detailed step-by-step instructions (takes ~30 minutes).

### Quick Summary:
1. Create Canvas with proper scaling
2. Build 3 main panels:
   - LobbyPanel (active by default)
   - FriendsMenuPanel (disabled)
   - RoomWaitingPanel (disabled)
3. Add all buttons, text fields, and UI elements
4. Wire everything to the GameManager script
5. Test the flow

## 📁 Project Structure

```
Unity_scene/
├── Assets/
│   ├── Scenes/
│   │   └── ChallasAath.unity          # Main scene
│   ├── Scripts/
│   │   ├── GameManager.cs             # Core logic (COMPLETE)
│   │   └── GameManager.cs.meta
│   ├── Textures/
│   │   ├── back_arrow.png             # ← Back icon
│   │   ├── gear.png                   # ⚙ Settings icon
│   │   ├── user_avatar.png            # 👤 Player icon
│   │   ├── divider.png                # Horizontal line
│   │   └── question.png               # ? Waiting player
│   └── Prefabs/                       # (Create your own)
├── ProjectSettings/
│   ├── ProjectSettings.asset
│   └── ProjectVersion.txt
├── .gitignore                         # Unity gitignore
├── README.md                          # Full documentation
├── SETUP_GUIDE.md                     # Step-by-step UI setup
├── VISUAL_GUIDE.md                    # Visual mockups
└── QUICKSTART.md                      # This file
```

## 🎯 What Works Out of the Box

- ✅ **GameManager.cs script** - Complete state management
- ✅ **Room code generation** - Random 6-character codes
- ✅ **Player join simulation** - Auto-joins after 3 seconds
- ✅ **Input validation** - 6-character alphanumeric room codes
- ✅ **Button state management** - Enable/disable logic
- ✅ **Panel switching** - Lobby → Friends Menu → Room Waiting

## ⚠️ What Needs Manual Setup

The UI layout must be created manually in Unity Editor:
- Canvas and panels
- Buttons and text fields
- Layout and positioning
- Wiring to GameManager

**Why?** Unity's UI system is visual and editor-based. The YAML scene format is very complex and error-prone to generate programmatically. Following the SETUP_GUIDE.md ensures everything works correctly.

## 🎮 Testing

After setup:
1. Press **Play** in Unity Editor
2. You should see the **Lobby** screen
3. Click **"Play with Friends"** → Friends menu appears
4. Click **"Create Room"** → Room waiting screen with random code
5. Wait 3 seconds → Second player joins
6. Click **"Start Game"** → Console message appears

## 🐛 Troubleshooting

### "TextMeshPro not found"
- Import TMP Essentials: Window → TextMeshPro → Import TMP Essential Resources

### "NullReferenceException in GameManager"
- You haven't assigned UI references yet
- Follow SETUP_GUIDE.md to create and wire the UI

### "Scene is empty"
- You need to manually create the UI (see SETUP_GUIDE.md)
- The scene file is just the starting point

### "Wrong Unity version"
- This project requires Unity 6000.1.14f1
- Download via Unity Hub if needed

## 📞 Next Steps

1. **Read SETUP_GUIDE.md** - Follow step-by-step to build the UI
2. **Check VISUAL_GUIDE.md** - See exact mockups of each screen
3. **Customize** - Adjust colors, fonts, and styling to your preference
4. **Extend** - Add networking, animations, sound effects

## 🎨 Color Reference (Heritage Theme)

```
Background:     #FDF5E6 (Warm Beige)
Primary:        #7B1113 (Deep Red)
Secondary:      #FFC300 (Amber)
Text on Red:    #FFFBF0 (Cream)
Ready State:    #228B22 (Green)
Waiting State:  #C0C0C0 (Gray)
```

## 🌟 Features

- ✅ Heritage-themed UI matching your React app
- ✅ Play with friends (create/join rooms)
- ✅ Play with random people (quick match simulation)
- ✅ Room code system (6-character alphanumeric)
- ✅ Player waiting simulation
- ✅ Mobile-ready (portrait orientation)

## 📚 Additional Resources

- **Unity UI Documentation**: https://docs.unity3d.com/Manual/UISystem.html
- **TextMeshPro Guide**: https://docs.unity3d.com/Manual/com.unity.textmeshpro.html
- **Canvas Tutorial**: https://learn.unity.com/tutorial/ui-canvas

## ⏱️ Time Estimate

- **Download & Open**: 5 minutes
- **UI Setup** (following guide): 30-40 minutes
- **Customization**: As needed
- **Total**: ~45 minutes to fully functional UI

---

**Ready to build?** Open **SETUP_GUIDE.md** and start creating the UI! 🚀
