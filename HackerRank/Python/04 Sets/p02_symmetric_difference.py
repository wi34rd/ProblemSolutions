# Symmetric Difference
# https://www.hackerrank.com/challenges/symmetric-difference/problem

M = int(input())
set1 = set(map(int, input().split()))
N = int(input())
set2 = set(map(int, input().split()))

print(*sorted(set1 ^ set2), sep='\n')
