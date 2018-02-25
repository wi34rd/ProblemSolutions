# Шахматная доска
# http://pythontutor.ru/lessons/ifelse/problems/chess_board/

col1 = int(input())
row1 = int(input())
col2 = int(input())
row2 = int(input())

if (row1 + col1) % 2 == (row2 + col2) % 2:
    print('YES')
else:
    print('NO')
