# Rebuilds site/index.html and docs/index.html from the Markdown files. Run from the repo root: python3 site/build.py
# The template is shared by all the 30-day courses. Only the settings below change.
import json
from pathlib import Path
from urllib.parse import quote

TITLE = "30 Days with C#"
REPO = "https://github.com/dsksnkz/30Days-with-csharp"
BADGE, BADGE_SIZE, BADGE_FG = "C#", 12, "#ffffff"
# Colours from the C# and .NET logos: .NET purple and C# violet.
COLORS = {
    "bg": "#16131f", "line": "#2e2a3d", "code": "#1f1b2b", "code-fg": "#d6cbf7",
    "brand-1": "#512bd4", "brand-2": "#9b4f96", "accent": "#b9a4ff", "link": "#a894ff",
}
PAGES = [("README", "Start"), ("SETUP", "Setup"), ("PORTABLE", "Portable"), ("REVISION", "Revision"), ("WEEK1", "Week 1"),
         ("ROADMAP", "Roadmap"), ("ERRORS", "Errors"), ("ONLINE", "Run online")]

theme = " ".join(f"--{k}: {v};" for k, v in COLORS.items())
icon = quote(f'<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 34 34"><polygon points="17,1 31,9 31,25 17,33 3,25 3,9" fill="{COLORS["brand-1"]}"/>'
             f'<polygon points="17,1 31,9 31,25 17,17" fill="{COLORS["brand-2"]}"/><text x="17" y="22" text-anchor="middle" font-family="sans-serif" '
             f'font-size="{BADGE_SIZE}" font-weight="800" fill="{BADGE_FG}">{BADGE.replace("#", "&#35;")}</text></svg>')

docs = {name.lower(): Path(f"{name}.md").read_text() for name, _ in PAGES}
data = json.dumps(docs).replace("</", "<\\/")
nav = "".join(f'<a href="#{n.lower()}">{label}</a>' for n, label in PAGES)
html = Path("site/template.html").read_text()
for key, value in {"THEME": theme, "BG": COLORS["bg"], "ICON": icon, "TITLE": TITLE, "REPO": REPO,
                   "BADGE": BADGE, "BADGE_SIZE": str(BADGE_SIZE), "BADGE_FG": BADGE_FG, "NAV": nav, "DATA": data}.items():
    html = html.replace("{{" + key + "}}", value)
Path("site/index.html").write_text(html)

# GitHub Pages serves docs/ and needs a full document.
head = '<!doctype html>\n<html lang="en">\n<meta charset="utf-8">\n<meta name="viewport" content="width=device-width, initial-scale=1, viewport-fit=cover">\n'
Path("docs").mkdir(exist_ok=True)
Path("docs/.nojekyll").touch()
Path("docs/index.html").write_text(head + html)
