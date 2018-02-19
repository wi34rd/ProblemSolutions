# The Captain's Room
# https://www.hackerrank.com/challenges/py-the-captains-room/problem

K, l = int(input()), list(map(int, input().split()))
s = set(l)

print((sum(s) * K - sum(l)) // (K - 1))
