# Portable C# on Windows (no install)

Use this on a Windows laptop where you **can't install .NET**. The whole C# compiler lives in one folder, which can be on the laptop or on a USB stick. It needs no admin rights and installs nothing.

You need internet once, to download .NET. The download is about 300 MB, and it unpacks to roughly 1 GB of space. After that, everything works offline.

## 1. Get the folder

1. On the [repo page](https://github.com/dsksnkz/30Days-with-csharp), click **Code → Download ZIP**.
2. Open the zip and copy the whole **`portable`** folder somewhere you can write to, for example your Desktop, `Documents` or a USB stick.

Avoid paths with `&` or `!` in them. Spaces are fine.

The laptop's own drive is much faster than a USB stick. Use a USB stick only if you need to carry the setup between computers.

## 2. Download .NET into it (once)

Double-click **`get-dotnet.bat`**. It downloads the .NET 10 SDK and unpacks it into `portable\dotnet\`. When it prints a version number like `10.0.100`, it's done.

**This step is slow, often 10–20 minutes.** The download is only part of it. Unpacking writes thousands of small files, and Windows Defender scans each one as it lands. On a USB stick it can take even longer. Leave the window open until it says `Done`. You only do this once.

If Windows says **"Windows protected your PC"**, click **More info → Run anyway**. That shows up for any script that came from the internet.

## 3. Paste and run

Double-click **`run.bat`**. Two windows open:

- **Notepad**, with `code.cs` in it. Paste your code over what's there and press **Ctrl+S**.
- **A black window.** Press any key in it to run your code. Type your input in this window too.

Change the code, save, and press a key again to rerun it. Close the black window when you're done.

The first run takes a few seconds while it compiles. Later runs are quicker.

You can also drag any `.cs` file onto `run.bat` to run that file instead.

## What the code should look like

Write it exactly the way the course does, with code loose in the file and methods at the bottom:

```csharp
Console.Write("Your name: ");
string name = Console.ReadLine()!;
Greet(name);

void Greet(string who)
{
    Console.WriteLine($"Hi {who}");
}
```

There's no need for `using System;`, `class Program` or `Main`. All your code goes in **one file**.

## Using the course commands

Double-click **`terminal.bat`**. It opens a command window that uses the portable .NET, so the usual commands work:

```bash
dotnet new console -o Day04
cd Day04
dotnet run
```

Use this once you get to projects with more than one file (Week 2 onwards).

## What's in the folder

| File | What it does |
|---|---|
| `get-dotnet.bat` | Downloads .NET into `dotnet\`. Run it once. |
| `run.bat` | Opens `code.cs` in Notepad and runs it each time you press a key |
| `terminal.bat` | Opens a command window where `dotnet` works |
| `template.cs` | The starter code a new `code.cs` begins with |
| `dotnet\` | .NET itself, made by `get-dotnet.bat` |
| `home\` | .NET's settings and cache, kept here instead of on the laptop |

To remove it all, delete the folder. The only things left behind on the laptop are a few temporary build files in Windows' temp folder.

## If get-dotnet.bat fails

Download the zip yourself:

1. Go to [dotnet.microsoft.com/download/dotnet/10.0](https://dotnet.microsoft.com/download/dotnet/10.0).
2. In the **SDK** column, under **Windows → Binaries**, click **x64**. Pick **Arm64** instead if the laptop has a Snapdragon chip.
3. Make a folder called `dotnet` inside `portable`.
4. Unzip the download into it, so that `portable\dotnet\dotnet.exe` exists.

Get the **Binaries** zip, not the Installer. The installer needs admin rights.

## If it still won't run

| Problem | What it means |
|---|---|
| `.NET isn't next to this file` | The `dotnet` folder isn't beside `run.bat`. Keep all the files together in one folder, with `dotnet.exe` at `dotnet\dotnet.exe`. |
| `'dotnet' is not recognized` | You have an old copy of `run.bat`. Download the folder again. |
| "This app has been blocked by your system administrator" | The laptop doesn't allow programs outside Program Files. Use [ONLINE.md](ONLINE.md) instead. |
| `Unrecognized command or argument 'code.cs'` | The SDK is older than .NET 10. Delete `dotnet\` and run `get-dotnet.bat` again. |
| Antivirus deletes `dotnet.exe` | It's a false alarm. Ask whoever runs the laptop, or use [ONLINE.md](ONLINE.md). |
