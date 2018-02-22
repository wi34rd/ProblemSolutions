# Piling Up!
# https://www.hackerrank.com/challenges/piling-up/problem

for _ in range(int(input())):
    n = int(input())
    l = [int(x) for x in input().split()]
    i = 0

    while i < n - 1 and l[i] >= l[i + 1]:
        i += 1

    while i < n - 1 and l[i] <= l[i + 1]:
        i += 1

    print("Yes" if i == n - 1 else "No")
