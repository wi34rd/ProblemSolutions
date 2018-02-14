# Capitalize!
# https://www.hackerrank.com/challenges/capitalize/problem

def capitalize(string):
    chars = []
    is_new_word = True
    
    for char in string:
        if is_new_word and not char.isspace():
            chars.append(char.upper())
            is_new_word = False
            continue
        elif not is_new_word and char.isspace():
            is_new_word = True
        
        chars.append(char)
    
    return ''.join(chars)


if __name__ == '__main__':
    string = input()
    capitalized_string = capitalize(string)
    print(capitalized_string)
