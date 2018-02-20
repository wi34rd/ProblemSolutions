# itertools.permutations()
# https://www.hackerrank.com/challenges/itertools-permutations/problem

from itertools import permutations


S, k = input().split()

print(*(''.join(permutation) for permutation in permutations(sorted(S), int(k))), sep='\n')
