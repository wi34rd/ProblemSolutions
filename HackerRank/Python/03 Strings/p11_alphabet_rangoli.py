# Alphabet Rangoli
# https://www.hackerrank.com/challenges/alphabet-rangoli/problem

def print_rangoli(size):
    alpha = 'abcdefghijklmnopqrstuvwxyz'
    l = []

    for i in range(size):
        s = '-'.join(alpha[i:size])
        l.append((s[::-1]+s[1:]).center(4*n-3, "-"))
    
    print(*(l[:0:-1] + l), sep='\n')


if __name__ == '__main__':
    n = int(input())
    
    print_rangoli(n)
