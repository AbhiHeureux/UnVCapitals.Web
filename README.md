# U &amp; V Financial Knowledge

Static website for **U &amp; V Financial Knowledge** &mdash; an educational and awareness initiative for financial literacy.

## Pages

- `index.html` &mdash; Home
- `about.html` &mdash; About us, vision, mission
- `services.html` &mdash; Services + FAQ
- `insights.html` &mdash; Articles list
- `post.html` &mdash; Single article
- `contact.html` &mdash; Contact + form
- `elements.html` &mdash; UI components
- `404.html` &mdash; Not-found page

## Local preview

Open `index.html` directly in your browser, or serve the folder with any static server:

```powershell
# Python
python -m http.server 8080

# Node
npx serve .
```

## Deploy to GitHub Pages

1. Push this repo to GitHub.
2. In the repo on GitHub: **Settings &rarr; Pages**.
3. Under **Build and deployment**, choose:
   - **Source:** Deploy from a branch
   - **Branch:** `main` (or `master`) &mdash; folder `/ (root)`
4. Save. Your site will be live at `https://<username>.github.io/<repo-name>/` in a minute or two.

The empty `.nojekyll` file tells GitHub Pages to skip Jekyll processing and serve files as-is.

## Structure

```
.
|-- index.html             # Home
|-- about.html
|-- services.html
|-- insights.html
|-- post.html
|-- contact.html
|-- elements.html
|-- 404.html
|-- favicon.ico
|-- .nojekyll              # disables Jekyll on GitHub Pages
`-- vaultedge/             # all CSS, JS, fonts, images
    |-- css/
    |-- fonts/
    |-- img/
    |-- js/
    `-- style.css
```
