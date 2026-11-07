# Setup on Arch Linux

## 1. Install Python

Arch usually has it already. Check:

```bash
python --version
```

If you see `Python 3.12` or newer, you're done. If not:

```bash
sudo pacman -S python python-pip
```

On Arch, `python` means Python 3. You don't need to type `python3`, though it works too.

## 2. Pick an editor

Anything works. Good choices:

- **Neovim** (`sudo pacman -S neovim`) if you like the terminal.
- **VS Code** (`code` from the AUR, or `sudo pacman -S code`) with the Python extension.
- **Helix** (`sudo pacman -S helix`): Python support out of the box.

Set your editor to use **4 spaces** for indenting. In Python, indenting isn't just tidiness: it's part of the code.

## 3. Your first program

```bash
mkdir -p ~/30Days-of-python/my-code/Day01 && cd ~/30Days-of-python/my-code/Day01
echo 'print("Hello, Python")' > hello.py
python hello.py
```

## 4. The REPL

Type `python` with no file to get a `>>>` prompt. It runs each line as soon as you press Enter, which is great for testing a small idea:

```
>>> 7 / 2
3.5
>>> len("hello")
5
```

Leave with `exit()` or **Ctrl+D**.

## 5. Installing packages (from Week 3)

Arch blocks `pip install` system-wide, and you'll see `error: externally-managed-environment`. That's on purpose. Use a **virtual environment** for each project instead:

```bash
python -m venv .venv
source .venv/bin/activate        # fish: source .venv/bin/activate.fish
pip install requests
deactivate                       # when you're done
```

Add `.venv/` to `.gitignore`, which this repo already does.

## 6. Hyprland tip

Put the editor and a terminal side by side. Save, switch to the terminal with your workspace keys, and run `python file.py`. To rerun quickly, press the up arrow and Enter.
