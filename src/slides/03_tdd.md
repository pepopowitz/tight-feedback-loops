---
class: loop

# The Developer-QA feedback loop

![Dev-QA Loop](images/loops/dev-qa.png)

???
Tyler? steve?

So let's take a look at a feedback loop we experience daily.

This is the loop between developers and QA.

There are a lot of stops along that loop.

A lot of opportunities for that loop to get bigger, and slower.

Tyler and I want to help you make that loop smaller, instead.

...

Here's our first suggestion.

What if we told you there was a shortcut on this loop?

---
class: loop

# The Developer-QA feedback loop

.transition[
![Dev-QA Loop](images/loops/dev-qa.png)
![Dev-QA Loop (shortcut)](images/loops/tdd-shortcut.png)
]

???
Tyler? steve?

What if we told you there was a way to get changes to the developer,

without having to go through half of this loop?

Our good friend Rob has some advice for us 

---
class: full-screen-image, meme
background-image: url(images/vanilla-ice.jpg)

# Collaborate! 

???
steve

And Tyler and i have a great way for that to happen.

---
class: full-screen-image, meme
background-image: url(images/vanilla-ice.jpg)

# Test Driven Development! 

???
steve

---
class: title

# For every change to the system, you must first introduce a failing test

???

Tyler
---
class: title

# Red/Green/Refactor

???

Tyler

---
class: full-screen-image, meme
background-image: url(images/demo.jpg)

# Demo

???

Alright we're gonna build a calculator!!! 
Pull up VS, take turns driving keyboard, have test and code alongside each other

Test cases/implementation direction
Division has weird edge cases
Tester writes the test name at the beginning
Later on QE writes the test themselves
Run with NCrunch or VS2017, show Code Coverage for 'slower' feedback
Go for 3-5 iterations, have QE suggest edges, have dev suggest edges

---
class: title

## How does TDD benefit the developer?

???

Tyler
---
class: title

# Promotes simplicity

???

Tyler

Developers will be happy that their code is simpler 

---
class: title

# Tightens the developer's feedback loop

???

Tyler

I don't have to re-launch the app every time I make a change, 

and step through 7 steps to get to the issue I'm fixing.

---
class: title

# Reduces the amount of mental clutter

???
steve

Grocery list

---
class: title

## How does TDD benefit the team?

???
steve

---
class: title

# Development + Testing + Peer Review

???
steve

It is a great opportunity for collaboration amongst team members  

---
class: title

# Documentation of the system

???
steve

All of the small, granular test cases serve as documentation of the system

---
class: title

# Find bugs before they've been written

???
steve

Because you are thinking about edge cases 

as you build it

---
class: title

## How does TDD benefit the product?

???
Tyler

---
class: title

# Puts you in the customer's shoes 

???
Tyler

Any time you make a change, you are looking at it from the perspective of the user of your system.

---
class: title

# Promotes maintainability

???
Tyler

Which leads to better quality

And fewer regression bugs

...

You can still write bad code with TDD

But it leads you toward writing better code 

(you make it harder on yourself by not writing clean code)



