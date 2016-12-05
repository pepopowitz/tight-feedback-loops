---

# The Developer-QE feedback loop

```
^code ----> build ---> deploy ---v
^<---- changes <---- test <-------v
```

???

Here's our first suggestion.

What if we told you there was a shortcut on this loop?

---

# The Developer-QE feedback loop

```
codez ----> build ---> deploy --v
^          v                    v
^          v                    v
<--- changes <---- test <-------v
```

???

What if we told you there was a way to get changes to the developer,

without having to go through the right half of this loop?

...

There is!

It's called collaboration.

And we're recommending Test Driven Development to help make it happen.

---

# Test Driven Development
## What is it?
* Definition: For every change to the system, you must first introduce a failing Test
* Simplified: Red/Green/Refactor
---

# Test Driven Development

## How does it benefit the developer?
* Tightens the feedback loop
* Reduces the amount of mental clutter

???

I don't have to re-launch the app every time I make a change, and step through 7 steps to get to the issue I'm fixing.

---

# Test Driven Development

## How does it benefit the team?
* Development + Testing + Peer Review
* Documentation of the system
* Find bugs before you've written them

???

It is a great opportunity for collaboration amongst team members  

---

# Test Driven Development
## How does it benefit the product?
* Puts you in the customer's shoes 
* Leads you toward better code

???

Any time you make a change, you are looking at it from the perspective of the user of your system.

You can still write bad code with TDD, but it leads you toward writing better code (you make it harder on yourself by not writing clean code)

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
