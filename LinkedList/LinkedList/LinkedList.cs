using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml;

namespace LinkedList
{
    class LinkedList
    {
        Node head;
        
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) // Constructor  
            { 
              data = d; 
              next = null; 
            } 
        }

        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public void deleteNode(Node del)
        {
            Node temp = del.next;
            del.data = temp.data;
            del.next = temp.next;
            //
            temp = null;
        }

        //public void addNode(int data)
        //{
        //    Node temp = new Node(data);
        //    Node n = head;
            
        //    //Node temp = del.next;
        //    //del.data = temp.data;
        //    //del.next = temp.next;
        //    //temp = null;
        //}

        public void addNode(int item, int pos)
        {
            int _listsize = 4;
            Node add = new Node(item);
            int ix = pos - 1;
            Node cur = head;
            for (int i = 0; i < _listsize; i++)
            {
                if (i == ix)
                {
                    add.next = cur.next;
                    cur.next = add;
                }
                cur = cur.next;
            }
            ++_listsize;
        }

        public static int[] closestSum(int[] nums, int d)
        {
            int[] result = new int[2];
            int max = int.MinValue;
            int start = 0;
            int end = nums.Length - 1;
            Array.Sort(nums);
            int i = 0;
            int j = 0;
            List<int> a = new List<int>();

            while (start <= end)
            {
                if ((nums[start] + nums[end]) <= d - 30)
                {
                    if (max < (nums[start] + nums[end]))
                    {
                        max = (nums[start] + nums[end]);
                        i=nums[start];
                        j = nums[end];
                    }
                    start++;
                }
                else if ((nums[start] + nums[end]) > d - 30)
                {
                    end--;
                }
            }

            result[0] = i;
            result[1] = j;
            return result;
        }

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public Node sortedMerge(Node a, Node b)
        {
            Node result = null;
            /* Base cases */
            if (a == null)
                return b;
            if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.data <= b.data)
            {
                result = a;
                result.next = sortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = sortedMerge(a, b.next);
            }
            return result;
        }

        public Node mergeSort(Node h)
        {
            // Base case : if head is null  
            if (h == null || h.next == null)
            {
                return h;
            }

            // get the middle of the list  
            Node middle = getMiddle(h);
            Node nextofmiddle = middle.next;

            // set the next of middle node to null  
            middle.next = null;

            // Apply mergeSort on left list  
            Node left = mergeSort(h);

            // Apply mergeSort on right list  
            Node right = mergeSort(nextofmiddle);

            // Merge the left and right lists  
            Node sortedlist = sortedMerge(left, right);
            return sortedlist;
        }

        // Utility function to get the  
        // middle of the linked list  
       public Node getMiddle(Node h)
        {
            // Base case  
            if (h == null)
                return h;
            Node fastptr = h.next;
            Node slowptr = h;

            // Move fastptr by two and slow ptr by one  
            // Finally slowptr will point to middle node  
            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;
        }

        public int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b%a, a);
        }

        public static int countSetBits(int n) 
            { 
                int count = 0; 
                while (n > 0) 
                { 
                    count = count + (n & 1); 
                    n >>= 2; 
                } 
                return count; 
            }

        public class Ele
        {
            public int x = 0;
            public int y = 0;
            public Ele(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static bool isDelim(Ele temp)
        {
            return (temp.x == -1 && temp.y == -1);
        }

        public static bool isValid(int i, int j)
        {
            return (i >= 0 && j >= 0 && i < 3 && j < 5);
        }

        public static bool checkAll(int[][] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i][j] == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        } 
        public static int rotOranges(int [][] arr)
        {
            LinkedList<Ele> Q=new LinkedList<Ele>();
            Ele temp;
            int ans=0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i][j] == 2)
                    {
                        Q.AddLast(new Ele(i,j));
                    }
                }

            }

            Q.AddLast(new Ele(-1,-1));

            while (Q.Count > 0)
            {
                bool flag = false;

                while (!isDelim(Q.First.Value))
                {
                    temp = Q.First.Value;
                    // Check bottom adjacent cell 
                    // if it can be rotten  
                    if (isValid(temp.x + 1, temp.y) && arr[temp.x + 1][temp.y] == 1)
                    {
                        if (!flag)
                        {
                            ans++;
                            flag = true;
                        }

                        arr[temp.x + 1][temp.y] = 2;
                        temp.x++;
                        Q.AddLast(new Ele(temp.x, temp.y));
                        temp.x--;
                    }

                    // Check top adjacent cell that  
                    // if it can be rotten  
                    if (isValid(temp.x -1, temp.y) && arr[temp.x - 1][temp.y] == 1)
                    {
                        if (!flag)
                        {
                            ans++;
                            flag = true;
                        }

                        arr[temp.x - 1][temp.y] = 2;
                        temp.x--;
                        Q.AddLast(new Ele(temp.x, temp.y));
                        temp.x++;
                    }

                    // Check right adjacent cell that 
                    // if it can be rotten  
                    if (isValid(temp.x, temp.y + 1) &&
                        arr[temp.x][temp.y + 1] == 1)
                    {
                        if (!flag)
                        {
                            ans++;
                            flag = true;
                        }
                        arr[temp.x][temp.y + 1] = 2;
                        temp.y++;

                        // Push this cell to Queue 
                        Q.AddLast(new Ele(temp.x, temp.y));
                        temp.y--;
                    }

                    // Check left adjacent cell that  
                    // if it can be rotten  
                    if (isValid(temp.x, temp.y - 1) &&
                        arr[temp.x][temp.y - 1] == 1)
                    {
                        if (!flag)
                        {
                            ans++;
                            flag = true;
                        }
                        arr[temp.x][temp.y - 1] = 2;
                        temp.y--;

                        // push this cell to Queue 
                        Q.AddLast(new Ele(temp.x, temp.y));
                    }

                    Q.RemoveFirst();
                   

                }
                Q.RemoveFirst();

                if (Q.Count > 0)
                {
                    Q.AddLast(new Ele(-1, -1));
                } 
            }

            return (checkAll(arr)) ? -1 : ans; 
        }

        public class MyInt
        {
            public int MyValue;
        }

        void rotate(int k)
        {
            if (k == 0) return;
            Node current = head;
            int count =1;
            while (count < k && current != null)
            {
                current = current.next;
                count++;
            }

            Node KthNode = current;

            if (current == null) return;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = head;
            head = KthNode.next;
            KthNode.next = null;
            

        }

        public static bool isPalindrome(string str)
        {
            // Start from leftmost and 
            // rightmost corners of str 
            int l = 0;
            int h = str.Length - 1;

            // Keep comparing characters 
            // while they are same 
            while (h > l)
            {
                //char char_left=str[l++];
                //char char_right = str[h--];
                if (str[l++] != str[h--])
                {
                    return false;
                }

                //char char_right = str[h--];
                if (str[l] != str[h])
                {
                    return false;
                }
                l++;
                h--;
            }

            // If we reach here, then all 
            // characters were matching 
            return true; 
        }

        public static bool isRotationOfPalindrome(string str)
        {
            // If string iteself is palindrome 
            if (isPalindrome(str))
            {
                return true;
            }

            // Now try all rotations one by one 
            int n = str.Length;
            for (int i = 0; i < n - 1; i++)
            {
                string str1 = str.Substring(i + 1);
                string str2 = str.Substring(0, i + 1);

                // Check if this rotation is palindrome 
                if (isPalindrome(str1 + str2))
                {
                    return true;
                }
            }
            return false;
        }
                
        static void Main(string[] args)
        {
            isPalindrome("madam");
            int xx ;
            Console.WriteLine("Enter your Character to get Decimal number");
            //Console.WriteLine(xx);
            xx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(xx);

            // Converting the decimal into character. 
            Console.WriteLine(Convert.ToChar(xx)); 
            //Console.WriteLine((isRotationOfPalindrome("aab")) ? 1 : 0);
            //Console.WriteLine((isRotationOfPalindrome("abcde")) ? 1 : 0);
            //Console.WriteLine((isPalindrome("aaaad")) ? 1 : 0);
            Console.WriteLine((isRotationOfPalindrome("aaaad")) ? 1 : 0);

            
            //
            string testxml = @"<?xml version=""1.0""?><userAdminData name=""DeleteUsers""><users><user name=""tnandinnnn""><error code=""0xC004302E"" text=""User does not exist in the system.""/></user></users></userAdminData>";
            XmlDocument delException = new XmlDocument();
            delException.LoadXml(testxml);
                       
            XmlNode errorNode = delException.DocumentElement.SelectSingleNode("/userAdminData/users/user/error1");
            if (errorNode != null)
            { string errortext = errorNode.Attributes["text"].Value; }

            
            //
            String strABC = "ABCD";
            int n = strABC.Length;
            Permutations.permute(strABC, 0, n - 1);

            //value by reference
            MyInt x = new MyInt();
            x.MyValue = 3;
            MyInt y = new MyInt();
            y = x;
            //x = y;
            MyInt z = new MyInt();
            z = x;
            y.MyValue = 4;
            z.MyValue = 5;
            //End value by reference

            //Sort an array

            int[] myArray = new int[] { 11,8,5,465,27,21};

            for (int i=0; i< myArray.Length; i++)
            {
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        int temp = 0;
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            
            //get the sum of lowest total bit
            //Expected output (2+4=6)+(6+8=14)+(14+20=34) = 54
            int[] arr11 = new int[]{2,4,8,20};
            int tempsum1=0;            
            int[] arrSum = new int[arr11.Length - 1];
           
            for (int i = 0; i <=arr11.Length-1; i++)
            {
                if (i == 0)
                {
                    tempsum1 = arr11[i] + arr11[i + 1];
                    arrSum[i] = arr11[i] + arr11[i + 1];                    
                    i = i + 1;

                }
                else if (i > 0)
                {
                    arrSum[i - 1] = tempsum1 + arr11[i];                   
                    tempsum1 = arrSum[i - 1];                   
                }
            }
            int sum = 0;
            foreach (int i in arrSum)
            {
                sum = sum + i;
            }


            //

            BinarySearchTree tree2 = new BinarySearchTree();
            BinarySearchTree.Node root1 = new BinarySearchTree.Node(10);
            BinarySearchTree.Node leftNode1 = new BinarySearchTree.Node(20);
            BinarySearchTree.Node rightNode1 = new BinarySearchTree.Node(30);
            BinarySearchTree.Node leftleftNode1 = new BinarySearchTree.Node(40);
            BinarySearchTree.Node leftrightNode1 = new BinarySearchTree.Node(60);
            root1.left = leftNode1;
            root1.right = rightNode1;
            leftNode1.left = leftleftNode1;
            leftNode1.right = leftrightNode1;
            int height = tree2.height(root1);
            
            //
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(100);
            tree.insert(20);
            tree.insert(500);
            tree.insert(10);
            tree.insert(30);
            tree.insert(40);

            tree.traversal(tree.root);
            //if(tree.root!=null)

            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.insert(27);
            tree1.insert(14);
            tree1.insert(35);
            tree1.insert(10);
            tree1.insert(19);
            tree1.insert(31);
            tree1.insert(20);
            tree1.insert(22);

            tree1.traversal(tree1.root);

            
            //tree.insert(50);
            //tree.insert(30);
            //tree.insert(20);
            //tree.insert(40);
            //tree.insert(70);
            //tree.insert(60);
            //tree.insert(80); 
            //
            LinkedList matrix = new LinkedList();
            int[][] arr = new int[][] { 
            new int[]{ 2,1,0,2,1 },
            new int[] {1,0,1,2,1},
            new int[] {1,0,0,2,1}};

            rotOranges(arr);

            int itest = 10 & 1;
            //
            int remender = 8 % 5;
            int revremender = 2 % 5;
            LinkedList li = new LinkedList();
            /////////////////////////////////
            int ii = 13;
                ii = 10 ^ 20;
            Console.Write(countSetBits(ii));
            //////////////////////////////////
            int gcd = li.gcd(3, 2);
            /*  
            * Let us create a unsorted linked list to test the functions  
            * created. The list shall be a: 2->3->20->5->10->15  
            */
            li.push(15);
            li.push(10);
            li.push(5);
            li.push(20);
            li.push(3);
            li.push(2);

            li.head = li.mergeSort(li.head); 
            ///////////////////////////////////////////////////////////////
            //Rotate linked list by 4//

            LinkedList lnklist = new LinkedList();
            lnklist.push(60);
            lnklist.push(50);
            lnklist.push(40);
            lnklist.push(30);
            lnklist.push(20);
            lnklist.push(10);

            lnklist.rotate(4);
            
            
            ///////////////////////////////////////////////////////////////

            //** Find 2nd most occurred string in string array**//
            Dictionary<string, int> dictionary=new Dictionary<string,int>();
            Dictionary<int, string> myDictionary=new Dictionary<int,string>();
           

            int len1=myDictionary.Count;
            int counter=0;

            string[] stringArray = new string[] {"aa","bb","cc","bb","aa","aa" };

            foreach(string str in stringArray)
            {
                counter = 0;
                foreach (string str1 in stringArray)
                {
                    if (str == str1)
                        counter++;
                }
                if (!dictionary.ContainsKey(str))
                {
                    dictionary.Add(str, counter);
                }

            }
            
            string  index = null;
            int first, second1;
            first = second1 = int.MinValue;
            foreach (var var in dictionary)
            {                
                if (var.Value >= first)
                {
                    second1 = first;
                    first = var.Value;             
                }

                else if (var.Value > second1 && var.Value != first)
                {
                    second1 = var.Value;
                    index = var.Key;
                    
                }
            }

            ////////////////////////////////////////////
            //Find the occurrance of substring in a string
            string str2becompared = "GeeksForGeekFor";
            string str2compare1 = "Fr";
            string str2compare2 = "For";
            int indexof1 = str2becompared.IndexOf(str2compare1, 0);
            int indexof2 = str2becompared.IndexOf(str2compare2, 0);
            int count = 0;
            for (int i = 0; i < str2becompared.Length; i++)
            {
                if (str2becompared.IndexOf(str2compare2, i) > 0)
                {
                    i = str2becompared.IndexOf(str2compare2, i) + str2compare2.Length-1;
                    count++;
                    
                }

            }
            ///////////////////////////////////////////////////
            //** Reverse a string**//
            string toReverse = "i.like.this.program.very.much";
            string[] strArray = toReverse.Split(new char[] {'.'});         
           
            StringBuilder reverse = new StringBuilder();
            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    reverse.Append(strArray[i]);
                }
                else
                {
                    reverse.Append(strArray[i] + '.');
                }
            }
            //////////////////////////////////////////
            string st1="geeksforgeeks";
            char[] arraySt1=st1.ToCharArray();
            string st2 = "mask";
            int len = st2.Length;
            

            foreach(char c2 in st2)
            {
                st1 = st1.Replace(c2.ToString(), string.Empty);
                
            }
            ////////////////////////////////////////////////////////
            //int max = int.MaxValue;
           // Math.
            int d = 250;
            int[] nums = new int[] { 90,85,75,60,120,150,125};

            int[] result = LinkedList.closestSum(nums,d);
            LinkedList llist = new LinkedList();

            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node fourth = new Node(4);

            llist.head.next = second;
            second.next = third;
            third.next = fourth;

            llist.printList();
           llist.addNode(5, 3);
          //llist.deleteNode(third);
            llist.printList();
            
            Console.ReadLine();
        }
    }
}
