# Iterables and Iterators
# https://www.hackerrank.com/challenges/iterables-and-iterators/problem

from itertools import combinations


input()
counter1 = 0
counter2 = 0

for combination in combinations(input().split(), int(input())):
    counter1 += 1
    
    if 'a' in combination:
        counter2 += 1

print(counter2 / counter1)
