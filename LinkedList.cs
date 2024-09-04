using System;

public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    // זמן ריצה: O(n)
    public int Length()
    {
        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // זמן ריצה: O(n)
    public void Add(int value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // זמן ריצה: O(n)
    public void RemoveValue(int value)
    {
        if (head == null) return;

        if (head.Data == value)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null && current.Next.Data != value)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // זמן ריצה: O(n)
    public void RemoveAllValues(int value)
    {
        while (head != null && head.Data == value)
        {
            head = head.Next;
        }

        Node current = head;
        while (current != null && current.Next != null)
        {
            if (current.Next.Data == value)
            {
                current.Next = current.Next.Next;
            }
            else
            {
                current = current.Next;
            }
        }
    }

    // זמן ריצה: O(n)
    public void RemoveIndex(int index)
    {
        if (index < 0 || head == null) return;

        if (index == 0)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        for (int i = 0; i < index - 1; i++)
        {
            if (current.Next == null) return;
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // זמן ריצה: O(n)
    public int Find(int value)
    {
        Node current = head;
        int index = 0;
        while (current != null)
        {
            if (current.Data == value)
            {
                return index;
            }
            current = current.Next;
            index++;
        }
        return -1; 
    }

    // זמן ריצה: O(n)
    public int Get(int index)
    {
        if (index < 0) return -1;

        Node current = head;
        for (int i = 0; i < index; i++)
        {
            if (current == null) return -1;
            current = current.Next;
        }

        return current != null ? current.Data : -1;
    }

    // זמן ריצה: O(n)
    public string Display()
    {
        if (head == null) return "";

        Node current = head;
        string result = "";
        while (current != null)
        {
            result += current.Data;
            if (current.Next != null)
            {
                result += " -> ";
            }
            current = current.Next;
        }
        return result;
    }
}
