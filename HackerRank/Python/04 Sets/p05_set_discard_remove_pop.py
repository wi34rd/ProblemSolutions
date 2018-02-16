# Set .discard(), .remove() & .pop()
# https://www.hackerrank.com/challenges/py-set-discard-remove-pop/problem

n = int(input())
s = set(map(int, input().split()))

for _ in range(int(input())):
    eval('s.{}({})'.format(*input().split() + ['']))

print(sum(s))
