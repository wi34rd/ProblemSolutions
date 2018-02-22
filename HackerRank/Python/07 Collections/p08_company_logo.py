# Company Logo
# https://www.hackerrank.com/challenges/most-commons/problem

from collections import Counter, OrderedDict


class OrderedCounter(Counter, OrderedDict):
    pass


for char, count in OrderedCounter(sorted(input())).most_common(3):
    print(char, count)
