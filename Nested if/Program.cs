﻿using System;

namespace Decision_statements_3
{
    class Program
    {
        static void Main(string[] args)
        {

			int first = 7, second = -23, third = 13;
			if (first > second)
			{
				if (first > third)
				{
					Console.WriteLine("{0} is the largest", first);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
			}
			else
			{
				if (second > third)
				{
					Console.WriteLine("{0} is the largest", second);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
			}
		}
	}
}







		
