using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_a_binary_search_tree //membuat implementasi struktur data dalam bentuk pohon//
{
    /* A Node class consists of a three things, the information, reference to the right child, and references to the left child. */

    class Node
    {
        public string info;             // Data yang disimpan dalam simpul (Node)
        public Node lchild;             // Referensi ke anak kiri dari simpul (Node)
        public Node rchild;             // Referensi ke anak kanan dari simpul (Node)

        public Node(string i, Node l, Node r) /* Constructor for the Node class */
        {
            info = i;       //Data yang tersimpan
            lchild = l;     //Subpohon kiri
            rchild = r;     //Subpohon kanan
        }
    }
    class BinaryTree    //kelas binary search tree mewakili pohon pencarian biner/
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /* Initializing ROOT to null*/
        }
        public void insert(string element) /* Inserts a Node in the Binary Search Tree */
        {
            Node tmp, parent = null, currentNode = null;
            find(element, ref parent, ref currentNode);
            if (currentNode != null) /*Checks if the node to be inserted is already present or not */
            {
                Console.WriteLine("Duplicates words not allowed");
                return;
            }
            else /* If the specified Node is not present */
            {
                tmp = new Node(element, null, null); /* Creates a Node */
                if (parent == null) /*If the tree is empty */
                    ROOT = tmp;
                else
                    if (String.Compare(element, parent.info) < 0)
                    parent.lchild = tmp;
                else
                    parent.rchild = tmp;
            }
        }

        internal string GetInOrderTraversal()
        {
            throw new NotImplementedException();
        }

        public void find(string element, ref Node parent, ref Node currentNode)
        {
            /* This function finds the currentNode of the specified Node as well as the currentNode of its parent. */

            currentNode = ROOT;         // Inisialisasi currentNode sebagai ROOT (akar) dari pohon
            parent = null;              // Inisialisasi parent sebagai null karena pada awalnya belum ada parent (ROOT adalah akar)
            while ((currentNode != null) && (currentNode.info != element)) // Melakukan pencarian dalam pohon biner
            {
                parent = currentNode;       // Menyimpan currentNode sebagai parent, karena akan bergerak ke anak kiri atau kanan
                // Memeriksa apakah element yang dicari kurang dari currentNode.info
                if (String.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.lchild;       // Bergerak ke anak kiri
                else
                    currentNode = currentNode.rchild;       // Bergerak ke anak kanan

            }    
        }
        public void inorder(Node ptr) /* Performs the preorder traversal of the tree*/
        {
            if(ROOT == null)        // Memeriksa apakah pohon kosong
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)                    // Mengunjungi simpul (Node) saat ini dalam urutan inorder
            {
                inorder(ptr.lchild);            // Mengunjungi anak kiri terlebih dahulu
                Console.Write(ptr.info + "  "); // Mencetak info dari simpul saat ini
                inorder(ptr.rchild);            // Traversal pada anak kanan
            }
        }

        public void preorder(Node ptr) /* Perfoms the preorder traversal of the tree */
        {
            if(ROOT == null)                    // Memeriksa apakah pohon kosong
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr !=null)
            {
                Console.Write(ptr.info + " ");      // Menampilkan info dari node saat ini
                preorder(ptr.lchild);               // Traversal pada anak kiri
                preorder(ptr.rchild);               // Traversal pada anak kanan
            }
        }
        public void postorder(Node ptr) /* Perfomes the postorder traversal of the tree */
        {
            if(ROOT == null)                   // Memeriksa apakah pohon kosong
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)                    // Memeriksa apakah ptr (node saat ini) tidak null
            {
                postorder(ptr.lchild);              // Traversal pada anak kiri
                postorder(ptr.rchild);              // Traversal pada anak kanan
                Console.Write(ptr.info + " ");      // Menampilkan info dari node saat ini
            }
        }
        static void Main(string [] args)
        {
            BinaryTree b = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\nMenu");                            //menampilkan menu
                Console.WriteLine("1. Implement insert operation");     //menampilkan kata sisipan
                Console.WriteLine("2. Perform inorder traversal");      //melakukan penjajahan berurutan
                Console.WriteLine("3. Perform preorder traversal");
                Console.WriteLine("4. Perform postorder traversal");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter your choice (1-5) : ");          //menampilkan pilihan 1-5
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word: ");        //Meminta pengguna memasukkan kata
                            string word = Console.ReadLine();
                            b.insert(word);                         //menyisipkan kata kedalam pohon
                        }
                        break;
                    case '2':
                        {
                            b.inorder(b.ROOT);                     //Menampilkan isi pohon dalam urutan inorder
                        }
                        break;
                    case '3':
                        {
                            b.preorder(b.ROOT);                    //Menampilkan isi pohon dalam urutan preorder
                        }
                        break; 
                            case '4':
                        {
                            b.postorder(b.ROOT);                   // Menampilkan isi pohon dalam urutan postorder
                        }
                        break;
                    case '5':
                        return;         // Keluar dari program
                    default:
                        {
                            Console.WriteLine("Invalid option");        // Pesan kesalahan untuk opsi yang tidak valid
                            break;
                        }
                }
            }
        }
    }
}
