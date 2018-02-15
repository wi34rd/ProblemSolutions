# The Minion Game
# https://www.hackerrank.com/challenges/the-minion-game/problem

def minion_game(string):
    volwes = 'AEIOU'
    stuart_score = 0
    kevin_score = 0

    for i in range(len(string)):
        if string[i] in volwes:
            kevin_score += len(string) - i
        else:
            stuart_score += len(string) - i

    if stuart_score > kevin_score:
        print('Stuart', stuart_score)
    elif kevin_score > stuart_score:
        print('Kevin', kevin_score)
    else:
        print('Draw')


if __name__ == '__main__':
    s = input()
    minion_game(s)
