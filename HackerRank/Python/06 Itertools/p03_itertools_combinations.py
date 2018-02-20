# itertools.combinations()
# https://www.hackerrank.com/challenges/itertools-combinations/problem

from itertools import combinations


S, k = input().split()

for i in range(1, int(k) + 1):
    print(*(''.join(combination) for combination in combinations(sorted(S), i)), sep='\n')
