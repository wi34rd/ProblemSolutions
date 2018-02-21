# Compress the String!
# https://www.hackerrank.com/challenges/compress-the-string/problem

from itertools import groupby


print(*((len(list(group)), key) for key, group in groupby(map(int, input()))))
