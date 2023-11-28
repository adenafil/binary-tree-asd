/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 28/11/2023
 * Time: 14:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BTSProgram
{
	/// <summary>
	/// Description of BST.
	/// </summary>
	public class BST
	{
		public Node Root;
		
		public BST()
		{
			this.Root = null;
			
		}
		
		public bool isEmpty()
		{
			return this.Root == null;
		}
		
		public void add(int data)
		{
			Node baru = new Node(data);
			// jika bst masih kosong, maka jadikan Root
			if (isEmpty())
			{
				this.Root = baru;
			}
			else
			{
				// cari posisi node baru
				Node tempRoot = this.Root;
				while(true)
				{
					// bandingkan node baru dengan tempRoot
					if (data < tempRoot.Data)
					{
						// jika lebih kecil dari tempRoot
						// maka jadikan left child
						if (tempRoot.LeftChild == null)
						{
							tempRoot.LeftChild = baru;
							break;
						} else
						{
							// geser 
							tempRoot = tempRoot.LeftChild;
						}
					}
					else {
						// jika lebih besar dari tempRoot maka
						// maka jadikan right child
						if (tempRoot.RightChild == null)
						{
							tempRoot.RightChild = baru;
							break;
						}
						else
						{
							// geser cihuyyy
							tempRoot = tempRoot.RightChild;
						}
					}
					
				}
				
			}
		}
		
		
		public void Preorder()
		{
			if(!isEmpty())
			{
				PreorderTraversal(this.Root);
				Console.WriteLine();
			}
		}
		
		private void PreorderTraversal(Node root)
		{
			if(root == null) return;
			
			// recursive case
			// visit root
			Console.Write(root.Data + " ");
			// traverse left subtree
			PreorderTraversal(root.LeftChild);
			// travers right subtree
			PreorderTraversal(root.RightChild);
		}
		
		public void Inorder()
		{
			if (!isEmpty())
			{
				InorderTraversal(this.Root);
				Console.WriteLine();
			}
		}
		
		public void InorderTraversal(Node root)
		{
			if(root == null) return;
			
			InorderTraversal(root.LeftChild);
			
			Console.Write(root.Data + " ");
			
			InorderTraversal(root.RightChild);
		}
		
			public void PostOrder()
		{
			if (!isEmpty())
			{
				PostOrderTraversal(this.Root);
				Console.WriteLine();
			}
		}
		
		public void PostOrderTraversal(Node root)
		{
			if(root == null) return;
			
			InorderTraversal(root.LeftChild);
			
			InorderTraversal(root.RightChild);
			
			Console.Write(root.Data + " ");
		}
		
	}
}
