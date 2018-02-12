# sWAP cASE
# https://www.hackerrank.com/challenges/swap-case/problem

def swap_case(s):
    result = list(s)
    
    for i, char in enumerate(s):
        if char.islower():
            result[i] = char.upper()
        elif char.isupper():
            result[i] = char.lower()
    
    return ''.join(result)


if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)
