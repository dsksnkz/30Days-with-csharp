# Rebuilds site/index.html from the Markdown files. Run from the repo root: python3 site/build.py
import json
from pathlib import Path

PAGES = [("README", "Start"), ("REVISION", "Revision"), ("WEEK1", "Week 1"),
         ("ROADMAP", "Roadmap"), ("ERRORS", "Errors"), ("REWARDS", "Rewards")]

docs = {name.lower(): Path(f"{name}.md").read_text() for name, _ in PAGES}
data = json.dumps(docs).replace("</", "<\\/")
nav = "".join(f'<a href="#{n.lower()}">{label}</a>' for n, label in PAGES)
template = Path("site/template.html").read_text()
Path("site/index.html").write_text(template.replace("{{NAV}}", nav).replace("{{DATA}}", data))
