# Ran Utils - UI

A collection of UI utility scripts for Unity projects, designed to simplify the creation and management of UI elements bound to data.

## Features

-   Generic base class for UI visual elements (`UIVisual<T>`) that can be bound to any data type
-   Easy data loading, unloading, and refreshing for UI components
-   Simple show/hide logic for UI elements
-   Extensible for custom UI behaviors

## Usage

### UIVisual<T>

Inherit from `UIVisual<T>` to create a UI component that represents and manages data of type `T`:

```csharp
using ran.utilities;

public class PlayerInfoUI : UIVisual<PlayerData>
{
    public override void Refresh()
    {
        // Update UI elements based on Data
    }

    public override void Reset()
    {
        // Reset UI elements to default state
    }
}
```

#### Key Methods & Properties

-   `Data`: The data associated with this UI visual
-   `IsLoaded`: Indicates if data is loaded
-   `Load(T newData)`: Loads new data and refreshes the UI
-   `Unload()`: Unloads data and resets the UI
-   `Refresh()`: Abstract method to update UI based on data
-   `Reset()`: Abstract method to reset UI to default state
-   `Show()`: Shows the UI element
-   `Hide()`: Hides the UI element

## Installation

### Option 1: Unity Git Package Manager (Recommended)

Add the following line to your project's `manifest.json` dependencies:

```json
"com.ran-utils.ui": "https://github.com/khalishzhafran/utils-ui.git"
```

This will automatically fetch and update the package via Unity's Package Manager.

### Option 2: Manual Copy

Copy the `Runtime/UI` folder into your Unity project's `Assets` directory.

## License

Copyright (c) 2025 Ran. Free to use, modify, and distribute for personal and commercial projects as long as this notice remains intact.
