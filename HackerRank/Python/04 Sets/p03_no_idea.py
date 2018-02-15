# No Idea!
# https://www.hackerrank.com/challenges/no-idea/problem

_ = input()
array = input().split()
A = set(input().split())
B = set(input().split())

print(sum((i in A) - (i in B) for i in array))
