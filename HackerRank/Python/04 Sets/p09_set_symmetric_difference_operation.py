# Set .symmetric_difference() Operation
# https://www.hackerrank.com/challenges/py-set-symmetric-difference-operation/problem

_ = input()
set1 = set(input().split())
_ = input()
set2 = set(input().split())

print(len(set1 ^ set2))
