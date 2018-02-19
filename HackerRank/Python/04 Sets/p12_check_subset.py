# Check Subset
# https://www.hackerrank.com/challenges/py-check-subset/problem

for i in range(int(input())):
    a = int(input()); A = set(input().split()) 
    b = int(input()); B = set(input().split())
    
    print(B > A)
