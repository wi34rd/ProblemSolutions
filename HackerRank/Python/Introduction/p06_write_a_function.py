# Write a function
# https://www.hackerrank.com/challenges/write-a-function/problem

def is_leap(year):
    if year % 4:
        return False
    elif year % 100:
        return True
    elif year % 400:
        return False
    
    return True
