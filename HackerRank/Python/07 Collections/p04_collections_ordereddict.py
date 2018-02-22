# Collections.OrderedDict()
# https://www.hackerrank.com/challenges/py-collections-ordereddict/problem

from collections import OrderedDict


items_prices = OrderedDict()
N = int(input())

for i in range(N):
    item, price = input().rsplit(maxsplit=1)
    items_prices[item] = items_prices.get(item, 0) + int(price)

for item, price in items_prices.items():
    print(item, price)
