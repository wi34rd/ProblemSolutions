# Word Order
# https://www.hackerrank.com/challenges/word-order/problem

from collections import OrderedDict


words = OrderedDict()

for i in range(int(input())):
    word = input()
    words[word] = words.get(word, 0) + 1

print(len(words))
print(*words.values())
