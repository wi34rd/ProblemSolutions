# Merge the Tools!
# https://www.hackerrank.com/challenges/merge-the-tools/problem

def merge_the_tools(string, k):
    for ti in [string[i:i + k] for i in range(0, len(string), k)]:
        ui = []

        for char in ti:
            if char not in ui:
                ui.append(char)

        print(''.join(ui))


if __name__ == '__main__':
    string, k = input(), int(input())
    merge_the_tools(string, k)
