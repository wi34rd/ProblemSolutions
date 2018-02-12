# Finding the percentage
# https://www.hackerrank.com/challenges/finding-the-percentage/problem

if __name__ == '__main__':
    student_marks = {}
    
    for _ in range(int(input())):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    
    query_name = input()
    print('{:.2f}'.format(sum(student_marks[query_name]) / len(student_marks[query_name])))
