# String Validators
# https://www.hackerrank.com/challenges/string-validators/problem

if __name__ == '__main__':
    s = input()
    results = [False, False, False, False, False]
    
    for char in s:
        if not results[0] and char.isalnum():
            results[0] = True
        if not results[1] and char.isalpha():
            results[1] = True
        if not results[2] and char.isdigit():
            results[2] = True
        if not results[3] and char.islower():
            results[3] = True
        if not results[4] and char.isupper():
            results[4] = True
    
    print(*results, sep='\n')
