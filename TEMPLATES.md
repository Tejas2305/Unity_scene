# Unity Component Templates

This file contains component templates you can reference when creating UI elements in Unity Editor.

## Standard Button Template

**Component: Button (TextMeshPro)**

```
Button Component Settings:
├─ Interactable: ✓ (checked)
├─ Transition: Color Tint
├─ Target Graphic: Image (Background)
├─ Normal Color: RGB(123, 17, 19) - Deep Red
├─ Highlighted Color: RGB(100, 14, 16) - Darker Red
├─ Pressed Color: RGB(90, 12, 14) - Even Darker
├─ Selected Color: RGB(123, 17, 19)
├─ Disabled Color: RGB(150, 150, 150) - Gray
└─ Color Multiplier: 1

Image Component (Background):
├─ Source Image: UI Sprite (Default or Rounded)
├─ Color: RGB(123, 17, 19) - Matches Normal Color
├─ Material: None (Default)
├─ Raycast Target: ✓ (checked)
└─ Preserve Aspect: ☐ (unchecked)

TextMeshPro - Text (UI) Component:
├─ Text: "BUTTON TEXT"
├─ Font Asset: Default or Custom
├─ Font Style: Bold
├─ Font Size: 40-48
├─ Color: RGB(255, 251, 240) - Cream
├─ Alignment: Center (both horizontal and vertical)
├─ Wrapping: Disabled
└─ Overflow: Overflow

RectTransform:
├─ Width: 900
├─ Height: 120
├─ Anchor: Middle Center (or as needed)
└─ Pivot: 0.5, 0.5
```

---

## Amber Button Template (Create Room)

```
Button Component Settings:
├─ Same as Standard Button

Image Component (Background):
├─ Color: RGB(255, 195, 0) - Amber

TextMeshPro - Text (UI):
├─ Text: "CREATE PRIVATE ROOM"
├─ Font Style: Bold
├─ Font Size: 40
├─ Color: RGB(123, 17, 19) - Deep Red (not cream!)
└─ Alignment: Center
```

---

## Title Text Template

**Component: TextMeshPro - Text (UI)**

```
TextMeshPro Component:
├─ Text: "CHALLAS AATH"
├─ Font Asset: Default (or Serif font if available)
├─ Font Style: Bold
├─ Font Size: 72
├─ Color: RGB(123, 17, 19) - Deep Red
├─ Alignment: Center (both)
├─ Wrapping: Disabled
├─ Overflow: Overflow
├─ Auto Size: ☐ (unchecked)
└─ Extra Settings:
    ├─ Character Spacing: 0.05 (optional, for wider spacing)
    └─ Word Spacing: 0

RectTransform:
├─ Width: 900
├─ Height: 150
├─ Anchor: Top Center
└─ Position: Adjust as needed
```

---

## Input Field Template (Room Code)

**Component: TMP_InputField**

```
TMP_InputField Component:
├─ Interactable: ✓
├─ Text Component: Child TextMeshPro component
├─ Placeholder: Child TextMeshPro component
├─ Character Limit: 6
├─ Content Type: Alphanumeric
├─ Line Type: Single Line
├─ Input Validator: (None, use OnValueChanged instead)
└─ On Value Changed:
    └─ GameManager.OnRoomIdChanged (assigned in code)

TextMeshPro (Text):
├─ Text: "" (empty initially)
├─ Font Size: 60
├─ Font Style: Bold
├─ Font: Monospace (if available, e.g., "Courier New")
├─ Color: RGB(0, 0, 0) - Black
├─ Alignment: Center
└─ Character Spacing: 0.1

TextMeshPro (Placeholder):
├─ Text: "E.g., C8H7K2"
├─ Font Size: 60
├─ Color: RGB(150, 150, 150) - Gray
└─ Alignment: Center

Image Component (Background):
├─ Color: RGB(255, 255, 255) - White
├─ Source Image: InputFieldBackground (Unity default)
└─ Type: Sliced (for borders)

RectTransform:
├─ Width: 600
├─ Height: 100
└─ Anchor: Middle Left (in panel)
```

---

## Panel Template (Room Code Display)

**Component: Image (Panel)**

```
Image Component:
├─ Color: RGB(255, 245, 225) - Light Amber
├─ Source Image: Panel-Round (if available) or create custom
├─ Material: None
└─ Raycast Target: ✓

RectTransform:
├─ Width: 700
├─ Height: 400
├─ Anchor: Middle Center
└─ Pivot: 0.5, 0.5

Optional - Add Outline:
Component: Outline (UI)
├─ Effect Color: RGB(255, 195, 0) - Amber
├─ Effect Distance: X=4, Y=4
└─ Use Graphic Alpha: ✓
```

---

## Room Code Display Text

**Component: TextMeshPro - Text (UI)**

```
TextMeshPro Component:
├─ Text: "ABC123" (placeholder)
├─ Font Asset: Monospace or Bold
├─ Font Style: Bold
├─ Font Size: 120
├─ Color: RGB(123, 17, 19) - Deep Red
├─ Alignment: Center (both)
├─ Character Spacing: 0.15 (wide spacing for readability)
├─ Wrapping: Disabled
└─ Overflow: Overflow

RectTransform:
├─ Width: 600
├─ Height: 200
└─ Anchor: Middle Center (in RoomCodePanel)
```

