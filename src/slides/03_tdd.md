---
background-image: url(images/loops/dev-qa.png)

# The Developer-QE feedback loop

???

Here's our first suggestion.

What if we told you there was a shortcut on this loop?

---
background-image: url(images/loops/tdd-shortcut.png)

# The Developer-QE feedback loop

TODO - animate most of loop to fade away

???

What if we told you there was a way to get changes to the developer,

without having to go through half of this loop?

...

What if you could collaborate with the developer while they are coding?

And we're recommending Test Driven Development to help make it happen.

---
class: title

# Test Driven Development

---
class: title

# For every change to the system, you must first introduce a failing test

---
class: title

# Red/Green/Refactor

---
class: title

## How does TDD benefit the developer?

---
class: title

# Promotes simplicity

???

Developers will be happy that their code is simpler 

---
class: title

# Tightens the developer's feedback loop

???

I don't have to re-launch the app every time I make a change, 

and step through 7 steps to get to the issue I'm fixing.

---
class: title

# Reduces the amount of mental clutter

???

Grocery list

---
class: title

## How does TDD benefit the team?

---
class: title

# Development + Testing + Peer Review

???

It is a great opportunity for collaboration amongst team members  

---
class: title

# Documentation of the system

???

All of the test cases serve as documentation of the system

---
class: title

# Find bugs before they've been written

???

Because you are thinking about edge cases 

as you build it

---
class: title

## How does TDD benefit the product?

---
class: title

# Puts you in the customer's shoes 

???

Any time you make a change, you are looking at it from the perspective of the user of your system.

---
class: title

# Promotes maintainability

???

You can still write bad code with TDD

But it leads you toward writing better code 

(you make it harder on yourself by not writing clean code)



---
# Test Driven Development 
## Demo

???

Alright we're gonna build a calculator!!! 
Pull up VS, take turns driving keyboard, have test and code alongside each other

Test cases/implementation direction
Division has weird edge cases
Tester writes the test name at the beginning
Later on QE writes the test themselves
Run with NCrunch or VS2017, show Code Coverage for 'slower' feedback
Go for 3-5 iterations, have QE suggest edges, have dev suggest edges
