# Setup

You need the **.NET SDK** (version 8 or newer) and an editor. Pick your system and follow its steps.

## Windows

Open **Terminal** (or PowerShell) and run:

```powershell
winget install Microsoft.DotNet.SDK.9
```

Or download the SDK installer from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download). Get the **SDK**, not just the Runtime.

Close and reopen Terminal afterwards.

**Not allowed to install?** Use the portable version in [PORTABLE.md](PORTABLE.md). It runs from a folder or USB stick with no admin rights.

## macOS

```bash
brew install --cask dotnet-sdk     # needs Homebrew: https://brew.sh
```

Or use the installer from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

## Linux

| Distribution | Command |
|---|---|
| Ubuntu, Debian | `sudo apt install dotnet-sdk-8.0` |
| Fedora | `sudo dnf install dotnet-sdk-8.0` |
| Arch | `sudo pacman -S dotnet-sdk` |

For other distributions, see [Install .NET on Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux).

## Check it worked

```bash
dotnet --version
```

If you see a number like `8.0.x` or `9.0.x`, you're ready. If the command isn't found, close and reopen the terminal, or restart the computer.

## Pick an editor

- **VS Code** (Windows, macOS, Linux) from [code.visualstudio.com](https://code.visualstudio.com/), with the **C# Dev Kit** extension.
- **Visual Studio Community** (Windows) or **JetBrains Rider** (all systems) if you'd rather have a full IDE.

This course runs everything from a terminal with `dotnet run`, which works the same everywhere. VS Code has a terminal built in: **View → Terminal**.

## Your first program

These commands work in PowerShell, macOS Terminal and Linux shells:

```bash
dotnet new console -o Day01
cd Day01
dotnet run
```

It prints `Hello, World!`. Open `Program.cs` in your editor to change it.

## Git (for saving your work)

- **Windows:** `winget install Git.Git`, or download from [git-scm.com](https://git-scm.com/).
- **macOS:** `xcode-select --install`, or `brew install git`.
- **Linux:** install `git` with your package manager.

No .NET at all? See [ONLINE.md](ONLINE.md).
