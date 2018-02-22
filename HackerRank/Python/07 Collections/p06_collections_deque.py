# Collections.deque()
# https://www.hackerrank.com/challenges/py-collections-deque/problem

from collections import deque


d = deque()

for _ in range(int(input())):
    cmd, *item = input().split()
    item = int(item[0]) if item else None
    
    if cmd == 'append':
        d.append(item)
    elif cmd == 'appendleft':
        d.appendleft(item)
    elif cmd == 'pop':
        d.pop()
    elif cmd == 'popleft':
        d.popleft()

print(*d)
