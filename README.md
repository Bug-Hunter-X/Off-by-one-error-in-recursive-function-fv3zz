# Off-by-one error in recursive function
This repository demonstrates a common off-by-one error in a recursive function written in C#. The bug causes incorrect results when the base case of the recursion is reached. 

## Bug Description
The `MyMethod` function is supposed to calculate a recursive sum. However, when `a` is 0, it returns `b` instead of the expected value of 1. This off-by-one error leads to incorrect results for certain input values.

## Bug Solution
The solution involves correcting the base case of the recursive function to return 1 when `a` is 0. This ensures that the recursion terminates correctly, and the final result is accurate.