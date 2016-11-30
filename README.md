# Tight Feedback Loops With TDD and DevOps

This is a talk built with [remark](https://github.com/gnab/remark) on tightening feedback loops with TDD and DevOps.

[Docs on remark are here](https://github.com/gnab/remark/wiki).

## Getting Started

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
