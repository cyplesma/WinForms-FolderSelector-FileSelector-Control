# WinForms File Selector Control

A reusable Windows Forms UserControl that combines a TextBox with a browse button.

Supports selecting either:

- Files
- Folders

Designed for .NET WinForms projects.

---

## Features

- Browse for files
- Browse for folders
- Enter path manually
- Fires FileNameChanged event only when the value actually changes
- Supports custom OpenFileDialog filters
- Simple drag-and-drop into existing WinForms projects

---

## Properties

| Property | Description |
|----------|-------------|
| FileName | Gets or sets the current path |
| FileType | OpenFileDialog filter string |
| SelectFolder | When true, opens FolderBrowserDialog instead of OpenFileDialog |
| Text | Alias for FileName |

Example:

```csharp
ucFileSelector1.FileType =
    "Images (*.png)|*.png|All Files (*.*)|*.*";

ucFileSelector1.SelectFolder = false;
```

---

## Events

### FileNameChanged

Raised when

- Enter is pressed
- The textbox loses focus
- A file is chosen
- A folder is chosen
- FileName/Text is set in code

Example:

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    ucFileSelector1.FileNameChanged += Selector_FileNameChanged;
}

private void Selector_FileNameChanged(object sender, EventArgs e)
{
    MessageBox.Show(ucFileSelector1.FileName);
}
```

---

## Installation

Simply copy

```
ucFileSelector.cs
ucFileSelector.Designer.cs
ucFileSelector.resx
```

into your WinForms project.

Build the project.

The control will appear in the Toolbox.

---

## Requirements

- .NET WinForms
- C#
- No external dependencies

---

## License

MIT
