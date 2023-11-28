/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 28/11/2023
 * Time: 14:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BTSProgram
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			BST bst = new BST();
			bst.add(8);
			bst.add(7);
			bst.add(2);
			bst.add(5);
			bst.add(10);
			bst.add(9);
			bst.add(14);
			
			bst.Preorder();
			bst.Inorder();
			bst.PostOrder();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}