# Find Angle MBC
# https://www.hackerrank.com/challenges/find-angle/problem

import math


AB = int(input())
BC = int(input())

print('{:.0f}°'.format(math.degrees(math.atan2(AB, BC))))
