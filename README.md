# tpt2calc (was tpt2eracalc)
Check the Releases section to download the calculator.
##### Allows support for "short named" and "scientific" notations! (on top of full notation)
###### Unsure of how to make it into a web application so if anyone wants to, feel free!

## Latest Version `0.4.9 >`<a href="https://github.com/cratorrex/tpt2eracalc/releases/tag/0.5">`0.5`</a>

New Utilities!

  - Essential Utilities: Module Drop Chance Calculator (MDCcalc)
  - Essential Utilities: Blueprint Decoder

Changes

  - A friendlier dark mode suggested by Rak.
  - Renamed Form1 to tpt Calculator, also suggested by Rak.
  - Added "math_ext.cs" to facilitate some future stuff... 👀

Some new settings

  - Remember tab
  - Open Utilities on Startup

## EraXPCalculator
  Basically calculates the expected amount of xp you'd get from era enemies.<br/>
  The form is pretty straightforward.<br/><br/>
  The xp formula only works on era, so if you are in `inf1 era1`, the formula in game assumes you are at `era1`.<br/>
  Has support for most/all things (related to era experience) up to the `Military Perks` Update.<br/>
  - When having the `Combat Surveillance` Military Perk, allows for log10 conversion, especially for numbers over Quintillions (e18).
 
 
## ElementDisableCalc
  Calculates the cost of elemental disables based off the base cost.
  This utility assumes that all elements' base cost is the same.
  
 If you need to know what the cost of an element as your nth disable is, enter in your base cost and click calculate and match the corresponding values. (I don't have a proficiency at explaining things ;-;)
 
  Notation for large numbers returned from the calculation is `Scientific`
 

## ClearSpeedCalculator
 ### Helps calculate your average clearspeed based on:
  - Your total Enemy kills in the run.
    - or allow the calculator to approximate kills based on one element's kill count
  - How long you were in that run `in real time`.
    - Toggleable between `game time`
  - Which region you're in.
  - Which Difficulty you're in.
  - and many more factors.
  
   Note: The result of the calculation will be more accurate with more kills and time spent in the run.
      The clearspeed should be the same throughout all your rounds regardless of region.
   #### Includes a more accurate Clear Speed formula courtesy of BudEBoy!

## ModuleDropChanceCalculator
  Calculates a module's drop chance based on Wave, Difficulty, Player's Module Drop Chance Statistic, and the Module's Base Drop Chance.
  
  Estimates how many rounds (rounded up) it will take, on average, with the given inputs, to get a cumulative 100% drop chance.
  
## Helper Utilities
  - Blueprint Decoder (a base64 decoder with some extra code formatting)
 

   #  
   Ping me `@cratorrex.rx#3589` on discord if you have some suggestions on what I should add to the calculator utility! :J
   #
