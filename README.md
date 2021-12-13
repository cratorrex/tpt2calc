# tpt2calc (was tpt2eracalc)
Check the Releases section to download the calculator.
##### Allows support for "short named" and "scientific" notations! (on top of full notation)
###### Unsure of how to make it into a web application so if anyone wants to, feel free!

## Latest Version `0.4X >`<a href="https://github.com/cratorrex/tpt2eracalc/releases/tag/0.4.9">`0.4.9`</a>
##### `0.4.9` Dark Mode!!!
##### `0.4X` A very major Expansion update to the Clear Speed Calculator courtesy of BudEBoy!
  - Fixed errors when inputting `float` values to some textboxes where they accepted `long`.
  - Added a bit more support for ***Named Notation*** (added **q** for e15 and **Q** for e18)
###### `CSPD Calculator`
  - Added Calculator to help accurately measure kills in the current run.
  - Added back Real Time to Game Time conversions (default is Real Time), and x3 speed can be factored in (on by default).
  - Added Wave Compression toggle (on by default).
  - Added Kills/sec calculation.
  - Added a more accurate formula, courtesy of bud.
##### `0.4XX` Bug Fixes
  - Fixed Resource Dropstat always returning 0.
  - Fixed CSpdCalc UI.
  - Added log10 support for EraXPCalc.
##### `0.4XXX` Fixes and Adds
  - Added an extra safeguard when using Calculate_Kills in the case they forgot to uncheck "Calculate for one Element".
  - Calculate_Kills now can convert notation numbers.
  - Calculate_Kills can now be kept open after calculation.

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

   #  
   Ping me `@cratorrex.rx#3589` on discord if you have some suggestions on what I should add to the calculator utility! :J
   #
