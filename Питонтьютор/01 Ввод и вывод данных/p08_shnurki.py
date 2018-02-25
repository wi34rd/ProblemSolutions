# Шнурки
# http://pythontutor.ru/lessons/inout_and_arithmetic_operations/problems/shoelace/

a, b, l, N = (int(input()) for _ in range(4))

print(2 * (N * (a + b) + l - b) - a)
