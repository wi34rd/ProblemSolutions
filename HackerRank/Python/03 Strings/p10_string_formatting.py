# String Formatting
# https://www.hackerrank.com/challenges/python-string-formatting/problem

def print_formatted(number):
    for i in range(1, number + 1):
        print('{1:{0}} {2:{0}o} {3:{0}X} {4:{0}b}'.format(len(bin(n)) - 2, i, i, i, i))


if __name__ == '__main__':
    n = int(input())
    
    print_formatted(n)
