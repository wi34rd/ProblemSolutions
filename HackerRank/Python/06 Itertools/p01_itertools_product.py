# itertools.product()
# https://www.hackerrank.com/challenges/itertools-product/problem

import itertools


print(*itertools.product(map(int, input().split()), map(int, input().split())))
