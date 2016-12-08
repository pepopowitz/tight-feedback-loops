# Tight Feedback Loops With TDD and DevOps

A talk on tightening feedback loops with TDD and DevOps.

## Looking for the slide deck?

[It's right here!](http://tight-feedback-loops.netlify.com/) 

Use your left and right arrow keys to move through the slides.

## Development

[Docs on remark are here](https://github.com/gnab/remark/wiki).

### Installation

Install dependencies with npm. 

- [NodeJS](http://nodejs.org/)
- [GulpJS](http://gulpjs.com/)

```sh
# install dependencies
$ npm install
```

### Running

Run the talk with the `npm start` task.

```sh
# run tasks and serve
$ gulp
```

### Adding a new section of slides to the talk

Slide sections for the talk live in the `src/slides` folder.

Slides in each section are written with [Markdown syntax](https://github.com/gnab/remark/wiki/Markdown). Individual slides are separated with `---`. Notes for each slide are preceded by `???`.  

To add a new section to the slideshow, you must reference it in the `templates/index.jade` template.
