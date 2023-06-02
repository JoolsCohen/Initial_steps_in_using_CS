//Семинар 4

using System;

public class Lesson4
{

  public static void Main(string[] args)
  {
    // TreeSet
    // TreeMap

    Tree tree = new Tree();
    Console.WriteLine(tree.add(8));
    Console.WriteLine(tree.add(2));
    Console.WriteLine(tree.add(3));
    Console.WriteLine(tree.add(12));
    Console.WriteLine(tree.add(12));
    Console.WriteLine(tree.add(1));
    Console.WriteLine(tree.add(14));

    Console.WriteLine();

    Console.WriteLine(tree.contains(8)); // true
    Console.WriteLine(tree.contains(1)); // true
    Console.WriteLine(tree.contains(3)); // true
    Console.WriteLine(tree.contains(12)); // true

    Console.WriteLine(tree.contains(4)); // false
    Console.WriteLine(tree.contains(2)); // false
    Console.WriteLine(tree.contains(14)); // false
    Console.WriteLine();


    Console.WriteLine(tree.dfs());
    Console.WriteLine(tree.bfs());

    int? x = 5;
    int? y = 7;

    Console.WriteLine(x.compareTo(y));


    Tree t = new Tree();
    t.add(1);
    t.add(2);
    t.add(3);
    t.add(4);
    t.add(5);
    t.add(6);
    t.add(7);
    t.add(8);

    //           1
    //                   2
    //                             3
    //                                      4
    //                                                 5

    Console.WriteLine(t.bfs());


  }

}








//Дерево

using System.Collections.Generic;

public class Tree
{
  private class Node
  {
    private readonly Tree outerInstance;

    internal int value;
    internal Node left;
    internal Node right;
    internal Node(Tree outerInstance, int value)
    {
      this.outerInstance = outerInstance;
      this.value = value;
    }
  }
  private Node root;
  public virtual bool add(int value)
  {
    if (root == null)
    {
      root = new Node(this, value);
      return true;
    }
    return addNode(root, value);
  }
  private bool addNode(Node current, int value)
  {
    // value < current.value ~ value.compareTo(current.value) == 0
    if (value == current.value)
    {
      return false;
    // value < current.value ~ value.compareTo(current.value) < 0
    }
    else if (value < current.value)
    {
      // Вставялем в левое поддерево
      if (current.left == null)
      {
        current.left = new Node(this, value);
        return true;
      }
      else
      {
        return addNode(current.left, value);
      }
      // value > current.value ~ value.compareTo(current.value) > 0
    }
    else
    { // value > root.value
      // Вставляем в правое поддерево
      if (current.right == null)
      {
        current.right = new Node(this, value);
        return true;
      }
      else
      {
        return addNode(current.right, value);
      }
    }
  }
  public virtual bool contains(int value)
  {
    return findNode(root, value) != null;
  }
  private Node findNode(Node current, int value)
  {
    if (current == null)
    {
      return null;
    }
    // найди узел в дереве current, значение которого равно value
    if (value == current.value)
    {
      return current;
    }
    else if (value < current.value)
    {
      return findNode(current.left, value);
    }
    else
    { // value > current.value
      return findNode(current.right, value);
    }
  }
  public virtual void remove(int value)
  {
    root = removeNode(root, value);
  }
  private Node removeNode(Node current, int value)
  {
    if (current == null)
    {
      return null;
    }
    // value = 8, current = 6
    // 6.right = 7
    // value = 8, current = 8
    if (value < current.value)
    {
      // нужно удалить в левом поддереве
      current.left = removeNode(current.left, value);
      return current;
    }
    else if (value > current.value)
    {
      // нужно удалить в правом поддереве
      current.right = removeNode(current.right, value);
      return current;
    }
    // Нужно удалить узел current
    // Есть 3 случая:
    // 1. Дочерних узлов нет
    if (current.left == null && current.right == null)
    {
      return null;
    }
    // 2. Есть только один дочерний узел
    if (current.left == null && current.right != null)
    {
      return current.right;
    }
    if (current.left != null && current.right == null)
    {
      return current.left;
    }
    // 3. Есть оба дочерних узла
    // Нужно найти минимальный элемент справа
    Node smallestNodeOnTheRight = findFirst(current.right);
    int smallestValueOnTheRight = smallestNodeOnTheRight.value;
    current.value = smallestValueOnTheRight;
    current.right = removeNode(current.right, smallestValueOnTheRight);
    return current;
  }
  public virtual int findFirst()
  {
    if (root == null)
    {
      throw new NoSuchElementException();
    }
    return findFirst(root).value;
  }
  private Node findFirst(Node current)
  {
    if (current.left == null)
    {
      return current;
    }
    return findFirst(current.left);
  }
  public virtual IList<int> dfs()
  {
    if (root == null)
    {
      return new List<int> {};
    }
    IList<int> list = new List<int>();
    dfs(root, list);
    return list;
  }
  private void dfs(Node current, IList<int> result)
  {
    // In-order
    if (current.left != null)
    {
      dfs(current.left, result);
    }
    result.Add(current.value);
    if (current.right != null)
    {
      dfs(current.right, result);
    }
  }
  public virtual IList<int> bfs()
  {
    if (root == null)
    {
      return new List<int> {};
    }
    IList<int> result = new List<int>();
    LinkedList<Node> queue = new LinkedList<Node>();
    queue.AddLast(root);
    while (queue.Count > 0)
    {
      Node next = queue.RemoveFirst();
      result.Add(next.value);
      if (next.left != null)
      {
        queue.AddLast(next.left);
      }
      if (next.right != null)
      {
        queue.AddLast(next.right);
      }
    }
    return result;
  }
}