using System;
using System.Text;

public class Stack
{
    public Stack nextStack;
    public char opr;

    public void Push(char opr) {
        Stack newStack = new Stack();
        newStack.opr = opr;
        newStack.nextStack = nextStack;
        nextStack = newStack;
    }

    public char Pop() {
        char opr = nextStack.opr;
        nextStack = nextStack.nextStack;

        return opr;
    }
}

class ONP
{
    static void Main() {
        Stack stack = new Stack();
        StringBuilder output = new StringBuilder();
        int t = int.Parse(Console.ReadLine());

        for ( ; t > 0; t-- ) {
            string expression = Console.ReadLine();

            for ( int i = 0; i < expression.Length; i++ ) {
                if ( expression[i] >= 'a' && expression[i] <= 'z' ) {
                    output.Append(expression[i]);
                } else if ( expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/' || expression[i] == '^' ) {
                    stack.Push(expression[i]);
                } else if ( expression[i] == ')' ) {
                    output.Append(stack.Pop());
                }
            }

            output.AppendLine();
        }

        Console.WriteLine(output);
    }
}
