# collections.Counter()
# https://www.hackerrank.com/challenges/collections-counter/problem

from collections import Counter


input()
shoe_sizes_counter = Counter(input().split())
total_money_earned = 0

for i in range(int(input())):
    shoe_size, price = input().split()
    price = int(price)
    
    if shoe_sizes_counter[shoe_size]:
        shoe_sizes_counter[shoe_size] -= 1
        total_money_earned += price

print(total_money_earned)
