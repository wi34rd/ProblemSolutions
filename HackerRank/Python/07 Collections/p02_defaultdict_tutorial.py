# DefaultDict Tutorial
# https://www.hackerrank.com/challenges/defaultdict-tutorial/problem

from collections import defaultdict


n, m = map(int, input().split())
A = defaultdict(list)

for i in range(1, n + 1):
    A[input()].append(i)

for i in range(m):
    x = input()
    
    if x in A:
        print(*A[x])
    else:
        print(-1)
