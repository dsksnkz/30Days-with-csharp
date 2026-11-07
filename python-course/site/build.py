# Rebuilds site/index.html and docs/index.html from the Markdown files. Run from the repo root: python3 site/build.py
import json
from pathlib import Path

PAGES = [("README", "Start"), ("SETUP", "Setup"), ("WEEK1", "Week 1"), ("ROADMAP", "Roadmap"),
         ("ERRORS", "Errors"), ("REWARDS", "Rewards"), ("ONLINE", "Run online")]

docs = {name.lower(): Path(f"{name}.md").read_text() for name, _ in PAGES}
data = json.dumps(docs).replace("</", "<\\/")
nav = "".join(f'<a href="#{n.lower()}">{label}</a>' for n, label in PAGES)
template = Path("site/template.html").read_text()
Path("site/index.html").write_text(template.replace("{{NAV}}", nav).replace("{{DATA}}", data))

# GitHub Pages serves docs/ and needs a full document.
head = '<!doctype html>\n<html lang="en">\n<meta charset="utf-8">\n<meta name="viewport" content="width=device-width, initial-scale=1, viewport-fit=cover">\n<style>body { margin: 0; }</style>\n'
Path("docs").mkdir(exist_ok=True)
Path("docs/.nojekyll").touch()
Path("docs/index.html").write_text(head + Path("site/index.html").read_text())
