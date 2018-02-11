# Python If-Else
# https://www.hackerrank.com/challenges/py-if-else/problem

if __name__ == '__main__':
    n = int(input())
    
    if n % 2 or n > 5 and n < 21:
        print('Weird')
    else:
        print('Not Weird')
