/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 28/11/2023
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BTSProgram
{
	/// <summary>
	/// Description of Node.
	/// </summary>
	public class Node
	{
		public int Data;
		public Node Parent;
		public Node LeftChild;
		public Node RightChild;
		
		public Node(int Data)
		{
			this.Data = Data;
			
		}
	}
}
