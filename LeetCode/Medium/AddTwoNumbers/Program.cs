using System.Numerics;

// https://leetcode.com/problems/add-two-numbers/

//Example 1:


//ListNode L13 = new ListNode(3, null);
//ListNode L12 = new ListNode(4, L13);
//ListNode L11 = new ListNode(2, L12);

//ListNode L23 = new ListNode(4, null);
//ListNode L22 = new ListNode(6, L23);
//ListNode L21 = new ListNode(5, L22);


//Example 2:

//ListNode L11 = new ListNode(0, null);
//ListNode L21 = new ListNode(0, null);

//Example 3:

//ListNode L17 = new ListNode(9, null);
//ListNode L16 = new ListNode(9, L17);
//ListNode L15 = new ListNode(9, L16);
//ListNode L14 = new ListNode(9, L15);
//ListNode L13 = new ListNode(9, L14);
//ListNode L12 = new ListNode(9, L13);
//ListNode L11 = new ListNode(9, L12);

//ListNode L24 = new ListNode(9, null);
//ListNode L23 = new ListNode(9, L24);
//ListNode L22 = new ListNode(9, L23);
//ListNode L21 = new ListNode(9, L22);


//Example 4:



ListNode L11 = new ListNode(9, null);

ListNode L30 = new ListNode(9, null);
ListNode L29 = new ListNode(9, L30);
ListNode L28 = new ListNode(9, L29);
ListNode L27 = new ListNode(9, L28);
ListNode L26 = new ListNode(9, L27);
ListNode L25 = new ListNode(9, L26);
ListNode L24 = new ListNode(9, L25);
ListNode L23 = new ListNode(9, L24);
ListNode L22 = new ListNode(9, L23);
ListNode L21 = new ListNode(1, L22);


MyProgram x = new MyProgram();
var firstNum = x.GetNumber(L11);
var secondNum = x.GetNumber(L21);
var result = x.ReverseNumber((firstNum + secondNum).ToString());
var node = x.CreateNode(result);
var numb = x.GetNumber(node);
Console.WriteLine(numb);

Console.ReadLine();

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class MyProgram
{
    public BigInteger GetNumber(ListNode node)
    {
        string number = null;

        do
        {
            number += node.val;
            node = node?.next;
        } while (node?.next != null);

        number += node?.val;

        return BigInteger.Parse(ReverseNumber(number));
    }

    public string ReverseNumber(string number)
    {
        string result = null;

        for (int i = number.Length; i > 0; i--)
        {
            result += number[i - 1];
        }

        return result;
    }

    public ListNode CreateNode(string number)
    {
        ListNode node = null;

        for (int i = number.Length; i > 0; i--)
        {
            node = new ListNode(Convert.ToInt32(number.Substring(i-1,1)), node);
        }

        return node;
    }
    public static ListNode CreateNode(int number)
    {
        ListNode node = null;
        while (number / 10 > 0)
        {
            node = new ListNode(number % 10, node);
            number /= 10;
        }

        return node;
    }
}

