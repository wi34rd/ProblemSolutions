# Set Mutations
# https://www.hackerrank.com/challenges/py-set-mutations/problem

_ = input()
s = set(map(int, input().split()))

for _ in range(int(input())):
    eval('s.{}({})'.format(input().split()[0], set(map(int, input().split()))))

print(sum(s))
