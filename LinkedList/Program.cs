using System;



namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.Print();

        }
    }



    public class Node{
        Node next;
        int data;
        public Node(int value)
        {
            this.data = value;
            this.next = null;
        }

        public void setNext(Node next) {
            this.next = next;
        }

        public Node getNext(){
            return this.next;
        }

        public int getData(){
            return this.data;
        }

        public void setData(int data){
            this.data = data;
        }
    }

    public class LinkedList{
    Node head;
    int count;
        public LinkedList() {
            this.head =null;
            this.count =0;
        }
        public void Append(int value){
            if(head==null)
            {
                this.head = new Node(value);
            }
            else
            {
                Node node = new Node(value);
                node.setNext(this.head);
                this.head =node;
            }
            count++;
        }

        public  void Print(){
            Node currentItem = this.head;
            while (currentItem != null)
            {
                Console.WriteLine(currentItem.getData());
                currentItem = currentItem.getNext();
            }

        }
    }
}