---

## Player Avatar Template (Circle)

**Component: Image (Avatar Background)**

```
Image Component:
├─ Color: RGB(192, 192, 192) - Gray (waiting) OR RGB(34, 139, 34) - Green (ready)
├─ Source Image: Circle sprite (create or use default circle)
├─ Material: None
├─ Raycast Target: ☐
└─ Preserve Aspect: ✓

RectTransform:
├─ Width: 128
├─ Height: 128
├─ Anchor: Middle Center
└─ Pivot: 0.5, 0.5

Child - Player Icon (Image):
├─ Source Image: user_avatar.png (from Assets/Textures)
├─ Color: RGB(255, 255, 255) - White
├─ Width: 80
├─ Height: 80
├─ Anchor: Middle Center
└─ Preserve Aspect: ✓

Child - Question Mark (Image) - for Player2 waiting state:
├─ Source Image: question.png
├─ Color: RGB(128, 128, 128) - Gray
├─ Width: 80
├─ Height: 80
├─ Anchor: Middle Center
└─ Active: ✓ (initially for Player2, ☐ for Player1)
```

---

## Back Button Template

**Component: Button (TextMeshPro)**

```
Button Component:
├─ Same as Standard Button
├─ Normal Color: Transparent or very light

TextMeshPro Component:
├─ Text: "← Back"
├─ Font Size: 32
├─ Font Style: Semi-Bold
├─ Color: RGB(123, 17, 19) - Deep Red
├─ Alignment: Left, Middle
└─ Enable Auto Size: ☐

Image Component (Background):
├─ Color: Transparent RGB(0, 0, 0, 0)
└─ Source Image: None

RectTransform:
├─ Width: 200
├─ Height: 80
├─ Anchor: Top Left
├─ Anchor Min: 0, 1
├─ Anchor Max: 0, 1
├─ Pivot: 0, 1
└─ Position: X=40, Y=-40 (offset from top-left corner)
```

---

## Layout Group Templates

### Vertical Layout Group (for button stacks)

```
Vertical Layout Group Component:
├─ Padding: Left=40, Right=40, Top=20, Bottom=20
├─ Spacing: 24
├─ Child Alignment: Upper Center
├─ Child Controls Size: 
│   ├─ Width: ☐
│   └─ Height: ☐
└─ Child Force Expand:
    ├─ Width: ☐
    └─ Height: ☐
```

### Horizontal Layout Group (for avatar row)

```
Horizontal Layout Group Component:
├─ Padding: All = 0
├─ Spacing: 40
├─ Child Alignment: Middle Center
├─ Child Controls Size:
│   ├─ Width: ☐
│   └─ Height: ☐
└─ Child Force Expand:
    ├─ Width: ☐
    └─ Height: ☐

RectTransform (of the container):
├─ Width: 300
├─ Height: 128
└─ Anchor: Middle Center
```

---

## Canvas Scaler Settings

```
Canvas Scaler Component:
├─ UI Scale Mode: Scale With Screen Size
├─ Reference Resolution: 
│   ├─ X: 1080
│   └─ Y: 1920
├─ Screen Match Mode: Match Width Or Height
├─ Match: 0.5 (middle slider position)
└─ Reference Pixels Per Unit: 100
```

---

## Anchor Presets Quick Reference

```
Common Anchors:
├─ Top Left: Min(0,1), Max(0,1), Pivot(0,1)
├─ Top Center: Min(0.5,1), Max(0.5,1), Pivot(0.5,1)
├─ Middle Center: Min(0.5,0.5), Max(0.5,0.5), Pivot(0.5,0.5)
├─ Stretch (Full): Min(0,0), Max(1,1), Pivot(0.5,0.5)
└─ Bottom Center: Min(0.5,0), Max(0.5,0), Pivot(0.5,0)
```

---

## Tips for Using Templates

1. **Copy Settings**: In Unity, you can right-click component → Copy Component, then paste to another object
2. **Save as Prefab**: Once you create a perfect button, make it a prefab for reuse
3. **Use Presets**: Unity allows saving Component Presets for quick application
4. **Duplicate**: Use Ctrl+D to duplicate existing objects and modify them

---

## Color Variables (for easy reference)

```csharp
// Add this to a UIColors.cs script if you want code-based colors
public static class UIColors
{
    public static Color HeritageBeige = new Color(0.992f, 0.961f, 0.902f); // #FDF5E6
    public static Color DeepRed = new Color(0.482f, 0.067f, 0.075f);       // #7B1113
    public static Color Amber = new Color(1f, 0.765f, 0f);                 // #FFC300
    public static Color Cream = new Color(1f, 0.984f, 0.941f);             // #FFFBF0
    public static Color ReadyGreen = new Color(0.133f, 0.545f, 0.133f);    // #228B22
    public static Color WaitingGray = new Color(0.753f, 0.753f, 0.753f);   // #C0C0C0
    public static Color LightAmber = new Color(1f, 0.961f, 0.882f);        // #FFF5E1
}
```

---

These templates should help you quickly configure Unity components to match the design!
