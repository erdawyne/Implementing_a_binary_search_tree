using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_a_binary_search_tree
{
    class UnitTest
    {
        public class BinaryTreeTests
        {
            //[TestMethod]
            public void Insert_AddsElementToTree()
            {
                // Arrange
                BinaryTree tree = new BinaryTree();

                // Act
                tree.insert("apple");

                // Assert
                Assert.IsNotNull(tree.ROOT);
                Assert.AreEqual("apple", tree.ROOT.info);
            }

            //[TestMethod]
            public void Insert_DuplicateElement_ShouldNotAllowDuplicates()
            {
                // Arrange
                BinaryTree tree = new BinaryTree();
                tree.insert("apple");

                // Act
                tree.insert("apple");

                // Menegaskan
                // Pastikan duplikat tidak diperbolehkan
                // Anda dapat memeriksa keluaran konsol atau membuat metode untuk memeriksa duplikat di pohon
                // Untuk mempermudah, anggaplah Anda memiliki metode `Berisi` di kelas BinaryTree Anda
                Assert.IsFalse(tree.Contains("apple"));
            }

            //[TestMethod]
            public void InOrderTraversal_ReturnsInOrderElements()
            {
                // Arrange
                BinaryTree tree = new BinaryTree();
                tree.insert("banana");
                tree.insert("apple");
                tree.insert("orange");

                // Act
                string result = tree.GetInOrderTraversal();

                // Assert
                Assert.AreEqual("apple banana orange", result);
            }

            // Tambahkan lebih banyak metode pengujian untuk fungsi lainnya

            // Contoh metode untuk memeriksa apakah ada kata di pohon
            //[TestMethod]
            public void Contains_WordPresent_ReturnsTrue()
            {
                // Arrange
                BinaryTree tree = new BinaryTree();
                tree.insert("banana");
                tree.insert("apple");
                tree.insert("orange");

                // Act
                bool result = tree.Contains("apple");

                // Assert
                Assert.IsTrue(result);
            }
        }
    }
}




