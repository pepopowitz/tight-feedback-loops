---
class: fit-image
background-image: url(images/dilbert.jpg)
# DevOps

---

## What is it?

- Flow                   <--- we skipped this, now we're gonna talk about it a bit more
- Feedback               <--- you are here
- Continuous Improvement <--- this is what you're gonna bring home after today

???

The Three Ways, by Gene Kim
Draw picture, basically this: http://itrevolution.com/the-three-ways-principles-underpinning-devops/

---
class: full-screen-image
background-image: url(images/startrek.png)

## So what is it _really_?

???
Collaboration
Faster feedback
Better business decisions

---

## What does this do for us?
Stop having weekend/night-time deployments

Run experiments and make small, rapid improvements

Faster feedback loops

---

# Every software feature is an experiment until you've obtained feedback on it in production

???

Example: Intuit running turbotax experiments in production during tax season
We've made the loop much longer, but we still want it to be fast. Enter automation....

---

## The DevOps feedback loop

```
codez ----> build ---> deploy ---> test --v
^                                         v
^                                         v
<--- changes <--- reviews <--- deliver <--v
```

???

How is this different from before? We've taken away the shortcuts, and added *customers*

---

# Demo

???
Build in TFS, deploy with Octopus
