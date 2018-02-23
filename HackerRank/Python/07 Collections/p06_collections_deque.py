# Collections.deque()
# https://www.hackerrank.com/challenges/py-collections-deque/problem

from collections import deque


d = deque()

for _ in range(int(input())):
    cmd, *item = input().split()
    exec('d.{}({})'.format(cmd, item[0] if item else ''))

print(*d)
