# TimeTeller
------------

This project was originally written for the XP Days Ukraine 2017 conference, and represents the fifth state of code for the "Improving Your Organization’s Technical Prowess With Legacy Code Retreats" talk.  https://github.com/hdeiner/xp2017ukraine06

Please do not judge me on this code alone. ☺ 

This code is designed to be an example of legacy code that works, but is nothing that we are proud of and pretty hard to maintain.

#### The goal at this point is to:
* I think we're in good shape to extend the project now.  Let's see what happens when we generalize time to use any time zone we want.
* Start with some tests.  In a new package I've called test.com.deinersoft.clock.  Now that we're past the refactoring phase, I like to stick to TDD as the coding methodology.
* Once we have a ClockTest for newYorkIsLosAngelesPlus3, we can implment Clock using java.time.ZonedDateTime.  That automatically allows us to use all world timezones easily, and eliminates the ClockLocal and ClockUTC classes.  We still want ClockForTesting to extend Clock and use the same interface.  clockForTestingIsAClock just verifies that unnecessarily.
* There was some minor refactoring to get rid of ClockLocal and ClockUTC, but with our automated tests already in place, that was painfree and safe.
* There was also some minor refactoring in Messenger and Email to code for the commonality in configuration files.  And, yes, SMS was quite easy using a REST interface to a Twillo account.
* But the point here is that the extensions were quite painless.  And that's due to the fact that we took the time to refactor and automate tests in out legacy code.  When you flip back to the original code and think about the continued horror story that would have been had we decided to just "get 'r done" and add the new features, I hope that you'll never consider an option like that again!