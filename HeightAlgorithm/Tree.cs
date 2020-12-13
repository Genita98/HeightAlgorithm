using System; 
  
// e krijojme fillimisht nje binary tree node (nyje)
public class Node  
{ 
    public int data; 
    public Node left, right; 
  
    public Node(int item)  
    { 
        data = item; 
        left = right = null; 
    } 
}

public class Tree
{
    public Node root;

    
    // ketu e krijojme nje metode e cila gjen thellesine maksimale te Depth ne menyre qe te gjindet lartesia e vargut
   public int maxDepth(Node node)
    {
        if (node == null)
            return 0;
        else
        {
           // nese nuk eshte node = null atehere e llogarisim thellesine te secilit subtree 
            int leftDepth = maxDepth(node.left);
            int rightDepth = maxDepth(node.right);

            //pasi e llogarisim depth maksimal te seciles subtree ketu e perdorim depth i cili eshte me i larte 
            if (leftDepth > rightDepth)
                return (leftDepth + 1);
            else
                return (rightDepth + 1);
        }
    }
}