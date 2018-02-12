# Nested Lists
# https://www.hackerrank.com/challenges/nested-list/problem

if __name__ == '__main__':
    list_ = [[input(), float(input())] for _ in range(int(input()))]
    second_lowest = sorted(list(set([score for _, score in list_])))[1]
    print('\n'.join(name for name, score in sorted(list_) if score == second_lowest))
