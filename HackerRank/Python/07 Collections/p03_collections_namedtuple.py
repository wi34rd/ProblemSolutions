# Collections.namedtuple()
# https://www.hackerrank.com/challenges/py-collections-namedtuple/problem

from collections import namedtuple


N = int(input())
Student = namedtuple('Student', input())
marks_sum = 0

for i in range(N):
    student = Student(*input().split())
    marks_sum += int(student.MARKS)

print('{:.2f}'.format(marks_sum / N))
